using System;
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
    public partial class Unit1 : Form
    {
        public Unit1()
        {
            InitializeComponent();
        }

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
    }
}
