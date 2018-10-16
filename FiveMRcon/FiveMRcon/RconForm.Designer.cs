﻿namespace FiveMRcon
{
	partial class RconForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.InputText = new System.Windows.Forms.TextBox();
			this.InputSend = new System.Windows.Forms.Button();
			this.Log = new System.Windows.Forms.TextBox();
			this.Toolbar = new System.Windows.Forms.ToolStrip();
			this.ToolbarServerDropdown = new System.Windows.Forms.ToolStripDropDownButton();
			this.ToolbarServerDropdownConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.Toolbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// InputText
			// 
			this.InputText.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.InputText.Location = new System.Drawing.Point(12, 417);
			this.InputText.Name = "InputText";
			this.InputText.Size = new System.Drawing.Size(707, 20);
			this.InputText.TabIndex = 0;
			this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
			// 
			// InputSend
			// 
			this.InputSend.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.InputSend.Enabled = false;
			this.InputSend.Location = new System.Drawing.Point(725, 414);
			this.InputSend.Name = "InputSend";
			this.InputSend.Size = new System.Drawing.Size(63, 23);
			this.InputSend.TabIndex = 1;
			this.InputSend.Text = "Send";
			this.InputSend.UseVisualStyleBackColor = true;
			this.InputSend.Click += new System.EventHandler(this.InputSend_Click);
			// 
			// Log
			// 
			this.Log.Location = new System.Drawing.Point(12, 28);
			this.Log.Multiline = true;
			this.Log.Name = "Log";
			this.Log.ReadOnly = true;
			this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Log.Size = new System.Drawing.Size(776, 380);
			this.Log.TabIndex = 2;
			// 
			// Toolbar
			// 
			this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolbarServerDropdown});
			this.Toolbar.Location = new System.Drawing.Point(0, 0);
			this.Toolbar.Name = "Toolbar";
			this.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.Toolbar.Size = new System.Drawing.Size(800, 25);
			this.Toolbar.TabIndex = 3;
			// 
			// ToolbarServerDropdown
			// 
			this.ToolbarServerDropdown.AutoToolTip = false;
			this.ToolbarServerDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolbarServerDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolbarServerDropdownConnect});
			this.ToolbarServerDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolbarServerDropdown.Name = "ToolbarServerDropdown";
			this.ToolbarServerDropdown.Size = new System.Drawing.Size(52, 22);
			this.ToolbarServerDropdown.Text = "Server";
			this.ToolbarServerDropdown.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			// 
			// ToolbarServerDropdownConnect
			// 
			this.ToolbarServerDropdownConnect.Name = "ToolbarServerDropdownConnect";
			this.ToolbarServerDropdownConnect.Size = new System.Drawing.Size(119, 22);
			this.ToolbarServerDropdownConnect.Text = "Connect";
			this.ToolbarServerDropdownConnect.Click += new System.EventHandler(this.ToolbarServerDropdownConnect_Click);
			// 
			// RconForm
			// 
			this.AcceptButton = this.InputSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Toolbar);
			this.Controls.Add(this.Log);
			this.Controls.Add(this.InputSend);
			this.Controls.Add(this.InputText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "RconForm";
			this.Text = "FiveM Rcon";
			this.Toolbar.ResumeLayout(false);
			this.Toolbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputText;
		private System.Windows.Forms.Button InputSend;
		private System.Windows.Forms.TextBox Log;
		private System.Windows.Forms.ToolStrip Toolbar;
		private System.Windows.Forms.ToolStripDropDownButton ToolbarServerDropdown;
		private System.Windows.Forms.ToolStripMenuItem ToolbarServerDropdownConnect;
	}
}

