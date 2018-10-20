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
			if (args.Length > 0)
				InfoHolder.ServerIP = args[0];
			if (args.Length > 1)
				try
				{
					InfoHolder.ServerPort = int.Parse(args[1]);
				}
				catch (FormatException)
				{
					InfoHolder.ServerPort = 30120;
				}
			if (args.Length > 2)
				InfoHolder.ServerPass = args[2];

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new RconForm());
		}
	}
}
