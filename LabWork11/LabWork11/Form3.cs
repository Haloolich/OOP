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
using System.Data.SqlClient;

namespace LabWork11
{
    public partial class Form3 : Form
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RailwayStationDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPassangerFind_Click(object sender, EventArgs e)
        {
            //MySqlCommand command = new MySqlCommand("SELECT *FROM `passengers` WHERE `PassengerId` = @passangerID", BD.GetConnection());
            //MySqlCommand commander = new MySqlCommand("SELECT * FROM `tickets` WHERE `PassengerId` = @passangerID", BD.GetConnection());
            Class1 BD = new Class1();
            SqlConnection connection = new SqlConnection(connectionString);

            int studentId = Convert.ToInt32(txtPassengerFind.Text);
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `passengers` WHERE PassengerId = {studentId}", BD.GetConnection());
            MySqlCommand commander = new MySqlCommand($"SELECT * FROM `tickets` WHERE PassengerId = {studentId}", BD.GetConnection());
            BD.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row += reader.GetValue(i).ToString() + "\t";
                }
                richTxtBxPassangerTicket.AppendText(row + "\n");
            }

            reader.Close();

            MySqlDataReader readerer = commander.ExecuteReader();

            while (readerer.Read())
            {
                string rows = "";
                for (int i = 0; i < readerer.FieldCount; i++)
                {
                    rows += readerer.GetValue(i).ToString() + "\t";
                }
                richTxtList.AppendText(rows + "\n");
            }

            readerer.Close();
            BD.closeConnection();
        }
    }
}
