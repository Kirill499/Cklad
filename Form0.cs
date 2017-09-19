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
    public partial class Form0 : Form
    {
        private int failCounter = 0;

        public Form0()
        {
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser;
           
            bool isBlocked = false;

            try
            {
                regKey = regKey.OpenSubKey("SKLAD4");
                isBlocked = Convert.ToBoolean(regKey.GetValue("Blocked"));
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            if (isBlocked) Environment.Exit(0);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login,password, pin;
            login = "Admin";
            password = "123";
            pin = "9999";
            if (login == maskedTextBox1.Text &
                password == textBox2.Text &
                (!pinTextBox.Visible || (pinTextBox.Visible && pinTextBox.Text == pin))
                )
            {
                Form1 addForm1 = new Form1();
                addForm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                failCounter++;
            }

            if (failCounter >= 3)
            {
                pinLabel.Visible = true;
                pinTextBox.Visible = true;
            }

            if(failCounter >= 5)
            {
                Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser;
                regKey = regKey.CreateSubKey("SKLAD4");
                regKey.SetValue("Blocked", true);
                Close();
            }
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
