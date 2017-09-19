using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using Склад.CkladDataSetTableAdapters;

namespace Склад.Correction
{
    public partial class correction : Form
    {
        OleDbDataAdapter dataAdapter = null;
        DataTable data = new DataTable();
        OleDbConnection database;
        public string a1 = "";
        public string st1 = " ", st2 = " ", st3 = " ";
        string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
        
        public correction()
        {
            InitializeComponent();
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "SELECT * FROM Correction";
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
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Основание";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addcorrection addForm1 = new addcorrection();
            addForm1.ShowDialog();
          
        }

        private void Correction_Activated(object sender, EventArgs e)
        {
            database = new OleDbConnection(connectionString);
            database.Open();
            string queryString = "SELECT * FROM Correction";
            loadDataGrid(queryString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "DELETE Correction.id_Correction FROM Correction WHERE id_Correction = " + a1 + "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            amendcorrection addForm1 = new amendcorrection();
            addForm1.Owner = this;
            addForm1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            a1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void correction_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Correction". При необходимости она может быть перемещена или удалена.
            /*CorrectionTableAdapter
            CorrectionTableAdapter.Fill(this.ckladDataSet.Correction);
            this.correctionTableAdapter.Fill(this.ckladDataSet.Correction);
             * */
            a1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            MaximizeBox = false;
        }

        private void correction_FontChanged(object sender, EventArgs e)
        {
            database.Close();
        }

    }
}
