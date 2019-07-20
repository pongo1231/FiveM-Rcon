using System;
using System.Windows.Forms;

namespace FiveMRcon
{
	static class RconMain
	{
		[STAThread]
		static void Main()
		{
			string[] args = Environment.GetCommandLineArgs();
			if (args.Length > 1)
				InfoHolder.ServerIP = args[1];
			if (args.Length > 2)
            {
				if (int.TryParse(args[2], out int port))
					InfoHolder.ServerPort = port;
				else
					InfoHolder.ServerPort = 30120;
			}
			if (args.Length > 3)
				InfoHolder.ServerPass = args[3];

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new RconForm());
		}
	}
}
