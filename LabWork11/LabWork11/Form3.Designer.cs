namespace LabWork11
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassengerFind = new System.Windows.Forms.TextBox();
            this.btnPassangerFind = new System.Windows.Forms.Button();
            this.richTxtBxPassangerTicket = new System.Windows.Forms.RichTextBox();
            this.richTxtList = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Algerian", 32F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "Railway station";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassengerFind
            // 
            this.txtPassengerFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassengerFind.Location = new System.Drawing.Point(12, 107);
            this.txtPassengerFind.Name = "txtPassengerFind";
            this.txtPassengerFind.Size = new System.Drawing.Size(208, 38);
            this.txtPassengerFind.TabIndex = 11;
            // 
            // btnPassangerFind
            // 
            this.btnPassangerFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnPassangerFind.FlatAppearance.BorderSize = 0;
            this.btnPassangerFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassangerFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassangerFind.ForeColor = System.Drawing.Color.Silver;
            this.btnPassangerFind.Location = new System.Drawing.Point(226, 107);
            this.btnPassangerFind.Name = "btnPassangerFind";
            this.btnPassangerFind.Size = new System.Drawing.Size(178, 40);
            this.btnPassangerFind.TabIndex = 10;
            this.btnPassangerFind.Text = "Find Passenger";
            this.btnPassangerFind.UseVisualStyleBackColor = false;
            this.btnPassangerFind.Click += new System.EventHandler(this.btnPassangerFind_Click);
            // 
            // richTxtBxPassangerTicket
            // 
            this.richTxtBxPassangerTicket.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxPassangerTicket.Location = new System.Drawing.Point(12, 166);
            this.richTxtBxPassangerTicket.Name = "richTxtBxPassangerTicket";
            this.richTxtBxPassangerTicket.Size = new System.Drawing.Size(392, 34);
            this.richTxtBxPassangerTicket.TabIndex = 12;
            this.richTxtBxPassangerTicket.Text = "";
            // 
            // richTxtList
            // 
            this.richTxtList.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold);
            this.richTxtList.Location = new System.Drawing.Point(12, 206);
            this.richTxtList.Name = "richTxtList";
            this.richTxtList.Size = new System.Drawing.Size(392, 179);
            this.richTxtList.TabIndex = 13;
            this.richTxtList.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(416, 397);
            this.Controls.Add(this.richTxtList);
            this.Controls.Add(this.richTxtBxPassangerTicket);
            this.Controls.Add(this.txtPassengerFind);
            this.Controls.Add(this.btnPassangerFind);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Laboratory work 11 v16";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassengerFind;
        private System.Windows.Forms.Button btnPassangerFind;
        private System.Windows.Forms.RichTextBox richTxtBxPassangerTicket;
        private System.Windows.Forms.RichTextBox richTxtList;
    }
}