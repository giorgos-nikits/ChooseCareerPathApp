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
    public partial class direction : Form
    {
        public direction()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void direction_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sumSE = math1.Value + math3.Value + math5.Value;
            decimal sumGD = math2.Value + math8.Value + math9.Value;
            decimal sumFED = math4.Value + math6.Value + math7.Value;

            if(sumSE > sumGD && sumSE > sumFED)
            {
                MessageBox.Show("Η καταλληλη κατευθηνση για εσενα ειναι Software Engineer", "Επιτυχης Επιλογη", MessageBoxButtons.OK);
            }else if(sumGD > sumSE && sumGD > sumFED)
            {
                MessageBox.Show("Η καταλληλη κατευθηνση για εσενα ειναι Game Developer", "Επιτυχης Επιλογη", MessageBoxButtons.OK);
            }else if(sumFED > sumGD && sumFED > sumSE)
            {
                MessageBox.Show("Η καταλληλη κατευθηνση για εσενα ειναι Front-End Developer", "Επιτυχης Επιλογη", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("'Ολες οι κατευθήνσης σου ταιριάζουν κάνε το πρώτο μάθημα απο την κάθε μια για να έχεις μια καλύτερη νγώμη", "Επιτυχης Επιλογη", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu mmenu = new mainMenu();
            mmenu.Show();
            this.Hide();
        }
    }
}
