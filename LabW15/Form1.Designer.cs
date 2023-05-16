namespace LabW15
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            treeView1 = new TreeView();
            txtDirectoryName = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(399, 12);
            button1.Name = "button1";
            button1.Size = new Size(82, 51);
            button1.TabIndex = 17;
            button1.Text = "Switch Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSwitchDisplay_Click;
            // 
            // button2
            // 
            button2.Location = new Point(497, 12);
            button2.Name = "button2";
            button2.Size = new Size(68, 51);
            button2.TabIndex = 18;
            button2.Text = "Settings";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSettings_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(381, 268);
            treeView1.TabIndex = 19;
            // 
            // txtDirectoryName
            // 
            txtDirectoryName.Location = new Point(399, 79);
            txtDirectoryName.Name = "txtDirectoryName";
            txtDirectoryName.Size = new Size(166, 23);
            txtDirectoryName.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(399, 108);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "Create";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnCreateDirectory_Click;
            // 
            // button4
            // 
            button4.Location = new Point(490, 108);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 22;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDeleteDirectory_Click;
            // 
            // button5
            // 
            button5.Location = new Point(443, 137);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 23;
            button5.Text = "Upload";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnUploadFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 294);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtDirectoryName);
            Controls.Add(treeView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private TreeView treeView1;
        private TextBox txtDirectoryName;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}