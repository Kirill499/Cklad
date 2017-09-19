using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using Склад.Measuring;
using Склад.Correction;
using Склад.Mark;
using Склад.Stock;
using Склад.Post;

namespace Склад
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        SQL query = new SQL(); 
        public string a, a2, a3;
        public string st1, st2, st3, st4, st5, st6, st7, st21, st22, st23, st24;
        public string st31, st32, st33;
        string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI"; //"Provider=SQLOLEDB; Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=True"; //Jet OLEDB:Database Password=123;
        
        public Form1()
        {
            InitializeComponent();
            query.Select(this, connectionString);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Provider addForm1 = new Provider();
            addForm1.ShowDialog(this);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Employees addForm1 = new Employees();
            addForm1.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Journal". При необходимости она может быть перемещена или удалена.
            this.journalTableAdapter.Fill(this.ckladDataSet.Journal);
            //MaximizeBox = false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            query.Select(this, connectionString);
            dataGridView1.Columns[1].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            a2 = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            st21 = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            st22 = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            st23 = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            st24 = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            a3 = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            st21 = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            st22 = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            st23 = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            st24 = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            searchlog addForm1 = new searchlog();
            addForm1.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Print2 addForm1 = new Print2();
            addForm1.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            searchwaybill addForm1 = new searchwaybill();
            addForm1.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Print3 addForm1 = new Print3();
            addForm1.ShowDialog();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            searchlistobj addForm1 = new searchlistobj();
            addForm1.ShowDialog();
        }

        private void dataGridView3_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            a3 = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            st31 = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            st32 = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            st33 = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P addForm1 = new P();
            addForm1.ShowDialog(this);
        }

        private void коррекцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            correction addForm1 = new correction();
            addForm1.ShowDialog(this);
        }

        private void измеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            measuring addForm1 = new measuring();
            addForm1.ShowDialog(this);
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock addForm1 = new stock();
            addForm1.ShowDialog(this);
        }

        private void материToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mark addForm1 = new mark();
            addForm1.ShowDialog(this);
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addForm1 = new Form2();
            addForm1.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addlog addForm1 = new addlog();
            addForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            amendlog addForm1 = new amendlog();
            addForm1.Owner = this;
            addForm1.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OleDbConnection database;
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=True";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "DELETE Journal.id_Journal FROM Journal WHERE id_Journal = " + a + "";
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

        private void button10_Click_1(object sender, EventArgs e)
        {
            addwaybill addForm1 = new addwaybill();
            addForm1.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            amendwaybill addForm1 = new amendwaybill();
            addForm1.Owner = this;
            addForm1.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            //OleDbConnection database;
            //string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=True";
            //try
            //{
            //    database = new OleDbConnection(connectionString);
            //    database.Open();
            //    string queryString = "DELETE Nakladnaya.id_Nakladnaya FROM Nakladnaya WHERE id_Nakladnaya = " + a2 + "";
            //    OleDbCommand SQLQuery = new OleDbCommand();
            //    SQLQuery.CommandText = queryString;
            //    SQLQuery.Connection = database;
            //    SQLQuery.ExecuteNonQuery();
            //    database.Close();
            //    MessageBox.Show("Удалено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
            query.Delete(this, connectionString);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            addlistobj addForm1 = new addlistobj();
            addForm1.ShowDialog();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            amendlistobj addForm1 = new amendlistobj();
            addForm1.Owner = this;
            addForm1.ShowDialog();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            OleDbConnection database;
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=True";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "DELETE Materiala.id_Materiala FROM Materiala WHERE id_Materiala = " + a3 + "";
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

        private void button16_Click(object sender, EventArgs e)
        {
            Form3 addForm1 = new Form3();
            addForm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Print1 addForm1 = new Print1();
            addForm1.ShowDialog();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
