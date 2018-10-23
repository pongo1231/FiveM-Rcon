namespace FiveMRcon
{
	public enum ServerProtocolType
	{
		FIVEM,
		SRCDS
	}

	public struct Server
	{
		public ServerProtocolType ServerProtocol { get; }
		public string ServerName { get; }
		public string ServerIP { get; }
		public int ServerPort { get; }
		public string ServerPassword { get; }

		public Server(ServerProtocolType protocol, string name, string ip, int port, string password = null)
		{
			ServerProtocol = protocol;
			ServerName = name;
			ServerIP = ip;
			ServerPort = port;
			ServerPassword = password;
		}
	}
}
