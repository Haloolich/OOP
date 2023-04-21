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
    public partial class TrainForm : Form
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RailwayStationDB.mdf;Integrated Security=True;Connect Timeout=30";
        public TrainForm()
        {
            InitializeComponent();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (txtTrainName.Text == "")
            {
                MessageBox.Show("Enter train name");
                return;
            }

            if (txtTrainID.Text == "")
            {
                MessageBox.Show("Enter train ID");
                return;
            }

            if (txtOriginCity.Text == "")
            {
                MessageBox.Show("Enter Origin City");
                return;
            }
            if (txtDestinationCity.Text == "")
            {
                MessageBox.Show("Enter Destination City");
                return;
            }

            if (checkTrain() == true)
            {
                return;
            }

            Class1 BD = new Class1();
            MySqlCommand command = new MySqlCommand("INSERT INTO trains (TrainId,TrainName, OriginCity, DestinationCity) VALUES (@trainid, @trainname, @origincity, @dectinationcity)", BD.GetConnection());

            command.Parameters.Add("@trainid", MySqlDbType.VarChar).Value = txtTrainID.Text;
            command.Parameters.Add("@trainname", MySqlDbType.VarChar).Value = txtTrainName.Text;
            command.Parameters.Add("@origincity", MySqlDbType.VarChar).Value = txtOriginCity.Text;
            command.Parameters.Add("@dectinationcity", MySqlDbType.VarChar).Value = txtDestinationCity.Text;

            BD.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Train add");
            }
            else
            {
                MessageBox.Show("Error");
            }

            BD.closeConnection();
        }

        public Boolean checkTrain()
        {
            Class1 BD = new Class1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `trains` WHERE `TrainName` = @tN AND `TrainId` = @tI", BD.GetConnection());

            command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = txtTrainName.Text;
            command.Parameters.Add("@tI", MySqlDbType.VarChar).Value = txtTrainID.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
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
