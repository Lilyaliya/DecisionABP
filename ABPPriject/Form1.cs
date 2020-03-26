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
using System.IO;

namespace ABPPriject
{
    public partial class Form1 : Form
    {
        string ExcelDrons;
        string ExcelComp;
        string ExcelTech;
        string directory;
        DataTable ExcelSet;
        bool IsException = false;
        public Form1()
        {

            InitializeComponent();
            directory = @Directory.GetCurrentDirectory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Импортирование Excel файла";
                fileDialog.Filter = "Excel Workbook(*.xls;*.xlsx)|*.xlsx;*.xls";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    GetConnStr1(fileDialog.FileName);
                    textBox1.Text = fileDialog.FileName;
                    
                }
            }
            button1.Enabled = false;
        }

        public void GetConnStr1(string ExcelName)
        {
            ExcelDrons = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelName + ";Extended Properties=Excel 12.0;";
        }

        public void GetConnStr2(string ExcelName)
        {
            ExcelComp = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelName + ";Extended Properties=Excel 12.0;";
        }
        public void GetConnStr3(string ExcelName)
        {
            ExcelTech = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelName + ";Extended Properties=Excel 12.0;";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            DownDrons();
            if (textBox2.Text!="")
            DownComp();
            if (textBox3.Text!="")
            DownTech();
            if (!IsException)
            {
                Tables tables = new Tables();
                tables.Show();
            }
        }

        public void DownDrons()
        {
            OleDbConnection dbase = new OleDbConnection(ExcelDrons);
            // OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.ConnStr);
            //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [Лист1$]", dbase);
            //ExcelSet = new DataTable();
            //oleDbDataAdapter.Fill(ExcelSet);
            //dataGridView2.DataSource = ExcelSet;
            dbase.Open(); // открыть соединение
                          //string directory = @Directory.GetCurrentDirectory();
            string Command = @"Insert Into [MS Access;Database=" + directory + "\\Таблицы.accdb;].[Дроны] Select * From [Лист1$]";
            OleDbCommand sql_comm = new OleDbCommand(Command, dbase);
            sql_comm.ExecuteNonQuery();
            dbase.Close();
        }

        public void DownComp()
        {
            OleDbConnection dbase = new OleDbConnection(ExcelComp);
            // OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.ConnStr);
            //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [Лист1$]", dbase);
            //ExcelSet = new DataTable();
            //oleDbDataAdapter.Fill(ExcelSet);
            //dataGridView2.DataSource = ExcelSet;
            dbase.Open(); // открыть соединение
                          //string directory = @Directory.GetCurrentDirectory();
            string Command = @"Insert Into [MS Access;Database=" + directory + "\\Таблицы.accdb;].[Комплектующие] Select * From [Лист1$]";
            OleDbCommand sql_comm = new OleDbCommand(Command, dbase);
            sql_comm.ExecuteNonQuery();
            dbase.Close();
        }

        public void DownTech()
        {
            OleDbConnection dbase = new OleDbConnection(ExcelTech);
            // OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.ConnStr);
            //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [Лист1$]", dbase);
            //ExcelSet = new DataTable();

            //oleDbDataAdapter.Fill(ExcelSet);
            //dataGridView2.DataSource = ExcelSet;
            dbase.Open(); // открыть соединение
                          //string directory = @Directory.GetCurrentDirectory();
            string Command3 = "Delete*From [MS Access;Database=" + directory + "\\Таблицы.accdb;].[Технол]";
            string Command = @"  Insert Into [MS Access;Database=" + directory + "\\Таблицы.accdb;].[Технол] Select [Дрон], [Деталь],[Количество] From [Лист1$]";
                                                                                                                                                                 
            Insertion(dbase, Command3);
            dbase.Open();
            Insertion(dbase, Command);

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [MS Access;Database=" + directory + @"\\Таблицы.accdb;].[Технол]", dbase);
            ExcelSet = new DataTable();
            oleDbDataAdapter.Fill(ExcelSet);
            foreach (DataRow yach in ExcelSet.Rows)
            {
                var cells = yach.ItemArray;
                string Command1;
                try
                {
                    cells[3] = (int)cells[3];
                    bool notnull = ((string)cells[2] != "") ? true : false;
                    bool notnull2 = ((string)cells[1] != "") ? true : false;
                    if (!notnull && !notnull2)
                        throw new Exception();
                }
                catch (Exception)
                {
                    IsException = true;
                    MessageBox.Show("Похоже, в тех. картах указаны неверные данные. Исправьте значения в таблице и загрузите её еще раз еще раз");
                    break;
                }
            }

            
                foreach (DataRow yach in ExcelSet.Rows)
            {
                if (!IsException)
                {
                    var cells = yach.ItemArray;
                    string Command1;
                    Command1 = @"Insert Into [MS Access;Database=" + directory + @"\\Таблицы.accdb;].[ТехнологическиеКарты] Values(" + cells[0] + ",'" + cells[1] + "','" + cells[2] + "'," + cells[3] + ")";
                    dbase.Open();
                    Insertion(dbase, Command1);
                }
                else break;
            }

              

                
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Импортирование Excel файла";
                fileDialog.Filter = "Excel Workbook(*.xls;*.xlsx)|*.xlsx;*.xls";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    GetConnStr2(fileDialog.FileName);
                    textBox2.Text = fileDialog.FileName;

                }
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Импортирование Excel файла";
                fileDialog.Filter = "Excel Workbook(*.xls;*.xlsx)|*.xlsx;*.xls";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    GetConnStr3(fileDialog.FileName);
                    button3.Enabled = false;
                    textBox3.Text = fileDialog.FileName;
                }
            }
        }

        public void Insertion(OleDbConnection dbase, string command)
        {
            
            OleDbCommand sql_comm = new OleDbCommand(command, dbase);
            sql_comm.ExecuteNonQuery();
            dbase.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
