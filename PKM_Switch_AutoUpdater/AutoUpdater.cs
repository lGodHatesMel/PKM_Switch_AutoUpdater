using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM_Switch_AutoUpdater
{
    public partial class AutoUpdater : Form
    {
        private static readonly HttpClient HttpClient = new();
        private readonly List<string> logsList = new();
        private int totalDownloads;
        private int completedDownloads;

        public AutoUpdater() { InitializeComponent(); }

        private void LogButton(object sender, EventArgs e)
        {
            LogTextBox.Text = GetLogsAsString();
        }

        private async void AMS_HEK_DownloadButton(object sender, EventArgs e)
        {
            var SuccessfulDownloads = new List<string>();
            totalDownloads = 4;
            completedDownloads = 0;

            await CollectDownloads(SuccessfulDownloads, "Atmosphere-NX", "Atmosphere", true);
            await CollectDownloads(SuccessfulDownloads, "Atmosphere-NX", "Atmosphere");
            await CollectDownloads(SuccessfulDownloads, "CTCaer", "hekate");
            await CollectDownloads(SuccessfulDownloads, "olliz0r", "sys-botbase");

            var message = string.Join(Environment.NewLine, SuccessfulDownloads);
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show($"Downloaded:{Environment.NewLine}{message}", "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void PokeViewer_DownloadButton(object sender, EventArgs e)
        {
            var SuccessfulDownloads = new List<string>();
            totalDownloads = 1;
            completedDownloads = 0;

            await CollectDownloads(SuccessfulDownloads, "zyro670", "PokeViewer.NET");

            var message = string.Join(Environment.NewLine, SuccessfulDownloads);

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show($"Downloaded:{Environment.NewLine}{message}", "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void PKHeX_ALM_Official_DownloadButton(object sender, EventArgs e)
        {
            var SuccessfulDownloads = new List<string>();
            totalDownloads = 1;
            completedDownloads = 0;

            await CollectDownloads(SuccessfulDownloads, "architdate", "PKHeX-Plugins");

            var message = string.Join(Environment.NewLine, SuccessfulDownloads);

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show($"Downloaded:{Environment.NewLine}{message}", "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void PKHeX_ALM_Santacrab2_DownloadButton(object sender, EventArgs e)
        {
            var SuccessfulDownloads = new List<string>();
            totalDownloads = 1;
            completedDownloads = 0;

            await CollectDownloads(SuccessfulDownloads, "santacrab2", "PKHeX-Plugins");

            var message = string.Join(Environment.NewLine, SuccessfulDownloads);

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show($"Downloaded:{Environment.NewLine}{message}", "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task CollectDownloads(List<string> SuccessfulDownloads, string owner, string repo, bool preRelease = false)
        {
            try
            {
                HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("SwitchAutoUpdater");

                var apiUrl = preRelease
                    ? $"https://api.github.com/repos/{owner}/{repo}/releases"
                    : $"https://api.github.com/repos/{owner}/{repo}/releases/latest";

                var response = await HttpClient.GetStringAsync(apiUrl);

                var startIndex = response.IndexOf("\"tag_name\":\"") + 12;
                var endIndex = response.IndexOf("\"", startIndex);
                var versionNumber = response[startIndex..endIndex];

                Log($"Version Number: {versionNumber}");

                startIndex = response.IndexOf("\"browser_download_url\":\"") + 24;
                endIndex = response.IndexOf("\"", startIndex);
                var downloadUrl = response[startIndex..endIndex];
                var assetBytes = await HttpClient.GetByteArrayAsync(downloadUrl);

                var releaseType = preRelease ? "Pre" : "Latest";
                var fileName = $"{repo}_{versionNumber}.zip";

                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                await File.WriteAllBytesAsync(filePath, assetBytes);
                SuccessfulDownloads.Add(filePath);

                Log($"Downloaded: {filePath}");

                if (response.Contains("fusee.bin"))
                {
                    startIndex = response.IndexOf("\"browser_download_url\":\"", endIndex) + 24;
                    endIndex = response.IndexOf("\"", startIndex);
                    var fuseeDownloadUrl = response[startIndex..endIndex];

                    var fuseeBytes = await HttpClient.GetByteArrayAsync(fuseeDownloadUrl);

                    var fuseeFileName = $"Atmosphere_v{versionNumber}.bin";
                    var fuseeFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fuseeFileName);
                    await File.WriteAllBytesAsync(fuseeFilePath, fuseeBytes);
                    SuccessfulDownloads.Add(fuseeFilePath);

                    Log($"Downloaded: {fuseeFilePath}");
                }

                completedDownloads++;
                UpdateProgressBar();
            }
            catch (Exception ex)
            {
                Log($"Error downloading {owner}/{repo}: {ex.Message}");
                MessageBox.Show($"Error downloading {owner}/{repo}: {ex.Message}", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar()
        {
            int progress = (int)(((double)completedDownloads / totalDownloads) * 100);
            progressBar.Value = progress;
        }

        private void Log(string logMessage)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log(logMessage)));
            }
            else
            {
                logsList.Add(logMessage);
                LogTextBox.Text = GetLogsAsString();
            }
        }

        private string GetLogsAsString()
        {
            return string.Join(Environment.NewLine, logsList);
        }

        public class GitHubRelease
        {
            public string TagName { get; set; } = string.Empty;
            public bool Prerelease { get; set; }
            public List<GitHubAsset> Assets { get; set; } = new List<GitHubAsset>();
        }

        public class GitHubAsset
        {
            public string BrowserDownloadUrl { get; set; } = string.Empty;
        }

        private void LogTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}