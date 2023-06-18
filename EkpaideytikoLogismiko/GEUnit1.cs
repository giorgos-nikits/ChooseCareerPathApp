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
    public partial class GEUnit1 : Form
    {
        public GEUnit1()
        {
            InitializeComponent();
        }

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
    }
}
