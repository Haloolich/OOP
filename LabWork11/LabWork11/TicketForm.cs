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
    public partial class TicketForm : Form
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RailwayStationDB.mdf;Integrated Security=True;Connect Timeout=30";
        public TicketForm()
        {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (txtTicketId.Text == "")
            {
                MessageBox.Show("Enter ticket id");
                return;
            }

            if (txtPassangerID.Text == "")
            {
                MessageBox.Show("Enter Passanger ID");
                return;
            }

            if (txtTrainID.Text == "")
            {
                MessageBox.Show("Enter Train ID");
                return;
            }
            if (txtJourneyDate.Text == "")
            {
                MessageBox.Show("Enter Journey Date");
                return;
            }

            if (checkTicket() == true)
            {
                return;
            }

            Class1 BD = new Class1();
            MySqlCommand command = new MySqlCommand("INSERT INTO tickets (TicketId,PassengerId,TrainId,JourneyDate) VALUES (@ticketid,@passangerid,@trainid, @journeydate)", BD.GetConnection());

            command.Parameters.Add("@ticketid", MySqlDbType.VarChar).Value = txtTicketId.Text;
            command.Parameters.Add("@passangerid", MySqlDbType.VarChar).Value = txtPassangerID.Text;
            command.Parameters.Add("@trainid", MySqlDbType.VarChar).Value = txtTrainID.Text;
            command.Parameters.Add("@journeydate", MySqlDbType.VarChar).Value = txtJourneyDate.Text;

            BD.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ticket Buy");
            }
            else
            {
                MessageBox.Show("Error");
            }

            BD.closeConnection();
        }

        public Boolean checkTicket()
        {
            Class1 BD = new Class1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tickets` WHERE `TicketId` = @tickI", BD.GetConnection());

            command.Parameters.Add("@tickI", MySqlDbType.VarChar).Value = txtTicketId.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This ID ticket in database");
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
