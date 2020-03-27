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
    public partial class SelectOst : Form
    {
        public SelectOst()
        {
            InitializeComponent();
        }

        private void SelectOst_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet2.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter.Fill(this.таблицыDataSet2.Комплектующие);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите оформить остатки выбранных комплектующих?", "Подтверждение действия", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Ostatok ostatok = new Ostatok();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var arr = row.Cells;
                    if (Convert.ToBoolean(arr[0].Value)==true)
                    {
                        ostatok.LoadOst(arr[2].Value.ToString());
                    }
                }
                ostatok.Show();
            }
        }
    }
}
