namespace LabW16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLocalIP = new TextBox();
            txtLocalPort = new TextBox();
            txtRemotePort = new TextBox();
            txtChatLog = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtMessage = new TextBox();
            txtUserName = new TextBox();
            btn_settings = new Button();
            SuspendLayout();
            // 
            // txtLocalIP
            // 
            txtLocalIP.Location = new Point(12, 42);
            txtLocalIP.Name = "txtLocalIP";
            txtLocalIP.PlaceholderText = "IP";
            txtLocalIP.Size = new Size(100, 23);
            txtLocalIP.TabIndex = 0;
            // 
            // txtLocalPort
            // 
            txtLocalPort.Location = new Point(12, 71);
            txtLocalPort.Name = "txtLocalPort";
            txtLocalPort.PlaceholderText = "Local Port";
            txtLocalPort.Size = new Size(100, 23);
            txtLocalPort.TabIndex = 1;
            // 
            // txtRemotePort
            // 
            txtRemotePort.Location = new Point(12, 100);
            txtRemotePort.Name = "txtRemotePort";
            txtRemotePort.PlaceholderText = "Remote Port";
            txtRemotePort.Size = new Size(100, 23);
            txtRemotePort.TabIndex = 2;
            // 
            // txtChatLog
            // 
            txtChatLog.Font = new Font("Magneto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtChatLog.ForeColor = Color.FromArgb(27, 32, 141);
            txtChatLog.Location = new Point(134, 12);
            txtChatLog.Multiline = true;
            txtChatLog.Name = "txtChatLog";
            txtChatLog.PlaceholderText = "Chat Log";
            txtChatLog.Size = new Size(234, 111);
            txtChatLog.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 188);
            button1.Name = "button1";
            button1.Size = new Size(107, 41);
            button1.TabIndex = 5;
            button1.Text = "Save Log";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSaveChatLog_Click;
            // 
            // button2
            // 
            button2.Location = new Point(261, 141);
            button2.Name = "button2";
            button2.Size = new Size(107, 41);
            button2.TabIndex = 6;
            button2.Text = "Send Message";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSendMessage_Click;
            // 
            // button3
            // 
            button3.Location = new Point(136, 188);
            button3.Name = "button3";
            button3.Size = new Size(107, 41);
            button3.TabIndex = 7;
            button3.Text = "Update Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnUpdateSettings_Click;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Magneto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMessage.ForeColor = Color.FromArgb(27, 32, 141);
            txtMessage.Location = new Point(12, 141);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Message";
            txtMessage.Size = new Size(243, 41);
            txtMessage.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 9;
            // 
            // btn_settings
            // 
            btn_settings.Location = new Point(261, 188);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(107, 41);
            btn_settings.TabIndex = 10;
            btn_settings.Text = "Settings Chat";
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 237);
            Controls.Add(btn_settings);
            Controls.Add(txtUserName);
            Controls.Add(txtMessage);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtChatLog);
            Controls.Add(txtRemotePort);
            Controls.Add(txtLocalPort);
            Controls.Add(txtLocalIP);
            Name = "Form1";
            Text = "Laboratory work 16 v16";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocalIP;
        private TextBox txtLocalPort;
        private TextBox txtRemotePort;
        private TextBox txtChatLog;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtMessage;
        private TextBox txtUserName;
        private Button btn_settings;
    }
}