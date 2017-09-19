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
    public partial class searchlog : Form
    {
        string queryString;
        string s, a;
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;
        string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
        public searchlog()
        {
            InitializeComponent();
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                queryString = "SELECT * FROM Journal";
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
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
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
                    s = "Journal.Date";
                    a = "#";
                    queryString = "SELECT * FROM Journal WHERE (((Journal.Date)=#"+ this.dateTimePicker1.Text + "#));";
                }
                else if (radioButton2.Checked == true)
                {
                    s = "Journal.Title";
                    a = "'";
                    queryString = "SELECT * FROM Journal WHERE ( " + s + " = " + a + "" + textBox1.Text + "" + a + ");";
                }
                else if (radioButton3.Checked == true)
                {
                    s = "Journal.Unit_of_measure";
                    a = "'";
                    dateTimePicker1.Enabled = false;
                    textBox1.Enabled = true;
                    queryString = "SELECT * FROM Journal WHERE ( " + s + " = " + a + "" + textBox1.Text + "" + a + ");";
                }
                else if (radioButton4.Checked == true)
                {
                    s = "Journal.[Number]";
                    a = "";
                    dateTimePicker1.Enabled = false;
                    textBox1.Enabled = true;
                    queryString = "SELECT * FROM Journal WHERE ( " + s + " = " + a + "" + textBox1.Text + "" + a + ");";
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void searchlog_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            MaximizeBox = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            database = new OleDbConnection(connectionString);
            database.Open();
            queryString = "SELECT * FROM Journal";
            loadDataGrid(queryString);
        }
    }
}
