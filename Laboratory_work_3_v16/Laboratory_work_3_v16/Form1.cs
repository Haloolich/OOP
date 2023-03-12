using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_3_v16
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
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rbtnComplex.Checked) 
            { 
                int imag = Convert.ToInt32(txtImag.Text);
                int real = Convert.ToInt32(txtReal.Text);
                Complex c = new Complex(real, imag);
                txt = "Complex modulus: " + c.CalculateModulus() + "\n";
                txt += "Complex norm: " + c.CalculateNorm();
            }
            if (rbtnVector.Checked) 
            { 
                int x = Convert.ToInt32(txtX.Text);
                int y = Convert.ToInt32(txtY.Text);
                int z = Convert.ToInt32(txtZ.Text);
                Vector3D v = new Vector3D(x, y, z);
                txt = "Vector modulus: " + v.CalculateModulus() + "\n";
                txt += "Vector norm: " + v.CalculateNorm();
            }
            lblResult.Text = txt;
        }

        private void rbtnComplex_CheckedChanged(object sender, EventArgs e)
        {
            txtImag.Clear();
            txtReal.Clear();
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            txtX.Enabled = false;
            txtY.Enabled = false;
            txtZ.Enabled = false;
            txtImag.Enabled = true;
            txtReal.Enabled = true;

        }

        private void rbtnVector_CheckedChanged(object sender, EventArgs e)
        {
            txtImag.Clear();
            txtReal.Clear();
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            txtX.Enabled = true;
            txtY.Enabled = true;
            txtZ.Enabled = true;
            txtImag.Enabled = false;
            txtReal.Enabled = false;
        }

        private void txtImag_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtImag.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtImag.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;

        }

        private void txtReal_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtReal.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtReal.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
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
            if (e.KeyChar == '-')
            {
                if (txtX.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            //помилка
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtY.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtY.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtZ_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtZ.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txtZ.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}
