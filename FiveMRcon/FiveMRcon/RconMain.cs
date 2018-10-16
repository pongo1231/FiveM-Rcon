using System;
using System.Windows.Forms;

namespace FiveMRcon
{
	static class RconMain
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new RconForm());
		}
	}
}
