using RconSharp;
using RconSharp.Net45;
using System;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace FiveMRcon
{
	public partial class RconForm : Form
	{
		private CmdHistoryNode _CurrentCmdHistoryNode;

		public RconForm()
		{
			_CurrentCmdHistoryNode = new CmdHistoryNode(null);

			InitializeComponent();
			ActiveControl = InputText;
		}

		private void ToolbarServerDropdownConnect_Click(object sender, EventArgs e)
		{
			new ServerConnectForm(this).ShowDialog();
		}

		private void ToolbarServerDropdownSaved_Click(object sender, EventArgs e)
		{
			try
			{
				new ServerListForm(this).ShowDialog();
			}
			catch (ObjectDisposedException) { /* Don't panic bro */ }
		}

		private void ToolbarEditDropdownClearHistory_Click(object sender, EventArgs e)
		{
			_CurrentCmdHistoryNode = new CmdHistoryNode(null);
			MessageBox.Show("Previous Commands Cleared!");
		}

		private void ToolbarEditDropdownSettings_Click(object sender, EventArgs e)
		{
			new SettingsForm().ShowDialog();
		}

		private void InputText_TextChanged(object sender, EventArgs e)
		{
			InputSend.Enabled = !InputText.Text._IsStringNull();
		}

		private void InputText_KeyUp(object sender, KeyEventArgs e)
		{
			bool relevantKeyUp = false;
			if (e.KeyCode == Keys.Up)
			{
				relevantKeyUp = true;
				if (_CurrentCmdHistoryNode.PreviousCmdNode != null)
					_CurrentCmdHistoryNode = _CurrentCmdHistoryNode.PreviousCmdNode;
				else
					SystemSounds.Beep.Play();
			}
			else if (e.KeyCode == Keys.Down)
			{
				relevantKeyUp = true;
				if (_CurrentCmdHistoryNode.NextCmdNode != null)
					_CurrentCmdHistoryNode = _CurrentCmdHistoryNode.NextCmdNode;
				else
					SystemSounds.Beep.Play();
			}

			if (relevantKeyUp)
			{
				InputText.Text = _CurrentCmdHistoryNode.Command;
				InputText.SelectionStart = InputText.TextLength;
			}
		}

		private void InputSend_Click(object sender, EventArgs e)
		{
			InputSend.Enabled = false;

			_Log(_LogType.SENT, InputText.Text);

			string ip = InfoHolder.ServerIP;
			int port = InfoHolder.ServerPort;
			string pass = InfoHolder.ServerPass;
			ServerProtocolType protocol = InfoHolder.ServerProtocol;
			if (ip == null || port == 0 || pass == null)
			{
				_Log(_LogType.RECEIVED, "Please specify a server first.", true);
			}
			else
			{
				IPEndPoint endPoint = null;
				try
				{
					endPoint = new IPEndPoint(Dns.GetHostAddresses(ip)[0], port);
					_ProtocolSendRcon(endPoint, protocol, pass, InputText.Text.Trim());
				}
				catch (SocketException)
				{
					_Log(_LogType.RECEIVED, "Invalid IP", true);
				}
			}

			// Get to the newest node first
			while (_CurrentCmdHistoryNode.NextCmdNode != null)
				_CurrentCmdHistoryNode = _CurrentCmdHistoryNode.NextCmdNode;
			// Create new node
			CmdHistoryNode newCmdHistoryNode = new CmdHistoryNode(_CurrentCmdHistoryNode);
			// Set command and next node of current node
			_CurrentCmdHistoryNode.Command = InputText.Text;
			_CurrentCmdHistoryNode.NextCmdNode = newCmdHistoryNode;
			// Set current node to new one
			_CurrentCmdHistoryNode = newCmdHistoryNode;

			InputText.ResetText();
			ActiveControl = InputText;
		}

		private async void _ProtocolSendRcon(IPEndPoint endPoint, ServerProtocolType protocol, string pass, string cmd)
		{
			switch (protocol)
			{
				case ServerProtocolType.FiveM:
					UdpClient udp = new UdpClient();
					udp.Client.SendTimeout = 1000;
					udp.Client.ReceiveTimeout = 1000;

					byte[] sendData = Encoding.Default.GetBytes($"\xFF\xFF\xFF\xFFrcon {pass} {cmd}");
					await udp.SendAsync(sendData, sendData.Length, endPoint);

					try
					{
						byte[] receiveData = udp.Receive(ref endPoint);
						_Log(_LogType.RECEIVED, Encoding.Default.GetString(receiveData).Substring(10).Trim());
					}
					catch (SocketException)
					{
						_Log(_LogType.RECEIVED, "Timeout (No Answer)", true);
					}
					break;
				case ServerProtocolType.Srcds:
					RconMessenger messenger = new RconMessenger(new RconSocket());
					if (!await messenger.ConnectAsync($"{endPoint.Address}", endPoint.Port))
					{
						_Log(_LogType.RECEIVED, "Timeout (No Answer)", true);
						return;
					}

					if (!await messenger.AuthenticateAsync(pass))
					{
						_Log(_LogType.RECEIVED, "Wrong Password", true);
						return;
					}
					else
					{
						string response = await messenger.ExecuteCommandAsync(cmd);
						if (!response._IsStringNull())
							_Log(_LogType.RECEIVED, response.Trim());
					}
					break;
			}
		}

		private enum _LogType {
			SENT,
			RECEIVED
		}

		private void _Log(_LogType logType, string text, bool fatal = false)
		{
			string prefix = null;
			if (InfoHolder.ServerIP != null)
				prefix = InfoHolder.ServerIP;
			if (logType == _LogType.SENT)
				prefix = $"{prefix} >";
			else
				prefix = $"{prefix} <";
			Log.AppendText($"{prefix} {text} \r\n");
			if (fatal)
				SystemSounds.Beep.Play();
		}
	}
}
