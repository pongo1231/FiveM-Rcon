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
			ServerConnectForm serverConnectDialog = new ServerConnectForm(this);
			serverConnectDialog.ShowDialog();
		}

		private void ToolbarEditDropdownClearHistory_Click(object sender, EventArgs e)
		{
			_CurrentCmdHistoryNode = new CmdHistoryNode(null);
			MessageBox.Show("Command History cleared!");
		}

		private void InputText_TextChanged(object sender, EventArgs e)
		{
			InputSend.Enabled = InputText.Text.Trim().Length > 0;
		}

		private void InputText_KeyUp(object sender, KeyEventArgs e)
		{
			bool relevantKeyUp = false;
			if (e.KeyCode == Keys.Up)
			{
				if (_CurrentCmdHistoryNode.PreviousCmdNode != null)
				{
					_CurrentCmdHistoryNode = _CurrentCmdHistoryNode.PreviousCmdNode;
					relevantKeyUp = true;
				}
				else
					SystemSounds.Beep.Play();
			}
			else if (e.KeyCode == Keys.Down)
			{
				if (_CurrentCmdHistoryNode.NextCmdNode != null)
				{
					_CurrentCmdHistoryNode = _CurrentCmdHistoryNode.NextCmdNode;
					relevantKeyUp = true;
				}
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

			_Log(LogType.SENT, InputText.Text);

			string ip = InfoHolder.ServerIP;
			int port = InfoHolder.ServerPort;
			string pass = InfoHolder.ServerPass;
			if (ip == null || port == 0 || pass == null)
			{
				_Log(LogType.RECEIVED, "Please specify a server first.");
				SystemSounds.Beep.Play();
			}
			else
			{
				IPEndPoint endPoint = null;
				try
				{
					endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
				}
				catch (FormatException)
				{
					_Log(LogType.RECEIVED, "Invalid IP");
					SystemSounds.Beep.Play();
				}

				if (endPoint != null)
				{
					UdpClient udp = new UdpClient();
					udp.Client.SendTimeout = 1000;
					udp.Client.ReceiveTimeout = 1000;

					byte[] sendData = Encoding.Default.GetBytes($"\xFF\xFF\xFF\xFFrcon {pass} {InputText.Text}");
					udp.Send(sendData, sendData.Length, endPoint);

					try
					{
						byte[] receiveData = udp.Receive(ref endPoint);
						_Log(LogType.RECEIVED, Encoding.Default.GetString(receiveData).Substring(10));
					}
					catch (SocketException)
					{
						_Log(LogType.RECEIVED, "Time Out");
						SystemSounds.Beep.Play();
					}
				}
			}

			CmdHistoryNode newCmdHistoryNode = new CmdHistoryNode(_CurrentCmdHistoryNode);
			// Set command and next node of current node
			_CurrentCmdHistoryNode.Command = InputText.Text;
			_CurrentCmdHistoryNode.NextCmdNode = newCmdHistoryNode;
			// Set current node to new one
			_CurrentCmdHistoryNode = newCmdHistoryNode;

			InputText.ResetText();
			ActiveControl = InputText;
		}

		private enum LogType {
			SENT,
			RECEIVED
		}

		private void _Log(LogType logType, string text)
		{
			string prefix = null;
			if (InfoHolder.ServerIP != null)
				prefix = InfoHolder.ServerIP;
			if (logType == LogType.SENT)
				prefix = $"{prefix} >";
			else
				prefix = $"{prefix} <";
			Log.AppendText($"{prefix} {text} \r\n");
		}
	}
}
