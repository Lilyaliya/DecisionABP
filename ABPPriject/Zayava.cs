﻿using System;
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
    public partial class Zayava : Form
    {
        public string user = "";
        public Zayava()
        {
            InitializeComponent();
        }

       /* private void Zayava_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таблицыDataSet6.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.таблицыDataSet6.Заявки);

        }*/

            public void ZayavaLoad()
        {
            this.заявкиTableAdapter.Fill(this.таблицыDataSet6.Заявки);
        }

        public void LoadAll(string value)
        {
            заявкиTableAdapter.FillBy(таблицыDataSet6.Заявки, value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                var cells = row.Cells;
                заявкиTableAdapter.UpdateQuery(Convert.ToDateTime(DateTime.Now.ToString()), cells[3].Value.ToString(), cells[5].Value.ToString());
            }
            if (user != "")
                LoadAll(user);
            else
                ZayavaLoad();
        }
    }
}
