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
    public partial class SeEpanT : Form
    {
        public SeEpanT()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        int countS = 0;
        int countL = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            new SeUnitF().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb1cor.Checked == true)
            {
                txtB1.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB1.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rb2cor.Checked == true)
            {
                txtB2.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB2.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rb3cor.Checked == true)
            {
                txtB3.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB3.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rb4cor.Checked == true)
            {
                txtB4.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB4.Text = " ΛΑΘΟΣ";
                countL += 1;
            }
            if (rb5cor.Checked == true)
            {
                txtB5.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB5.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rb6cor.Checked == true)
            {
                txtB6.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB6.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rb7cor.Checked == true)
            {
                txtB7.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB7.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            if (rb8cor.Checked == true)
            {
                txtB8.Text = "ΣΩΣΤΟ";
                countS += 1;
            }
            else
            {
                txtB8.Text = " ΛΑΘΟΣ";
                countL += 1;
            }

            
            con.Open();
            string tempUsername = Class1.LoggedInUsername;
            string submit = "UPDATE tbl_users SET SEET = @ValueToAdd WHERE username = @Username";
            using (OleDbCommand cmd = new OleDbCommand(submit, con))
            {
                cmd.Parameters.AddWithValue("@ValueToAdd", countS);
                cmd.Parameters.AddWithValue("@Username", tempUsername);

                cmd.ExecuteNonQuery();
            }
            con.Close();
            
            
            Class1.SEET = countS;
            MessageBox.Show("Your results:" + countS + "/8", "Test Complete", MessageBoxButtons.OK);
            countS = 0;
        }
    }
}
