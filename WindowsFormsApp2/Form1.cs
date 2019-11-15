using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=WiserDB.mdb; User ID=Admin;Jet OLEDB:Encrypt Database=False";
        OleDbConnection con;
        DataTable dt;
        OleDbDataAdapter da;
        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand myCommand = null;
        public Form1()
        {
            InitializeComponent();
            myCommand = new OleDbCommand();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wiserDBDataSet.Devices". При необходимости она может быть перемещена или удалена.
            this.devicesTableAdapter.Fill(this.wiserDBDataSet.Devices);

        }

        private void AddString_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Left = this.Left;
            form2.Top = this.Top;
            form2.Show();
            this.Hide();
        }

        private void UpdateDB()
        {
            OleDbCommandBuilder cm = new OleDbCommandBuilder(da);
            da.Update(dt);
        }

        private void UpdTable_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.devicesTableAdapter.Fill(this.wiserDBDataSet.Devices);
        }

        private void DelString_Click(object sender, EventArgs e)
        {
            var number = dataGridView1[0,dataGridView1.CurrentCell.RowIndex].Value;
            string query = String.Format("delete FROM devices where deviceCode = {0}",number);
            con = new OleDbConnection(connectionString);
            con.Open();
            myCommand = new OleDbCommand(query, con);
            myCommand.ExecuteNonQuery();
            con.Close();
            this.devicesTableAdapter.Fill(this.wiserDBDataSet.Devices);
        }
    }
}
