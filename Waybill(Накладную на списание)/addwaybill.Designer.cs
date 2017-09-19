namespace Склад
{
    partial class addwaybill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ckladDataSet = new Склад.CkladDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nakladnayaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nakladnayaTableAdapter = new Склад.CkladDataSetTableAdapters.NakladnayaTableAdapter();
            this.materialaTableAdapter = new Склад.CkladDataSetTableAdapters.MaterialaTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 102);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для ввода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Материал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(178, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 102);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поле ввода";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.materialaBindingSource1;
            this.comboBox2.DisplayMember = "id_Materiala";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "id_Materiala";
            // 
            // materialaBindingSource1
            // 
            this.materialaBindingSource1.DataMember = "Materiala";
            this.materialaBindingSource1.DataSource = this.ckladDataSet;
            // 
            // ckladDataSet
            // 
            this.ckladDataSet.DataSetName = "CkladDataSet";
            this.ckladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nakladnayaBindingSource;
            this.comboBox1.DisplayMember = "id_Staff";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id_Staff";
            // 
            // nakladnayaBindingSource
            // 
            this.nakladnayaBindingSource.DataMember = "Nakladnaya";
            this.nakladnayaBindingSource.DataSource = this.ckladDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2015, 5, 6, 0, 0, 0, 0);
            // 
            // materialaBindingSource
            // 
            this.materialaBindingSource.DataMember = "Materiala";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(286, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nakladnayaTableAdapter
            // 
            this.nakladnayaTableAdapter.ClearBeforeFill = true;
            // 
            // materialaTableAdapter
            // 
            this.materialaTableAdapter.ClearBeforeFill = true;
            // 
            // addwaybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addwaybill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление в накладную на списание";
            this.Load += new System.EventHandler(this.addwaybill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        //private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        //private baseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource materialaBindingSource;
        private CkladDataSet ckladDataSet;
        private System.Windows.Forms.BindingSource nakladnayaBindingSource;
        private CkladDataSetTableAdapters.NakladnayaTableAdapter nakladnayaTableAdapter;
        private System.Windows.Forms.BindingSource materialaBindingSource1;
        private CkladDataSetTableAdapters.MaterialaTableAdapter materialaTableAdapter;
        //private baseDataSetTableAdapters.MaterialaTableAdapter materialaTableAdapter;
    }
}