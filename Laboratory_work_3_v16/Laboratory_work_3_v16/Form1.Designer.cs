namespace Laboratory_work_3_v16
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rbtnComplex = new System.Windows.Forms.RadioButton();
            this.rbtnVector = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtImag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complex number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "imaginary number";
            // 
            // txtImag
            // 
            this.txtImag.Location = new System.Drawing.Point(101, 23);
            this.txtImag.Name = "txtImag";
            this.txtImag.Size = new System.Drawing.Size(86, 20);
            this.txtImag.TabIndex = 1;
            this.txtImag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImag_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "real number";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(101, 49);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(86, 20);
            this.txtReal.TabIndex = 3;
            this.txtReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReal_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtZ);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vector3D";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(101, 49);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(86, 20);
            this.txtY.TabIndex = 3;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "coordinate y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(101, 23);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(86, 20);
            this.txtX.TabIndex = 1;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "coordinate x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "coordinate z";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(101, 75);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(86, 20);
            this.txtZ.TabIndex = 5;
            this.txtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZ_KeyPress);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(242, 12);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(207, 134);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label6";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(367, 170);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(82, 36);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rbtnComplex
            // 
            this.rbtnComplex.AutoSize = true;
            this.rbtnComplex.Location = new System.Drawing.Point(242, 163);
            this.rbtnComplex.Name = "rbtnComplex";
            this.rbtnComplex.Size = new System.Drawing.Size(119, 17);
            this.rbtnComplex.TabIndex = 7;
            this.rbtnComplex.TabStop = true;
            this.rbtnComplex.Text = "calculate a complex";
            this.rbtnComplex.UseVisualStyleBackColor = true;
            this.rbtnComplex.CheckedChanged += new System.EventHandler(this.rbtnComplex_CheckedChanged);
            // 
            // rbtnVector
            // 
            this.rbtnVector.AutoSize = true;
            this.rbtnVector.Location = new System.Drawing.Point(242, 189);
            this.rbtnVector.Name = "rbtnVector";
            this.rbtnVector.Size = new System.Drawing.Size(119, 17);
            this.rbtnVector.TabIndex = 8;
            this.rbtnVector.TabStop = true;
            this.rbtnVector.Text = "calculate the vector";
            this.rbtnVector.UseVisualStyleBackColor = true;
            this.rbtnVector.CheckedChanged += new System.EventHandler(this.rbtnVector_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 241);
            this.Controls.Add(this.rbtnVector);
            this.Controls.Add(this.rbtnComplex);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Laboratory work 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rbtnComplex;
        private System.Windows.Forms.RadioButton rbtnVector;
    }
}

