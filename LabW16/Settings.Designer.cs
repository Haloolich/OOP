﻿namespace LabW16
{
    partial class Settings
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
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 12);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 0;
            button1.Text = "Save Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSaveSettings_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 56);
            button2.Name = "button2";
            button2.Size = new Size(131, 38);
            button2.TabIndex = 1;
            button2.Text = "Select Font";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(42, 100);
            button3.Name = "button3";
            button3.Size = new Size(131, 38);
            button3.TabIndex = 2;
            button3.Text = "Select Color";
            button3.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 149);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
        }

        #endregion

        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}