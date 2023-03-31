using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Win32;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpftutorialsamples
{
    public partial class MainWindow : Window
    {
        private string filePath;
        public MainWindow()
        {
            InitializeComponent();
            cmbfontfamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbfontsize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26,
28, 36, 48, 72 };

        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Rich Text Format (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                TextRange range = new TextRange(rtbeditor.Document.ContentStart, rtbeditor.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }
        }

        private void cmbfontfamily_Selectionchanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbfontfamily.SelectedItem != null)
                rtbeditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbfontfamily.SelectedItem);
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Rich Text Format (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                TextRange range = new TextRange(rtbeditor.Document.ContentStart, rtbeditor.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);

            }
        }

        private void rtbeditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = rtbeditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
           
            temp = rtbeditor.Selection.GetPropertyValue(Inline.FontStyleProperty);

            temp = rtbeditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);


            temp = rtbeditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbfontfamily.SelectedItem = temp;
            temp = rtbeditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbfontsize.Text = temp.ToString();
        }
        private void cmbfontsize_Textchanged(object sender, TextChangedEventArgs e)
        {
            rtbeditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbfontsize.Text);
        }
        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var newFile = new MainWindow();
            newFile.Show();

        }
        void PrintRTBContent(Object sender, RoutedEventArgs args)
        {
            PrintCommand();
        }
        private void PrintCommand()
        {
            PrintDialog pd = new PrintDialog();
            if ((pd.ShowDialog() == true))
            {
                pd.PrintVisual(rtbeditor as Visual, "printing as visual");
                pd.PrintDocument((((IDocumentPaginatorSource)rtbeditor.Document).DocumentPaginator), "printing as paginator");
            }
        }

        private void UkrLang_Click(object sender, RoutedEventArgs e)
        {
            btnBold.ToolTip = "Текст Жирним";
            btnItalic.ToolTip = "Текст Курсивом";
            btnUnderline.ToolTip = "Текст Підкреслений";
            btnAlignCenter.ToolTip = "Вирівнювання по центру";
            btnAlignRight.ToolTip = "Вирівнювання по правому краю";
            btnAlignLeft.ToolTip = "Вирівнювання по лівому краю";
            btnAlignJustify.ToolTip = "Вирівнювання по ширині";
            cmbfontfamily.ToolTip = "Вибір шрифта";
            cmbfontsize.ToolTip = "Вибір розміру";
            btnNewFile.ToolTip = "Створити новий файл";
            btnOpenFile.ToolTip = "Відкрити файл";
            btnSaveFile.ToolTip = "Зберегти файл";
            btnCut.ToolTip = "Вирізати";
            btnCopy.ToolTip = "Копіювати";
            btnPaste.ToolTip = "Вставити";
            btnRedo.ToolTip = "Відмінити";
            btnUndo.ToolTip = "Повернути";
            btnPrint.ToolTip = "Друк";
            btnUkrLang.ToolTip = "Змінити мову на українську";
            btnEngLang.ToolTip = "Змінити мову на англійську";
            btnImage.ToolTip = "Вставити зображення";
        }

        private void EngLang_Click(object sender, RoutedEventArgs e)
        {
            btnBold.ToolTip = "Bold Text";
            btnItalic.ToolTip = "Italic Text";
            btnUnderline.ToolTip = "Text Underlined";
            btnAlignCenter.ToolTip = "Center alignment";
            btnAlignRight.ToolTip = "Right alignment";
            btnAlignLeft.ToolTip = "Align on the left edge";
            btnAlignJustify.ToolTip = "Width Alignment";
            cmbfontfamily.ToolTip = "Choose a font";
            cmbfontsize.ToolTip = "Select size";
            btnNewFile.ToolTip = "Create a new file";
            btnOpenFile.ToolTip = "Open File";
            btnSaveFile.ToolTip = "Save File";
            btnCut.ToolTip = "Cut";
            btnCopy.ToolTip = "Copy";
            btnPaste.ToolTip = "Paste";
            btnRedo.ToolTip = "Undo";
            btnUndo.ToolTip = "Undo";
            btnPrint.ToolTip = "Print";
            btnUkrLang.ToolTip = "Change language to Ukrainian";
            btnEngLang.ToolTip = "Change language to English";
            btnImage.ToolTip = "Image";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName, UriKind.Absolute);
                bitmap.EndInit();

                Image image = new Image();
                image.Source = bitmap;

                InlineUIContainer container = new InlineUIContainer(image);

                TextPointer position = rtbeditor.CaretPosition;
                if (position != null)
                {
                    position.Paragraph.Inlines.Add(container);
                }
            }
        }
    }
}
