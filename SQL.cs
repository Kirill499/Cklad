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
    class SQL
    {
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;

        public void Select(Form1 form, string connect)
        {
            try
            {
                database = new OleDbConnection(connect);
                database.Open();

                string queryString1 = "SELECT Journal.id_Journal, Journal.id_Postavschik, Journal.id_Materiala, Journal.id_measuring, Journal.Date, Journal.Number, Staff.Surename FROM Journal INNER JOIN Staff ON Journal.id_Staff = Staff.id_Staff";
                loadDataGrid1(form, queryString1);
                string queryString2 = "SELECT * FROM Nakladnaya";
                loadDataGrid2(form, queryString2);
                string queryString3 = "SELECT * FROM Materiala";
                loadDataGrid3(form, queryString3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void loadDataGrid1(Form1 form, string sqlQueryString)
        {
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            form.dataGridView1.DataSource = null;
            SQLQuery.Connection = null;
            form.dataGridView1.Columns.Clear();
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            form.dataGridView1.DataSource = data;
            form.dataGridView1.AllowUserToAddRows = false;
            form.dataGridView1.ReadOnly = true;
            form.dataGridView1.Columns[0].Visible = false;
            //form.dataGridView1.Columns[1].Visible = false;
            //form.dataGridView1.Columns[2].Visible = false;
            //form.dataGridView1.Columns[3].Visible = false;
            //form.dataGridView1.Columns[4].Visible = false;
            //form.dataGridView1.Columns[5].HeaderText = "Название";
            //form.dataGridView1.Columns[6].HeaderText = "Дата";
            //form.dataGridView1.Columns[7].HeaderText = "Количество";
            for (int i = 0; i < form.dataGridView1.Rows.Count; i++)
            {
                form.dataGridView1.Rows[i].HeaderCell.Value
                    = i.ToString();
            }
        }

        public void loadDataGrid2(Form1 form, string sqlQueryString)
        {
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            form.dataGridView2.DataSource = null;
            SQLQuery.Connection = null;
            form.dataGridView2.Columns.Clear();
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            form.dataGridView2.DataSource = data;
            form.dataGridView2.AllowUserToAddRows = false;
            form.dataGridView2.ReadOnly = true;
            //form.dataGridView2.Columns[0].Visible = false;
            //form.dataGridView2.Columns[1].Visible = false;
            //form.dataGridView2.Columns[2].Visible = false;
            //form.dataGridView1.Columns[3].HeaderText = "Дата";
        }

        public void loadDataGrid3(Form1 form, string sqlQueryString)
        {
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            form.dataGridView3.DataSource = null;
            SQLQuery.Connection = null;
            form.dataGridView3.Columns.Clear();
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            form.dataGridView3.DataSource = data;
            form.dataGridView3.AllowUserToAddRows = false;
            form.dataGridView3.ReadOnly = true;
            //form.dataGridView3.Columns[0].Visible = false; ;
            //form.dataGridView1.Columns[1].HeaderText = "Цена";
        }

        public void Delete(Form1 form, string connect)
        {
            OleDbConnection database;
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=True";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "DELETE Nakladnaya.id_Nakladnaya FROM Nakladnaya WHERE id_Nakladnaya = " + form.a2 + "";
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
    }
}
