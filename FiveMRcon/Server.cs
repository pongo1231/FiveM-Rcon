namespace FiveMRcon
{
	public enum ServerProtocolType
	{
		FIVEM,
		SRCDS
	}

	public struct Server
	{
		public string ServerName { get; }
		public string ServerIP { get; }
		public int ServerPort { get; }
		public string ServerPassword { get; }

		public Server(string name, string ip, int port, string password = null)
		{
			ServerName = name;
			ServerIP = ip;
			ServerPort = port;
			ServerPassword = password;
		}
	}
}
