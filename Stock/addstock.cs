using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Склад.Stock
{
    public partial class addstock : Form
    {
        public addstock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OleDbConnection database;
            //string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            //try
            //{
                //database = new OleDbConnection(connectionString);
                //database.Open();
                //string queryString = "INSERT INTO Correction ( id_Materiala, id_Staff, [Date], Base )" +
                //" VALUES('" + textBox1.Text + "','" + this.dateTimePicker1.Text + "')";
                //OleDbCommand SQLQuery = new OleDbCommand();
                //SQLQuery.CommandText = queryString;
                //SQLQuery.Connection = database;
                //SQLQuery.ExecuteNonQuery();
                //database.Close();
                //MessageBox.Show("Добавлено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
        }

        private void addstock_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Materiala". При необходимости она может быть перемещена или удалена.
            this.materialaTableAdapter.Fill(this.ckladDataSet.Materiala);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Correction". При необходимости она может быть перемещена или удалена.
            this.correctionTableAdapter.Fill(this.ckladDataSet.Correction);

        }
    }
}
