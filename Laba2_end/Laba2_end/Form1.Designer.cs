namespace Laba2_end
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
            this.lblfract1 = new System.Windows.Forms.Label();
            this.lblfract2 = new System.Windows.Forms.Label();
            this.lblvariable = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbtnMath = new System.Windows.Forms.RadioButton();
            this.rbtnPower = new System.Windows.Forms.RadioButton();
            this.rbtnEqual = new System.Windows.Forms.RadioButton();
            this.txtFract1 = new System.Windows.Forms.TextBox();
            this.txtFract2 = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfract1
            // 
            this.lblfract1.AutoSize = true;
            this.lblfract1.Location = new System.Drawing.Point(12, 116);
            this.lblfract1.Name = "lblfract1";
            this.lblfract1.Size = new System.Drawing.Size(67, 13);
            this.lblfract1.TabIndex = 0;
            this.lblfract1.Text = "First fraction:";
            // 
            // lblfract2
            // 
            this.lblfract2.AutoSize = true;
            this.lblfract2.Location = new System.Drawing.Point(12, 158);
            this.lblfract2.Name = "lblfract2";
            this.lblfract2.Size = new System.Drawing.Size(85, 13);
            this.lblfract2.TabIndex = 1;
            this.lblfract2.Text = "Second fraction:";
            // 
            // lblvariable
            // 
            this.lblvariable.AutoSize = true;
            this.lblvariable.Location = new System.Drawing.Point(12, 77);
            this.lblvariable.Name = "lblvariable";
            this.lblvariable.Size = new System.Drawing.Size(146, 13);
            this.lblvariable.TabIndex = 2;
            this.lblvariable.Text = "Enter the number of fractions:";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(295, 77);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(304, 179);
            this.lblResult.TabIndex = 3;
            // 
            // rbtnMath
            // 
            this.rbtnMath.AutoSize = true;
            this.rbtnMath.Location = new System.Drawing.Point(295, 36);
            this.rbtnMath.Name = "rbtnMath";
            this.rbtnMath.Size = new System.Drawing.Size(100, 17);
            this.rbtnMath.TabIndex = 4;
            this.rbtnMath.TabStop = true;
            this.rbtnMath.Text = "math operations";
            this.rbtnMath.UseVisualStyleBackColor = true;
            this.rbtnMath.CheckedChanged += new System.EventHandler(this.rbtnMath_CheckedChanged);
            // 
            // rbtnPower
            // 
            this.rbtnPower.AutoSize = true;
            this.rbtnPower.Location = new System.Drawing.Point(405, 36);
            this.rbtnPower.Name = "rbtnPower";
            this.rbtnPower.Size = new System.Drawing.Size(98, 17);
            this.rbtnPower.TabIndex = 5;
            this.rbtnPower.TabStop = true;
            this.rbtnPower.Text = "to exponentiate";
            this.rbtnPower.UseVisualStyleBackColor = true;
            this.rbtnPower.CheckedChanged += new System.EventHandler(this.rbtnPower_CheckedChanged);
            // 
            // rbtnEqual
            // 
            this.rbtnEqual.AutoSize = true;
            this.rbtnEqual.Location = new System.Drawing.Point(521, 36);
            this.rbtnEqual.Name = "rbtnEqual";
            this.rbtnEqual.Size = new System.Drawing.Size(78, 17);
            this.rbtnEqual.TabIndex = 6;
            this.rbtnEqual.TabStop = true;
            this.rbtnEqual.Text = "to compare";
            this.rbtnEqual.UseVisualStyleBackColor = true;
            this.rbtnEqual.CheckedChanged += new System.EventHandler(this.rbtnEqual_CheckedChanged);
            // 
            // txtFract1
            // 
            this.txtFract1.Location = new System.Drawing.Point(164, 116);
            this.txtFract1.Name = "txtFract1";
            this.txtFract1.Size = new System.Drawing.Size(115, 20);
            this.txtFract1.TabIndex = 7;
            this.txtFract1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFract1_KeyPress);
            // 
            // txtFract2
            // 
            this.txtFract2.Location = new System.Drawing.Point(164, 158);
            this.txtFract2.Name = "txtFract2";
            this.txtFract2.Size = new System.Drawing.Size(115, 20);
            this.txtFract2.TabIndex = 8;
            this.txtFract2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFract2_KeyPress);
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(164, 77);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(115, 20);
            this.txtPower.TabIndex = 9;
            this.txtPower.TextChanged += new System.EventHandler(this.txtPower_TextChanged);
            this.txtPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPower_KeyPress);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(191, 223);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(88, 33);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 291);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.txtFract2);
            this.Controls.Add(this.txtFract1);
            this.Controls.Add(this.rbtnEqual);
            this.Controls.Add(this.rbtnPower);
            this.Controls.Add(this.rbtnMath);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblvariable);
            this.Controls.Add(this.lblfract2);
            this.Controls.Add(this.lblfract1);
            this.Name = "Form1";
            this.Text = "Laboratory work 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfract1;
        private System.Windows.Forms.Label lblfract2;
        private System.Windows.Forms.Label lblvariable;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rbtnMath;
        private System.Windows.Forms.RadioButton rbtnPower;
        private System.Windows.Forms.RadioButton rbtnEqual;
        private System.Windows.Forms.TextBox txtFract1;
        private System.Windows.Forms.TextBox txtFract2;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Button btnCalc;
    }
}

