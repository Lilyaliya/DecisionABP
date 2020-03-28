namespace ABPPriject
{
    partial class Exception
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.детальDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.essentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблицыDataSet7 = new ABPPriject.ТаблицыDataSet7();
            this.essentialsTableAdapter = new ABPPriject.ТаблицыDataSet7TableAdapters.EssentialsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.essentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Необходимо комплектующих";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.детальDataGridViewTextBoxColumn,
            this.итогDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.essentialsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // детальDataGridViewTextBoxColumn
            // 
            this.детальDataGridViewTextBoxColumn.DataPropertyName = "Деталь";
            this.детальDataGridViewTextBoxColumn.HeaderText = "Деталь";
            this.детальDataGridViewTextBoxColumn.Name = "детальDataGridViewTextBoxColumn";
            // 
            // итогDataGridViewTextBoxColumn
            // 
            this.итогDataGridViewTextBoxColumn.DataPropertyName = "Итог";
            this.итогDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.итогDataGridViewTextBoxColumn.Name = "итогDataGridViewTextBoxColumn";
            // 
            // essentialsBindingSource
            // 
            this.essentialsBindingSource.DataMember = "Essentials";
            this.essentialsBindingSource.DataSource = this.таблицыDataSet7;
            // 
            // таблицыDataSet7
            // 
            this.таблицыDataSet7.DataSetName = "ТаблицыDataSet7";
            this.таблицыDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // essentialsTableAdapter
            // 
            this.essentialsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Exception";
            this.Text = "Exception";
            this.Load += new System.EventHandler(this.Exception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.essentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ТаблицыDataSet7 таблицыDataSet7;
        private System.Windows.Forms.BindingSource essentialsBindingSource;
        private ТаблицыDataSet7TableAdapters.EssentialsTableAdapter essentialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn детальDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}