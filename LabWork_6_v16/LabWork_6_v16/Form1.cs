using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_6_v16
{
    public partial class Form1 : Form
    {
        public string txt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string inputString = Convert.ToString(txtCheck.Text);

            try
            {
                char[] charArray = inputString.ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string(charArray);

                if (inputString.Equals(reversedString))
                {
                    txt = "\nThe string is a palindrome.";
                }
                else
                {
                    txt = "\nThe string is not a palindrome.";
                }
            }
            catch (Exception ex)
            {
                txt = "\nAn error occurred: " + ex.Message;
            }
            finally
            {
                txt += "\n\nProgram execution complete.";
            }
            lblCheck.Text = txt;
        }
    }
}
