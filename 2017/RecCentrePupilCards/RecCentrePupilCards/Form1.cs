using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RecCentrePupilCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidCSVPath(csvPathTextBox.Text) && Validation.IsValidFolderPath(destinationPathTextBox.Text))
            {
                PhotoExport.SetPaths(csvPathTextBox.Text, destinationPathTextBox.Text);
                PhotoExport.CopyPhotos();
                PhotoExport.CompletionMessage();
            }
        }

        private void setCSVPathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                csvPathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void SetDestinationFolderPathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                destinationPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://vle.kings-school.co.uk/isadmin/aide-memoire/rec-centre-pupil-cards");
        }
    }
}
