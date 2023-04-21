using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork11
{
    public partial class Form2 : Form
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RailwayStationDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPassanger_Click(object sender, EventArgs e)
        {
            if(txtContactInfo.Text == "")
            {
                MessageBox.Show("Enter contact");
                return;
            }

            if (txtPassangerID.Text == "")
            {
                MessageBox.Show("Enter ID");
                return;
            }

            if (txtPassangerName.Text == "")
            {
                MessageBox.Show("Enter Name");
                return;
            }

            if (checkPassanger() == true)
            {
                return;
            }

            Class1 BD = new Class1();
            MySqlCommand command = new MySqlCommand("INSERT INTO passengers (PassengerID,PassengerName,ContactInfo) VALUES (@passangerid,@passangername, @contactinfo)", BD.GetConnection());

            command.Parameters.Add("@passangerid", MySqlDbType.VarChar).Value = txtPassangerID.Text;
            command.Parameters.Add("@passangername", MySqlDbType.VarChar).Value = txtPassangerName.Text;
            command.Parameters.Add("@contactinfo", MySqlDbType.VarChar).Value = txtContactInfo.Text;

            BD.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Passanger add");
            }
            else
            {
                MessageBox.Show("Error");
            }

            BD.closeConnection();
        }

        public Boolean checkPassanger()
        {
            Class1 BD = new Class1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `passengers` WHERE `PassengerName` = @pN AND `ContactInfo` = @cI",BD.GetConnection());

            command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = txtPassangerName.Text;
            command.Parameters.Add("@cI", MySqlDbType.VarChar).Value = txtContactInfo.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("This ID in database");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 IndexForm = new Form1();
            IndexForm.Show();
        }
    }
}
