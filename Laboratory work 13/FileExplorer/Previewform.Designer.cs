﻿namespace FileExplorer
{
    partial class Previewform
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
            this.preview_txt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hex_prev_txt = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.photo_preview = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.replaceTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_preview)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // preview_txt
            // 
            this.preview_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_txt.Location = new System.Drawing.Point(3, 3);
            this.preview_txt.Multiline = true;
            this.preview_txt.Name = "preview_txt";
            this.preview_txt.ReadOnly = true;
            this.preview_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.preview_txt.Size = new System.Drawing.Size(270, 229);
            this.preview_txt.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 261);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.preview_txt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ASCII";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hex_prev_txt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HEX Dump";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hex_prev_txt
            // 
            this.hex_prev_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hex_prev_txt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_prev_txt.Location = new System.Drawing.Point(3, 3);
            this.hex_prev_txt.Multiline = true;
            this.hex_prev_txt.Name = "hex_prev_txt";
            this.hex_prev_txt.ReadOnly = true;
            this.hex_prev_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hex_prev_txt.Size = new System.Drawing.Size(270, 229);
            this.hex_prev_txt.TabIndex = 0;
            this.hex_prev_txt.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.photo_preview);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(276, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Photo View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // photo_preview
            // 
            this.photo_preview.Location = new System.Drawing.Point(3, 3);
            this.photo_preview.Name = "photo_preview";
            this.photo_preview.Size = new System.Drawing.Size(270, 229);
            this.photo_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.photo_preview.TabIndex = 0;
            this.photo_preview.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.replaceTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(276, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceTextBox.Location = new System.Drawing.Point(3, 3);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(270, 229);
            this.replaceTextBox.TabIndex = 0;
            this.replaceTextBox.Text = "";
            // 
            // Previewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Previewform";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.Previewform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo_preview)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox preview_txt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox hex_prev_txt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox photo_preview;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.RichTextBox replaceTextBox;
    }
}