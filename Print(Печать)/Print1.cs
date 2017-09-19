using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Склад
{
    public partial class Print1 : Form
    {
        public Print1()
        {
            InitializeComponent();
        }

        private void Print1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "CkladDataSet.Nakladnaya". При необходимости она может быть перемещена или удалена.
            this.NakladnayaTableAdapter.Fill(this.CkladDataSet.Nakladnaya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "CkladDataSet.Journal". При необходимости она может быть перемещена или удалена.
            this.JournalTableAdapter.Fill(this.CkladDataSet.Journal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Zhurnal_priema". При необходимости она может быть перемещена или удалена.
            //this.Zhurnal_priemaTableAdapter.Fill(this.baseDataSet.Zhurnal_priema);

          //  this.reportViewer1.RefreshReport();
            MaximizeBox = false;
        }
    }
}
