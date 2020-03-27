namespace ABPPriject
{
    partial class LoadForm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.importFormLabel1 = new System.Windows.Forms.Label();
            this.importFormLabel3 = new System.Windows.Forms.Label();
            this.importFormLabel2 = new System.Windows.Forms.Label();
            this.importFormDataDrons = new System.Windows.Forms.TextBox();
            this.importFormDataUtilities = new System.Windows.Forms.TextBox();
            this.importFormDataCards = new System.Windows.Forms.TextBox();
            this.importFormImportButton = new System.Windows.Forms.Button();
            this.importFormExitButton = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.Label();
            this.goodBox = new System.Windows.Forms.Label();
            this.importPanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editPanelData = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.victimTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.victimLabel = new System.Windows.Forms.Label();
            this.таблицыDataSet4 = new ABPPriject.ТаблицыDataSet4();
            this.поступленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поступленияTableAdapter = new ABPPriject.ТаблицыDataSet4TableAdapters.ПоступленияTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPanelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступленияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // importFormLabel1
            // 
            this.importFormLabel1.AutoSize = true;
            this.importFormLabel1.Location = new System.Drawing.Point(12, 30);
            this.importFormLabel1.Name = "importFormLabel1";
            this.importFormLabel1.Size = new System.Drawing.Size(42, 13);
            this.importFormLabel1.TabIndex = 0;
            this.importFormLabel1.Text = "Дроны";
            // 
            // importFormLabel3
            // 
            this.importFormLabel3.AutoSize = true;
            this.importFormLabel3.Location = new System.Drawing.Point(12, 97);
            this.importFormLabel3.Name = "importFormLabel3";
            this.importFormLabel3.Size = new System.Drawing.Size(63, 13);
            this.importFormLabel3.TabIndex = 1;
            this.importFormLabel3.Text = "Тех. Карты";
            // 
            // importFormLabel2
            // 
            this.importFormLabel2.AutoSize = true;
            this.importFormLabel2.Location = new System.Drawing.Point(12, 63);
            this.importFormLabel2.Name = "importFormLabel2";
            this.importFormLabel2.Size = new System.Drawing.Size(91, 13);
            this.importFormLabel2.TabIndex = 2;
            this.importFormLabel2.Text = "Комплектующие";
            // 
            // importFormDataDrons
            // 
            this.importFormDataDrons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormDataDrons.Location = new System.Drawing.Point(136, 27);
            this.importFormDataDrons.Name = "importFormDataDrons";
            this.importFormDataDrons.Size = new System.Drawing.Size(205, 20);
            this.importFormDataDrons.TabIndex = 3;
            this.importFormDataDrons.Text = "Выбор файла";
            // 
            // importFormDataUtilities
            // 
            this.importFormDataUtilities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormDataUtilities.Location = new System.Drawing.Point(136, 60);
            this.importFormDataUtilities.Name = "importFormDataUtilities";
            this.importFormDataUtilities.Size = new System.Drawing.Size(205, 20);
            this.importFormDataUtilities.TabIndex = 4;
            this.importFormDataUtilities.Text = "Выбор файла";
            // 
            // importFormDataCards
            // 
            this.importFormDataCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormDataCards.Location = new System.Drawing.Point(136, 94);
            this.importFormDataCards.Name = "importFormDataCards";
            this.importFormDataCards.Size = new System.Drawing.Size(205, 20);
            this.importFormDataCards.TabIndex = 5;
            this.importFormDataCards.Text = "Выбор файла";
            // 
            // importFormImportButton
            // 
            this.importFormImportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormImportButton.Location = new System.Drawing.Point(15, 157);
            this.importFormImportButton.Name = "importFormImportButton";
            this.importFormImportButton.Size = new System.Drawing.Size(88, 23);
            this.importFormImportButton.TabIndex = 6;
            this.importFormImportButton.Text = "Загрузить";
            this.importFormImportButton.UseVisualStyleBackColor = true;
            // 
            // importFormExitButton
            // 
            this.importFormExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormExitButton.Location = new System.Drawing.Point(109, 157);
            this.importFormExitButton.Name = "importFormExitButton";
            this.importFormExitButton.Size = new System.Drawing.Size(91, 23);
            this.importFormExitButton.TabIndex = 7;
            this.importFormExitButton.Text = "Выйти";
            this.importFormExitButton.UseVisualStyleBackColor = true;
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(12, 128);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(0, 13);
            this.errorBox.TabIndex = 8;
            // 
            // goodBox
            // 
            this.goodBox.AutoSize = true;
            this.goodBox.ForeColor = System.Drawing.Color.Lime;
            this.goodBox.Location = new System.Drawing.Point(18, 128);
            this.goodBox.Name = "goodBox";
            this.goodBox.Size = new System.Drawing.Size(0, 13);
            this.goodBox.TabIndex = 9;
            // 
            // importPanel
            // 
            this.importPanel.Controls.Add(this.importFormDataUtilities);
            this.importPanel.Controls.Add(this.importFormLabel1);
            this.importPanel.Controls.Add(this.importFormLabel3);
            this.importPanel.Controls.Add(this.importFormDataDrons);
            this.importPanel.Controls.Add(this.importFormLabel2);
            this.importPanel.Controls.Add(this.importFormDataCards);
            this.importPanel.Controls.Add(this.importFormImportButton);
            this.importPanel.Controls.Add(this.importFormExitButton);
            this.importPanel.Controls.Add(this.goodBox);
            this.importPanel.Controls.Add(this.errorBox);
            this.importPanel.Location = new System.Drawing.Point(0, 0);
            this.importPanel.Name = "importPanel";
            this.importPanel.Size = new System.Drawing.Size(354, 210);
            this.importPanel.TabIndex = 10;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editPanelData);
            this.editPanel.Controls.Add(this.closeButton);
            this.editPanel.Controls.Add(this.writeButton);
            this.editPanel.Controls.Add(this.okButton);
            this.editPanel.Controls.Add(this.victimTextBox);
            this.editPanel.Controls.Add(this.infoLabel);
            this.editPanel.Controls.Add(this.victimLabel);
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(679, 474);
            this.editPanel.TabIndex = 11;
            // 
            // editPanelData
            // 
            this.editPanelData.AllowUserToOrderColumns = true;
            this.editPanelData.AutoGenerateColumns = false;
            this.editPanelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editPanelData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.editPanelData.DataSource = this.поступленияBindingSource;
            this.editPanelData.Location = new System.Drawing.Point(26, 94);
            this.editPanelData.Name = "editPanelData";
            this.editPanelData.Size = new System.Drawing.Size(336, 255);
            this.editPanelData.TabIndex = 6;
            this.editPanelData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editPanelData_CellContentClick);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(228, 433);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(97, 30);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // writeButton
            // 
            this.writeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeButton.Location = new System.Drawing.Point(128, 433);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(94, 30);
            this.writeButton.TabIndex = 4;
            this.writeButton.Text = "Записать";
            this.writeButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(28, 433);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 30);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // victimTextBox
            // 
            this.victimTextBox.Location = new System.Drawing.Point(206, 60);
            this.victimTextBox.Name = "victimTextBox";
            this.victimTextBox.Size = new System.Drawing.Size(168, 20);
            this.victimTextBox.TabIndex = 2;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(104, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(497, 25);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Поступление комплектующих №@num от @date";
            // 
            // victimLabel
            // 
            this.victimLabel.AutoSize = true;
            this.victimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.victimLabel.Location = new System.Drawing.Point(23, 60);
            this.victimLabel.Name = "victimLabel";
            this.victimLabel.Size = new System.Drawing.Size(177, 16);
            this.victimLabel.TabIndex = 1;
            this.victimLabel.Text = "Ответственный за приём:";
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
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Комплектующее";
            this.dataGridViewTextBoxColumn2.HeaderText = "Комплектующее";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Серийный номер";
            this.dataGridViewTextBoxColumn1.HeaderText = "Серийный номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // LoadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.ControlBox = false;
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.importPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadForm1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Загрузка";
            this.Load += new System.EventHandler(this.LoadForm1_Load);
            this.importPanel.ResumeLayout(false);
            this.importPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPanelData)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.таблицыDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступленияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label importFormLabel1;
        private System.Windows.Forms.Label importFormLabel3;
        private System.Windows.Forms.Label importFormLabel2;
        private System.Windows.Forms.TextBox importFormDataDrons;
        private System.Windows.Forms.TextBox importFormDataUtilities;
        private System.Windows.Forms.TextBox importFormDataCards;
        private System.Windows.Forms.Button importFormImportButton;
        private System.Windows.Forms.Button importFormExitButton;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.Label goodBox;
        private System.Windows.Forms.Panel importPanel;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.DataGridView editPanelData;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox victimTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label victimLabel;
        //private ТаблицыDataSet3TableAdapters.ПоступленияTableAdapter поступленияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn комплектующееDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private ТаблицыDataSet4 таблицыDataSet4;
        private System.Windows.Forms.BindingSource поступленияBindingSource;
        private ТаблицыDataSet4TableAdapters.ПоступленияTableAdapter поступленияTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

