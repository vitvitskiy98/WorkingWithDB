using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlAppVitvitskiy
{
    public partial class МодельныйРядПегасИмпорт : Form
    {
        public МодельныйРядПегасИмпорт()
        {
            InitializeComponent();
        }

        private void модельныйРядПегасИмпортBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.модельныйРядПегасИмпортBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void МодельныйРядПегасИмпорт_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.МодельныйРядПегасИмпорт". При необходимости она может быть перемещена или удалена.
            this.модельныйРядПегасИмпортTableAdapter.Fill(this.factoryDBDataSet.МодельныйРядПегасИмпорт);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (модельныйРядПегасИмпортDataGridView.Rows.Count > 0)
            {
                модельныйРядПегасИмпортDataGridView.AllowUserToAddRows = false;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < модельныйРядПегасИмпортDataGridView.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = модельныйРядПегасИмпортDataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < модельныйРядПегасИмпортDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < модельныйРядПегасИмпортDataGridView.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = модельныйРядПегасИмпортDataGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                app.Columns.AutoFit();
                app.Rows.AutoFit();
                app.Visible = true;
                модельныйРядПегасИмпортDataGridView.AllowUserToAddRows = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PegasImport pegasimport = new PegasImport();
            pegasimport.Show();
        }
    }
}
