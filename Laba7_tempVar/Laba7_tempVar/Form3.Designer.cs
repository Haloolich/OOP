namespace Laba7_tempVar
{
    partial class FindForm
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
            this.components = new System.ComponentModel.Container();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCalcel = new System.Windows.Forms.Button();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.cdMatchWhole = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(12, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(192, 20);
            this.txtFind.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(225, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCalcel
            // 
            this.btnCalcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalcel.Location = new System.Drawing.Point(225, 38);
            this.btnCalcel.Name = "btnCalcel";
            this.btnCalcel.Size = new System.Drawing.Size(75, 23);
            this.btnCalcel.TabIndex = 3;
            this.btnCalcel.Text = "&Cancel";
            this.btnCalcel.UseVisualStyleBackColor = true;
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(12, 44);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(83, 17);
            this.cbMatchCase.TabIndex = 4;
            this.cbMatchCase.Text = "Match &Case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // cdMatchWhole
            // 
            this.cdMatchWhole.AutoSize = true;
            this.cdMatchWhole.Location = new System.Drawing.Point(104, 44);
            this.cdMatchWhole.Name = "cdMatchWhole";
            this.cdMatchWhole.Size = new System.Drawing.Size(113, 17);
            this.cdMatchWhole.TabIndex = 5;
            this.cdMatchWhole.Text = "Match &whole word";
            this.cdMatchWhole.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 73);
            this.Controls.Add(this.cdMatchWhole);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.btnCalcel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCalcel;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.CheckBox cdMatchWhole;
    }
}