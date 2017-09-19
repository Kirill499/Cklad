using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace Склад
{
    public partial class searchwaybill : Form
    {
        string queryString;
        string s, a;
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;
        string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
        public searchwaybill()
        {
            InitializeComponent();
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                queryString = "SELECT * FROM Nakladnaya_na_spisanie";
                loadDataGrid(queryString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void loadDataGrid(string sqlQueryString)
        {
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            dataGridView1.DataSource = null;
            SQLQuery.Connection = null;
            dataGridView1.Columns.Clear();
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                if (radioButton1.Checked == true)
                {
                    s = "Nakladnaya_na_spisanie.Date";
                    a = "#";
                    queryString = "SELECT * FROM Nakladnaya_na_spisanie WHERE (((Nakladnaya_na_spisanie.Date)=#" + this.dateTimePicker1.Text + "#));";
                    MessageBox.Show(queryString);
                }
                else if (radioButton2.Checked == true)
                {
                    s = "Nakladnaya_na_spisanie.Number";
                    a = "'";
                    queryString = "SELECT * FROM Nakladnaya_na_spisanie WHERE ( " + s + " = " + a + "" + textBox1.Text + "" + a + ");";
                }
                OleDbCommand SQLQuery = new OleDbCommand();
                SQLQuery.CommandText = queryString;
                SQLQuery.Connection = database;
                SQLQuery.ExecuteNonQuery();
                loadDataGrid(queryString);
                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchwaybill_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            MaximizeBox = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            database = new OleDbConnection(connectionString);
            database.Open();
            queryString = "SELECT * FROM Nakladnaya_na_spisanie";
            loadDataGrid(queryString);
        }
    }
}
