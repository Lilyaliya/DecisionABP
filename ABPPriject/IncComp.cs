using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ABPPriject
{
    public partial class IncComp : Form
    {
        public IncComp()
        {
            InitializeComponent();
        }

        private void IncComp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet2.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter.Fill(this.таблицыDataSet2.Комплектующие);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Вы уверены что хотите оформить поступление выбранных комплектующих?","Подтверждение действия", MessageBoxButtons.OKCancel);
            if (MessageBox.Show("Вы уверены что хотите оформить поступление выбранных комплектующих?", "Подтверждение действия", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                /* Insertion loadForm = new Insertion();
                 foreach (DataGridViewRow row in dataGridView1.Rows)
                 {
                     var arr = row.Cells;
                     if (Convert.ToBoolean(arr[0].Value) == true)
                     {
                         loadForm.LoadBase(arr[2].Value.ToString());
                     }
                 }
                 loadForm.Show();
                 */
                Properties.Settings.Default.Insertion += 1;
                Properties.Settings.Default.Save();
                Insertion loadForm = new Insertion();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var arr = row.Cells;
                    if (Convert.ToBoolean(arr[0].Value) == true)
                    {
                        loadForm.LoadBase(arr[2].Value.ToString(), Properties.Settings.Default.Insertion);
                    }
                }
                loadForm.Show();
            }
            
        }

      
    }
}
