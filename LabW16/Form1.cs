using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace LabW16
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private IPEndPoint remoteEndPoint;
        private string localIPAddress;
        private int localPort;
        private int remotePort;
         private Font chatFont;
         private Color chatTextColor;

        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize default chat parameters
            localIPAddress = "127.0.0.1"; // Default local IP address
            localPort = 5000; // Default local port
            remotePort = 5000; // Default remote port

            // Set the initial values in the UI
            txtLocalIP.Text = localIPAddress;
            txtLocalPort.Text = localPort.ToString();
            txtRemotePort.Text = remotePort.ToString();
            /*chatFont = new Font("Arial", 12);
            chatTextColor = Color.Black;
            SetChatFont(chatFont);
            SetChatTextColor(chatTextColor);*/

            // Initialize UDP client
            udpClient = new UdpClient(localPort);
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(localIPAddress), remotePort);

            // Start receiving messages in a background thread
            StartReceiving();
        }

        private void StartReceiving()
        {
            udpClient.BeginReceive(ReceiveCallback, null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                byte[] receivedBytes = udpClient.EndReceive(ar, ref remoteEndPoint);
                string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

                // Display the received message in the chat log
                AddToChatLog($"[Received] {receivedMessage}");

                // Continue listening for more messages
                StartReceiving();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during receiving
                MessageBox.Show("An error occurred while receiving a message: " + ex.Message);
            }
        }

        private void SendMessage(string message)
        {
            try
            {
                string username = txtUserName.Text;
                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                udpClient.Send(sendBytes, sendBytes.Length, remoteEndPoint);

                // Display the sent message in the chat log
                AddToChatLog($"[{username}] {message}");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during sending
                MessageBox.Show("An error occurred while sending a message: " + ex.Message);
            }
        }

        private void AddToChatLog(string message)
        {
            txtChatLog.AppendText(message + Environment.NewLine);
        }

        private void btnSaveChatLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string chatLog = txtChatLog.Text;

                // Save the chat log to a text file
                File.WriteAllText(filePath, chatLog);

                MessageBox.Show("Chat log saved successfully!");
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                SendMessage(message);
                txtMessage.Clear();
            }
        }
        private void UpdateChatSettings()
         {
             // Update chat font based on the selected font name and size
             string fontName = chatSettingsForm.SelectedFontName;
             float fontSize = chatSettingsForm.SelectedFontSize;
             chatFont = new Font(fontName, fontSize);

             // Update chat text color based on the selected color
             chatTextColor = chatSettingsForm.SelectedColor;

             // Apply the new chat settings to the UI elements
             SetChatFont(chatFont);
             SetChatTextColor(chatTextColor);
         }

         private void SetChatTextColor(Color color)
         {
             txtChatLog.ForeColor = color;
             txtMessage.ForeColor = color;
         }
         private void SetChatFont(Font font)
         {
             txtChatLog.Font = font;
             txtMessage.Font = font;
         }
         private void SetChatSize(Size size)
         {
             txtChatLog.Size = size;
             txtMessage.Size = size;
         }
        private void btnUpdateSettings_Click(object sender, EventArgs e)
        {
            // Update chat parameters based on the values entered in the UI
            localIPAddress = txtLocalIP.Text.Trim();
            localPort = int.Parse(txtLocalPort.Text.Trim());
            remotePort = int.Parse(txtRemotePort.Text.Trim());
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(localIPAddress), remotePort);
            udpClient.Close();
            udpClient = new UdpClient(localPort);

            MessageBox.Show("Chat settings updated successfully!");
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(chatFont, chatTextColor, chatSize);
            settingsForm.ShowDialog();
            if (chatSettingsForm.ShowDialog() == DialogResult.OK)
             {
                 // Retrieve the updated chat settings from the settings form
                 chatFont = chatSettingsForm.SelectedFont;
                 chatTextColor = chatSettingsForm.SelectedColor;
                 chatSize = chatSettingsForm.SelectedSize;

                 // Apply the new chat settings to the UI elements
                 SetChatFont(chatFont);
                 SetChatTextColor(chatTextColor);
                 SetChatSize(chatSize);

             }
        }
    }
}