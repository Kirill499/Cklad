namespace Склад
{
    partial class Print1
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
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NakladnayaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CkladDataSet = new Склад.CkladDataSet();
            this.Zhurnal_priemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.JournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JournalTableAdapter = new Склад.CkladDataSetTableAdapters.JournalTableAdapter();
            this.NakladnayaTableAdapter = new Склад.CkladDataSetTableAdapters.NakladnayaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NakladnayaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zhurnal_priemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NakladnayaBindingSource
            // 
            this.NakladnayaBindingSource.DataMember = "Nakladnaya";
            this.NakladnayaBindingSource.DataSource = this.CkladDataSet;
            // 
            // CkladDataSet
            // 
            this.CkladDataSet.DataSetName = "CkladDataSet";
            this.CkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Zhurnal_priemaBindingSource
            // 
            this.Zhurnal_priemaBindingSource.DataMember = "Zhurnal_priema";
            // 
            // reportViewer1
            // 
          //  this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
          //  reportDataSource1.Name = "DataSet1";
          //  reportDataSource1.Value = this.JournalBindingSource;
          //  this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
           // this.reportViewer1.LocalReport.ReportEmbeddedResource = "Склад.Print(Печать).Report1.rdlc";
           // this.reportViewer1.Location = new System.Drawing.Point(0, 0);
           // this.reportViewer1.Name = "reportViewer1";
           // this.reportViewer1.Size = new System.Drawing.Size(701, 266);
           // this.reportViewer1.TabIndex = 0;
            // 
            // JournalBindingSource
            // 
            this.JournalBindingSource.DataMember = "Journal";
            this.JournalBindingSource.DataSource = this.CkladDataSet;
            // 
            // JournalTableAdapter
            // 
            this.JournalTableAdapter.ClearBeforeFill = true;
            // 
            // NakladnayaTableAdapter
            // 
            this.NakladnayaTableAdapter.ClearBeforeFill = true;
            // 
            // Print1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 266);
            //this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Print1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать";
            this.Load += new System.EventHandler(this.Print1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NakladnayaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zhurnal_priemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Zhurnal_priemaBindingSource;
        private System.Windows.Forms.BindingSource JournalBindingSource;
        private CkladDataSet CkladDataSet;
        private CkladDataSetTableAdapters.JournalTableAdapter JournalTableAdapter;
        private System.Windows.Forms.BindingSource NakladnayaBindingSource;
        private CkladDataSetTableAdapters.NakladnayaTableAdapter NakladnayaTableAdapter;
        //private baseDataSet baseDataSet;
        //private baseDataSetTableAdapters.Zhurnal_priemaTableAdapter Zhurnal_priemaTableAdapter;
    }
}