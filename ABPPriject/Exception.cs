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
    public partial class Exception : Form
    {

        public string data;
        public bool isChange;
        public Exception()
        {
            InitializeComponent();
        }

        private void Exception_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet7.Essentials". При необходимости она может быть перемещена или удалена.
           // this.essentialsTableAdapter.Fill(this.таблицыDataSet7.Essentials);

        }
        public void LoadEss(int value)
        {
            essentialsTableAdapter.InsertQuery(value);
            this.essentialsTableAdapter.Fill(this.таблицыDataSet7.Essentials);
            Sum();
        }

        public int SelectSum(string value)
        {
           return Convert.ToInt32(essentialsTableAdapter.ScalarQuery(value));
        }

        public void UpdateSum(int itogo, string detail)
        {
            essentialsTableAdapter.UpdateQuery(itogo, detail);
        }
        public void Sum()
        {
            foreach (var row in таблицыDataSet7.Essentials)
            {
                var cells = row.ItemArray;
                int sum = SelectSum(cells[1].ToString());
                UpdateSum(sum, cells[1].ToString());
            }
            this.essentialsTableAdapter.Fill(this.таблицыDataSet7.Essentials);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var row in таблицыDataSet7.Essentials)
            {
                var cells = row.ItemArray;
                int? ost = (int?)essentialsTableAdapter.ScalarQuery1(cells[1].ToString(), Convert.ToDateTime(data));
               
                    essentialsTableAdapter.UpdateQuery1(ost, cells[1].ToString());
                
            }
            this.essentialsTableAdapter.Fill(this.таблицыDataSet7.Essentials);
            if (essentialsTableAdapter.FillBy(this.таблицыDataSet7.Essentials)!=0)
            {
                label1.Text = "Нехватка деталей.Невозможно осуществить операцию";
                isChange = false;
                button1.Enabled = false;

            }
            else
            {
                this.essentialsTableAdapter.Fill(this.таблицыDataSet7.Essentials);
                foreach (var row in таблицыDataSet7.Essentials)
                {
                    var cells = row.ItemArray;
                    essentialsTableAdapter.UpdateQuery2(Convert.ToInt32(cells[2].ToString()), Convert.ToDateTime(data), cells[1].ToString());
                }
                isChange = true;
            }
            
            //this.essentialsTableAdapter.Fill(this.таблицыDataSet7.Essentials);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            essentialsTableAdapter.DeleteQuery();
            
        }
    }
}
