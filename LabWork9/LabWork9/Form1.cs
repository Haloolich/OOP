using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabWork9
{
    public partial class Form1 : Form
    {
        private double m;
        private double R;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // Draw x-axis
            g.DrawLine(Pens.Black, 0, height / 2, width, height / 2);
            for (int i = -10; i <= 10; i += 2)
            {
                int x = width / 2 + i * width / 10;
                g.DrawLine(Pens.Black, x, height / 2 - 3, x, height / 2 + 3);
                g.DrawString(i.ToString(), Font, Brushes.Black, x, height / 2 + 3);
            }
            g.DrawString("x", Font, Brushes.Black, width - 10, height / 2 + 3);

            // Draw y-axis
            g.DrawLine(Pens.Black, width / 2, 0, width / 2, height);
            for (int i = -10; i <= 10; i += 2)
            {
                int y = height / 2 - i * height / 10;
                g.DrawLine(Pens.Black, width / 2 - 3, y, width / 2 + 3, y);
                g.DrawString(i.ToString(), Font, Brushes.Black, width / 2 + 3, y);
            }
            g.DrawString("y", Font, Brushes.Black, width / 2 + 3, 0);

            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m, R;
            if (!double.TryParse(txtM.Text, out m) || !double.TryParse(txtR.Text, out R))
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // Draw x-axis
            g.DrawLine(Pens.Black, 0, height / 2, width, height / 2);
            for (int i = -10; i <= 10; i += 2)
            {
                int x = width / 2 + i * width / 10;
                g.DrawLine(Pens.Black, x, height / 2 - 3, x, height / 2 + 3);
                g.DrawString(i.ToString(), Font, Brushes.Black, x, height / 2 + 3);
            }
            g.DrawString("x", Font, Brushes.Black, width - 10, height / 2 + 3);

            // Draw y-axis
            g.DrawLine(Pens.Black, width / 2, 0, width / 2, height);
            for (int i = -10; i <= 10; i += 2)
            {
                int y = height / 2 - i * height / 10;
                g.DrawLine(Pens.Black, width / 2 - 3, y, width / 2 + 3, y);
                g.DrawString(i.ToString(), Font, Brushes.Black, width / 2 + 3, y);
            }
            g.DrawString("y", Font, Brushes.Black, width / 2 + 3, 0);

            double tMin = -10;
            double tMax = 10;
            double dt = 0.01;

            // Plot curve
            double x0 = (R - m * R) * Math.Cos(m * tMin) + m * Math.Cos(tMin - m * tMin);
            double y0 = (R - m * R) * Math.Sin(m * tMin) - m * Math.Sin(tMin - m * tMin);
            for (double t = tMin + dt; t <= tMax; t += dt)
            {
                double x = (R - m * R) * Math.Cos(m * t) + m * Math.Cos(t - m * t);
                double y = (R - m * R) * Math.Sin(m * t) - m * Math.Sin(t - m * t);
                g.DrawLine(Pens.DarkRed, (float)(width / 2 + x0 * width / 20), (float)(height / 2 - y0 * height / 20),
                    (float)(width / 2 + x * width / 20), (float)(height / 2 - y * height / 20));
                x0 = x;
                y0 = y;
            }

            pictureBox1.Image = bmp;
        }
    }
  }
