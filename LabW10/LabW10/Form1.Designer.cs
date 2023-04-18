namespace LabW10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RandomNumberTextBox = new System.Windows.Forms.TextBox();
            this.FirstMethodButton = new System.Windows.Forms.Button();
            this.SecondMethodButton = new System.Windows.Forms.Button();
            this.ThirdMethodButton = new System.Windows.Forms.Button();
            this.StartThreadingButton = new System.Windows.Forms.Button();
            this.StopThreadButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbPlaintext = new System.Windows.Forms.TextBox();
            this.tbSEAL = new System.Windows.Forms.TextBox();
            this.tbMD4 = new System.Windows.Forms.TextBox();
            this.tbCAST = new System.Windows.Forms.TextBox();
            this.btnCript = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 275);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(264, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 275);
            this.panel2.TabIndex = 1;
            // 
            // RandomNumberTextBox
            // 
            this.RandomNumberTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RandomNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandomNumberTextBox.Location = new System.Drawing.Point(520, 7);
            this.RandomNumberTextBox.Multiline = true;
            this.RandomNumberTextBox.Name = "RandomNumberTextBox";
            this.RandomNumberTextBox.Size = new System.Drawing.Size(242, 275);
            this.RandomNumberTextBox.TabIndex = 2;
            // 
            // FirstMethodButton
            // 
            this.FirstMethodButton.Location = new System.Drawing.Point(52, 288);
            this.FirstMethodButton.Name = "FirstMethodButton";
            this.FirstMethodButton.Size = new System.Drawing.Size(75, 23);
            this.FirstMethodButton.TabIndex = 3;
            this.FirstMethodButton.Text = "Start";
            this.FirstMethodButton.UseVisualStyleBackColor = true;
            this.FirstMethodButton.Click += new System.EventHandler(this.FirstMethodButton_Click);
            // 
            // SecondMethodButton
            // 
            this.SecondMethodButton.Location = new System.Drawing.Point(297, 288);
            this.SecondMethodButton.Name = "SecondMethodButton";
            this.SecondMethodButton.Size = new System.Drawing.Size(75, 23);
            this.SecondMethodButton.TabIndex = 4;
            this.SecondMethodButton.Text = "Start";
            this.SecondMethodButton.UseVisualStyleBackColor = true;
            this.SecondMethodButton.Click += new System.EventHandler(this.SecondMethodButton_Click);
            // 
            // ThirdMethodButton
            // 
            this.ThirdMethodButton.Location = new System.Drawing.Point(570, 288);
            this.ThirdMethodButton.Name = "ThirdMethodButton";
            this.ThirdMethodButton.Size = new System.Drawing.Size(75, 23);
            this.ThirdMethodButton.TabIndex = 5;
            this.ThirdMethodButton.Text = "Start";
            this.ThirdMethodButton.UseVisualStyleBackColor = true;
            this.ThirdMethodButton.Click += new System.EventHandler(this.ThirdMethodButton_Click);
            // 
            // StartThreadingButton
            // 
            this.StartThreadingButton.Location = new System.Drawing.Point(264, 354);
            this.StartThreadingButton.Name = "StartThreadingButton";
            this.StartThreadingButton.Size = new System.Drawing.Size(108, 23);
            this.StartThreadingButton.TabIndex = 6;
            this.StartThreadingButton.Text = "Start all";
            this.StartThreadingButton.UseVisualStyleBackColor = true;
            this.StartThreadingButton.Click += new System.EventHandler(this.StartThreadingButton_Click);
            // 
            // StopThreadButton
            // 
            this.StopThreadButton.Location = new System.Drawing.Point(392, 354);
            this.StopThreadButton.Name = "StopThreadButton";
            this.StopThreadButton.Size = new System.Drawing.Size(108, 23);
            this.StopThreadButton.TabIndex = 7;
            this.StopThreadButton.Text = "Stop all";
            this.StopThreadButton.UseVisualStyleBackColor = true;
            this.StopThreadButton.Click += new System.EventHandler(this.StopThreadButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 433);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.RandomNumberTextBox);
            this.tabPage1.Controls.Add(this.StartThreadingButton);
            this.tabPage1.Controls.Add(this.StopThreadButton);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.FirstMethodButton);
            this.tabPage1.Controls.Add(this.ThirdMethodButton);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.SecondMethodButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "example";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbKey);
            this.tabPage2.Controls.Add(this.tbPlaintext);
            this.tabPage2.Controls.Add(this.tbSEAL);
            this.tabPage2.Controls.Add(this.tbMD4);
            this.tabPage2.Controls.Add(this.tbCAST);
            this.tabPage2.Controls.Add(this.btnCript);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "me code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(75, 331);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(234, 70);
            this.tbKey.TabIndex = 5;
            // 
            // tbPlaintext
            // 
            this.tbPlaintext.Location = new System.Drawing.Point(400, 331);
            this.tbPlaintext.Multiline = true;
            this.tbPlaintext.Name = "tbPlaintext";
            this.tbPlaintext.Size = new System.Drawing.Size(234, 70);
            this.tbPlaintext.TabIndex = 4;
            // 
            // tbSEAL
            // 
            this.tbSEAL.Location = new System.Drawing.Point(518, 45);
            this.tbSEAL.Multiline = true;
            this.tbSEAL.Name = "tbSEAL";
            this.tbSEAL.Size = new System.Drawing.Size(234, 235);
            this.tbSEAL.TabIndex = 3;
            // 
            // tbMD4
            // 
            this.tbMD4.Location = new System.Drawing.Point(259, 45);
            this.tbMD4.Multiline = true;
            this.tbMD4.Name = "tbMD4";
            this.tbMD4.Size = new System.Drawing.Size(234, 235);
            this.tbMD4.TabIndex = 2;
            // 
            // tbCAST
            // 
            this.tbCAST.Location = new System.Drawing.Point(10, 45);
            this.tbCAST.Multiline = true;
            this.tbCAST.Name = "tbCAST";
            this.tbCAST.Size = new System.Drawing.Size(234, 235);
            this.tbCAST.TabIndex = 1;
            // 
            // btnCript
            // 
            this.btnCript.Location = new System.Drawing.Point(643, 331);
            this.btnCript.Name = "btnCript";
            this.btnCript.Size = new System.Drawing.Size(122, 29);
            this.btnCript.TabIndex = 0;
            this.btnCript.Text = "START";
            this.btnCript.UseVisualStyleBackColor = true;
            this.btnCript.Click += new System.EventHandler(this.btnCript_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "cipher text";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "encryption key";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(643, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "STOP";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CAST-encryption";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "MD-4-encryption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SEAL-encryption";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 29);
            this.button5.TabIndex = 12;
            this.button5.Text = "START";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 286);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 29);
            this.button6.TabIndex = 13;
            this.button6.Text = "STOP";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(259, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 29);
            this.button7.TabIndex = 14;
            this.button7.Text = "START";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(518, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 29);
            this.button8.TabIndex = 15;
            this.button8.Text = "START";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(387, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 29);
            this.button9.TabIndex = 16;
            this.button9.Text = "STOP";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(646, 286);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 29);
            this.button10.TabIndex = 17;
            this.button10.Text = "STOP";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Laboratory work 10 v16";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RandomNumberTextBox;
        private System.Windows.Forms.Button FirstMethodButton;
        private System.Windows.Forms.Button SecondMethodButton;
        private System.Windows.Forms.Button ThirdMethodButton;
        private System.Windows.Forms.Button StartThreadingButton;
        private System.Windows.Forms.Button StopThreadButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCript;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbPlaintext;
        private System.Windows.Forms.TextBox tbSEAL;
        private System.Windows.Forms.TextBox tbMD4;
        private System.Windows.Forms.TextBox tbCAST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

