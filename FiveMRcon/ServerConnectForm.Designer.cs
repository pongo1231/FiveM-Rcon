namespace FiveMRcon
{
	partial class ServerConnectForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConnectForm));
			this.InputIP = new System.Windows.Forms.TextBox();
			this.InputPass = new System.Windows.Forms.TextBox();
			this.InputConnect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.InputPort = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// InputIP
			// 
			this.InputIP.Location = new System.Drawing.Point(75, 16);
			this.InputIP.Name = "InputIP";
			this.InputIP.Size = new System.Drawing.Size(155, 20);
			this.InputIP.TabIndex = 0;
			this.InputIP.TextChanged += new System.EventHandler(this.InputIP_TextChanged);
			// 
			// InputPass
			// 
			this.InputPass.Location = new System.Drawing.Point(75, 62);
			this.InputPass.Name = "InputPass";
			this.InputPass.Size = new System.Drawing.Size(155, 20);
			this.InputPass.TabIndex = 1;
			this.InputPass.UseSystemPasswordChar = true;
			this.InputPass.TextChanged += new System.EventHandler(this.InputPass_TextChanged);
			// 
			// InputConnect
			// 
			this.InputConnect.Enabled = false;
			this.InputConnect.Location = new System.Drawing.Point(239, 62);
			this.InputConnect.Name = "InputConnect";
			this.InputConnect.Size = new System.Drawing.Size(75, 20);
			this.InputConnect.TabIndex = 2;
			this.InputConnect.Text = "Connect";
			this.InputConnect.UseVisualStyleBackColor = true;
			this.InputConnect.Click += new System.EventHandler(this.InputConnect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "IP Address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(236, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Port:";
			// 
			// InputPort
			// 
			this.InputPort.BeepOnError = true;
			this.InputPort.Location = new System.Drawing.Point(271, 16);
			this.InputPort.Mask = "00000";
			this.InputPort.Name = "InputPort";
			this.InputPort.Size = new System.Drawing.Size(39, 20);
			this.InputPort.TabIndex = 7;
			// 
			// ServerConnectForm
			// 
			this.AcceptButton = this.InputConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 97);
			this.Controls.Add(this.InputPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputConnect);
			this.Controls.Add(this.InputPass);
			this.Controls.Add(this.InputIP);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ServerConnectForm";
			this.ShowInTaskbar = false;
			this.Text = "Connect To Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.TextBox InputIP;
		private System.Windows.Forms.TextBox InputPass;
		private System.Windows.Forms.Button InputConnect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox InputPort;
	}
}