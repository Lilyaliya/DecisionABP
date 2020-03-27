namespace ABPPriject
{
    partial class formm1
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
            this.importFormLabel1 = new System.Windows.Forms.Label();
            this.importFormLabel3 = new System.Windows.Forms.Label();
            this.importFormLabel2 = new System.Windows.Forms.Label();
            this.importFormDataDrons = new System.Windows.Forms.TextBox();
            this.importFormDataUtilities = new System.Windows.Forms.TextBox();
            this.importFormDataCards = new System.Windows.Forms.TextBox();
            this.pickFileCardsDialog = new System.Windows.Forms.OpenFileDialog();
            this.pickFileDronsDialog = new System.Windows.Forms.OpenFileDialog();
            this.pickFileUtilitiesDialog = new System.Windows.Forms.OpenFileDialog();
            this.importFormImportButton = new System.Windows.Forms.Button();
            this.importFormExitButton = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.Label();
            this.goodBox = new System.Windows.Forms.Label();
            this.importPanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Комплектующее = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СерийныйНомер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Колличество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.victimTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.victimLabel = new System.Windows.Forms.Label();
            this.exitWarningPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.importPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.exitWarningPanel.SuspendLayout();
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
            this.importFormDataDrons.Click += new System.EventHandler(this.importFormDataDrons_Click);
            // 
            // importFormDataUtilities
            // 
            this.importFormDataUtilities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormDataUtilities.Location = new System.Drawing.Point(136, 60);
            this.importFormDataUtilities.Name = "importFormDataUtilities";
            this.importFormDataUtilities.Size = new System.Drawing.Size(205, 20);
            this.importFormDataUtilities.TabIndex = 4;
            this.importFormDataUtilities.Text = "Выбор файла";
            this.importFormDataUtilities.Click += new System.EventHandler(this.importFormDataUtilities_Click);
            // 
            // importFormDataCards
            // 
            this.importFormDataCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFormDataCards.Location = new System.Drawing.Point(136, 94);
            this.importFormDataCards.Name = "importFormDataCards";
            this.importFormDataCards.Size = new System.Drawing.Size(205, 20);
            this.importFormDataCards.TabIndex = 5;
            this.importFormDataCards.Text = "Выбор файла";
            this.importFormDataCards.Click += new System.EventHandler(this.importFormDataCards_Click);
            // 
            // pickFileCardsDialog
            // 
            this.pickFileCardsDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pickFileCardsDialog_FileOk);
            // 
            // pickFileDronsDialog
            // 
            this.pickFileDronsDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pickFileDronsDialog_FileOk);
            // 
            // pickFileUtilitiesDialog
            // 
            this.pickFileUtilitiesDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pickFileUtilitiesDialog_FileOk);
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
            this.importFormImportButton.Click += new System.EventHandler(this.importFormImportButton_Click);
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
            this.importFormExitButton.Click += new System.EventHandler(this.importFormExitButton_Click);
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
            this.editPanel.Controls.Add(this.info);
            this.editPanel.Controls.Add(this.dataGridView1);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.label1);
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
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(25, 417);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Комплектующее,
            this.СерийныйНомер,
            this.Колличество});
            this.dataGridView1.Location = new System.Drawing.Point(28, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 269);
            this.dataGridView1.TabIndex = 10;
            // 
            // Комплектующее
            // 
            this.Комплектующее.HeaderText = "Комплектующее";
            this.Комплектующее.Name = "Комплектующее";
            // 
            // СерийныйНомер
            // 
            this.СерийныйНомер.HeaderText = "Серийный номер";
            this.СерийныйНомер.Name = "СерийныйНомер";
            // 
            // Колличество
            // 
            this.Колличество.HeaderText = "Колличество";
            this.Колличество.Name = "Колличество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Колличество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Серийный номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Комплектующее";
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
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
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
            // exitWarningPanel
            // 
            this.exitWarningPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitWarningPanel.Controls.Add(this.backButton);
            this.exitWarningPanel.Controls.Add(this.button1);
            this.exitWarningPanel.Controls.Add(this.warningLabel);
            this.exitWarningPanel.Location = new System.Drawing.Point(152, 132);
            this.exitWarningPanel.Name = "exitWarningPanel";
            this.exitWarningPanel.Size = new System.Drawing.Size(374, 210);
            this.exitWarningPanel.TabIndex = 8;
            this.exitWarningPanel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(69, 175);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 30);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(188, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(-5, 71);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(366, 79);
            this.warningLabel.TabIndex = 0;
            this.warningLabel.Text = "Имеются несохранённые данные! \r\nВы уверены, что хотите выйти?\r\n";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 475);
            this.ControlBox = false;
            this.Controls.Add(this.exitWarningPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.importPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formm1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Загрузка";
            this.importPanel.ResumeLayout(false);
            this.importPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.exitWarningPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label importFormLabel1;
        private System.Windows.Forms.Label importFormLabel3;
        private System.Windows.Forms.Label importFormLabel2;
        private System.Windows.Forms.TextBox importFormDataDrons;
        private System.Windows.Forms.TextBox importFormDataUtilities;
        private System.Windows.Forms.TextBox importFormDataCards;
        private System.Windows.Forms.OpenFileDialog pickFileCardsDialog;
        private System.Windows.Forms.OpenFileDialog pickFileDronsDialog;
        private System.Windows.Forms.OpenFileDialog pickFileUtilitiesDialog;
        private System.Windows.Forms.Button importFormImportButton;
        private System.Windows.Forms.Button importFormExitButton;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.Label goodBox;
        private System.Windows.Forms.Panel importPanel;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox victimTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label victimLabel;
        private System.Windows.Forms.Panel exitWarningPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Комплектующее;
        private System.Windows.Forms.DataGridViewTextBoxColumn СерийныйНомер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Колличество;
        private System.Windows.Forms.Label info;
    }
}

