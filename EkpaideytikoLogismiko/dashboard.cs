﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Principal;

namespace EkpaideytikoLogismiko
{
    public partial class dashboard : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public dashboard()
        {
            InitializeComponent();
            lblName.Text = Class1.LoggedInUsername;
            if(Class1.SEE1S == 1)
            {
                checkBox1.Checked = true;
            }
            if(Class1.SEE2S == 1)
            {
                checkBox2.Checked = true;
            }
            if (Class1.GDE1S == 1)
            {
                checkBox3.Checked = true;
            }
            if (Class1.GDE2S == 1)
            {
                checkBox4.Checked = true;
            }
            lblE1T.Text = Class1.SEE1T.ToString();
            lblE2T.Text = Class1.SEE2T.ToString();
            lblGDE1T.Text = Class1.GDE1T.ToString();
            lblGDE2T.Text = Class1.GDE2T.ToString();
            lblEPT1.Text = Class1.SEET.ToString();
            lblGDET.Text = Class1.GDET.ToString();

        }
        

        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new mainMenu().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
