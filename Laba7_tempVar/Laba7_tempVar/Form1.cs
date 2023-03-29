using System;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Laba7_tempVar.blank;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba7_tempVar
{
    public partial class frmmain : Form
    {
        public static void SetAlignment(IntPtr handle, int alignment)
        {
            RichTextBoxNativeMethods.PARAFORMAT format = new RichTextBoxNativeMethods.PARAFORMAT();
            format.cbSize = Marshal.SizeOf(format);
            format.dwMask = RichTextBoxNativeMethods.PFM_ALIGNMENT;
            format.wAlignment = (short)alignment;

            RichTextBoxNativeMethods.SendMessage(handle, RichTextBoxNativeMethods.EM_SETPARAFORMAT, 0, ref format);
        }
        private int openDocuments = 0;
        private Font printFont;
        private string printText;
        public frmmain()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(fontFamily.Name);
            }
            for (int i = 8; i <= 72; i++)
            {
                sizeBtn.Items.Add(i.ToString());
            }

            sizeBtn.SelectedItem = "12";
        }
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.IsSaved = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            blank frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            Font oldFont = frm.richTextBox1.SelectionFont;
            FontStyle newStyle = oldFont.Style ^ FontStyle.Bold;
            Font newFont = new Font(oldFont, newStyle);
            frm.richTextBox1.SelectionFont = newFont;
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            Font oldFont = frm.richTextBox1.SelectionFont;
            FontStyle newStyle = oldFont.Style ^ FontStyle.Italic;
            Font newFont = new Font(oldFont, newStyle);
            frm.richTextBox1.SelectionFont = newFont;
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            Font oldFont = frm.richTextBox1.SelectionFont;
            FontStyle newStyle = oldFont.Style ^ FontStyle.Underline;
            Font newFont = new Font(oldFont, newStyle);
            frm.richTextBox1.SelectionFont = newFont;
        }

        private void sizeBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            int newSize = int.Parse(sizeBtn.SelectedItem.ToString());
            Font oldFont = frm.richTextBox1.SelectionFont;
            Font newFont = new Font(oldFont.FontFamily, newSize, oldFont.Style);
            frm.richTextBox1.SelectionFont = newFont;
            frm.richTextBox1.Focus();

        }

        private void sizeBtn_Click(object sender, EventArgs e)
        {
            //помилкова дія

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            string newFontFamily = toolStripComboBox1.SelectedItem.ToString();
            Font oldFont = frm.richTextBox1.SelectionFont;
            Font newFont = new Font(newFontFamily, oldFont.Size, oldFont.Style);
            frm.richTextBox1.SelectionFont = newFont;
            frm.richTextBox1.Focus();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leftAlignBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightAlignBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void justifyAlignBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            SetAlignment(frm.richTextBox1.Handle, 4);
        }

        private void ImgBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                Clipboard.SetImage(image);
                frm.richTextBox1.Paste();
            }
        }

        private void highliteBtn_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            string code = frm.richTextBox1.Text;
            RichTextBox rtb = new RichTextBox();
            rtb.Rtf = frm.richTextBox1.Rtf;
            string[] keywords = { "string", "privat", "public", "this", "auto", "break", "case", "char", "const", "continue", "default", "do", "double", "else", "enum", "extern", "float", "for", "goto", "if", "int", "long", "register", "return", "short", "signed", "sizeof", "static", "struct", "switch", "typedef", "union", "unsigned", "void", "volatile", "while" };
            foreach (string keyword in keywords)
            {
                int index = 0;
                while (index < code.Length)
                {
                    index = code.IndexOf(keyword, index);
                    if (index == -1)
                        break;
                    rtb.Select(index, keyword.Length);
                    rtb.SelectionColor = Color.Blue;
                    index += keyword.Length;
                }
            }
            frm.richTextBox1.Rtf = rtb.Rtf;
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            if (frm.richTextBox1.CanUndo)
            {
                frm.richTextBox1.Undo();
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings = printDialog.PrinterSettings;
                printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDoc.DocumentName = "Друкований документ";
                printText = frm.richTextBox1.Text;
                printDoc.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printText, printFont, Brushes.Black, 20, 20);
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            printFont = new Font("Arial", 12);
        }

        private void ukrLangBtn_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "Файл";
            newFileToolStripMenuItem.Text = "Новий файл";
            openFileToolStripMenuItem.Text = "Відкрити файл";
            saveToolStripMenuItem.Text = "Зберегти";
            saveAsToolStripMenuItem.Text = "Зберегти як";
            exitToolStripMenuItem.Text = "Вихід";
            editToolStripMenuItem.Text = "Редагувати";
            cutToolStripMenuItem.Text = "Вирізати";
            copyToolStripMenuItem.Text = "Копіювати";
            pasteToolStripMenuItem.Text = "Вставити";
            deleteToolStripMenuItem.Text = "Видалити";
            selectAllToolStripMenuItem.Text = "Виділити все";
            formatToolStripMenuItem.Text = "Формат";
            fontToolStripMenuItem.Text = "Шрифт...";
            colorToolStripMenuItem.Text = "Колір...";
            windowToolStripMenuItem.Text = "Вікно";
            arrangeIconsToolStripMenuItem.Text = "Упорядкувати";
            cascadeToolStripMenuItem.Text = "Каскадом";
            theHorizontalToolStripMenuItem.Text = "Горизонтально";
            theVerticalToolStripMenuItem.Text = "Вертикально";
            aboutProgramToolStripMenuItem.Text = "Про програму";
            boldBtn.Text = "Полужирний";
            italicBtn.Text = "Курсив";
            underlineBtn.Text = "Підкреслення";
            toolStripComboBox1.Text = "Тип шрифта";
            sizeBtn.Text = "Розмір шрифта";
            toolStripButton19.Text = "Колір тексту";
            leftAlignBtn.Text = "Вирівняти по лівому краю";
            centerAlignBtn.Text = "Вирівняти по центру";
            rightAlignBtn.Text = "Вирівняти по правому краю";
            justifyAlignBtn.Text = "Вирівняти по ширині";
            ImgBtn.Text = "Вставити зображення";
            highliteBtn.Text = "Синтаксис С мов";
            toolStripButton8.Text = "Новий файл";
            toolStripButton9.Text = "Відкрити файл";
            toolStripButton10.Text = "Зберегти";
            toolStripButton11.Text = "Копіюівти";
            copyButton.Text = "Вставити";
            toolStripButton13.Text = "Вирізати";
            toolStripButton14.Text = "Друкувати";
            toolStripButton15.Text = "Відмінити дію";
            toolStripButton16.Text = "Про програму";
            ukrLangBtn.Text = "Мова інтерфейсу українська";
            engLangBtn.Text = "Мова інтерфейсу англійська";
        }

        private void engLangBtn_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "File";
            newFileToolStripMenuItem.Text = "New file";
            openFileToolStripMenuItem.Text = "Open file";
            saveToolStripMenuItem.Text = "Save";
            saveAsToolStripMenuItem.Text = "Save as";
            exitToolStripMenuItem.Text = "Exit";
            editToolStripMenuItem.Text = "Edit";
            cutToolStripMenuItem.Text = "Cut";
            copyToolStripMenuItem.Text = "Copy";
            pasteToolStripMenuItem.Text = "Paste";
            deleteToolStripMenuItem.Text = "Delete";
            selectAllToolStripMenuItem.Text = "Select all";
            formatToolStripMenuItem.Text = "Format";
            fontToolStripMenuItem.Text = "Font...";
            colorToolStripMenuItem.Text = "Color...";
            windowToolStripMenuItem.Text = "Window";
            arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            cascadeToolStripMenuItem.Text = "Cascade";
            theHorizontalToolStripMenuItem.Text = "Horizontal";
            theVerticalToolStripMenuItem.Text = "Vertical";
            aboutProgramToolStripMenuItem.Text = "About programm";
            boldBtn.Text = "Bold";
            italicBtn.Text = "Italic";
            underlineBtn.Text = "Underline";
            toolStripComboBox1.Text = "Type Font";
            sizeBtn.Text = "Size Font";
            toolStripButton19.Text = "Color text";
            leftAlignBtn.Text = "Left Align";
            centerAlignBtn.Text = "Center Align";
            rightAlignBtn.Text = "Right Align";
            justifyAlignBtn.Text = "Justify Align";
            ImgBtn.Text = "Image";
            highliteBtn.Text = "Language C";
            toolStripButton8.Text = "New file";
            toolStripButton9.Text = "Open file";
            toolStripButton10.Text = "Save";
            toolStripButton11.Text = "Copy";
            copyButton.Text = "Paste";
            toolStripButton13.Text = "Cut";
            toolStripButton14.Text = "Print";
            toolStripButton15.Text = "Cancel";
            toolStripButton16.Text = "About programm";
            ukrLangBtn.Text = "Ukrainian interface";
            engLangBtn.Text = "English interface";
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            blank frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void toolStripLabel1_TextChanged(object sender, EventArgs e)
        {
            //помилкова дія
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blank form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void theHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void theVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }
    }
}
