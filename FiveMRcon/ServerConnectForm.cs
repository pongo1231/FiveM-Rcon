using System;
using System.Windows.Forms;

namespace FiveMRcon
{
	public partial class ServerConnectForm : Form
	{
		private Form _Parent { get; }

		public ServerConnectForm(Form parent)
		{
			_Parent = parent;

			InitializeComponent();

			if (InfoHolder.ServerIP != null)
				InputIP.Text = InfoHolder.ServerIP;
			if (InfoHolder.ServerPort != 0)
				InputPort.Text = $"{InfoHolder.ServerPort}";
			if (InfoHolder.ServerPass != null)
				InputPass.Text = InfoHolder.ServerPass;
		}

		private void InputIP_TextChanged(object sender, System.EventArgs e)
		{
			InputConnect.Enabled = _IsIPEntered();
		}

		private void InputPass_TextChanged(object sender, System.EventArgs e)
		{
			InputConnect.Enabled = _IsIPEntered();
		}

		private void InputConnect_Click(object sender, System.EventArgs e)
		{
			InfoHolder.ServerIP = InputIP.Text.Trim();
			if (int.TryParse(InputPort.Text, out int port))
				InfoHolder.ServerPort = port;
			else
				InfoHolder.ServerPort = 30120;

			_Parent.Text = InputIP.Text;
			Close();
		}

		private bool _IsIPEntered()
		{
			return !InputIP.Text._IsStringNull();
		}
	}
}
