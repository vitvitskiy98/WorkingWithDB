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
    public partial class PegasImport : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ESH0O13\\MSSQLSERVER01;Initial Catalog=FactoryDB;Integrated Security=True");
        public PegasImport()
        {
            InitializeComponent();
        }

        private void модельныйРядПегасИмпортBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.модельныйРядПегасИмпортBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void PegasImport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.МодельныйРядПегасИмпорт". При необходимости она может быть перемещена или удалена.
            this.модельныйРядПегасИмпортTableAdapter.Fill(this.factoryDBDataSet.МодельныйРядПегасИмпорт);
            модельныйРядПегасИмпортDataGridView.AllowUserToAddRows = false;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            модельныйРядПегасИмпортDataGridView.DataSource = dt;
        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                модельныйРядПегасИмпортDataGridView.AllowUserToAddRows = false;
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
            модельныйРядПегасИмпортDataGridView.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            модельныйРядПегасИмпортDataGridView.AllowUserToAddRows = false;
            con.Open();
            for (int i = 0; i < модельныйРядПегасИмпортDataGridView.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[МодельныйРядПегасИмпорт]([Pegas_id],[ИндексЛифта],[Грузоподъемность],[Скорость]," +
                    "[ШиринаКабины],[ГлубинаКабины],[ВысотаКабины],[ШтихмасКабины(мм)],[ШиринаШахты],[ГлубинаШахты],[Противовес],[ШиринаПроемаДверей])" +
                    "VALUES('" + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[0].Value + "','" + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[1].Value + "','"
                    + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[2].Value + "','" + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[3].Value + "','" +
                   модельныйРядПегасИмпортDataGridView.Rows[i].Cells[4].Value + "','" + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[5].Value + "','"
                    + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[6].Value + "','" + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[7].Value + "','" +
                    модельныйРядПегасИмпортDataGridView.Rows[i].Cells[8].Value + "','" + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[9].Value + "','"
                    + модельныйРядПегасИмпортDataGridView.Rows[i].Cells[10].Value + "','"+ модельныйРядПегасИмпортDataGridView.Rows[i].Cells[11].Value + "')", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Данные были успешно загружены в базу данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView();
        }
    }
}
