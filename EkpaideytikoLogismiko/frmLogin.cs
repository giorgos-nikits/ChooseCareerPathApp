using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EkpaideytikoLogismiko
{

    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            //con.Close();

            if (dr.Read() == true)
            {
                new mainMenu().Show();
                this.Hide();
                Class1.LoggedInUsername = txtUsername.Text;
                Class1.SEE1T = LoadVariableFromDatabase("SEE1T");
                Class1.SEE2T = LoadVariableFromDatabase("SEE2T");
                Class1.GDE1T = LoadVariableFromDatabase("GDE1T");
                Class1.GDE2T = LoadVariableFromDatabase("GDE2T");
                Class1.SEE1S = LoadVariableFromDatabase("SEE1");
                Class1.SEE2S = LoadVariableFromDatabase("SEE2");
                Class1.GDE1S = LoadVariableFromDatabase("GDE1");
                Class1.GDE2S = LoadVariableFromDatabase("GdE2");
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password, please try again", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void checkBxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '•';

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private int LoadVariableFromDatabase(string columnName)
        {
            string databasePath = @"C:\Users\Giorgos Nik\source\repos\EkpaideytikoLogismiko\EkpaideytikoLogismiko\bin\Debug\net6.0-windows\db_users.mdb";
            //string databasePath = @"Data Source=db_users.mdb";
            string tableName = "tbl_users";
            //string columnName = "SEE1T";

            // Create the connection string
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";

            // Create the SQL query
            string query = $"SELECT {columnName} FROM {tableName} WHERE username='" + txtUsername.Text + "'";

            // Create a new OleDbConnection using the connection string
            using (var connection = new OleDbConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a new OleDbCommand using the SQL query and connection
                using (var command = new OleDbCommand(query, connection))
                {
                    // Execute the query and retrieve the value
                    var value = command.ExecuteScalar();

                    // Close the connection
                    connection.Close();

                    // Return the retrieved value               
                    return Convert.ToInt32(value);
                    

                }
            }
        }

        
    }
}
