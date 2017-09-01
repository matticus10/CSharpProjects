namespace RecCentrePupilCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.csvPathTextBox = new System.Windows.Forms.TextBox();
            this.destinationPathTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.csvPathLabel = new System.Windows.Forms.Label();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.setCSVPathButton = new System.Windows.Forms.Button();
            this.SetDestinationFolderPathButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // csvPathTextBox
            // 
            this.csvPathTextBox.Location = new System.Drawing.Point(113, 12);
            this.csvPathTextBox.Name = "csvPathTextBox";
            this.csvPathTextBox.Size = new System.Drawing.Size(309, 20);
            this.csvPathTextBox.TabIndex = 1;
            // 
            // destinationPathTextBox
            // 
            this.destinationPathTextBox.Location = new System.Drawing.Point(113, 47);
            this.destinationPathTextBox.Name = "destinationPathTextBox";
            this.destinationPathTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.destinationPathTextBox.Size = new System.Drawing.Size(309, 20);
            this.destinationPathTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(428, 91);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // csvPathLabel
            // 
            this.csvPathLabel.AutoSize = true;
            this.csvPathLabel.Location = new System.Drawing.Point(51, 15);
            this.csvPathLabel.Name = "csvPathLabel";
            this.csvPathLabel.Size = new System.Drawing.Size(56, 13);
            this.csvPathLabel.TabIndex = 4;
            this.csvPathLabel.Text = "CSV Path:";
            // 
            // destinationPathLabel
            // 
            this.destinationPathLabel.AutoSize = true;
            this.destinationPathLabel.Location = new System.Drawing.Point(12, 50);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(95, 13);
            this.destinationPathLabel.TabIndex = 5;
            this.destinationPathLabel.Text = "Destination Folder:";
            // 
            // setCSVPathButton
            // 
            this.setCSVPathButton.Location = new System.Drawing.Point(428, 10);
            this.setCSVPathButton.Name = "setCSVPathButton";
            this.setCSVPathButton.Size = new System.Drawing.Size(75, 23);
            this.setCSVPathButton.TabIndex = 6;
            this.setCSVPathButton.Text = "Browse";
            this.setCSVPathButton.UseVisualStyleBackColor = true;
            this.setCSVPathButton.Click += new System.EventHandler(this.setCSVPathButton_Click);
            // 
            // SetDestinationFolderPathButton
            // 
            this.SetDestinationFolderPathButton.Location = new System.Drawing.Point(428, 45);
            this.SetDestinationFolderPathButton.Name = "SetDestinationFolderPathButton";
            this.SetDestinationFolderPathButton.Size = new System.Drawing.Size(75, 23);
            this.SetDestinationFolderPathButton.TabIndex = 7;
            this.SetDestinationFolderPathButton.Text = "Browse";
            this.SetDestinationFolderPathButton.UseVisualStyleBackColor = true;
            this.SetDestinationFolderPathButton.Click += new System.EventHandler(this.SetDestinationFolderPathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "For more information visit:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(145, 129);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(358, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://vle.kings-school.co.uk/isadmin/aide-memoire/rec-centre-pupil-cards";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 152);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetDestinationFolderPathButton);
            this.Controls.Add(this.setCSVPathButton);
            this.Controls.Add(this.destinationPathLabel);
            this.Controls.Add(this.csvPathLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.destinationPathTextBox);
            this.Controls.Add(this.csvPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rec Centre Photo Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox csvPathTextBox;
        private System.Windows.Forms.TextBox destinationPathTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label csvPathLabel;
        private System.Windows.Forms.Label destinationPathLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button setCSVPathButton;
        private System.Windows.Forms.Button SetDestinationFolderPathButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

