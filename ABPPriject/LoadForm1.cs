using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABPPriject
{
    public partial class LoadForm1 : Form
    {
        public LoadForm1()
        {
            InitializeComponent();
        }

       /* private void importFormDataDrons_Click(object sender, EventArgs e)
        {
            pickFileDronsDialog.ShowDialog();
        }

        private void importFormDataUtilities_Click(object sender, EventArgs e)
        {
            pickFileUtilitiesDialog.ShowDialog();
        }

        private void importFormDataCards_Click(object sender, EventArgs e)
        {
            pickFileCardsDialog.ShowDialog();
        }

        private void pickFileDronsDialog_FileOk(object sender, CancelEventArgs e)
        {
            importFormDataDrons.Text = pickFileDronsDialog.SafeFileName;
        }

        private void pickFileUtilitiesDialog_FileOk(object sender, CancelEventArgs e)
        {
            importFormDataUtilities.Text = pickFileUtilitiesDialog.SafeFileName;
        }

        private void pickFileCardsDialog_FileOk(object sender, CancelEventArgs e)
        {
            importFormDataCards.Text = pickFileCardsDialog.SafeFileName;
        }

        private void importFormExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importFormImportButton_Click(object sender, EventArgs e)
        {*/
           /* if (pickFileCardsDialog.FileName == "" || pickFileDronsDialog.FileName == "" || pickFileUtilitiesDialog.FileName == "")
            {
                errorBox.Text = "Заполните все поля!";
                goodBox.Text = "";
            }
            else
            {
                try
                {
                    var cards = ExcelC.getData(pickFileCardsDialog.FileName, 4);
                    var utilities = ExcelC.getData(pickFileUtilitiesDialog.FileName, 3);
                    var drons = ExcelC.getData(pickFileDronsDialog.FileName, 2);

                    goodBox.Text = "Успешно";
                    errorBox.Text = "";
                }
                catch
                {
                    goodBox.Text = "";
                    errorBox.Text = "Произошла ошибка";
                }

            }*/
       // }
        public void LoadBase(string value)
        {
           this.поступленияTableAdapter.InsertQuery1(value);
        }
        private void LoadForm1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet4.Поступления". При необходимости она может быть перемещена или удалена.
            this.поступленияTableAdapter.Fill(this.таблицыDataSet4.Поступления);


        }

        private void editPanelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
