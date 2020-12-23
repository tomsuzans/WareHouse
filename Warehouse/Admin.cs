using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace eksamens
{
    public partial class Admin : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\data_base\\noliktava.mdb;";
        private OleDbConnection myConnection;
        public Admin() 
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }



        private void Form2_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'noliktavaDataSet.Pardots' table. You can move, or remove it, as needed.
            this.pardotsTableAdapter1.Fill(this.noliktavaDataSet.Pardots);
            // TODO: This line of code loads data into the 'noliktavaDataSet.Preces' table. You can move, or remove it, as needed.
            this.precesTableAdapter2.Fill(this.noliktavaDataSet.Preces);

            // TODO: This line of code loads data into the 'aptiekaDataSet1.Preces' table. You can move, or remove it, as needed.
            //this.precesTableAdapter1.Fill(this.aptiekaDataSet1.Preces);
            // TODO: This line of code loads data into the 'aptiekaDataSet.Pardots' table. You can move, or remove it, as needed.
            //this.pardotsTableAdapter.Fill(this.aptiekaDataSet.Pardots);



            double sum = 0;
            int daudzums = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i) 
            {

                sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value);
            }
            textBox6.Text = sum.ToString();
        }


        private void button1_Click(object sender, EventArgs e) 
        {

            try
            {
                string query = "INSERT INTO Preces (Nosaukums, Tips, Daudzums, Cena) VALUES ('"
                        + textBox1.Text + "' , '"
                        + textBox2.Text + "' , '"
                        + textBox3.Text + "' , '"
                        + textBox4.Text + "') ";

                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();

                DialogResult d;
                d = MessageBox.Show("Prece pievienota", "Izdevās", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                DialogResult d;
                d = MessageBox.Show("Pārbaudiet ievadīto Informāciju", "Neizdevās", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            this.dataGridView1.Refresh();
            this.dataGridView1.Update();
            System.Threading.Thread.Sleep(500);
            this.precesTableAdapter2.Fill(this.noliktavaDataSet.Preces);
        }

        private void button2_Click(object sender, EventArgs e) 
        {


            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];


            int idval = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            string query = "SELECT Daudzums FROM Preces WHERE ID=" + idval + "";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            string TempDaudzums = command.ExecuteScalar().ToString();


            int Daudzums = int.Parse(TempDaudzums) + int.Parse(textBox5.Text);


            string query2 = "UPDATE Preces SET Daudzums = '" + Daudzums + "' WHERE ID=" + idval + "";
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            command2.ExecuteNonQuery();

            this.dataGridView1.Refresh();
            this.dataGridView1.Update();
            System.Threading.Thread.Sleep(500);
            this.precesTableAdapter2.Fill(this.noliktavaDataSet.Preces);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) 
        {
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            precesTableAdapter2.Update(noliktavaDataSet);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
