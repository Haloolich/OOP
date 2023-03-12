using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_end
{
    public partial class Form1 : Form
    {
        string txt;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblvariable.Text = "Enter the number of fractions:";
            lblfract1.Text = "First fraction:";
            lblfract2.Text = "Second fraction:";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rbtnMath.Checked)
            {
                lblvariable.Text = "Enter the number of fractions:";
                int numberOfFractions = Convert.ToInt32(txtPower.Text);
                Random rand = new Random();

                Fraction[] fractions = new Fraction[numberOfFractions];

                for (int i = 0; i < numberOfFractions; i++)
                {
                    int numerator = rand.Next(1, 100);
                    int denominator = rand.Next(numerator + 1, 100);

                    Fraction fraction = new Fraction(numerator, denominator);
                    fractions[i] = fraction;
                }

                txt = "Fractions entered:\n";
                foreach (Fraction f in fractions)
                {
                    txt += f + "\n";
                }

                Fraction sum = new Fraction();
                foreach (Fraction f in fractions)
                {
                    sum += f;
                }

                txt += "Sum of fractions: " + sum + "\n";

                Fraction diff = fractions[0];
                for (int i = 1; i < numberOfFractions; i++)
                {
                    diff -= fractions[i];
                }

                txt += "Difference of fractions: " + diff + "\n";

                Fraction prod = new Fraction(1, 1);
                foreach (Fraction f in fractions)
                {
                    prod *= f;
                }

                txt += "Product of fractions: " + prod + "\n";

                Fraction quotient = fractions[0];
                for (int i = 1; i < numberOfFractions; i++)
                {
                    quotient /= fractions[i];
                }

                txt += "Quotient of fractions:  " + quotient;
            }
            if (rbtnPower.Checked)
            {
                lblvariable.Text = "Enter the power:";
                string fract = txtFract1.Text;
                string[] powerParts = fract.Split('/');
                int powerNum = int.Parse(powerParts[0]);
                int powerDenom = int.Parse(powerParts[1]);
                Fraction powerFraction = new Fraction(powerNum, powerDenom);
                int power = int.Parse(txtPower.Text);
                txt = powerFraction + " raised to the " + power + " power is " + powerFraction.Power(power);
            }
            if (rbtnEqual.Checked)
            {
                string n1 = txtFract1.Text;
                string[] compParts1 = n1.Split('/');
                double nmntr1 = Convert.ToDouble(compParts1[0]);
                double dnmntr1 = Convert.ToDouble(compParts1[1]);
                double compFraction1 = nmntr1 / dnmntr1;
                string n2 = txtFract2.Text;
                string[] compParts2 = n2.Split('/');
                double nmntr2 = Convert.ToDouble(compParts2[0]);
                double dnmntr2 = Convert.ToDouble(compParts2[1]);
                double compFraction2 = nmntr2 / dnmntr2;
                if (compFraction1 == compFraction2)
                {
                    txt = n1 + " is equal to " + n2 + "\n" ;
                }
                else if (compFraction1 != compFraction2)
                {
                    txt = n1 + " is not equal " + n2 + "\n";
                }
                if (compFraction1 > compFraction2)
                {
                    txt += n1 + " is greater than " + n2 + "\n";
                }
                if (compFraction1 < compFraction2)
                {
                    txt += n1 + " is less than " + n2 + "\n";
                }
                if (compFraction1 >= compFraction2)
                {
                    txt += n1 + " is greater than or equal to " + n2 + "\n";
                }
                if (compFraction1 <= compFraction2)
                {
                    txt += n1 + " is less than or equal to " + n2 + "\n";
                }

            }
            lblResult.Text = txt;
        }

        private void rbtnPower_CheckedChanged(object sender, EventArgs e)
        {
            txtFract1.Clear();
            txtFract2.Clear();
            txtPower.Clear();
            txtFract2.Enabled = false;
            txtPower.Enabled = true;
            txtFract1.Enabled = true;
        }

        private void rbtnMath_CheckedChanged(object sender, EventArgs e)
        {
            txtFract1.Clear();
            txtFract2.Clear();
            txtPower.Clear();
            txtFract1.Enabled = false;
            txtFract2.Enabled = false;
            txtPower.Enabled = true;
        }

        private void rbtnEqual_CheckedChanged(object sender, EventArgs e)
        {
            txtFract1.Clear();
            txtFract2.Clear();
            txtPower.Clear();
            txtPower.Enabled = false;
            txtFract1.Enabled = true;
            txtFract2.Enabled = true;
        }

        private void txtFract1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '/')
            {
                if (txtFract1.Text.IndexOf('/') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            e.Handled = true;
        }

        private void txtFract2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '/')
            {
                if (txtFract2.Text.IndexOf('/') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            e.Handled = true;
        }

        private void txtPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            e.Handled = true;
        }
        private void txtPower_TextChanged(object sender, EventArgs e)
        {
            //помилка
        }
    }
}
