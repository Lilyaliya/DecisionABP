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
    public partial class Insertion : Form
    {
        public Insertion()
        {
            InitializeComponent();
        }

        private void Insertion_Load(object sender, EventArgs e)
        {
            label2.Text = Properties.Settings.Default.Insertion.ToString("D5");
            label4.Text = DateTime.Now.ToShortDateString();
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet3.Поступления". При необходимости она может быть перемещена или удалена.
            this.поступленияTableAdapter1.Fill(this.таблицыDataSet3.Поступления, Properties.Settings.Default.Insertion);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet4.Поступления". При необходимости она может быть перемещена или удалена.
            // this.поступленияTableAdapter.Fill(this.таблицыDataSet4.Поступления);

        }

        public void LoadBase(string value, int postuplenie)
        {
            this.поступленияTableAdapter1.InsertQuery(value, postuplenie);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Insertion+=1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells;
                if (cells[0].Value!=null)
                {
                    try
                    {
                        поступленияTableAdapter1.UpdateQuery(cells[1].Value.ToString(), (int)cells[2].Value, textBox1.Text, Convert.ToDateTime(label4.Text), cells[0].Value.ToString(), Properties.Settings.Default.Insertion);
                        поступленияTableAdapter1.UpdateQuery1((int)cells[2].Value, cells[0].Value.ToString());
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                        MessageBox.Show("Заполните все необходимые поля и попробуйте еще раз");
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells;
                if (cells[1].Value!=null||cells[2].Value!=null)
                    if (MessageBox.Show("Некоторые поля остались незаполненными.Уверены, что хотите выйти?", "Подтверждение действия", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        this.Close();
                    }
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
