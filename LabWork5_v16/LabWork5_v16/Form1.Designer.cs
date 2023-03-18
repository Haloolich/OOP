namespace LabWork5_v16
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression to check:";
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(33, 56);
            this.txtCheck.Multiline = true;
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(248, 150);
            this.txtCheck.TabIndex = 1;
            // 
            // lblCheck
            // 
            this.lblCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheck.Location = new System.Drawing.Point(33, 231);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(248, 31);
            this.lblCheck.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Location = new System.Drawing.Point(33, 280);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(97, 36);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 341);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laboratory work 5 v16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button btnCheck;
    }
}

