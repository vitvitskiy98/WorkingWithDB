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
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;
using NMemory.Tables;

namespace SqlAppVitvitskiy
{
    public partial class FreightElevatorImport : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ESH0O13\\MSSQLSERVER01;Initial Catalog=FactoryDB;Integrated Security=True");
        public FreightElevatorImport()
        {
            InitializeComponent();
        }

        private void FreightElevatorImport_Load(object sender, EventArgs e)
        {
            
            //  this.грузовойЛифтTableAdapter.Fill(this.factoryDBDataSet.ГрузовойЛифт);
            грузовойЛифтТестDataGridView.AllowUserToAddRows = false;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            грузовойЛифтТестDataGridView.DataSource = dt;
        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                грузовойЛифтТестDataGridView.AllowUserToAddRows = false;
                if (openfileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openfileDialog.FileName;
                    using (var stream = File.Open(openfileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                comboBox1.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }
            
            

       
         private void FillDataGridView()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ГрузовойЛифтТест", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            грузовойЛифтТестDataGridView.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            грузовойЛифтТестDataGridView.AllowUserToAddRows = false;
            con.Open();
            for (int i = 0; i < грузовойЛифтТестDataGridView.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[ГрузовойЛифтТест]([freightElevatorID],[ИндексЛифта],[Грузоподъемность],[Скорость]," +
                    "[ШиринаКабины],[ГлубинаКабины],[ВысотаКабины],[ШиринаШахты],[ГлубинаШахты],[Противовес],[ШиринаПроемаДверей],[МаксВысотаПодъема],[ОстановокКабины])" +
                    "VALUES('"+ грузовойЛифтТестDataGridView.Rows[i].Cells[0].Value+ "','" + грузовойЛифтТестDataGridView.Rows[i].Cells[1].Value + "','"
                    + грузовойЛифтТестDataGridView.Rows[i].Cells[2].Value + "','" + грузовойЛифтТестDataGridView.Rows[i].Cells[3].Value + "','" +
                   грузовойЛифтТестDataGridView.Rows[i].Cells[4].Value + "','" + грузовойЛифтТестDataGridView.Rows[i].Cells[5].Value + "','" 
                    + грузовойЛифтТестDataGridView.Rows[i].Cells[6].Value + "','" + грузовойЛифтТестDataGridView.Rows[i].Cells[7].Value + "','" +
                    грузовойЛифтТестDataGridView.Rows[i].Cells[8].Value + "','" + грузовойЛифтТестDataGridView.Rows[i].Cells[9].Value + "','" 
                    + грузовойЛифтТестDataGridView.Rows[i].Cells[10].Value + "','" + грузовойЛифтТестDataGridView.Rows[i].Cells[11].Value + "','" 
                    + грузовойЛифтТестDataGridView.Rows[i].Cells[12].Value + "')", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Данные были успешно загружены в базу данных","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView(); 

        }

    }
}
