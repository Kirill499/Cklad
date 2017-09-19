namespace Склад
{
    partial class Print3
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
            this.MaterialaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.baseDataSet = new Склад.baseDataSet();
           // this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            //this.MaterialaTableAdapter = new Склад.baseDataSetTableAdapters.MaterialaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialaBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialaBindingSource
            // 
            this.MaterialaBindingSource.DataMember = "Materiala";
            //this.MaterialaBindingSource.DataSource = this.baseDataSet;
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
            //reportDataSource1.Value = this.MaterialaBindingSource;
           // this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
           // this.reportViewer1.LocalReport.ReportEmbeddedResource = "Склад.Print.Report3.rdlc";
           // this.reportViewer1.Location = new System.Drawing.Point(0, 0);
           // this.reportViewer1.Name = "reportViewer1";
           // this.reportViewer1.Size = new System.Drawing.Size(688, 266);
           // this.reportViewer1.TabIndex = 0;
            // 
            // MaterialaTableAdapter
            // 
            //this.MaterialaTableAdapter.ClearBeforeFill = true;
            // 
            // Print3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 266);
           // this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Print3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать";
            this.Load += new System.EventHandler(this.Print3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialaBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MaterialaBindingSource;
        //private baseDataSet baseDataSet;
        //private baseDataSetTableAdapters.MaterialaTableAdapter MaterialaTableAdapter;
    }
}