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
    public partial class GdUnitF : Form
    {
        public GdUnitF()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GEunit2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GdEpanT().Show();
            this.Hide();
        }
    }
}
