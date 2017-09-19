using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Склад.Measuring
{
    public partial class amendmeasuring : Form
    {
        string s;
        int i = 0;
        public amendmeasuring()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Provider main = this.Owner as Provider;
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
                //MessageBox.Show(s);
                string queryString = "UPDATE Measuring SET  Measuring.unit = '" + textBox1.Text + "', " +
                " WHERE (Measuring.id_Measuring = " + s + " ) ";
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

        private void amendmeasuring_Activated(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Provider main = this.Owner as Provider;
                if (main != null)
                {
                    this.textBox1.Text = main.st1;
                }
                ++i;
            }
        }
    }
}
