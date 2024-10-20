using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace html_image_listing
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedBrowser = Txtbox_Browser.Text;
            if (Properties.Settings.Default.SelectedBrowser == "")
            {
                Properties.Settings.Default.SelectedBrowser = @"C:\Program Files\Internet Explorer\iexplore.exe";
            }
            Properties.Settings.Default.SelectedImageViewer = Txtbox_ImageViewer.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            Txtbox_Browser.Text = Properties.Settings.Default.SelectedBrowser;
            Txtbox_ImageViewer.Text = Properties.Settings.Default.SelectedImageViewer;
        }

        private void Btn_SelectBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select the executable for your browser";
            openFileDialog1.InitialDirectory = System.Environment.GetEnvironmentVariable("UserProfile");
            openFileDialog1.Filter = "Executable files|*.exe";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Txtbox_Browser.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_SelectImageViewer_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select the executable for your image viewer";
            openFileDialog1.InitialDirectory = System.Environment.GetEnvironmentVariable("UserProfile");
            openFileDialog1.Filter = "Executable files|*.exe";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Txtbox_ImageViewer.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_ClearBrowser_Click(object sender, EventArgs e)
        {
            Txtbox_Browser.Text = "";
        }

        private void Btn_ClearImageViewer_Click(object sender, EventArgs e)
        {
            Txtbox_ImageViewer.Text = "";
        }
    }
}
