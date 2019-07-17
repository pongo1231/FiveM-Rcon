namespace FiveMRcon
{
	partial class RconForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RconForm));
            this.InputText = new System.Windows.Forms.TextBox();
            this.InputSend = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.ToolbarServerDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolbarServerDropdownSaved = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarServerDropdownConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarEditDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolbarEditDropdownSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarEditDropdownClearHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputText.Location = new System.Drawing.Point(12, 416);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(707, 20);
            this.InputText.TabIndex = 0;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            this.InputText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputText_KeyUp);
            // 
            // InputSend
            // 
            this.InputSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputSend.Enabled = false;
            this.InputSend.Location = new System.Drawing.Point(725, 416);
            this.InputSend.Name = "InputSend";
            this.InputSend.Size = new System.Drawing.Size(63, 20);
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
            this.ToolbarServerDropdown,
            this.ToolbarEditDropdown});
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
            this.ToolbarServerDropdownSaved,
            this.ToolbarServerDropdownConnect});
            this.ToolbarServerDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolbarServerDropdown.Name = "ToolbarServerDropdown";
            this.ToolbarServerDropdown.Size = new System.Drawing.Size(52, 22);
            this.ToolbarServerDropdown.Text = "Server";
            this.ToolbarServerDropdown.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // ToolbarServerDropdownSaved
            // 
            this.ToolbarServerDropdownSaved.Name = "ToolbarServerDropdownSaved";
            this.ToolbarServerDropdownSaved.Size = new System.Drawing.Size(153, 22);
            this.ToolbarServerDropdownSaved.Text = "Saved Servers";
            this.ToolbarServerDropdownSaved.Click += new System.EventHandler(this.ToolbarServerDropdownSaved_Click);
            // 
            // ToolbarServerDropdownConnect
            // 
            this.ToolbarServerDropdownConnect.Name = "ToolbarServerDropdownConnect";
            this.ToolbarServerDropdownConnect.Size = new System.Drawing.Size(153, 22);
            this.ToolbarServerDropdownConnect.Text = "Direct Connect";
            this.ToolbarServerDropdownConnect.Click += new System.EventHandler(this.ToolbarServerDropdownConnect_Click);
            // 
            // ToolbarEditDropdown
            // 
            this.ToolbarEditDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolbarEditDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolbarEditDropdownSettings,
            this.ToolbarEditDropdownClearHistory});
            this.ToolbarEditDropdown.Image = ((System.Drawing.Image)(resources.GetObject("ToolbarEditDropdown.Image")));
            this.ToolbarEditDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolbarEditDropdown.Name = "ToolbarEditDropdown";
            this.ToolbarEditDropdown.Size = new System.Drawing.Size(40, 22);
            this.ToolbarEditDropdown.Text = "Edit";
            // 
            // ToolbarEditDropdownSettings
            // 
            this.ToolbarEditDropdownSettings.Enabled = false;
            this.ToolbarEditDropdownSettings.Name = "ToolbarEditDropdownSettings";
            this.ToolbarEditDropdownSettings.Size = new System.Drawing.Size(214, 22);
            this.ToolbarEditDropdownSettings.Text = "Settings";
            this.ToolbarEditDropdownSettings.Click += new System.EventHandler(this.ToolbarEditDropdownSettings_Click);
            // 
            // ToolbarEditDropdownClearHistory
            // 
            this.ToolbarEditDropdownClearHistory.Name = "ToolbarEditDropdownClearHistory";
            this.ToolbarEditDropdownClearHistory.Size = new System.Drawing.Size(214, 22);
            this.ToolbarEditDropdownClearHistory.Text = "Clear Previous Commands";
            this.ToolbarEditDropdownClearHistory.Click += new System.EventHandler(this.ToolbarEditDropdownClearHistory_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RconForm";
            this.Text = "FiveM Rcon";
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.TextBox InputText;
		private System.Windows.Forms.Button InputSend;
		private System.Windows.Forms.TextBox Log;
		private System.Windows.Forms.ToolStrip Toolbar;
		private System.Windows.Forms.ToolStripDropDownButton ToolbarServerDropdown;
		private System.Windows.Forms.ToolStripMenuItem ToolbarServerDropdownConnect;
		private System.Windows.Forms.ToolStripDropDownButton ToolbarEditDropdown;
		private System.Windows.Forms.ToolStripMenuItem ToolbarEditDropdownClearHistory;
		private System.Windows.Forms.ToolStripMenuItem ToolbarEditDropdownSettings;
		private System.Windows.Forms.ToolStripMenuItem ToolbarServerDropdownSaved;
	}
}

