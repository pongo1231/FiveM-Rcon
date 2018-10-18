using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace FiveMRcon
{
	public partial class ServerListForm : Form
	{
		private const string _XFileName = "servers.xml";
		private List<Server> _ServerList;

		public ServerListForm()
		{
			InitializeComponent();
			try
			{
				_InitServers();
			}
			catch (Exception e) when (e is IOException || e is UnauthorizedAccessException || e is FileNotFoundException)
			{
				MessageBox.Show($"Failed reading servers file: {e.Message} {e.StackTrace}");
			}
		}

		private void ServerList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			Server selectedServer = _ServerList[e.Item.Index];
			ServerInputIP.Enabled = true;
			ServerInputIP.Text = selectedServer.ServerIP;
			ServerInputPort.Enabled = true;
			ServerInputPort.Text = $"{selectedServer.ServerPort}";
			ServerInputPass.Enabled = true;
			ServerInputPass.Text = selectedServer.ServerPassword;
			ServerInputSave.Enabled = true;
			ServerDelete.Enabled = true;
		}

		private void _InitServers()
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.LoadXml(_InitFile());
			_ServerList = new List<Server>();
			foreach (XmlNode xServer in xDoc.DocumentElement.ChildNodes)
			{
				string ip = null;
				if (xServer["ip"] != null)
					ip = xServer["ip"].InnerText;
				int port = -1;
				if (xServer["port"] != null)
					port = int.Parse(xServer["port"].InnerText);
				string pass = null;
				if (xServer["pass"] != null)
					pass = xServer["pass"].InnerText;

				if (ip != null && port != -1)
					_ServerList.Add(new Server(ip, port, pass));
			}

			foreach (Server server in _ServerList)
				ServerList.Items.Add(server.ServerIP);
		}

		private string _InitFile()
		{
			if (!File.Exists(_XFileName))
			{
				File.Create(_XFileName).Dispose();
				File.WriteAllText(_XFileName, "<servers>\n\n</servers>");
			}

			return File.ReadAllText(_XFileName);
		}
	}
}
