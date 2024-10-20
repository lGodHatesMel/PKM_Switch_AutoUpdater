namespace PKM_Switch_AutoUpdater
{
    partial class AutoUpdater
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button SYSDownload;
        private System.Windows.Forms.Button PokeViewerDownload;
        private System.Windows.Forms.Button PKHeXOfficialALMDownload;
        private System.Windows.Forms.Button PKHeXSantaCrab2ALMDownload;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.ProgressBar progressBar;

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
            this.PKHeXOfficialALMDownload = new System.Windows.Forms.Button();
            this.PKHeXSantaCrab2ALMDownload = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            
            // SYSDownload
            this.SYSDownload.Location = new System.Drawing.Point(10, 10);
            this.SYSDownload.Name = "SYSDownload";
            this.SYSDownload.Size = new System.Drawing.Size(150, 40);
            this.SYSDownload.TabIndex = 0;
            this.SYSDownload.Text = "AMS+HEKETE";
            this.SYSDownload.Click += new System.EventHandler(this.AMS_HEK_DownloadButton);
            
            // PokeViewerDownload
            this.PokeViewerDownload.Location = new System.Drawing.Point(170, 10);
            this.PokeViewerDownload.Name = "PokeViewerDownload";
            this.PokeViewerDownload.Size = new System.Drawing.Size(150, 40);
            this.PokeViewerDownload.TabIndex = 1;
            this.PokeViewerDownload.Text = "PokeViewer";
            this.PokeViewerDownload.Click += new System.EventHandler(this.PokeViewer_DownloadButton);
            
            // PKHeXOfficialALMDownload
            this.PKHeXOfficialALMDownload.Location = new System.Drawing.Point(10, 60);
            this.PKHeXOfficialALMDownload.Name = "PKHeXOfficialALMDownload";
            this.PKHeXOfficialALMDownload.Size = new System.Drawing.Size(150, 40);
            this.PKHeXOfficialALMDownload.TabIndex = 2;
            this.PKHeXOfficialALMDownload.Text = "PKHeX Official ALM";
            this.PKHeXOfficialALMDownload.Click += new System.EventHandler(this.PKHeX_ALM_Official_DownloadButton);
            
            // PKHeXSantaCrab2ALMDownload
            this.PKHeXSantaCrab2ALMDownload.Location = new System.Drawing.Point(170, 60);
            this.PKHeXSantaCrab2ALMDownload.Name = "PKHeXSantaCrab2ALMDownload";
            this.PKHeXSantaCrab2ALMDownload.Size = new System.Drawing.Size(150, 40);
            this.PKHeXSantaCrab2ALMDownload.TabIndex = 3;
            this.PKHeXSantaCrab2ALMDownload.Text = "PKHeX SantaCrab2 ALM";
            this.PKHeXSantaCrab2ALMDownload.Click += new System.EventHandler(this.PKHeX_ALM_Santacrab2_DownloadButton);
            
            // LogTextBox
            this.LogTextBox.Location = new System.Drawing.Point(10, 110);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(310, 100);
            this.LogTextBox.TabIndex = 4;

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(10, 220);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(310, 30);
            this.progressBar.TabIndex = 5;
            
            // AutoUpdater
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 260);
            this.Controls.Add(this.SYSDownload);
            this.Controls.Add(this.PokeViewerDownload);
            this.Controls.Add(this.PKHeXOfficialALMDownload);
            this.Controls.Add(this.PKHeXSantaCrab2ALMDownload);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.progressBar);
            this.MaximizeBox = false;
            this.Name = "AutoUpdater";
            this.Text = "Switch Files Auto Updater";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}