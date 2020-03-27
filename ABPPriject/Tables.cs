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
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            комплектующиеTableAdapter1.Update(таблицыDataSet21.Комплектующие);
            дроныTableAdapter1.Update(таблицыDataSet11.Дроны);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet21.ТехнологическиеКарты". При необходимости она может быть перемещена или удалена.
            this.технологическиеКартыTableAdapter2.Fill(this.таблицыDataSet21.ТехнологическиеКарты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet11.ТехнологическиеКарты". При необходимости она может быть перемещена или удалена.
            this.технологическиеКартыTableAdapter1.Fill(this.таблицыDataSet11.ТехнологическиеКарты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet21.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter1.Fill(this.таблицыDataSet21.Комплектующие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet11.Дроны". При необходимости она может быть перемещена или удалена.
            this.дроныTableAdapter1.Fill(this.таблицыDataSet11.Дроны);
            комплектующиеTableAdapter1.UpdateQuery();
            this.комплектующиеTableAdapter1.Fill(this.таблицыDataSet21.Комплектующие);
            //.Update(таблицыDataSet21.Комплектующие);
        }

        //TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet3.ТехнологическиеКарты". При необходимости она может быть перемещена или удалена.
        // this.технологическиеКартыTableAdapter.Fill(this.таблицыDataSet3.ТехнологическиеКарты);
        // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet2.Комплектующие". При необходимости она может быть перемещена или удалена.
        // this.комплектующиеTableAdapter.Fill(this.таблицыDataSet2.Комплектующие);
        // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet1.Дроны". При необходимости она может быть перемещена или удалена.
    }
}
