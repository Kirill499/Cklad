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

namespace Склад
{
    public partial class Form3 : Form
    {
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;
        public Form3()
        {
            InitializeComponent();
            try
            {
                database = new OleDbConnection();
                database.ConnectionString = "Provider=SQLOLEDB;" + "Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
                database.Open();
                string queryString = "SELECT * FROM Journal";
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
            chart1.DataSource = null;
            SQLQuery.Connection = null;
            //dataGridView1.Columns.Clear();
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            chart1.DataSource = data;
           
            chart1.Series["Тариф"].XValueMember = "Number";
            chart1.Series["Тариф"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["Тариф"].YValueMembers = "";
            chart1.Series["Тариф"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart2.DataSource = data;
            chart2.Series["Тариф"].XValueMember = "Number";
            chart2.Series["Тариф"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series["Тариф"].YValueMembers = "";
            chart2.Series["Тариф"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
    }
}




