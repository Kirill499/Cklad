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
    public partial class searchprovider : Form
    {
        string queryString;
        string s,a;
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;
        string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
        public searchprovider()
        {
            InitializeComponent();
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                queryString = "SELECT * FROM Postavschik";
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
                    s = "Postavschik.Naimenovanie_organizatsii";
                    a = "'";
                }
                if (radioButton2.Checked == true)
                {
                    s = "Postavschik.Fakticheskiy_adres";
                    a = "'";
                }
                else if (radioButton3.Checked == true)
                {
                    s = "Postavschik.Yuridicheskiy_adres";
                    a = "'";
                }
                else if (radioButton4.Checked == true)
                {
                    s = "Postavschik.Person_in_charge";
                    a = "'";
                }
                else if (radioButton5.Checked == true)
                {
                    s = "Postavschik.Telefon_postavschika";
                    a = "'";
                }
                queryString = "SELECT * FROM Postavschik WHERE ( " + s + " = " + a + "" + textBox1.Text + "" + a + ");";
                //MessageBox.Show(queryString);
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

        private void button3_Click(object sender, EventArgs e)
        {
            database = new OleDbConnection(connectionString);
            database.Open();
            queryString = "SELECT * FROM Postavschik";
            loadDataGrid(queryString);
        }

        private void searchprovider_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
