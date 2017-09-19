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
    public partial class Print3 : Form
    {
        public Print3()
        {
            InitializeComponent();
        }

        private void Print3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Materiala". При необходимости она может быть перемещена или удалена.
            //this.MaterialaTableAdapter.Fill(this.baseDataSet.Materiala);

          //  this.reportViewer1.RefreshReport();
            MaximizeBox = false;
        }
    }
}
