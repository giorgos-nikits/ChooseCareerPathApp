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
    public partial class GEUnit1 : Form
    {
        public GEUnit1()
        {
            InitializeComponent();
            if(Class1.GDE1S == 1)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;  
            }
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void GEUnit1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new GDUnitStart().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GDunit1test().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GEunit2().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Class1.GDE1S = 1;

            }
            else
            {
                Class1.GDE1S = 0;

            }


            con.Open();
            string tempUsername = Class1.LoggedInUsername;
            string submit = "UPDATE tbl_users SET GDE1 = @ValueToAdd WHERE username = @Username";
            using (OleDbCommand cmd = new OleDbCommand(submit, con))
            {
                cmd.Parameters.AddWithValue("@ValueToAdd", Class1.GDE1S);
                cmd.Parameters.AddWithValue("@Username", tempUsername);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
