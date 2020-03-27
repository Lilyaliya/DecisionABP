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
    }
}
