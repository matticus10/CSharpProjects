using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RecCentrePupilCards
{
    public class PhotoExport
    {
        private static int fileCount;
        private static int duplicateCount;
        private static string csvPath;
        private static string destinationPath;
        private static string photoRepositoryPath = @"";    // TODO Set iSAMS photo repository path
        private static List<string> photoName = new List<string>();
        private static List<string> photoPath = new List<string>();
        
        public static void SetPaths(string csvPathInput, string destinationPathInput)
        {
            // Clear lists if they have been used before
            if (photoName.Count > 0 || photoPath.Count > 0)
            {
                photoName.Clear();
                photoPath.Clear();
            }

            csvPath = csvPathInput;            
            destinationPath = destinationPathInput + @"\";

            foreach (var line in File.ReadLines(csvPath))
            {
                var input = line.Split(',');
                photoName.Add(input[0] + ".jpg");
                photoPath.Add(input[1]);
            }
        }

        public static void CopyPhotos()
        {
            fileCount = 0;
            duplicateCount = 0;

            for (var i = 0; i < photoPath.Count; i++)
            {
                if (!File.Exists(destinationPath + photoName[i]))
                {
                    File.Copy(photoRepositoryPath + photoPath[i], destinationPath + photoName[i]);
                    fileCount++;
                }
                else
                {
                    duplicateCount++;
                }
            }
        }

        public static void CompletionMessage()
        {
            MessageBox.Show(string.Format("Export complete!\n\n{0} files copied.\n{1} duplicates were not copied.", fileCount, duplicateCount), "Rec Centre Photo Exporter");
        }
    }
}
