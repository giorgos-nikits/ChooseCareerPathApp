using System.Data.OleDb;
namespace EkpaideytikoLogismiko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;;Data Source=db_users.mdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty","Η εγγραφή απέτυχε",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txtpassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES('" + txtUsername.Text + "','" + txtpassword.Text + "','"+0+"','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "')";
                cmd = new OleDbCommand(register,con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtComPassword.Text = "";


                MessageBox.Show("Ο λογαριασμός σας δημιουργήθηκε!", "Επιτυχής Εγγραφή", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match, please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtComPassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void checkBxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}