namespace Склад
{
    partial class Print2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
          //  Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Nakladnaya_na_spisanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.baseDataSet = new Склад.baseDataSet();
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            //this.Nakladnaya_na_spisanieTableAdapter = new Склад.baseDataSetTableAdapters.Nakladnaya_na_spisanieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Nakladnaya_na_spisanieBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Nakladnaya_na_spisanieBindingSource
            // 
            this.Nakladnaya_na_spisanieBindingSource.DataMember = "Nakladnaya_na_spisanie";
            //this.Nakladnaya_na_spisanieBindingSource.DataSource = this.baseDataSet;
            // 
            // baseDataSet
            // 
            //this.baseDataSet.DataSetName = "baseDataSet";
            //this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //reportDataSource1.Name = "DataSet1";
            //reportDataSource1.Value = this.Nakladnaya_na_spisanieBindingSource;
            //this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Склад.Print.Report2.rdlc";
            //this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.Size = new System.Drawing.Size(984, 266);
            //this.reportViewer1.TabIndex = 0;
            // 
            // Nakladnaya_na_spisanieTableAdapter
            // 
            //this.Nakladnaya_na_spisanieTableAdapter.ClearBeforeFill = true;
            // 
            // Print2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 266);
            //this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Print2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать";
            this.Load += new System.EventHandler(this.Print2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nakladnaya_na_spisanieBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Nakladnaya_na_spisanieBindingSource;
        //private baseDataSet baseDataSet;
        //private baseDataSetTableAdapters.Nakladnaya_na_spisanieTableAdapter Nakladnaya_na_spisanieTableAdapter;
    }
}