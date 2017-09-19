namespace Склад.Stock
{
    partial class addstock
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckladDataSet = new Склад.CkladDataSet();
            this.ckladDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ckladDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.correctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correctionTableAdapter = new Склад.CkladDataSetTableAdapters.CorrectionTableAdapter();
            this.materialaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialaTableAdapter = new Склад.CkladDataSetTableAdapters.MaterialaTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 72);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для ввода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Количество";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(249, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(144, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 72);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поле ввода";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.materialaBindingSource;
            this.comboBox1.DisplayMember = "id_Materiala";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "id_Materiala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Материал";
            // 
            // ckladDataSet
            // 
            this.ckladDataSet.DataSetName = "CkladDataSet";
            this.ckladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ckladDataSetBindingSource
            // 
            this.ckladDataSetBindingSource.DataSource = this.ckladDataSet;
            this.ckladDataSetBindingSource.Position = 0;
            // 
            // ckladDataSetBindingSource1
            // 
            this.ckladDataSetBindingSource1.DataSource = this.ckladDataSet;
            this.ckladDataSetBindingSource1.Position = 0;
            // 
            // correctionBindingSource
            // 
            this.correctionBindingSource.DataMember = "Correction";
            this.correctionBindingSource.DataSource = this.ckladDataSetBindingSource;
            // 
            // correctionTableAdapter
            // 
            this.correctionTableAdapter.ClearBeforeFill = true;
            // 
            // materialaBindingSource
            // 
            this.materialaBindingSource.DataMember = "Materiala";
            this.materialaBindingSource.DataSource = this.ckladDataSetBindingSource1;
            // 
            // materialaTableAdapter
            // 
            this.materialaTableAdapter.ClearBeforeFill = true;
            // 
            // addstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 123);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление в склад";
            this.Load += new System.EventHandler(this.addstock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckladDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ckladDataSetBindingSource1;
        private CkladDataSet ckladDataSet;
        private System.Windows.Forms.BindingSource ckladDataSetBindingSource;
        private System.Windows.Forms.BindingSource correctionBindingSource;
        private CkladDataSetTableAdapters.CorrectionTableAdapter correctionTableAdapter;
        private System.Windows.Forms.BindingSource materialaBindingSource;
        private CkladDataSetTableAdapters.MaterialaTableAdapter materialaTableAdapter;
    }
}