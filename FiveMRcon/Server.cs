namespace FiveMRcon
{
	public struct Server
	{
		public string ServerIP { get; }
		public int ServerPort { get; }
		public string ServerPassword { get; }

		public Server(string ip, int port, string password = null)
		{
			ServerIP = ip;
			ServerPort = port;
			ServerPassword = password;
		}
	}
}
