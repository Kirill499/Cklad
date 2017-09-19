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
    public partial class amendemployees : Form
    {
        string s;
        int i = 0;
        public amendemployees()
        {
            InitializeComponent();
        }

        private void amendemployees_Activated(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Employees main = this.Owner as Employees;
                if (main != null)
                {
                    this.textBox1.Text = main.st1;
                    this.textBox2.Text = main.st2;
                    this.dateTimePicker1.Text = main.st3;
                }
                ++i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees main = this.Owner as Employees;
            if (main != null)
            {
                this.s = main.a1;
            }
            OleDbConnection database;
            string connectionString = "Provider=SQLOLEDB;Data Source=КИРИЛЛ-ПК\\SQLEXPRESS;Initial Catalog=Cklad;Integrated Security=SSPI";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
                string queryString = "UPDATE Staff SET Staff.post = '" + textBox1.Text + "', Staff.SNP = '" + textBox2.Text + "', Staff.Date_of_birth = '" + this.dateTimePicker1.Value.ToString()+ "' " +
                " WHERE Staff.id_Staff = " + s + " ";
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

        private void amendemployees_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}
