using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace eksamens
{
    public partial class Login : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\data_base\\noliktava.mdb;";
        private OleDbConnection myConnection;
        public Login() 
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            myConnection.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string source = textBox2.Text;
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                textBox3.Text = hash;
            }

            string query = "SELECT pass FROM login WHERE login = 'admin'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            textBox1.Text = command.ExecuteScalar().ToString();

            if (textBox1.Text == textBox3.Text)
            {
                Admin form2 = new Admin();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {

            string source = textBox2.Text;
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);


                textBox3.Text = hash;
            }

            string query = "SELECT pass FROM login WHERE login = 'manager'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            textBox1.Text = command.ExecuteScalar().ToString();

            if (textBox1.Text == textBox3.Text)
            {
                Manager form3 = new Manager();
                this.Hide();
                form3.ShowDialog();
                this.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
