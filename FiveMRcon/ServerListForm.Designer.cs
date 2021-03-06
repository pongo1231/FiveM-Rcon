﻿namespace FiveMRcon
{
	partial class ServerListForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerListForm));
            this.ServerList = new System.Windows.Forms.ListView();
            this.ServerAdd = new System.Windows.Forms.Button();
            this.ServerDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerInputIP = new System.Windows.Forms.TextBox();
            this.ServerInputPort = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerInputPass = new System.Windows.Forms.TextBox();
            this.ServerInputSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerInputName = new System.Windows.Forms.TextBox();
            this.ServerInputConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ServerInputProtocol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ServerList
            // 
            this.ServerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerList.FullRowSelect = true;
            this.ServerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ServerList.HideSelection = false;
            this.ServerList.Location = new System.Drawing.Point(13, 13);
            this.ServerList.MultiSelect = false;
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(210, 389);
            this.ServerList.TabIndex = 0;
            this.ServerList.UseCompatibleStateImageBehavior = false;
            this.ServerList.View = System.Windows.Forms.View.Tile;
            this.ServerList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ServerList_ItemSelectionChanged);
            // 
            // ServerAdd
            // 
            this.ServerAdd.Location = new System.Drawing.Point(13, 408);
            this.ServerAdd.Name = "ServerAdd";
            this.ServerAdd.Size = new System.Drawing.Size(100, 33);
            this.ServerAdd.TabIndex = 1;
            this.ServerAdd.Text = "New";
            this.ServerAdd.UseVisualStyleBackColor = true;
            this.ServerAdd.Click += new System.EventHandler(this.ServerAdd_Click);
            // 
            // ServerDelete
            // 
            this.ServerDelete.Enabled = false;
            this.ServerDelete.Location = new System.Drawing.Point(123, 408);
            this.ServerDelete.Name = "ServerDelete";
            this.ServerDelete.Size = new System.Drawing.Size(100, 33);
            this.ServerDelete.TabIndex = 2;
            this.ServerDelete.Text = "Delete";
            this.ServerDelete.UseVisualStyleBackColor = true;
            this.ServerDelete.Click += new System.EventHandler(this.ServerDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Port:";
            // 
            // ServerInputIP
            // 
            this.ServerInputIP.Enabled = false;
            this.ServerInputIP.Location = new System.Drawing.Point(328, 58);
            this.ServerInputIP.Name = "ServerInputIP";
            this.ServerInputIP.Size = new System.Drawing.Size(192, 20);
            this.ServerInputIP.TabIndex = 5;
            // 
            // ServerInputPort
            // 
            this.ServerInputPort.Enabled = false;
            this.ServerInputPort.Location = new System.Drawing.Point(328, 105);
            this.ServerInputPort.Mask = "00000";
            this.ServerInputPort.Name = "ServerInputPort";
            this.ServerInputPort.Size = new System.Drawing.Size(37, 20);
            this.ServerInputPort.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server Password:";
            // 
            // ServerInputPass
            // 
            this.ServerInputPass.Enabled = false;
            this.ServerInputPass.Location = new System.Drawing.Point(328, 153);
            this.ServerInputPass.Name = "ServerInputPass";
            this.ServerInputPass.Size = new System.Drawing.Size(100, 20);
            this.ServerInputPass.TabIndex = 8;
            this.ServerInputPass.UseSystemPasswordChar = true;
            // 
            // ServerInputSave
            // 
            this.ServerInputSave.Enabled = false;
            this.ServerInputSave.Location = new System.Drawing.Point(417, 408);
            this.ServerInputSave.Name = "ServerInputSave";
            this.ServerInputSave.Size = new System.Drawing.Size(100, 33);
            this.ServerInputSave.TabIndex = 9;
            this.ServerInputSave.Text = "Save";
            this.ServerInputSave.UseVisualStyleBackColor = true;
            this.ServerInputSave.Click += new System.EventHandler(this.ServerInputSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Server Name:";
            // 
            // ServerInputName
            // 
            this.ServerInputName.Enabled = false;
            this.ServerInputName.Location = new System.Drawing.Point(328, 12);
            this.ServerInputName.Name = "ServerInputName";
            this.ServerInputName.Size = new System.Drawing.Size(192, 20);
            this.ServerInputName.TabIndex = 11;
            // 
            // ServerInputConnect
            // 
            this.ServerInputConnect.Enabled = false;
            this.ServerInputConnect.Location = new System.Drawing.Point(311, 408);
            this.ServerInputConnect.Name = "ServerInputConnect";
            this.ServerInputConnect.Size = new System.Drawing.Size(100, 33);
            this.ServerInputConnect.TabIndex = 12;
            this.ServerInputConnect.Text = "Connect";
            this.ServerInputConnect.UseVisualStyleBackColor = true;
            this.ServerInputConnect.Click += new System.EventHandler(this.ServerInputConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "(Optional, Saves it in plaintext!)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(Optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server Protocol:";
            // 
            // ServerInputProtocol
            // 
            this.ServerInputProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerInputProtocol.FormattingEnabled = true;
            this.ServerInputProtocol.Location = new System.Drawing.Point(325, 203);
            this.ServerInputProtocol.Name = "ServerInputProtocol";
            this.ServerInputProtocol.Size = new System.Drawing.Size(121, 21);
            this.ServerInputProtocol.TabIndex = 16;
            // 
            // ServerListForm
            // 
            this.AcceptButton = this.ServerInputSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 453);
            this.Controls.Add(this.ServerInputProtocol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ServerInputConnect);
            this.Controls.Add(this.ServerInputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ServerInputSave);
            this.Controls.Add(this.ServerInputPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerInputPort);
            this.Controls.Add(this.ServerInputIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerDelete);
            this.Controls.Add(this.ServerAdd);
            this.Controls.Add(this.ServerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerListForm";
            this.ShowInTaskbar = false;
            this.Text = "Saved Servers";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.ListView ServerList;
		private System.Windows.Forms.Button ServerAdd;
		private System.Windows.Forms.Button ServerDelete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ServerInputIP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ServerInputPass;
		private System.Windows.Forms.Button ServerInputSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ServerInputName;
		private System.Windows.Forms.MaskedTextBox ServerInputPort;
		private System.Windows.Forms.Button ServerInputConnect;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox ServerInputProtocol;
	}
}