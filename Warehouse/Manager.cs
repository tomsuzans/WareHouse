using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace eksamens
{
    public partial class Manager : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\data_base\\noliktava.mdb;";
        private OleDbConnection myConnection;
        public Manager()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            string txtNosaukums = textBox1.Text;
          
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int idval = Convert.ToInt32(selectedRow.Cells["ID"].Value);


       
            string query = "SELECT Daudzums FROM Preces WHERE Nosaukums='" + txtNosaukums + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            string TempDaudzums = command.ExecuteScalar().ToString();


            int Daudzums = int.Parse(TempDaudzums) - int.Parse(textBox3.Text);



            if (Daudzums >= 0) 
            {

                string query2 = "UPDATE Preces SET Daudzums = '" + Daudzums + "' WHERE Nosaukums='" + txtNosaukums + "'";
                OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                command2.ExecuteNonQuery();


                this.dataGridView1.Refresh();
                this.dataGridView1.Update();
                System.Threading.Thread.Sleep(500);
                this.precesTableAdapter2.Fill(this.noliktavaDataSet.Preces);


                DialogResult d;
                d = MessageBox.Show("Prece pardota", "Izdevās", MessageBoxButtons.OK, MessageBoxIcon.Information);



                string query3 = "SELECT Nosaukums, Tips, Cena FROM Preces WHERE Nosaukums='" + txtNosaukums + "'";
                OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                OleDbDataReader reader = command3.ExecuteReader();
                string TempNosaukums = "";
                string TempTips = "";
                string TempCena = "";
                while (reader.Read())
                {
                    TempNosaukums = reader[0].ToString();
                    TempTips = reader[1].ToString();
                    TempCena = reader[2].ToString();
                }
                reader.Close();


                try
                {

                    string query4 = "INSERT INTO Pardots (Nosaukums, Tips, Daudzums, Cena, Klients) VALUES ('"
                            + TempNosaukums + "' , '"
                            + TempTips      + "' , '"
                            + textBox3.Text + "' , '"
                            + TempCena      + "' , '"
                            + textBox4.Text + "') ";

                    OleDbCommand command4 = new OleDbCommand(query4, myConnection);
                    command4.ExecuteNonQuery();
                }

                catch
                {

                    DialogResult dialogD;
                    dialogD = MessageBox.Show("Pārbaudiet ievadīto Informāciju", "Neizdevās", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                DialogResult d;
                d = MessageBox.Show("Nevar pārdot vairāk nekā ir noliktavā", "Neizdevās", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.dataGridView1.Refresh();
            this.dataGridView1.Update();
            System.Threading.Thread.Sleep(500);
            this.precesTableAdapter1.Fill(this.aptiekaDataSet1.Preces);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'noliktavaDataSet.Preces' table. You can move, or remove it, as needed.
            this.precesTableAdapter2.Fill(this.noliktavaDataSet.Preces);
            // TODO: This line of code loads data into the 'aptiekaDataSet1.Preces' table. You can move, or remove it, as needed.
            this.precesTableAdapter1.Fill(this.aptiekaDataSet1.Preces);
                
                    string strSql = "SELECT Nosaukums FROM Preces WHERE ID >=0";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, myConnection));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    comboBox1.DataSource = ds.Tables[0];
                    comboBox1.DisplayMember = "Nosaukums";
                    comboBox1.ValueMember = "Nosaukums";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
