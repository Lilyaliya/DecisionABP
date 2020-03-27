namespace ABPPriject
{
    partial class Zayava
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблицыDataSet6 = new ABPPriject.ТаблицыDataSet6();
            this.заявкиTableAdapter = new ABPPriject.ТаблицыDataSet6TableAdapters.ЗаявкиTableAdapter();
            this.ппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСозданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзмененияСостоянияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСуммаЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользовательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ппDataGridViewTextBoxColumn,
            this.датаСозданияDataGridViewTextBoxColumn,
            this.датаИзмененияСостоянияDataGridViewTextBoxColumn,
            this.состояниеDataGridViewTextBoxColumn,
            this.общаяСуммаЗаявкиDataGridViewTextBoxColumn,
            this.пользовательDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.заявкиBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(79, 84);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(642, 150);
            this.dataGridView5.TabIndex = 1;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.таблицыDataSet6;
            // 
            // таблицыDataSet6
            // 
            this.таблицыDataSet6.DataSetName = "ТаблицыDataSet6";
            this.таблицыDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // ппDataGridViewTextBoxColumn
            // 
            this.ппDataGridViewTextBoxColumn.DataPropertyName = "№п/п";
            this.ппDataGridViewTextBoxColumn.HeaderText = "№п/п";
            this.ппDataGridViewTextBoxColumn.Name = "ппDataGridViewTextBoxColumn";
            this.ппDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаСозданияDataGridViewTextBoxColumn
            // 
            this.датаСозданияDataGridViewTextBoxColumn.DataPropertyName = "Дата создания";
            this.датаСозданияDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.датаСозданияDataGridViewTextBoxColumn.Name = "датаСозданияDataGridViewTextBoxColumn";
            this.датаСозданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаИзмененияСостоянияDataGridViewTextBoxColumn
            // 
            this.датаИзмененияСостоянияDataGridViewTextBoxColumn.DataPropertyName = "Дата изменения состояния";
            this.датаИзмененияСостоянияDataGridViewTextBoxColumn.HeaderText = "Дата изменения состояния";
            this.датаИзмененияСостоянияDataGridViewTextBoxColumn.Name = "датаИзмененияСостоянияDataGridViewTextBoxColumn";
            // 
            // состояниеDataGridViewTextBoxColumn
            // 
            this.состояниеDataGridViewTextBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.Name = "состояниеDataGridViewTextBoxColumn";
            // 
            // общаяСуммаЗаявкиDataGridViewTextBoxColumn
            // 
            this.общаяСуммаЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "Общая сумма заявки";
            this.общаяСуммаЗаявкиDataGridViewTextBoxColumn.HeaderText = "Общая сумма заявки";
            this.общаяСуммаЗаявкиDataGridViewTextBoxColumn.Name = "общаяСуммаЗаявкиDataGridViewTextBoxColumn";
            this.общаяСуммаЗаявкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пользовательDataGridViewTextBoxColumn
            // 
            this.пользовательDataGridViewTextBoxColumn.DataPropertyName = "Пользователь";
            this.пользовательDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.пользовательDataGridViewTextBoxColumn.Name = "пользовательDataGridViewTextBoxColumn";
            // 
            // Zayava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button1);
            this.Name = "Zayava";
            this.Text = "Zayava";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView5;
        private ТаблицыDataSet6 таблицыDataSet6;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private ТаблицыDataSet6TableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСозданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИзмененияСостоянияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСуммаЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пользовательDataGridViewTextBoxColumn;
    }
}