using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LabW17
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread receiveThread;
        private string username;
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    Close();
                    return;
                }

                string host = loginForm.Host;
                int port = loginForm.Port;
                username = loginForm.Username;
                client = new TcpClient(host, port);
                NetworkStream stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                receiveThread = new Thread(ReceiveMessages);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    string message = reader.ReadLine();
                    Invoke(new Action(() =>
                    {
                        chatTextBox.AppendText(username + ": " + message + Environment.NewLine);
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = messageTextBox.Text;
                writer.WriteLine(message);
                writer.Flush();
                chatTextBox.AppendText(username + ": " + message + Environment.NewLine);
                messageTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                receiveThread?.Abort();
                writer?.Close();
                reader?.Close();
                client?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
