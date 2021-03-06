﻿using System;
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
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void Registry_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet1.Дроны". При необходимости она может быть перемещена или удалена.
            this.дроныTableAdapter.Fill(this.таблицыDataSet1.Дроны);

        }

        public void LoadReg()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDrons(string dron, int count, string user)
        {
            OleDbConnection dbase = new OleDbConnection(Properties.Settings.Default.ConnStr);
          
            dbase.Open(); 
            string Command = @"Insert Into Число(Дроны, Количество, Пользователь, [Номер заявки]) Values ('"+dron+"',"+count+", '"+user+"',"+Properties.Settings.Default.Zayava+")";
            OleDbCommand sql_comm = new OleDbCommand(Command, dbase);
            sql_comm.ExecuteNonQuery();
            dbase.Close();
        }

        public void UpdateDrons()
        {
            OleDbConnection dbase = new OleDbConnection(Properties.Settings.Default.ConnStr);

            dbase.Open();
            string Command = @"Update Число Set [Номер заявки]="+" Where [Номер заявки]=0";
            OleDbCommand sql_comm = new OleDbCommand(Command, dbase);
            sql_comm.ExecuteNonQuery();
            dbase.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Zayava zayava = new Zayava();
            //int? isin = (int?)дроныTableAdapter.ScalarQuery(textBox1.Text);
            if (textBox1.Text!="")
            {
                Properties.Settings.Default.Zayava++;
                Properties.Settings.Default.Save();
                int Sum = 0;
                bool hasval = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    var cells = row.Cells;
                    if (Convert.ToBoolean(cells[0].Value) ==true)
                    {
                        hasval = true;
                        Sum += int.Parse(cells[3].Value.ToString());
                        Sum *= int.Parse(cells[4].EditedFormattedValue.ToString());
                        LoadDrons(cells[2].Value.ToString(), int.Parse(cells[4].Value.ToString()), textBox1.Text);
                        //дроныTableAdapter.InsertQuery1()
                        //LoadReg();
                        // int selected = Convert.ToInt32(остаткиTableAdapter.ScalarQuery(cells[1].Value.ToString(), Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString())));
                        // остаткиTableAdapter.UpdateQueryAll(selected,cells[1].Value.ToString() , Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
                    }
                }
                if ((int?)дроныTableAdapter.ScalarQuery(textBox1.Text)==0)
                {
                    дроныTableAdapter.InsertQuery(Properties.Settings.Default.Zayava, Convert.ToDateTime(DateTime.Now.ToShortDateString()), textBox1.Text, Sum);
                    zayava.user = textBox1.Text;
                    zayava.LoadAll(textBox1.Text);
                    zayava.dataGridView5.Columns[5].Visible = false;
                }
                
                else if ((int?)дроныTableAdapter.ScalarQuery(textBox1.Text) != 0 && hasval)
                {
                    дроныTableAdapter.InsertQuery(Properties.Settings.Default.Zayava, Convert.ToDateTime(DateTime.Now.ToShortDateString()), textBox1.Text, Sum);
                    zayava.user = textBox1.Text;
                    zayava.LoadAll(textBox1.Text);
                    zayava.dataGridView5.Columns[5].Visible = false;
                }
            }
            else
            {
                zayava.ZayavaLoad();
            }
            zayava.Show();
        }
    }
}
