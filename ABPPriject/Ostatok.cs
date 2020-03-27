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
    public partial class Ostatok : Form
    {
        public Ostatok()
        {
            InitializeComponent();
        }

        public void LoadOst(string value)
        {
            остаткиTableAdapter.InsertQuery(value);
        }

        private void Ostatok_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet5.Остатки". При необходимости она может быть перемещена или удалена.
           int count= this.остаткиTableAdapter.Fill(this.таблицыDataSet5.Остатки);

        }


        public void LoadDate(int value)
        {
            остаткиTableAdapter.UpdateQueryData(Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells;
                if (cells[1].Value != null)
                { 
                    LoadDate((int)cells[0].Value);
                   // int selected = Convert.ToInt32(остаткиTableAdapter.ScalarQuery(cells[1].Value.ToString(), Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString())));
                   // остаткиTableAdapter.UpdateQueryAll(selected,cells[1].Value.ToString() , Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells;
                if (cells[1].Value != null)
                {
                   // LoadDate((int)cells[0].Value);
                    int? selected = (int?)остаткиTableAdapter.ScalarQuery(cells[1].Value.ToString(), Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
                    остаткиTableAdapter.UpdateQueryAll(selected, cells[1].Value.ToString(), Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
                }
            }
            остаткиTableAdapter.FillBy(таблицыDataSet5.Остатки);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* Microsoft.Office.Interop.Excel.Application Exl = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb;

            XlReferenceStyle RefStyle = Exl.ReferenceStyle;
            Exl.Visible = true;

            String TemplatePath = System.Windows.Forms.Application.StartupPath + @"\Экспорт данных.xlt";
            try
            {
                wb = Exl.Workbooks.Add(TemplatePath); // !!!
            }
            catch (System.Exception ex)
            {
                throw new Exception("Не удалось загрузить шаблон для экспорта " + TemplatePath + "\n" + ex.Message);
            }
            Worksheet ws = wb.Worksheets.get_Item(1) as Worksheet;
            for (int j = 0; j < grid.Columns.Count; ++j)
            {
                (ws.Cells[1, j + 1] as Range).Value2 = grid.Columns[j].HeaderText;
                for (int i = 0; i < grid.Rows.Count; ++i)
                {
                    object Val = grid.Rows[i].Cells[j].Value;
                    if (Val != null)
                        (ws.Cells[i + 2, j + 1] as Range).Value2 = Val.ToString();
                }
            }
            ws.Columns.EntireColumn.AutoFit();
            Exl.ReferenceStyle = RefStyle;
            ReleaseExcel(Exl as Object);*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dialog = new PrintDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               //dialog.PrintVisual(dataGridView1, "Вывод этикетки на печать");
            }
        }
    }
}
