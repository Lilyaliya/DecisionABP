using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;

namespace ABPPriject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet8.Остатки". При необходимости она может быть перемещена или удалена.
            this.остаткиTableAdapter.FillBy(this.таблицыDataSet8.Остатки, Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()));
            cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Дата"
            });

            cartesianChart2.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Количество",
                LabelFormatter = value => value.ToString()
            }) ;
           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null&&dateTimePicker2.Value!=null)
            {
                this.остаткиTableAdapter.FillBy(this.таблицыDataSet8.Остатки, Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()));
                cartesianChart2.Series.Clear();
                SeriesCollection coll = new SeriesCollection();
                List<int> values = new List<int>();
                foreach (var row in таблицыDataSet8.Остатки)
                {
                    var cells = row.ItemArray;
                    values.Add(int.Parse(cells[2].ToString()));


                }
                coll.Add(new LineSeries() { Title = "дата", Values = new ChartValues<int>(values) });
                cartesianChart2.Series = coll;
            }
            else
            {
                cartesianChart2.Series.Clear();
                return;
            }
            //var date=(from o in остаткиBindingSource.DataSource as List<>)
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null && dateTimePicker2.Value != null)
            {
                this.остаткиTableAdapter.FillBy(this.таблицыDataSet8.Остатки, Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()));
                cartesianChart2.Series.Clear();
                SeriesCollection coll = new SeriesCollection();
                List<int> values = new List<int>();
                foreach (var row in таблицыDataSet8.Остатки)
                {
                    var cells = row.ItemArray;
                    values.Add(int.Parse(cells[2].ToString()));


                }
                coll.Add(new LineSeries() { Title = "дата", Values = new ChartValues<int>(values) });
                cartesianChart2.Series = coll;
            }
            else
            {
                cartesianChart2.Series.Clear();
                return;
            }
        }
    }
}
