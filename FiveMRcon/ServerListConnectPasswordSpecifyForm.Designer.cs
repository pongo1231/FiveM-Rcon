namespace FiveMRcon
{
	partial class ServerListConnectPasswordSpecifyForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.ConnectPass = new System.Windows.Forms.TextBox();
			this.ConnectOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server Password:";
			// 
			// ConnectPass
			// 
			this.ConnectPass.Location = new System.Drawing.Point(120, 6);
			this.ConnectPass.Name = "ConnectPass";
			this.ConnectPass.Size = new System.Drawing.Size(100, 20);
			this.ConnectPass.TabIndex = 1;
			this.ConnectPass.UseSystemPasswordChar = true;
			// 
			// ConnectOK
			// 
			this.ConnectOK.Location = new System.Drawing.Point(145, 60);
			this.ConnectOK.Name = "ConnectOK";
			this.ConnectOK.Size = new System.Drawing.Size(75, 23);
			this.ConnectOK.TabIndex = 2;
			this.ConnectOK.Text = "OK";
			this.ConnectOK.UseVisualStyleBackColor = true;
			this.ConnectOK.Click += new System.EventHandler(this.ConnectOK_Click);
			// 
			// ServerListConnectPasswordSpecifyForm
			// 
			this.AcceptButton = this.ConnectOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 95);
			this.ControlBox = false;
			this.Controls.Add(this.ConnectOK);
			this.Controls.Add(this.ConnectPass);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ServerListConnectPasswordSpecifyForm";
			this.ShowInTaskbar = false;
			this.Text = "Connect";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ConnectPass;
		private System.Windows.Forms.Button ConnectOK;
	}
}