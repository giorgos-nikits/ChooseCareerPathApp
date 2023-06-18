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
    public partial class GEunit2 : Form
    {
        public GEunit2()
        {
            InitializeComponent();
        }

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
    }
}
