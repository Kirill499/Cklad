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
    public partial class Form2 : Form
    {
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;
        public Form2()
        {
            InitializeComponent();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                database = new OleDbConnection();
                database.ConnectionString = "Provider=SQLOLEDB;" + "Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
                database.Open();
                //string queryString = "SELECT Journal.surname, Journal.name, Journal.patronymic, Journal.title FROM //Страна(tariffid)// INNER JOIN //Абонент (Journal)// ON tariff.tariffid = Journal.tariffid GROUP BY Journal.surname, Journal.name, Journal.patronymic, tariff.title;";
                //loadDataGrid(queryString);
                //dataGridView1.Columns[0].HeaderText = "Фамилия";
                //dataGridView1.Columns[1].HeaderText = "Имя";
                //dataGridView1.Columns[2].HeaderText = "Отчество";
                //dataGridView1.Columns[3].HeaderText = "Название тарифа";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                database = new OleDbConnection();
                database.ConnectionString = "Provider=SQLOLEDB;" + "Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
                database.Open();
                string queryString = "SELECT Journal.surname, Journal.name, Journal.patronymic, tariff.title, tariff.thestarttime FROM tariff INNER JOIN Journal ON tariff.tariffid = Journal.tariffid GROUP BY Journal.surname, Journal.name, Journal.patronymic, tariff.title, tariff.thestarttime HAVING (tariff.thestarttime BETWEEN 1 and 5);";
                loadDataGrid(queryString);
                //dataGridView1.Columns[0].HeaderText = "Фамилия";
                //dataGridView1.Columns[1].HeaderText = "Имя";
                //dataGridView1.Columns[2].HeaderText = "Отчество";
                //dataGridView1.Columns[3].HeaderText = "Название тарифа";
                //dataGridView1.Columns[4].HeaderText = "Время начала действия";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                database = new OleDbConnection();
                database.ConnectionString = "Provider=SQLOLEDB;" + "Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
                database.Open();
                //string queryString = "SELECT Journal.surname, Journal.name, Journal.patronymic, tariff.title, Min(tariff.expirationtime) FROM tariff INNER JOIN Journal ON tariff.tariffid = Journal.tariffid GROUP BY Journal.surname, Journal.name, Journal.patronymic, tariff.title;";
                //loadDataGrid(queryString);
                //dataGridView1.Columns[0].HeaderText = "Фамилия";
                //dataGridView1.Columns[1].HeaderText = "Имя";
                //dataGridView1.Columns[2].HeaderText = "Отчество";
                //dataGridView1.Columns[3].HeaderText = "Название тарифа";
                //dataGridView1.Columns[4].HeaderText = "Минимальное время окончания";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
