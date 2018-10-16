using System;
using System.Windows.Forms;

namespace FiveMRcon
{
	public partial class ServerConnectForm : Form
	{
		private bool _IsIPAndPassEntered
		{
			get
			{
				return InputIP.Text.Trim().Length > 0 && InputPass.Text.Trim().Length > 0;
			}
		}

		public ServerConnectForm()
		{
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
			InputConnect.Enabled = _IsIPAndPassEntered;
		}

		private void InputPass_TextChanged(object sender, System.EventArgs e)
		{
			InputConnect.Enabled = _IsIPAndPassEntered;
		}

		private void InputConnect_Click(object sender, System.EventArgs e)
		{
			InfoHolder.ServerIP = InputIP.Text.Trim();
			try
			{
				InfoHolder.ServerPort = int.Parse(InputPort.Text);
			}
			catch (FormatException)
			{
				InfoHolder.ServerPort = 30120;
			}
			InfoHolder.ServerPass = InputPass.Text.Trim();
			Close();
		}
	}
}
