﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Склад.post
{
    public partial class amendpost : Form
    {
        string s;
        int i = 0;
        public amendpost()
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
                string queryString = "UPDATE Post SET Post.Base = '" + textBox1.Text + "' " +
                " WHERE Post.id_post = " + s + " ";
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

        private void amendpost_Activated(object sender, EventArgs e)
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
