namespace LabWork12
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
            this.txtUniName = new System.Windows.Forms.TextBox();
            this.txtAddressNumber = new System.Windows.Forms.TextBox();
            this.txtNumbSert = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtOsoba = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.comboBoxStud = new System.Windows.Forms.ComboBox();
            this.comboBoxCurs = new System.Windows.Forms.ComboBox();
            this.txtFormEdu = new System.Windows.Forms.ComboBox();
            this.txtFinancy = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.ComboBox();
            this.txtTermin = new System.Windows.Forms.DateTimePicker();
            this.txtComercy = new System.Windows.Forms.ComboBox();
            this.txtAcreditation = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.comboBoxInstut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUniName
            // 
            this.txtUniName.Location = new System.Drawing.Point(6, 19);
            this.txtUniName.Name = "txtUniName";
            this.txtUniName.Size = new System.Drawing.Size(180, 20);
            this.txtUniName.TabIndex = 0;
            this.txtUniName.Text = "Назва закладу";
            // 
            // txtAddressNumber
            // 
            this.txtAddressNumber.Location = new System.Drawing.Point(6, 46);
            this.txtAddressNumber.Name = "txtAddressNumber";
            this.txtAddressNumber.Size = new System.Drawing.Size(180, 20);
            this.txtAddressNumber.TabIndex = 1;
            this.txtAddressNumber.Text = "Адреса";
            // 
            // txtNumbSert
            // 
            this.txtNumbSert.Location = new System.Drawing.Point(6, 233);
            this.txtNumbSert.Name = "txtNumbSert";
            this.txtNumbSert.Size = new System.Drawing.Size(180, 20);
            this.txtNumbSert.TabIndex = 2;
            this.txtNumbSert.Text = "Номер довідки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Згенерувати довідку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerateCertificate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обрати шаблон довідки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Location = new System.Drawing.Point(6, 207);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(6, 46);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(180, 20);
            this.txtNameSurname.TabIndex = 7;
            this.txtNameSurname.Text = "Ім\'я студента";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(6, 180);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(180, 20);
            this.txtSpec.TabIndex = 10;
            this.txtSpec.Text = "Спеціальність";
            // 
            // txtOsoba
            // 
            this.txtOsoba.Location = new System.Drawing.Point(6, 154);
            this.txtOsoba.Name = "txtOsoba";
            this.txtOsoba.Size = new System.Drawing.Size(180, 20);
            this.txtOsoba.TabIndex = 16;
            this.txtOsoba.Text = "Довідку видав";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(6, 207);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(180, 20);
            this.txtFaculty.TabIndex = 17;
            this.txtFaculty.Text = "Назва факультету";
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Location = new System.Drawing.Point(455, 74);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.Size = new System.Drawing.Size(177, 20);
            this.txtTemplatePath.TabIndex = 18;
            this.txtTemplatePath.Text = "Шлях для відкриття файлу";
            // 
            // comboBoxStud
            // 
            this.comboBoxStud.FormattingEnabled = true;
            this.comboBoxStud.Items.AddRange(new object[] {
            "Студент",
            "Студентка"});
            this.comboBoxStud.Location = new System.Drawing.Point(6, 19);
            this.comboBoxStud.Name = "comboBoxStud";
            this.comboBoxStud.Size = new System.Drawing.Size(180, 21);
            this.comboBoxStud.TabIndex = 19;
            this.comboBoxStud.Text = "Стать";
            // 
            // comboBoxCurs
            // 
            this.comboBoxCurs.FormattingEnabled = true;
            this.comboBoxCurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCurs.Location = new System.Drawing.Point(6, 72);
            this.comboBoxCurs.Name = "comboBoxCurs";
            this.comboBoxCurs.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCurs.TabIndex = 20;
            this.comboBoxCurs.Text = "Курс";
            // 
            // txtFormEdu
            // 
            this.txtFormEdu.FormattingEnabled = true;
            this.txtFormEdu.Items.AddRange(new object[] {
            "денної",
            "заочної",
            "дистанційної"});
            this.txtFormEdu.Location = new System.Drawing.Point(6, 99);
            this.txtFormEdu.Name = "txtFormEdu";
            this.txtFormEdu.Size = new System.Drawing.Size(180, 21);
            this.txtFormEdu.TabIndex = 21;
            this.txtFormEdu.Text = "Форма навчання";
            // 
            // txtFinancy
            // 
            this.txtFinancy.FormattingEnabled = true;
            this.txtFinancy.Items.AddRange(new object[] {
            "бюджетній",
            "контрактній"});
            this.txtFinancy.Location = new System.Drawing.Point(6, 126);
            this.txtFinancy.Name = "txtFinancy";
            this.txtFinancy.Size = new System.Drawing.Size(180, 21);
            this.txtFinancy.TabIndex = 22;
            this.txtFinancy.Text = "Фінансування";
            // 
            // txtMoney
            // 
            this.txtMoney.FormattingEnabled = true;
            this.txtMoney.Items.AddRange(new object[] {
            "з отриманням",
            "без отримання"});
            this.txtMoney.Location = new System.Drawing.Point(6, 153);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(180, 21);
            this.txtMoney.TabIndex = 23;
            this.txtMoney.Text = "Стипендія";
            // 
            // txtTermin
            // 
            this.txtTermin.Location = new System.Drawing.Point(6, 233);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(180, 20);
            this.txtTermin.TabIndex = 24;
            // 
            // txtComercy
            // 
            this.txtComercy.FormattingEnabled = true;
            this.txtComercy.Items.AddRange(new object[] {
            "державним",
            "комерційним"});
            this.txtComercy.Location = new System.Drawing.Point(6, 99);
            this.txtComercy.Name = "txtComercy";
            this.txtComercy.Size = new System.Drawing.Size(180, 21);
            this.txtComercy.TabIndex = 25;
            this.txtComercy.Text = "Підпорядкування";
            // 
            // txtAcreditation
            // 
            this.txtAcreditation.FormattingEnabled = true;
            this.txtAcreditation.Items.AddRange(new object[] {
            "I",
            "ІІ",
            "ІІІ",
            "IV"});
            this.txtAcreditation.Location = new System.Drawing.Point(6, 125);
            this.txtAcreditation.Name = "txtAcreditation";
            this.txtAcreditation.Size = new System.Drawing.Size(180, 21);
            this.txtAcreditation.TabIndex = 26;
            this.txtAcreditation.Text = "Ступінь акритдитації";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 72);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(180, 20);
            this.txtNumber.TabIndex = 27;
            this.txtNumber.Text = "Телефон";
            // 
            // comboBoxInstut
            // 
            this.comboBoxInstut.FormattingEnabled = true;
            this.comboBoxInstut.Items.AddRange(new object[] {
            "навчально-наукового інституту",
            "факультету"});
            this.comboBoxInstut.Location = new System.Drawing.Point(6, 180);
            this.comboBoxInstut.Name = "comboBoxInstut";
            this.comboBoxInstut.Size = new System.Drawing.Size(180, 21);
            this.comboBoxInstut.TabIndex = 28;
            this.comboBoxInstut.Text = "Підзаклад";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "Generate a certificate from the place of study";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxStud);
            this.groupBox1.Controls.Add(this.txtSpec);
            this.groupBox1.Controls.Add(this.txtFaculty);
            this.groupBox1.Controls.Add(this.txtNameSurname);
            this.groupBox1.Controls.Add(this.txtTermin);
            this.groupBox1.Controls.Add(this.comboBoxCurs);
            this.groupBox1.Controls.Add(this.txtFormEdu);
            this.groupBox1.Controls.Add(this.txtFinancy);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 268);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація про студента";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUniName);
            this.groupBox2.Controls.Add(this.txtAddressNumber);
            this.groupBox2.Controls.Add(this.txtNumber);
            this.groupBox2.Controls.Add(this.txtAcreditation);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.comboBoxInstut);
            this.groupBox2.Controls.Add(this.txtNumbSert);
            this.groupBox2.Controls.Add(this.txtComercy);
            this.groupBox2.Controls.Add(this.txtOsoba);
            this.groupBox2.Location = new System.Drawing.Point(235, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 268);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Інформація про заклад";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(454, 100);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(177, 20);
            this.txtSave.TabIndex = 32;
            this.txtSave.Text = "Шлях для збереження файлу";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 34);
            this.button3.TabIndex = 33;
            this.button3.Text = "Обрати місце збереження";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 339);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemplatePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Laboratory work 12 v16";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUniName;
        private System.Windows.Forms.TextBox txtAddressNumber;
        private System.Windows.Forms.TextBox txtNumbSert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TextBox txtOsoba;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.ComboBox comboBoxStud;
        private System.Windows.Forms.ComboBox comboBoxCurs;
        private System.Windows.Forms.ComboBox txtFormEdu;
        private System.Windows.Forms.ComboBox txtFinancy;
        private System.Windows.Forms.ComboBox txtMoney;
        private System.Windows.Forms.DateTimePicker txtTermin;
        private System.Windows.Forms.ComboBox txtComercy;
        private System.Windows.Forms.ComboBox txtAcreditation;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox comboBoxInstut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
    }
}

