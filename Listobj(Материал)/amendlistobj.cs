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
    public partial class amendlistobj : Form
    {
        string s;
        int i = 0;
        public amendlistobj()
        {
            InitializeComponent();
        }

        private void amendlistobj_Activated(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    this.textBox1.Text = main.st31;
                    this.textBox2.Text = main.st32;
                    this.textBox3.Text = main.st33;
                }
                ++i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                this.s = main.a3;
            }
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "UPDATE Materiala SET  Materiala.Naimenovanie_materiala = '" + textBox1.Text + "', " +
                " Materiala.Brand = '" + textBox2.Text + "', Materiala.Price = '" + textBox3.Text + "' " +
                " WHERE (Materiala.id_Materiala = " + s + " ); ";
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

        private void amendlistobj_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
