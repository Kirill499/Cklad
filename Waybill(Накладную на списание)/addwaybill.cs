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
    public partial class addwaybill : Form
    {
        public addwaybill()
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
                string queryString = "INSERT INTO Nakladnaya ( id_Staff, id_Materiala, [Date] )" +
                " VALUES('" + comboBox1.SelectedValue.ToString() + "','" + comboBox2.SelectedValue.ToString() + "','" + this.dateTimePicker1.Text + "');";
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

        private void addwaybill_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Materiala". При необходимости она может быть перемещена или удалена.
            this.materialaTableAdapter.Fill(this.ckladDataSet.Materiala);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Nakladnaya". При необходимости она может быть перемещена или удалена.
            this.nakladnayaTableAdapter.Fill(this.ckladDataSet.Nakladnaya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Materiala". При необходимости она может быть перемещена или удалена.
            //this.materialaTableAdapter.Fill(this.baseDataSet.Materiala);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Staff". При необходимости она может быть перемещена или удалена.
            //this.staffTableAdapter.Fill(this.baseDataSet.Staff);

            MaximizeBox = false;
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}
