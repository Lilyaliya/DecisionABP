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
using System.Data.OleDb;

namespace ABPPriject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void RetTable()
        {
            List<Tuple<string, int>> collection = new List<Tuple<string, int>>();
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.ConnStr);
            connection.Open();
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string date1 = DateTime.Now.ToShortDateString();
            string command = @"Select Комплектующее, Остаток From Остатки Where Дата Like '"+date1+"'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
            DataTable table = new DataTable();
            int a=adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                string name = cells[0].ToString();
                
                int count=int.Parse(cells[1].ToString());
                collection.Add(new Tuple<string, int>(name,count));
            }

        }

        public void RetZayava()
        {
            List<Tuple<int, string,string,string,string>> collection = new List<Tuple<int, string,string,string,string>>();
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.ConnStr);
            connection.Open();
            //DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string date1 = DateTime.Now.ToShortDateString();
            string command = @"Select * From Заявки ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(command, connection);
            DataTable table = new DataTable();
            int a = adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                int number = int.Parse(cells[0].ToString());
                string data1 = cells[1].ToString();
                string data2 = cells[2].ToString();
                string sostoyanie = cells[3].ToString();
                string sum = cells[4].ToString();
                collection.Add(new Tuple<int, string,string,string,string>(number, data1,data2,sostoyanie,sum));
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            RetTable();
            RetZayava();
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
