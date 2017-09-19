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
    public partial class addlog : Form
    {
        public addlog()
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
                string queryString = "INSERT INTO Journal (id_Staff, id_Postavschik, id_Materiala, id_Measuring, [Date], [Number] )" +
                " VALUES('" + comboBox1.SelectedValue.ToString() + "','" + comboBox2.SelectedValue.ToString() + "','" + comboBox3.SelectedValue.ToString() + "','" + comboBox4.SelectedValue.ToString() + "','" + this.dateTimePicker1.Text + "'," +
                " '" + Int32.Parse(textBox1.Text) + "')";
                //MessageBox.Show(queryString);
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

        private void addlog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Mark". При необходимости она может быть перемещена или удалена.
            this.markTableAdapter.Fill(this.ckladDataSet.Mark);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Measuring". При необходимости она может быть перемещена или удалена.
            this.measuringTableAdapter.Fill(this.ckladDataSet.Measuring);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Materiala". При необходимости она может быть перемещена или удалена.
            this.materialaTableAdapter.Fill(this.ckladDataSet.Materiala);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Postavschik". При необходимости она может быть перемещена или удалена.
            this.postavschikTableAdapter.Fill(this.ckladDataSet.Postavschik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.ckladDataSet.Post);


            MaximizeBox = false;
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}
