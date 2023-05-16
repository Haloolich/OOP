using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabW15
{
    public partial class SettingsForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string ServerAddress { get; private set; }

        private const string settingsFilePath = "settings.txt";

        public SettingsForm()
        {
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(settingsFilePath))
            {
                // Load settings from the text file if it exists
                string[] settings = File.ReadAllLines(settingsFilePath);
                if (settings.Length >= 3)
                {
                    txtUsername.Text = settings[0];
                    txtPassword.Text = settings[1];
                    txtServerAddress.Text = settings[2];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the settings to the text file
            string[] settings = { txtUsername.Text, txtPassword.Text, txtServerAddress.Text };
            File.WriteAllLines(settingsFilePath, settings);

            // Set the property values
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            ServerAddress = txtServerAddress.Text;

            // Close the form
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving
            Close();
        }
    }
}
