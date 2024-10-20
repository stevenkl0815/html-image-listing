
namespace html_image_listing
{
    partial class Form1
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
            this.Btn_browseInput = new System.Windows.Forms.Button();
            this.Txtbox_input = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_browseOutput = new System.Windows.Forms.Button();
            this.Txtbox_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Config = new System.Windows.Forms.Button();
            this.Btn_LoadLastResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbobox_LastResults = new System.Windows.Forms.ComboBox();
            this.tree_ResultView = new System.Windows.Forms.TreeView();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_browseInput);
            this.groupBox1.Controls.Add(this.Txtbox_input);
            this.groupBox1.Controls.Add(this.lbl_input);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Btn_browseInput
            // 
            this.Btn_browseInput.Location = new System.Drawing.Point(508, 30);
            this.Btn_browseInput.Name = "Btn_browseInput";
            this.Btn_browseInput.Size = new System.Drawing.Size(75, 23);
            this.Btn_browseInput.TabIndex = 2;
            this.Btn_browseInput.Text = "Browse";
            this.Btn_browseInput.UseVisualStyleBackColor = true;
            this.Btn_browseInput.Click += new System.EventHandler(this.btn_browseInput_Click);
            // 
            // Txtbox_input
            // 
            this.Txtbox_input.Location = new System.Drawing.Point(9, 32);
            this.Txtbox_input.Name = "Txtbox_input";
            this.Txtbox_input.ReadOnly = true;
            this.Txtbox_input.Size = new System.Drawing.Size(493, 20);
            this.Txtbox_input.TabIndex = 1;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(6, 16);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(114, 13);
            this.lbl_input.TabIndex = 0;
            this.lbl_input.Text = "Directory with html files";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_browseOutput);
            this.groupBox2.Controls.Add(this.Txtbox_output);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // Btn_browseOutput
            // 
            this.Btn_browseOutput.Location = new System.Drawing.Point(508, 30);
            this.Btn_browseOutput.Name = "Btn_browseOutput";
            this.Btn_browseOutput.Size = new System.Drawing.Size(75, 23);
            this.Btn_browseOutput.TabIndex = 4;
            this.Btn_browseOutput.Text = "Browse";
            this.Btn_browseOutput.UseVisualStyleBackColor = true;
            this.Btn_browseOutput.Click += new System.EventHandler(this.btn_browseOutput_Click);
            // 
            // Txtbox_output
            // 
            this.Txtbox_output.Location = new System.Drawing.Point(9, 32);
            this.Txtbox_output.Name = "Txtbox_output";
            this.Txtbox_output.ReadOnly = true;
            this.Txtbox_output.Size = new System.Drawing.Size(493, 20);
            this.Txtbox_output.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path for Results file";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Result.xml";
            this.saveFileDialog1.Filter = "XML-File|*.xml|All files|*.*";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Enabled = false;
            this.Btn_Start.Location = new System.Drawing.Point(520, 561);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Config);
            this.groupBox3.Controls.Add(this.Btn_LoadLastResult);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Cbobox_LastResults);
            this.groupBox3.Controls.Add(this.tree_ResultView);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 395);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // Btn_Config
            // 
            this.Btn_Config.Location = new System.Drawing.Point(508, 30);
            this.Btn_Config.Name = "Btn_Config";
            this.Btn_Config.Size = new System.Drawing.Size(75, 23);
            this.Btn_Config.TabIndex = 4;
            this.Btn_Config.Text = "Config";
            this.Btn_Config.UseVisualStyleBackColor = true;
            this.Btn_Config.Click += new System.EventHandler(this.Btn_Config_Click);
            // 
            // Btn_LoadLastResult
            // 
            this.Btn_LoadLastResult.Enabled = false;
            this.Btn_LoadLastResult.Location = new System.Drawing.Point(252, 30);
            this.Btn_LoadLastResult.Name = "Btn_LoadLastResult";
            this.Btn_LoadLastResult.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoadLastResult.TabIndex = 3;
            this.Btn_LoadLastResult.Text = "Load";
            this.Btn_LoadLastResult.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Results";
            // 
            // Cbobox_LastResults
            // 
            this.Cbobox_LastResults.Enabled = false;
            this.Cbobox_LastResults.FormattingEnabled = true;
            this.Cbobox_LastResults.Location = new System.Drawing.Point(9, 32);
            this.Cbobox_LastResults.Name = "Cbobox_LastResults";
            this.Cbobox_LastResults.Size = new System.Drawing.Size(237, 21);
            this.Cbobox_LastResults.TabIndex = 1;
            // 
            // tree_ResultView
            // 
            this.tree_ResultView.Location = new System.Drawing.Point(9, 59);
            this.tree_ResultView.Name = "tree_ResultView";
            this.tree_ResultView.Size = new System.Drawing.Size(574, 330);
            this.tree_ResultView.TabIndex = 0;
            this.tree_ResultView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_ResultView_NodeMouseDoubleClick);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(21, 561);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 590);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Images in HTML files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_browseInput;
        private System.Windows.Forms.TextBox Txtbox_input;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_browseOutput;
        private System.Windows.Forms.TextBox Txtbox_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView tree_ResultView;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Config;
        private System.Windows.Forms.Button Btn_LoadLastResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbobox_LastResults;
    }
}

