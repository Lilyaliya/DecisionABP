namespace ABPPriject
{
    partial class Insertion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.таблицыDataSet4 = new ABPPriject.ТаблицыDataSet4();
            this.поступленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поступленияTableAdapter = new ABPPriject.ТаблицыDataSet4TableAdapters.ПоступленияTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.комплектующееDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серийныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поступленияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.таблицыDataSet3 = new ABPPriject.ТаблицыDataSet3();
            this.поступленияTableAdapter1 = new ABPPriject.ТаблицыDataSet3TableAdapters.ПоступленияTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступленияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.комплектующееDataGridViewTextBoxColumn,
            this.серийныйНомерDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поступленияBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(118, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // таблицыDataSet4
            // 
            this.таблицыDataSet4.DataSetName = "ТаблицыDataSet4";
            this.таблицыDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поступленияBindingSource
            // 
            this.поступленияBindingSource.DataMember = "Поступления";
            this.поступленияBindingSource.DataSource = this.таблицыDataSet4;
            // 
            // поступленияTableAdapter
            // 
            this.поступленияTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Записать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поступление комплектующих №";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // комплектующееDataGridViewTextBoxColumn
            // 
            this.комплектующееDataGridViewTextBoxColumn.DataPropertyName = "Комплектующее";
            this.комплектующееDataGridViewTextBoxColumn.HeaderText = "Комплектующее";
            this.комплектующееDataGridViewTextBoxColumn.Name = "комплектующееDataGridViewTextBoxColumn";
            // 
            // серийныйНомерDataGridViewTextBoxColumn
            // 
            this.серийныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.серийныйНомерDataGridViewTextBoxColumn.Name = "серийныйНомерDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // поступленияBindingSource1
            // 
            this.поступленияBindingSource1.DataMember = "Поступления";
            this.поступленияBindingSource1.DataSource = this.таблицыDataSet3;
            // 
            // таблицыDataSet3
            // 
            this.таблицыDataSet3.DataSetName = "ТаблицыDataSet3";
            this.таблицыDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поступленияTableAdapter1
            // 
            this.поступленияTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ответственный за прием";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Insertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Insertion";
            this.Text = "Insertion";
            this.Load += new System.EventHandler(this.Insertion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступленияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ТаблицыDataSet4 таблицыDataSet4;
        private System.Windows.Forms.BindingSource поступленияBindingSource;
        private ТаблицыDataSet4TableAdapters.ПоступленияTableAdapter поступленияTableAdapter;
        private ТаблицыDataSet3 таблицыDataSet3;
        private System.Windows.Forms.BindingSource поступленияBindingSource1;
        private ТаблицыDataSet3TableAdapters.ПоступленияTableAdapter поступленияTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn комплектующееDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}