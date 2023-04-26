using Microsoft.Office.Interop.Word;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabWork12
{
    public partial class Form1 : Form
    {
        private string templatePath = "";
        private string outputiPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Document (*.dotx)|*.dotx";
            openFileDialog.Title = "Select a Word Template File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                templatePath = openFileDialog.FileName;
                txtTemplatePath.Text = templatePath;
            }
        }

        private void btnGenerateCertificate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(templatePath))
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDoc = null;

                try
                {
                    Object missingObj = System.Reflection.Missing.Value;
                    Object trueObj = true;
                    Object falseObj = false;
                    Object templatePathObj = templatePath;

                    wordDoc = wordApp.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                    wordDoc.Activate();

                    ReplacePlaceholder("[контактні телефони]", txtNumber.Text, wordDoc);
                    ReplacePlaceholder("[Студент (студентка)]", comboBoxStud.Text, wordDoc);
                    ReplacePlaceholder("[Повна назва навчального закладу]", txtUniName.Text, wordDoc);
                    ReplacePlaceholder("[назва навчального закладу]", txtUniName.Text, wordDoc);
                    ReplacePlaceholder("[Адреса]", txtAddressNumber.Text, wordDoc);
                    ReplacePlaceholder("[номер довідки]", txtNumbSert.Text, wordDoc);
                    ReplacePlaceholder("[Прізвище Ім’я По-батькові]", txtNameSurname.Text, wordDoc);
                    ReplacePlaceholder("[курс]", comboBoxCurs.Text, wordDoc);
                    ReplacePlaceholder("[форма навчання]", txtFormEdu.Text, wordDoc);
                    ReplacePlaceholder("[спеціальність]", txtSpec.Text, wordDoc);
                    ReplacePlaceholder("[фінансування]", txtFinancy.Text, wordDoc);
                    ReplacePlaceholder("[без (з) отримання(м)]", txtMoney.Text, wordDoc);
                    ReplacePlaceholder("[дата закінчення навчання]", txtTermin.Text, wordDoc);
                    ReplacePlaceholder("[державний чи часний]", txtComercy.Text, wordDoc);
                    ReplacePlaceholder("[рівень акридитації]", txtAcreditation.Text, wordDoc);
                    ReplacePlaceholder("[Прізвище ініціали директора]", txtOsoba.Text, wordDoc);
                    ReplacePlaceholder("[назва факультету]", txtFaculty.Text, wordDoc);
                    ReplacePlaceholder("[факультету]", comboBoxInstut.Text, wordDoc);
                    ReplacePlaceholder("[Дата]", dtpDate.Value.ToShortDateString(), wordDoc);

                  
                    wordApp.Visible = true;

                    string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{txtNameSurname.Text} Certificate.docx");
                    wordDoc.SaveAs2(outputPath);
                    MessageBox.Show("Certificate generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    wordDoc.Close();
                    wordApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Please select a Word template file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplacePlaceholder(string placeholder, string value, Document wordDoc)
        {
            var range = wordDoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: placeholder, ReplaceWith: value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
            saveFileDialog.Title = "Select a Word Template File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputiPath = saveFileDialog.FileName;
                txtSave.Text = outputiPath;
            }
        }
    }
}
