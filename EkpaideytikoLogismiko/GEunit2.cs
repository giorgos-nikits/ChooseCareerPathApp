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
    public partial class GEunit2 : Form
    {
        public GEunit2()
        {
            InitializeComponent();
            if(Class1.GDE2S == 1)
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

        private void button3_Click(object sender, EventArgs e)
        {
            new GDUnitStart().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GDunit2test().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Class1.GDE2S = 1;

            }
            else
            {
                Class1.GDE2S = 0;

            }


            con.Open();
            string tempUsername = Class1.LoggedInUsername;
            string submit = "UPDATE tbl_users SET SEE1 = @ValueToAdd WHERE username = @Username";
            using (OleDbCommand cmd = new OleDbCommand(submit, con))
            {
                cmd.Parameters.AddWithValue("@ValueToAdd", Class1.GDE2S);
                cmd.Parameters.AddWithValue("@Username", tempUsername);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
