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
    public partial class amendlog : Form
    {
        string s;
        int i = 0;
        public amendlog()
        {
            InitializeComponent();
        }

        private void amendlog_Activated(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    this.comboBox1.Text = main.st1;
                    this.comboBox2.Text = main.st2;
                    this.comboBox3.Text = main.st3;
                    this.comboBox4.Text = main.st3;
                    this.dateTimePicker1.Text = main.st5;
                    this.textBox3.Text = main.st6;
                }
                ++i;
            }
        }

        private void amendlog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Mark". При необходимости она может быть перемещена или удалена.
            this.markTableAdapter.Fill(this.ckladDataSet.Mark);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Materiala". При необходимости она может быть перемещена или удалена.
            this.materialaTableAdapter.Fill(this.ckladDataSet.Materiala);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Postavschik". При необходимости она может быть перемещена или удалена.
            this.postavschikTableAdapter.Fill(this.ckladDataSet.Postavschik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ckladDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.ckladDataSet.Staff);

            dateTimePicker1.Value = DateTime.Today;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                this.s = main.a;
            }
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "UPDATE Journal SET Journal.id_Staff = '" + comboBox1.SelectedValue.ToString() + "', Journal.id_Postavschik = '" + comboBox2.SelectedValue.ToString() + "', " +
                " Journal.id_Materiala = '" + comboBox3.SelectedValue.ToString() + "', Journal.Unit_of_measure = '" + comboBox4.SelectedValue.ToString() + "', Journal.[Date] = '" + this.dateTimePicker1.Text + "', Journal.[Number] = '" + textBox3.Text + "' " +
                " WHERE (Journal.id_Journal = " + s + " ) ";
                MessageBox.Show(queryString);
                OleDbCommand SQLQuery = new OleDbCommand();
                SQLQuery.CommandText = queryString;
                SQLQuery.Connection = database;
                SQLQuery.ExecuteNonQuery();
                database.Close();
                MessageBox.Show("Изменено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
