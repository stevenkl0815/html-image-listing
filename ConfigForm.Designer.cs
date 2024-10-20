
namespace html_image_listing
{
    partial class ConfigForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ClearImageViewer = new System.Windows.Forms.Button();
            this.Btn_ClearBrowser = new System.Windows.Forms.Button();
            this.Btn_SelectImageViewer = new System.Windows.Forms.Button();
            this.Btn_SelectBrowser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtbox_ImageViewer = new System.Windows.Forms.TextBox();
            this.Txtbox_Browser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Btn_ClearImageViewer);
            this.groupBox1.Controls.Add(this.Btn_ClearBrowser);
            this.groupBox1.Controls.Add(this.Btn_SelectImageViewer);
            this.groupBox1.Controls.Add(this.Btn_SelectBrowser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txtbox_ImageViewer);
            this.groupBox1.Controls.Add(this.Txtbox_Browser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.groupBox1.Size = new System.Drawing.Size(440, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your settings";
            // 
            // Btn_ClearImageViewer
            // 
            this.Btn_ClearImageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClearImageViewer.Location = new System.Drawing.Point(375, 86);
            this.Btn_ClearImageViewer.Name = "Btn_ClearImageViewer";
            this.Btn_ClearImageViewer.Size = new System.Drawing.Size(54, 23);
            this.Btn_ClearImageViewer.TabIndex = 7;
            this.Btn_ClearImageViewer.Text = "Reset";
            this.Btn_ClearImageViewer.UseVisualStyleBackColor = true;
            this.Btn_ClearImageViewer.Click += new System.EventHandler(this.Btn_ClearImageViewer_Click);
            // 
            // Btn_ClearBrowser
            // 
            this.Btn_ClearBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClearBrowser.Location = new System.Drawing.Point(375, 39);
            this.Btn_ClearBrowser.Name = "Btn_ClearBrowser";
            this.Btn_ClearBrowser.Size = new System.Drawing.Size(54, 23);
            this.Btn_ClearBrowser.TabIndex = 6;
            this.Btn_ClearBrowser.Text = "Reset";
            this.Btn_ClearBrowser.UseVisualStyleBackColor = true;
            this.Btn_ClearBrowser.Click += new System.EventHandler(this.Btn_ClearBrowser_Click);
            // 
            // Btn_SelectImageViewer
            // 
            this.Btn_SelectImageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_SelectImageViewer.Location = new System.Drawing.Point(315, 86);
            this.Btn_SelectImageViewer.Name = "Btn_SelectImageViewer";
            this.Btn_SelectImageViewer.Size = new System.Drawing.Size(54, 23);
            this.Btn_SelectImageViewer.TabIndex = 5;
            this.Btn_SelectImageViewer.Text = "Browse";
            this.Btn_SelectImageViewer.UseVisualStyleBackColor = true;
            this.Btn_SelectImageViewer.Click += new System.EventHandler(this.Btn_SelectImageViewer_Click);
            // 
            // Btn_SelectBrowser
            // 
            this.Btn_SelectBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_SelectBrowser.Location = new System.Drawing.Point(315, 39);
            this.Btn_SelectBrowser.Name = "Btn_SelectBrowser";
            this.Btn_SelectBrowser.Size = new System.Drawing.Size(54, 23);
            this.Btn_SelectBrowser.TabIndex = 4;
            this.Btn_SelectBrowser.Text = "Browse";
            this.Btn_SelectBrowser.UseVisualStyleBackColor = true;
            this.Btn_SelectBrowser.Click += new System.EventHandler(this.Btn_SelectBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Viewer for images";
            // 
            // Txtbox_ImageViewer
            // 
            this.Txtbox_ImageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtbox_ImageViewer.Enabled = false;
            this.Txtbox_ImageViewer.Location = new System.Drawing.Point(11, 88);
            this.Txtbox_ImageViewer.Name = "Txtbox_ImageViewer";
            this.Txtbox_ImageViewer.Size = new System.Drawing.Size(298, 20);
            this.Txtbox_ImageViewer.TabIndex = 2;
            // 
            // Txtbox_Browser
            // 
            this.Txtbox_Browser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtbox_Browser.Enabled = false;
            this.Txtbox_Browser.Location = new System.Drawing.Point(11, 41);
            this.Txtbox_Browser.Name = "Txtbox_Browser";
            this.Txtbox_Browser.Size = new System.Drawing.Size(298, 20);
            this.Txtbox_Browser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browser for HTML files";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.Location = new System.Drawing.Point(377, 144);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(12, 144);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(464, 179);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_SelectImageViewer;
        private System.Windows.Forms.Button Btn_SelectBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtbox_ImageViewer;
        private System.Windows.Forms.TextBox Txtbox_Browser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_ClearImageViewer;
        private System.Windows.Forms.Button Btn_ClearBrowser;
    }
}