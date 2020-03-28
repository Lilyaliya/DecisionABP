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
    public partial class Zayava : Form
    {
        public string user = "";
        public ChangeState changeState;
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

        public void LoadEss()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                var cells = row.Cells;
                if (cells[0].Value!=null)
                {
                    
                    if (cells[0].Selected)
                    {
                        заявкиTableAdapter.UpdateQuery1(Convert.ToDateTime(DateTime.Now.ToShortDateString()), changeState.value, int.Parse(cells[0].Value.ToString()));
                        if ((string)cells[3].Value == "Идет сборка" && changeState.value == "Готова к отгрузке")
                        {
                            Exception exception = new Exception();
                            exception.data = DateTime.Now.ToShortDateString();
                            exception.LoadEss(int.Parse(cells[0].Value.ToString()));
                            exception.Show();
                        }
                    }
                    
                }    
               
            }
            if (user != "")
                LoadAll(user);
            else
                ZayavaLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeState = new ChangeState();
            changeState.Show();
        }
    }
}
