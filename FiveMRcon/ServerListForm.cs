﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace FiveMRcon
{
	public partial class ServerListForm : Form
	{
		private const string _XFileName = "servers.xml";
		private Form _Parent;
		private List<Server> _ServerList;
		private int _ServerItemIndex;

		public ServerListForm(Form parent)
		{
			_Parent = parent;
			_ServerItemIndex = -1;

			InitializeComponent();
			try
			{
				_InitServersList();
			}
			catch (Exception e) when (e is IOException || e is UnauthorizedAccessException || e is FileNotFoundException)
			{
				MessageBox.Show($"Failed reading {_XFileName}: {e.Message} {e.StackTrace}");
			}
		}

		private void ServerList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			bool isSelected = ServerList.SelectedItems.Count > 0;
			_SetServerEditUIEnabled(isSelected);
			if (!isSelected)
			{
				_ClearServerEditInputs();
				_ServerItemIndex = -1;
			}
			else
			{
				Server selectedServer = _ServerList[e.ItemIndex];
				ServerInputName.Text = selectedServer.ServerName;
				ServerInputIP.Text = selectedServer.ServerIP;
				ServerInputPort.Text = $"{selectedServer.ServerPort}";
				ServerInputPass.Text = selectedServer.ServerPassword;
				_ServerItemIndex = e.ItemIndex;
			}
		}

		private void ServerInputSave_Click(object sender, EventArgs e)
		{
			if (_CheckForValidInputIPAndPort())
			{
				// Replace current server info with new ones
				_ApplyInputInfoToServer();
				_WriteAndRefreshServerItems();
			}
		}

		private void ServerInputConnect_Click(object sender, EventArgs e)
		{
			if (_CheckForValidInputIPAndPort())
			{
				_ApplyInputInfoToServer();
				_WriteServersFile();
				Server server = _ServerList[_ServerItemIndex];
				InfoHolder.ServerIP = server.ServerIP;
				InfoHolder.ServerPort = server.ServerPort;
				if (_IsStringNull(server.ServerPassword))
					new ServerListConnectPasswordSpecifyForm().ShowDialog();
				else
					InfoHolder.ServerPass = server.ServerPassword;
				_Parent.Text = !_IsStringNull(server.ServerName) ? server.ServerName : server.ServerIP;
				Close();
			}
		}

		private void ServerAdd_Click(object sender, EventArgs e)
		{
			Server newServer = new Server("New Server", null, 30120);
			_ServerList.Add(newServer);
			// Set item index to new server item
			_ServerItemIndex = _ServerList.Count - 1;
			_WriteAndRefreshServerItems();
		}


		private void ServerDelete_Click(object sender, EventArgs e)
		{
			_ServerList.RemoveAt(_ServerItemIndex);
			// Don't set focus on any item after refresh
			_ServerItemIndex = -1;
			_WriteAndRefreshServerItems();
		}

		private void _SetServerEditUIEnabled(bool enabled)
		{
			ServerInputName.Enabled = enabled;
			ServerInputIP.Enabled = enabled;
			ServerInputPort.Enabled = enabled;
			ServerInputPass.Enabled = enabled;
			ServerInputSave.Enabled = enabled;
			ServerInputConnect.Enabled = enabled;
			ServerDelete.Enabled = enabled;
		}

		private void _ClearServerEditInputs()
		{
			ServerInputName.Text = null;
			ServerInputIP.Text = null;
			ServerInputPort.Text = null;
			ServerInputPass.Text = null;
		}

		private void _InitServersList()
		{
			XmlDocument xDoc = new XmlDocument();
			try
			{
				xDoc.LoadXml(_InitServersFile());
			}
			catch (XmlException)
			{
				MessageBox.Show($"{_XFileName} is corrupted! Please check the file for errors or remove it for regeneration.");
				Close();
				return;
			}

			_ServerList = new List<Server>();
			foreach (XmlNode xServer in xDoc.DocumentElement.ChildNodes)
			{
				string name = null;
				if (xServer["name"] != null)
					name = xServer["name"].InnerText.Trim();
				string ip = null;
				if (xServer["ip"] != null)
					ip = xServer["ip"].InnerText.Trim();
				int port = -1;
				if (xServer["port"] != null)
					try
					{
						port = int.Parse(xServer["port"].InnerText.Trim());
					}
					catch (FormatException)
					{
						MessageBox.Show($"Error while parsing port of server in {_XFileName}: {(!_IsStringNull(name) ? "name / " : "")}" +
							$"{ip}:{xServer["port"].InnerText.Trim()}");
						Close();
						return;
					}
				string pass = null;
				if (xServer["pass"] != null)
					pass = xServer["pass"].InnerText.Trim();
				_ServerList.Add(new Server(name, ip, port, pass));
			}

			ServerList.Items.Clear();
			foreach (Server server in _ServerList)
				ServerList.Items.Add(!_IsStringNull(server.ServerName) ? server.ServerName : server.ServerIP);

			_SetServerEditUIEnabled(_ServerItemIndex != -1);
			_ClearServerEditInputs();
			// Set focus on previous item (if an item was previously selected)
			if (_ServerItemIndex != -1)
			{
				ServerList.Items[_ServerItemIndex].Selected = true;
				ServerList.Select();
				//ServerList.Items[_ServerItemIndex].EnsureVisible();
			}
		}

		private string _InitServersFile()
		{
			if (!File.Exists(_XFileName))
				File.WriteAllText(_XFileName, "<servers>\n\n</servers>");

			return File.ReadAllText(_XFileName);
		}

		private void _WriteServersFile()
		{
			string writeText = "<servers>\n";
			foreach (Server server in _ServerList)
			{
				writeText += "	<server>\n";
				if (!_IsStringNull(server.ServerName))
					writeText += $"		<name>{server.ServerName.Trim()}</name>\n";
				if (!_IsStringNull(server.ServerIP))
					writeText += $"		<ip>{server.ServerIP.Trim()}</ip>\n";
				writeText += $"		<port>{server.ServerPort}</port>\n";
				if (!_IsStringNull(server.ServerPassword))
					writeText += $"		<pass>{server.ServerPassword.Trim()}</pass>\n";
				writeText += "	</server>\n";
			}
			writeText += "</servers>";
			File.WriteAllText(_XFileName, writeText);
		}

		private void _WriteAndRefreshServerItems()
		{
			_WriteServersFile();
			_InitServersList();
		}

		private bool _IsStringNull(string text)
		{
			return text == null || text.Trim() == "";
		}

		private bool _CheckForValidInputIPAndPort()
		{
			bool valid = !_IsStringNull(ServerInputIP.Text) && !_IsStringNull(ServerInputPort.Text);
			if (!valid)
				MessageBox.Show("Please enter an IP and a Port.");
			return valid;
		}

		private void _ApplyInputInfoToServer()
		{
			_ServerList[_ServerItemIndex] = new Server(ServerInputName.Text, ServerInputIP.Text, int.Parse(ServerInputPort.Text),
					ServerInputPass.Text);
		}
	}
}
