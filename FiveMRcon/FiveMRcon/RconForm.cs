using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace FiveMRcon
{
	public partial class RconForm : Form
	{
		public RconForm()
		{
			InitializeComponent();
			ActiveControl = InputText;
		}

		private void ToolbarServerDropdownConnect_Click(object sender, EventArgs e)
		{
			ServerConnectForm serverConnectDialog = new ServerConnectForm();
			serverConnectDialog.ShowDialog();
		}

		private void InputText_TextChanged(object sender, EventArgs e)
		{
			InputSend.Enabled = InputText.Text.Trim().Length > 0;
		}

		private void InputSend_Click(object sender, EventArgs e)
		{
			InputSend.Enabled = false;

			_Log(LogType.SENT, InputText.Text);

			string ip = InfoHolder.ServerIP;
			int port = InfoHolder.ServerPort;
			string pass = InfoHolder.ServerPass;
			if (ip == null || port == 0 || pass == null)
				_Log(LogType.RECEIVED, "Please specify a server first.");
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
					}
				}
			}

			InputText.ResetText();
			ActiveControl = InputText;
		}

		private enum LogType {
			SENT,
			RECEIVED
		}

		private void _Log(LogType logType, string text)
		{
			Log.AppendText($"{(logType == LogType.SENT ? "> " : "< ")} {text} \r\n");
		}
	}
}
