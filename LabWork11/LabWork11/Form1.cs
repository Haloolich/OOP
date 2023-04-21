using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LabWork11.Properties;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace LabWork11
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RailwayStationDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPassanger_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 passangerForm = new Form2();
            passangerForm.Show();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainForm trainForm = new TrainForm();
            trainForm.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketForm ticketForm = new TicketForm();
            ticketForm.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 FindForm = new Form3();
            FindForm.Show();
        }
    }
}
