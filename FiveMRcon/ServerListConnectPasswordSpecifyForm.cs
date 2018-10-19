using System.Windows.Forms;

namespace FiveMRcon
{
	public partial class ServerListConnectPasswordSpecifyForm : Form
	{
		public ServerListConnectPasswordSpecifyForm()
		{
			InitializeComponent();
		}

		private void ConnectOK_Click(object sender, System.EventArgs e)
		{
			InfoHolder.ServerPass = ConnectPass.Text.Trim();
			Close();
		}
	}
}
