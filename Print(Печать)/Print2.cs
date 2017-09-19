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
    public partial class Print2 : Form
    {
        public Print2()
        {
            InitializeComponent();
        }

        private void Print2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Nakladnaya_na_spisanie". При необходимости она может быть перемещена или удалена.
            //this.Nakladnaya_na_spisanieTableAdapter.Fill(this.baseDataSet.Nakladnaya_na_spisanie);

            //his.reportViewer1.RefreshReport();
            MaximizeBox = false;
        }
    }
}
