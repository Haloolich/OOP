using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabW16
{
    public partial class Settings : Form
    {
        public Font SelectedFont { get; private set; }
        public Color SelectedColor { get; private set; }
        public Size SelectedSize { get; private set; }
        public Settings(Font currentFont, Color currentColor, Size currentSize)
        {
            InitializeComponent();
            fontDialog1.Font = currentFont;
            fontDialog1.MinSize = Convert.ToInt32(currentSize);
            colorDialog1.Color = currentColor;
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
              // Retrieve the selected font name and size from the UI
              string fontName = Convert.ToString(fontDialog1.Font);
              float fontSize = fontDialog1.MinSize;

              // Update the selected font
              SelectedFont = new Font(fontName, fontSize);

              // Update the selected color
              SelectedColor = colorDialog1.Color;

              // Close the settings form
              DialogResult = DialogResult.OK;
              Close();
        }
    }
}

