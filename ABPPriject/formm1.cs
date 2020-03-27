using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ABPPriject
{
    public partial class formm1 : Form
    {
        public formm1()
        {
            InitializeComponent();
            string path = @"cur.txt";

            int currentNum = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                currentNum = int.Parse(sr.ReadToEnd());
            }

            infoLabel.Text = "Поступление комплектующих # " + currentNum + " от " + DateTime.Now.ToString();

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(currentNum + 1);
            }
        }

        private void importFormDataDrons_Click(object sender, EventArgs e)
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
        {
            /*if (pickFileCardsDialog.FileName == "" || pickFileDronsDialog.FileName == "" || pickFileUtilitiesDialog.FileName == "")
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
        }

        private void editPanelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            exitWarningPanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            exitWarningPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            info.Text = "Успешно!";
            this.Close();
        }
    }
}
