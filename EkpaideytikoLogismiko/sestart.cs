﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkpaideytikoLogismiko
{
    public partial class sestart : Form
    {
        public sestart()
        {
            InitializeComponent();
        }

        private void sestart_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new mainMenu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Unit1().Show();
            this.Hide();
        }
    }
}
