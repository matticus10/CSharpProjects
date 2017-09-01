using System;
using System.IO;
using System.Windows.Forms;

namespace RecCentrePupilCards
{
    public class Validation
    {
        private static string programName = "Rec Centre Photo Exporter";

        public static bool IsValidCSVPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                ErrorMessage("No file selected. Select a CSV file and try again.");
                return false;
            }
            else if (!File.Exists(path))
            {
                ErrorMessage(String.Format("{0} can't find '{1}. Check the spelling and try again.", programName, path));
                return false;
            }
            else if (path.Substring(path.Length - 4, 4) != ".csv")  // Check if file is a CSV
            {
                ErrorMessage(String.Format("'{0}' is not a valid CSV file. Select a CSV file and try again.", path));
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidFolderPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                ErrorMessage("No destinatrion folder selected. Set a destination folder and try again.");
                return false;
            }
            else if (!Directory.Exists(path))
            {
                ErrorMessage(String.Format("{0} can't find '{1}. Check the spelling and try again.", programName, path));
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void ErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage, programName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
