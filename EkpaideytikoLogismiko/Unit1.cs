using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkpaideytikoLogismiko
{
    public partial class Unit1 : Form
    {
        public Unit1()
        {
            InitializeComponent();
            if(Class1.SEE1S == "checked")
            {
                checkBox1.Checked = true;
            }
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            new SeUnit1quiz().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new mainMenu().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                Class1.SEE1S = "checked";
            }
            else
            {
                Class1.SEE1S = "unchecked";
            }
            
   
            con.Open();
            string tempUsername = Class1.LoggedInUsername;
            string submit = "UPDATE tbl_users SET SEE1 = @ValueToAdd WHERE username = @Username";
            using (OleDbCommand cmd = new OleDbCommand(submit, con))
            {
                cmd.Parameters.AddWithValue("@ValueToAdd", Class1.SEE1S);
                cmd.Parameters.AddWithValue("@Username", tempUsername);

                cmd.ExecuteNonQuery();
            }
            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SeUnit2().Show();
            this.Hide();
        }
    }
}
