using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace html_image_listing
{
    public partial class Form1 : Form
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();

            Program.state.OnStateChange += new AppState.StateChangeHandler(UpdateForm);
        }

        private void UpdateForm(object sender)
        {
            folderBrowserDialog1.SelectedPath = Program.state.InputPath;
            Txtbox_input.Text = Program.state.InputPath;

            saveFileDialog1.FileName = Program.state.OutputFile;
            Txtbox_output.Text = Program.state.OutputFile;

            enableStartButton();
        }


        private void FillTreeView(ResultObject ro)
        {

            tree_ResultView.Nodes.Clear();
            var rootNode = new TreeNode(ro.BasePath, new TreeNode[] { });
            var filesNode = new TreeNode("Files", new TreeNode[] { });
            var unusedImagesNode = new TreeNode("Unused-Images", new TreeNode[] { });

            if (ro.UnusedImages.Count > 0)
            {
                foreach (var item in ro.UnusedImages)
                {
                    unusedImagesNode.Nodes.Add(item.Path);
                }
            }

            if (ro.Files.Count > 0)
            {
                foreach (var item in ro.Files)
                {
                    var node = new TreeNode(item.Path);
                    var brokenLinks = item.Links.Where(i => i.Status == "broken").ToList();
                    if (brokenLinks.Count > 0)
                    {
                        node.BackColor = Color.Red;
                        foreach (var link in brokenLinks)
                        {
                            node.Nodes.Add(link.Url);
                        }
                    }

                    filesNode.Nodes.Add(node);
                }
            }

            rootNode.Nodes.AddRange(new TreeNode[] { filesNode, unusedImagesNode });
            tree_ResultView.Nodes.Add(rootNode);

        }

        private void btn_browseInput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //txtbox_input.Text = folderBrowserDialog1.SelectedPath;
                Program.state.SetState("InputPath", folderBrowserDialog1.SelectedPath);
            }

            enableStartButton();
        }

        private void btn_browseOutput_Click(object sender, EventArgs e)
        {

            if (Program.state.InputPath != "")
            {
                saveFileDialog1.InitialDirectory = Program.state.InputPath;
            }
            else
            {
                saveFileDialog1.InitialDirectory = Application.ExecutablePath;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txtbox_output.Text = saveFileDialog1.FileName;
                Program.state.SetState("OutputFile", saveFileDialog1.FileName);
            }

            enableStartButton();
        }

        private void enableStartButton()
        {
            var path1 = folderBrowserDialog1.SelectedPath;

            if (
                System.IO.Directory.Exists(path1) &&
                Txtbox_output.Text != ""
            )
            {
                Btn_Start.Enabled = true;
            }
            else
            {
                Btn_Start.Enabled = false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateForm(null);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Program.BeginAnalyze();

            if (Program.state.LastError == 0)
            {
                FillTreeView(Program.state.Result);
            }
        }

        private void tree_ResultView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var parentNode = e.Node.Parent;

            if (parentNode.Text == "Unused-Images")
            {
                var openPath = $@"{Program.state.InputPath}\{e.Node.Text}";

                var imageViewer = Properties.Settings.Default.SelectedImageViewer;
                if (imageViewer.Length > 0 && System.IO.File.Exists(imageViewer))
                {

                    using (var process = new Process())
                    {
                        var procInfo = new ProcessStartInfo();
                        process.StartInfo = procInfo;
                        procInfo.FileName = imageViewer;
                        procInfo.Arguments = openPath;
                        _ = process.Start();
                    }
                }
                else
                {
                    Process.Start($"{openPath}");
                }
                
            }

            if (parentNode.Text == "Files")
            {
                var openPath = $@"{Program.state.InputPath}\{e.Node.Text}";
                openPath = openPath.Replace(@"\\", @"\");
                //var openPath = System.IO.Path.Combine(Program.state.InputPath, e.Node.Text);

                var browser = Properties.Settings.Default.SelectedBrowser;
                if (browser.Length <= 0 || !System.IO.File.Exists(browser))
                {
                    browser = @"C:\Program Files\Internet Explorer\iexplore.exe";
                }
                

                using (var process = new Process())
                {
                    Logger.Debug($"Starting {browser} with \"{openPath}\".");
                    var procInfo = new ProcessStartInfo();
                    process.StartInfo = procInfo;
                    procInfo.FileName = browser;
                    procInfo.Arguments = $"-nohangrecovery {openPath}";
                    _ = process.Start();
                }
            }
        }

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            var Config = new ConfigForm();
            _ = Config.ShowDialog(this);
        }
    }
}
