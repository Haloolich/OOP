using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_1_v16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblarea.Text = "";
            lblCheck.Text = "";
            lblX1.Text = "";
            lblNum.Text = "";
            lblTxt.Text = "";
            lblBuy.Text = "";
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtX.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOk.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double result = Math.Abs(x*x - x*x*x) - ((7*x)/(x*x*x - 15*x));
            lblResult.Text = result.ToString();
        }

        private void txtcircuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtcircuit.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btncalc.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double circle = Convert.ToDouble(txtcircuit.Text);
            double calc = Math.Pow(circle, 2) / (4 * Math.PI);
            lblarea.Text = calc.ToString();    
        }

        private void txtCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtCheck.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCheck.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtCheck.Text);
            string text = "Натуральне число " + num + " є точним квадратом";
            lblText.Text = text;
            if (Math.Sqrt(num) == Convert.ToInt32(Math.Sqrt(num)))
            {
                lblCheck.Text = Convert.ToString(true);
            }
            else
            {
                lblCheck.Text = Convert.ToString(false);
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtA.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCount.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtB.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCount.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double Ba = b / a;
            if (Ba > 0)
            {
                string txt = "x1 = 0";
                lblX1.Text = txt;
            }
            else
            {
                string txt = "x1 = 0, x2 = " + (-1 * Math.Sqrt(Ba*(-1))) + ", x3 = " + Math.Sqrt(Ba*(-1));
                lblX1.Text = txt;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtNum.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnNum.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int maxNum = Convert.ToInt32(txtNum.Text);
            string txtNumb = "";
            for (int i = 1; i <= maxNum; i++)
            {
                int n = i;
                bool isDivisible = true;
                while (n > 0)
                {
                    int digit = n % 10;
                    if (digit == 0 || i % digit != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                    n /= 10;
                }
                if (isDivisible)
                {
                    txtNumb += Convert.ToString(i) + " ";
                }
            }
            lblNum.Text = Convert.ToString(txtNumb);
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            string txtWord = "";
            string wordLine = txtText.Text; 
            string[] words = wordLine.Split(' ');
            foreach (string word in words)
            {
                if (word.Contains('k'))
                {
                    txtWord += word + " ";
                    Console.WriteLine(word);
                }
            }
            lblTxt.Text = Convert.ToString(txtWord);
        }

        private void txtBuyers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtBuyers.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnBuy.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtBuyer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtBuyer.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnBuy.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int numOfBuyers = Convert.ToInt32(txtBuyers.Text);

            int[] buyerServiceTimes = new int[numOfBuyers];
            Random rand = new Random();

            for (int i = 0; i < numOfBuyers; i++)
            {
                buyerServiceTimes[i] = rand.Next(1, 11);
            }

            int buyerNum = Convert.ToInt32(txtBuyer.Text);

            int totalWaitTime = 0;


            for (int i = 0; i < numOfBuyers; i++)
            {

                if (i < buyerNum - 1)
                {
                    totalWaitTime += buyerServiceTimes[i];
                }
            }
            string buyNumber = "Customer " + buyerNum + " total time spent in the queue: " + totalWaitTime + " minutes";
            lblBuy.Text = buyNumber;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblarea_Click(object sender, EventArgs e)
        {

        }
    }
}
