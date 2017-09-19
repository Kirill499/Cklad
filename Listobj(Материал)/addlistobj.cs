using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Склад
{
    public partial class addlistobj : Form
    {
        public addlistobj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "INSERT INTO Materiala ( id_mark, Price )" +
                " VALUES('" + textBox1.Text + "','" + comboBox1.SelectedValue.ToString() + "','" + textBox3.Text + "')";
                OleDbCommand SQLQuery = new OleDbCommand();
                SQLQuery.CommandText = queryString;
                SQLQuery.Connection = database;
                SQLQuery.ExecuteNonQuery();
                database.Close();
                MessageBox.Show("Добавлено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void addlistobj_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Mark". При необходимости она может быть перемещена или удалена.
            this.markTableAdapter.Fill(this.ckladDataSet.Mark);
            MaximizeBox = false;
        }
    }
}
