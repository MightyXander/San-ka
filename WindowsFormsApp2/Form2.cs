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
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }



        private void BTaddString_Click(object sender, EventArgs e)
        {
            if ((TBdeviceName.Text != "") && (TBprice.Text != "") && (TBcount.Text != ""))
            {
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\WiserDB.mdb; User ID=Admin;Jet OLEDB:Encrypt Database=False";
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand myCommand = new OleDbCommand();
                myCommand.Connection = conn;
                conn.Open();

                try
                {
                    myCommand.CommandText = "INSERT INTO devices (deviceName, devicePrice, deviceCount) VALUES (" + TBdeviceName.Text + ", " + TBprice.Text + " , " + TBcount.Text + ")";
                    myCommand.ExecuteNonQuery();//выполнение запроса.
                    conn.Close();
                    Form lol = Application.OpenForms[0];
                    lol.StartPosition = FormStartPosition.Manual;
                    lol.Left = this.Left;
                    lol.Top = this.Top;
                    this.Close();
                    lol.Show();
                    Form1.ActiveForm.Focus();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели значение в одно из полей !");
            }
        }

    }
}
