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
    public partial class ChangeState : Form
    {
        public string value;
        public DateTime time;
        public ChangeState()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = comboBox1.SelectedItem.ToString();
            time = dateTimePicker1.Value;
        }
    }
}
