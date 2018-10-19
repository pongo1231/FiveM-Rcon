namespace FiveMRcon
{
	public struct Server
	{
		public string ServerName;
		public string ServerIP;
		public int ServerPort;
		public string ServerPassword;

		public Server(string name, string ip, int port, string password = null)
		{
			ServerName = name;
			ServerIP = ip;
			ServerPort = port;
			ServerPassword = password;
		}
	}
}
