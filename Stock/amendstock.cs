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
    public partial class amendstock : Form
    {
        string s;
        int i = 0;
        public amendstock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                string queryString = "UPDATE Stock SET Stock.id_Materiala = '" + comboBox1.SelectedValue.ToString() + "', Stock.Number = '" + textBox1.Text + "'" +
                " WHERE (Stock.id_stock = " + s + " ) ";
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

        private void amendstock_Activated(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    this.comboBox1.Text = main.st1;
                    this.textBox1.Text = main.st2;
                }
                ++i;
            }
        }
    }
}
