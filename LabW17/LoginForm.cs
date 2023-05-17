using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabW17
{
    public partial class LoginForm : Form
    {
        public string Host { get; private set; }
        public int Port { get; private set; }
        public string Username { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateLogin(hostTextBox.Text, portTextBox.Text, usernameTextBox.Text, passwordTextBox.Text))
            {
                Host = hostTextBox.Text;
                Port = int.Parse(portTextBox.Text);
                Username = usernameTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateLogin(string host, string port, string username, string password)
        {
            return !string.IsNullOrWhiteSpace(host) &&
                   int.TryParse(port, out int portNumber) &&
                   !string.IsNullOrWhiteSpace(username) &&
                   !string.IsNullOrWhiteSpace(password);
        }
    }
}
