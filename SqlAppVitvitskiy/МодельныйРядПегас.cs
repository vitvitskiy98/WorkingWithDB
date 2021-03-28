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
    public partial class МодельныйРядПегас : Form
    {
        public МодельныйРядПегас()
        {
            InitializeComponent();
        }

        private void модельныйРядПегасBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.модельныйРядПегасBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void МодельныйРядПегас_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.МодельныйРядПегас". При необходимости она может быть перемещена или удалена.
            this.модельныйРядПегасTableAdapter.Fill(this.factoryDBDataSet.МодельныйРядПегас);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (модельныйРядПегасDataGridView.Rows.Count > 0)
            {
                модельныйРядПегасDataGridView.AllowUserToAddRows = false;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < модельныйРядПегасDataGridView.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = модельныйРядПегасDataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < модельныйРядПегасDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < модельныйРядПегасDataGridView.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = модельныйРядПегасDataGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                app.Columns.AutoFit();
                app.Rows.AutoFit();
                app.Visible = true;
                модельныйРядПегасDataGridView.AllowUserToAddRows = true;
            }
        }
    }
}
