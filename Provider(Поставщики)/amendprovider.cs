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
    public partial class amendprovider : Form
    {
        string s;
        int i = 0;
        public amendprovider()
        {
            InitializeComponent();
        }

        private void amendprovider_Activated(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Provider main = this.Owner as Provider;
                if (main != null)
                {
                    this.textBox1.Text = main.st1;
                    this.textBox2.Text = main.st2;
                    this.textBox3.Text = main.st3;
                    this.textBox4.Text = main.st4;
                    this.textBox5.Text = main.st5;
                }
                ++i;
            }
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
                string queryString = "UPDATE Postavschik SET  Postavschik.Naimenovanie_organizatsii = '" + textBox1.Text + "', " +
                " Postavschik.Fakticheskiy_adres = '" + textBox2.Text + "', Postavschik.Yuridicheskiy_adres = '" + textBox3.Text + "', Postavschik.Person_in_charge = '" + textBox4.Text + "', Postavschik.Telefon_postavschika = '" + textBox5.Text + "' " +
                " WHERE (Postavschik.id_Postavschik = " + s + " ) ";
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

        private void amendprovider_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
