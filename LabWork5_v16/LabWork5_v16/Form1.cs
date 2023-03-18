using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork5_v16
{
    public partial class Form1 : Form
    {
        public string txt;
        public Form1()
        {
            InitializeComponent();
        }
        static bool CheckParentheses(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else if (c == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (c == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else if (c == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string expression = Convert.ToString(txtCheck.Text);

            if (CheckParentheses(expression))
            {
                txt = "The parentheses are placed correctly.";
            }
            else
            {
                txt = "The parentheses are not placed correctly.";
            }
            lblCheck.Text = txt;

        }
    }
}
