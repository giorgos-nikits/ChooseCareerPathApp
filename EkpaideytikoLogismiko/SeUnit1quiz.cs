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
    public partial class SeUnit1quiz : Form
    {
        public SeUnit1quiz()
        {
            InitializeComponent();
            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        int countS = 0;
        int countL = 0;
        private void bE1_Click(object sender, EventArgs e)
        {
           
        }

        private void bE2_Click(object sender, EventArgs e)
        {
            
        }

        private void bE3_Click(object sender, EventArgs e)
        {
            
        }

        private void bE4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbE1cor.Checked == true)
            {
                txtBE1.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtBE1.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rbE2cor.Checked == true)
            {
                txtBE2.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtBE2.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rbE3cor.Checked == true)
            {
                txtBE3.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtBE3.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rbE4cor.Checked == true)
            {
                txtBE4.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtBE4.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            con.Open();
            string tempUsername = Class1.LoggedInUsername;
            string submit = "UPDATE tbl_users SET SEE1T = @ValueToAdd WHERE username = @Username";
            using (OleDbCommand cmd = new OleDbCommand(submit, con))
            {
                cmd.Parameters.AddWithValue("@ValueToAdd", countS);
                cmd.Parameters.AddWithValue("@Username", tempUsername);

                cmd.ExecuteNonQuery();
            }
            con.Close();


            MessageBox.Show("Your results:" + countS + "/4", "Test Complete",MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Unit1().Show();
            this.Hide();
        }
    }
}
