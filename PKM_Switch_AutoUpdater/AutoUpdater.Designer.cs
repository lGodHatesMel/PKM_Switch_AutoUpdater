namespace PKM_Switch_AutoUpdater
{
    partial class AutoUpdater
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button SYSDownload;
        private System.Windows.Forms.Button PokeViewerDownload;
        private System.Windows.Forms.Button PKHeXALMDownload;
        private System.Windows.Forms.Button Logs;
        private System.Windows.Forms.TextBox LogTextBox;
        // private System.Windows.Forms.ProgressBar progressBar;


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
            this.SYSDownload = new System.Windows.Forms.Button();
            this.PokeViewerDownload = new System.Windows.Forms.Button();
            this.PKHeXALMDownload = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SYSDownload
            // 
            this.SYSDownload.Location = new System.Drawing.Point(-3, 0);
            this.SYSDownload.Name = "SYSDownload";
            this.SYSDownload.Size = new System.Drawing.Size(115, 40);
            this.SYSDownload.TabIndex = 0;
            this.SYSDownload.Text = "AMS+HEKETE";
            this.SYSDownload.Click += new System.EventHandler(this.AMS_HEK_DownloadButton);
            // 
            // Logs
            // 
            this.Logs.Location = new System.Drawing.Point(124, 140);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(100, 40);
            this.Logs.TabIndex = 1;
            this.Logs.Text = "Show Log";
            this.Logs.Click += new System.EventHandler(this.LogButton);
            // 
            // PokeViewerDownload
            // 
            this.PokeViewerDownload.Location = new System.Drawing.Point(282, 0);
            this.PokeViewerDownload.Name = "PokeViewerDownload";
            this.PokeViewerDownload.Size = new System.Drawing.Size(115, 40);
            this.PokeViewerDownload.TabIndex = 2;
            this.PokeViewerDownload.Text = "PokeViewer";
            this.PokeViewerDownload.Click += new System.EventHandler(this.PokeViewer_DownloadButton);
            // 
            // PKHeXALMDownload
            // 
            this.PKHeXALMDownload.Location = new System.Drawing.Point(138, 0);
            this.PKHeXALMDownload.Name = "PKHeXALMDownload";
            this.PKHeXALMDownload.Size = new System.Drawing.Size(115, 40);
            this.PKHeXALMDownload.TabIndex = 2;
            this.PKHeXALMDownload.Text = "PKHeX+ALM";
            this.PKHeXALMDownload.Click += new System.EventHandler(this.PKHeX_ALM_DownloadButton);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(-3, 186);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(400, 101);
            this.LogTextBox.TabIndex = 3;
            // 
            // AutoUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 287);
            this.Controls.Add(this.SYSDownload);
            this.Controls.Add(this.PokeViewerDownload);
            this.Controls.Add(this.PKHeXALMDownload);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.LogTextBox);
            this.MaximizeBox = false;
            this.Name = "AutoUpdater";
            this.Text = "Switch Files Auto Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
