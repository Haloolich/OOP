using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace laboratoryWork_3_v16
{
    public partial class Form1 : Form
    {
        public void PrintArray(int[] arr)
        {
            txt += "[ ";
            for (int i = 0; i < arr.Length; i++)
            {
                txt += arr[i] + "; ";
            }
            txt += "]";

        }
        public void PrintTwoArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    txt += $"{array[i, j],3}";
                }
                txt += "\n";
            }
        }

        string txt;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult2.Text = "";
        }
        //exercise 1
        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            int [] arr = new int [n];

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1,100);
            }

            txt = "Original Array:\n";
            PrintArray(arr);

            int maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            txt += "\nThe maximum element of the array is " + arr[maxIndex] + " at index " + maxIndex;

            int firstZeroIndex = -1, secondZeroIndex = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    if (firstZeroIndex == -1)
                    {
                        firstZeroIndex = i;
                    }
                    else if (secondZeroIndex == -1)
                    {
                        secondZeroIndex = i;
                        break;
                    }
                }
            }
            double product = 1;
            if (firstZeroIndex != -1 && secondZeroIndex != -1)
            {
                for (int i = firstZeroIndex + 1; i < secondZeroIndex; i++)
                {
                    product *= arr[i];
                }
            }
            txt += "\nThe product of array elements between the first and second zero elements is " + product;

            int[] transformedArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    transformedArr[i] = arr[i * 2 + 1];
                }
                else
                {
                    transformedArr[i] = arr[(n - i - 1) * 2];
                }
            }

            txt += "\nTransformed Array:\n";
            PrintArray(transformedArr);
            
            lblResult2.Text = txt;
        }
        //exercise 2
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(txtI.Text); 

            //Console.Write("Enter the number of columns: ");
            int columns = Convert.ToInt32(txtJ.Text);

            int[,] array = new int[rows, columns];
            Random rnd = new Random();

            // Fill the array with random numbers
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rnd.Next(1, 101); // Generate a random number between 1 and 100
                }
            }

            txt = "The array is:\n";
            PrintTwoArray(array);
            string text;
            int row1 = Convert.ToInt32(txt1.Text);
            int column1 = Convert.ToInt32(txt2.Text);

            int row2 = Convert.ToInt32(txt3.Text);
            int column2 = Convert.ToInt32(txt4.Text);
            if (rbtnDIff.Checked) { 
                // Calculate the difference of the two elements
                int diff = array[row1, column1] - array[row2, column2];
                text = $"\nThe difference of \narray[{row1}, {column1}] and array[{row2}, {column2}] \nis {diff}";
                txt += text;
            }
            if (rbtnGeom.Checked) { 
                // Calculate the geometric mean of the two elements
                double geoMean = Math.Sqrt(array[row1, column1] * array[row2, column2]);
                text = $"\nThe geometric mean of \narray[{row1}, {column1}] and array[{row2}, {column2}] \nis {geoMean}";
                txt += text;
            }
            
            lblResult.Text = txt;
        }

        private void txtI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
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

        private void txtJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
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

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
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

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
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

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
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

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
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

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc2.Focus();
                return;
            }
            e.Handled = true;

        }
    }
}
