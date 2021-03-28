using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlAppVitvitskiy
{
    public partial class SmallFreightElevatorImport : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ESH0O13\\MSSQLSERVER01;Initial Catalog=FactoryDB;Integrated Security=True");
        public SmallFreightElevatorImport()
        {
            InitializeComponent();
        }

        private void малыйГрузовойЛифтИмпортBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.малыйГрузовойЛифтИмпортBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            малыйГрузовойЛифтИмпортDataGridView.DataSource = dt;
        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                малыйГрузовойЛифтИмпортDataGridView.AllowUserToAddRows = false;
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM МодельныйРядПегасИмпорт", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            малыйГрузовойЛифтИмпортDataGridView.DataSource = dt;
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            малыйГрузовойЛифтИмпортDataGridView.AllowUserToAddRows = false;
            con.Open();
            for (int i = 0; i < малыйГрузовойЛифтИмпортDataGridView.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[МалыйГрузовойЛифтИмпорт]([elevator_id],[ИндексЛифта],[Грузоподъемность],[Скорость]," +
                    "[ШиринаКабины],[ГлубинаКабины],[ВысотаКабины],[ШиринаШахты],[ГлубинаШахты],[Противовес],[ШиринаПроемаДверей],[МаксВысотаПодъема],[ОстановокКабины])" +
                    "VALUES('" + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[0].Value + "','" + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[1].Value + "','"
                    + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[2].Value + "','" + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[3].Value + "','" +
                   малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[4].Value + "','" + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[5].Value + "','"
                    + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[6].Value + "','" + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[7].Value + "','" +
                    малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[8].Value + "','" + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[9].Value + "','"
                    + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[10].Value + "','" + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[11].Value + "','"
                    + малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[12].Value + "')", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Данные были успешно загружены в базу данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView();
        }

        private void SmallFreightElevatorImport_Load(object sender, EventArgs e)
        {
            малыйГрузовойЛифтИмпортDataGridView.AllowUserToAddRows = false;
        }
    }
}
