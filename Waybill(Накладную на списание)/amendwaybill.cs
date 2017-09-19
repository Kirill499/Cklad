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
    public partial class amendwaybill : Form
    {
        string s;
        int i = 0;
        public amendwaybill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                this.s = main.a2;
            }
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "UPDATE Nakladnaya SET Nakladnaya.id_Staff = '" + comboBox1.SelectedValue.ToString() + "', Nakladnaya.id_Materiala = '" + comboBox2.SelectedValue.ToString() + "', " +
                " Nakladnaya.[Date] = '" + this.dateTimePicker1.Text + "', Nakladnaya.Number = '" + textBox1.Text + "'" +
                " WHERE (Nakladnaya.id_Nakladnaya = " + s + " ) ";
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

        private void amendwaybill_Activated(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    this.comboBox1.Text = main.st21;
                    this.comboBox2.Text = main.st22;
                    this.dateTimePicker1.Text = main.st23;
                    this.textBox1.Text = main.st24;
                }
                ++i;
            }
        }

        private void amendwaybill_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Materiala". При необходимости она может быть перемещена или удалена.
            //this.materialaTableAdapter.Fill(this.baseDataSet.Materiala);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Staff". При необходимости она может быть перемещена или удалена.
            //this.staffTableAdapter.Fill(this.baseDataSet.Staff);

            dateTimePicker1.Value = DateTime.Today;
            MaximizeBox = false;
        }
    }
}
