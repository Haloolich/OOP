namespace laboratoryWork_3_v16
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbtnGeom = new System.Windows.Forms.RadioButton();
            this.rbtnDIff = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtJ = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt4);
            this.tabPage1.Controls.Add(this.txt3);
            this.tabPage1.Controls.Add(this.txt2);
            this.tabPage1.Controls.Add(this.txt1);
            this.tabPage1.Controls.Add(this.btnCalc);
            this.tabPage1.Controls.Add(this.rbtnDIff);
            this.tabPage1.Controls.Add(this.rbtnGeom);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtN);
            this.tabPage2.Controls.Add(this.btnCalc2);
            this.tabPage2.Controls.Add(this.lblResult2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtJ);
            this.groupBox1.Controls.Add(this.txtI);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ArrayDate";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(223, 11);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(201, 229);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "lbl1";
            // 
            // rbtnGeom
            // 
            this.rbtnGeom.AutoSize = true;
            this.rbtnGeom.Location = new System.Drawing.Point(15, 261);
            this.rbtnGeom.Name = "rbtnGeom";
            this.rbtnGeom.Size = new System.Drawing.Size(160, 17);
            this.rbtnGeom.TabIndex = 3;
            this.rbtnGeom.TabStop = true;
            this.rbtnGeom.Text = "The geometric mean of array";
            this.rbtnGeom.UseVisualStyleBackColor = true;
            // 
            // rbtnDIff
            // 
            this.rbtnDIff.AutoSize = true;
            this.rbtnDIff.Location = new System.Drawing.Point(15, 236);
            this.rbtnDIff.Name = "rbtnDIff";
            this.rbtnDIff.Size = new System.Drawing.Size(132, 17);
            this.rbtnDIff.TabIndex = 4;
            this.rbtnDIff.TabStop = true;
            this.rbtnDIff.Text = "The difference of array";
            this.rbtnDIff.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(327, 255);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(97, 33);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.White;
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult2.Location = new System.Drawing.Point(16, 55);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(412, 165);
            this.lblResult2.TabIndex = 0;
            this.lblResult2.Text = "label2";
            // 
            // btnCalc2
            // 
            this.btnCalc2.Location = new System.Drawing.Point(327, 234);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(101, 40);
            this.btnCalc2.TabIndex = 1;
            this.btnCalc2.Text = "Calculate";
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(189, 22);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(9, 45);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(131, 20);
            this.txtI.TabIndex = 0;
            this.txtI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtI_KeyPress);
            // 
            // txtJ
            // 
            this.txtJ.Location = new System.Drawing.Point(9, 94);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(132, 20);
            this.txtJ.TabIndex = 1;
            this.txtJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJ_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(88, 161);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(26, 20);
            this.txt1.TabIndex = 6;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(120, 161);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(26, 20);
            this.txt2.TabIndex = 7;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(88, 203);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(26, 20);
            this.txt3.TabIndex = 8;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(120, 203);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(26, 20);
            this.txt4.TabIndex = 9;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "number of rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "number of columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter the indices of the first element:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "(row, column)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "(row, column)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter the indices of the second element:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Set to the desired size of the array:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 356);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Laboratory work 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rbtnDIff;
        private System.Windows.Forms.RadioButton rbtnGeom;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCalc2;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.TextBox txtJ;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

