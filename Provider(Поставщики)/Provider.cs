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
    public partial class Provider : Form
    {
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;
        public string a;
        public string st1, st2, st3, st4, st5;
        string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
        
        public Provider()
        {
            InitializeComponent();
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "SELECT * FROM Postavschik";
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

        private void Provider_Activated(object sender, EventArgs e)
        {
            database = new OleDbConnection(connectionString);
            database.Open();
            string queryString = "SELECT * FROM Postavschik";
            loadDataGrid(queryString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addprovider addForm1 = new addprovider();
            addForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            amendprovider addForm1 = new amendprovider();
            addForm1.Owner = this;
            addForm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "DELETE FROM Postavschik WHERE id_Postavschik = " + a + "";
                OleDbCommand SQLQuery = new OleDbCommand();
                SQLQuery.CommandText = queryString;
                SQLQuery.Connection = database;
                SQLQuery.ExecuteNonQuery();
                database.Close();
                MessageBox.Show("Удалено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchprovider addForm1 = new searchprovider();
            addForm1.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Provider_FontChanged(object sender, EventArgs e)
        {
            database.Close();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
