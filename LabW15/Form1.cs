using System.Net;

namespace LabW15
{
    public partial class Form1 : Form
    {
        private FtpWebRequest ftpRequest;
        private FtpWebResponse ftpResponse;
        private Stream ftpStream;
        private string ftpUsername;
        private string ftpPassword;
        private string serverAddress;

        public Form1()
        {
            InitializeComponent();
        }

        /* private void Form1_Load(object sender, EventArgs e)
         {
             LoadServerContent();
         }*/

        private void LoadServerContent()
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create(serverAddress);
            ftpRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpStream = ftpResponse.GetResponseStream();

            using (StreamReader reader = new StreamReader(ftpStream))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] lineParts = line.Split(new char[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                    string itemName = lineParts[8];

                    TreeNode itemNode = new TreeNode(itemName);
                    treeView1.Nodes.Add(itemNode);

                    line = reader.ReadLine();
                }
            }

            ftpStream.Close();
            ftpResponse.Close();
        }

        private void btnSwitchDisplay_Click(object sender, EventArgs e)
        {
            if (treeView1.ShowRootLines)
                treeView1.ShowRootLines = false;
            else
                treeView1.ShowRootLines = true;
            LoadServerContent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            // Update the server settings based on the values entered in the SettingsForm
            ftpUsername = settingsForm.Username;
            ftpPassword = settingsForm.Password;
            serverAddress = settingsForm.ServerAddress;

            // Clear the existing tree view nodes and load the server content with the updated settings
            treeView1.Nodes.Clear();
        }

        private void CreateDirectory(string directoryName)
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create(Path.Combine(serverAddress, directoryName));
            ftpRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
            ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;

            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }

        private void DeleteDirectory(string directoryName)
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create(Path.Combine(serverAddress, directoryName));
            ftpRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
            ftpRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;

            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }

        private void UploadFile(string localFilePath, string remoteFileName)
        {
            serverAddress = "ftp://192.168.1.2";
            ftpRequest = (FtpWebRequest)WebRequest.Create(Path.Combine(serverAddress, remoteFileName));
            ftpRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead(localFilePath))
            using (Stream ftpStream = ftpRequest.GetRequestStream())
            {
                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ftpStream.Write(buffer, 0, bytesRead);
                }
            }

            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }

        // Add event handlers for the create, delete, and upload actions

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            string directoryName = txtDirectoryName.Text.Trim();
            if (!string.IsNullOrEmpty(directoryName))
            {
                CreateDirectory(directoryName);
                // Refresh the server content after creating the directory
                treeView1.Nodes.Clear();
                LoadServerContent();
            }
        }

        private void btnDeleteDirectory_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != null && selectedNode.Parent != null)
            {
                string directoryName = selectedNode.Text;
                DeleteDirectory(directoryName);
                // Refresh the server content after deleting the directory
                treeView1.Nodes.Clear();
                LoadServerContent();
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = openFileDialog.FileName;
                string remoteFileName = Path.GetFileName(localFilePath);
                UploadFile(localFilePath, remoteFileName);
                // Refresh the server content after uploading the file
                treeView1.Nodes.Clear();
                LoadServerContent();
            }
        }

    }
}