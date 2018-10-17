namespace FiveMRcon
{
	partial class ServerListForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ServerList = new System.Windows.Forms.ListView();
			this.ServerAdd = new System.Windows.Forms.Button();
			this.ServerDelete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ServerInputIP = new System.Windows.Forms.TextBox();
			this.ServerInputPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ServerInputPass = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ServerList
			// 
			this.ServerList.Location = new System.Drawing.Point(13, 13);
			this.ServerList.Name = "ServerList";
			this.ServerList.Size = new System.Drawing.Size(210, 389);
			this.ServerList.TabIndex = 0;
			this.ServerList.UseCompatibleStateImageBehavior = false;
			// 
			// ServerAdd
			// 
			this.ServerAdd.Location = new System.Drawing.Point(13, 408);
			this.ServerAdd.Name = "ServerAdd";
			this.ServerAdd.Size = new System.Drawing.Size(100, 33);
			this.ServerAdd.TabIndex = 1;
			this.ServerAdd.Text = "New";
			this.ServerAdd.UseVisualStyleBackColor = true;
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
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(230, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Server Address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(231, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Server Port:";
			// 
			// ServerInputIP
			// 
			this.ServerInputIP.Enabled = false;
			this.ServerInputIP.Location = new System.Drawing.Point(327, 10);
			this.ServerInputIP.Name = "ServerInputIP";
			this.ServerInputIP.Size = new System.Drawing.Size(100, 20);
			this.ServerInputIP.TabIndex = 5;
			// 
			// ServerInputPort
			// 
			this.ServerInputPort.Enabled = false;
			this.ServerInputPort.Location = new System.Drawing.Point(327, 57);
			this.ServerInputPort.Name = "ServerInputPort";
			this.ServerInputPort.Size = new System.Drawing.Size(100, 20);
			this.ServerInputPort.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(231, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Server Password:";
			// 
			// ServerInputPass
			// 
			this.ServerInputPass.Enabled = false;
			this.ServerInputPass.Location = new System.Drawing.Point(327, 105);
			this.ServerInputPass.Name = "ServerInputPass";
			this.ServerInputPass.Size = new System.Drawing.Size(100, 20);
			this.ServerInputPass.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(475, 103);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// ServerListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 453);
			this.Controls.Add(this.button1);
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
			this.Name = "ServerListForm";
			this.Text = "Saved Servers";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView ServerList;
		private System.Windows.Forms.Button ServerAdd;
		private System.Windows.Forms.Button ServerDelete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ServerInputIP;
		private System.Windows.Forms.TextBox ServerInputPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ServerInputPass;
		private System.Windows.Forms.Button button1;
	}
}