namespace ABPPriject
{
    partial class Ostatok
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комплектующееDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остаткиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблицыDataSet5 = new ABPPriject.ТаблицыDataSet5();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.остаткиTableAdapter = new ABPPriject.ТаблицыDataSet5TableAdapters.ОстаткиTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаткиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 27, 8, 4, 25, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Остатки комплектующих";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Показывать остатки на";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ппDataGridViewTextBoxColumn,
            this.комплектующееDataGridViewTextBoxColumn,
            this.остатокDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.остаткиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 151);
            this.dataGridView1.TabIndex = 3;
            // 
            // ппDataGridViewTextBoxColumn
            // 
            this.ппDataGridViewTextBoxColumn.DataPropertyName = "№п/п";
            this.ппDataGridViewTextBoxColumn.HeaderText = "№п/п";
            this.ппDataGridViewTextBoxColumn.Name = "ппDataGridViewTextBoxColumn";
            // 
            // комплектующееDataGridViewTextBoxColumn
            // 
            this.комплектующееDataGridViewTextBoxColumn.DataPropertyName = "Комплектующее";
            this.комплектующееDataGridViewTextBoxColumn.HeaderText = "Комплектующее";
            this.комплектующееDataGridViewTextBoxColumn.Name = "комплектующееDataGridViewTextBoxColumn";
            // 
            // остатокDataGridViewTextBoxColumn
            // 
            this.остатокDataGridViewTextBoxColumn.DataPropertyName = "Остаток";
            this.остатокDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.остатокDataGridViewTextBoxColumn.Name = "остатокDataGridViewTextBoxColumn";
            // 
            // остаткиBindingSource
            // 
            this.остаткиBindingSource.DataMember = "Остатки";
            this.остаткиBindingSource.DataSource = this.таблицыDataSet5;
            // 
            // таблицыDataSet5
            // 
            this.таблицыDataSet5.DataSetName = "ТаблицыDataSet5";
            this.таблицыDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Экспорт в Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // остаткиTableAdapter
            // 
            this.остаткиTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "печать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ostatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 417);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Ostatok";
            this.Text = "Ostatok";
            this.Load += new System.EventHandler(this.Ostatok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.остаткиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ТаблицыDataSet5 таблицыDataSet5;
        private System.Windows.Forms.BindingSource остаткиBindingSource;
        private ТаблицыDataSet5TableAdapters.ОстаткиTableAdapter остаткиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комплектующееDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}