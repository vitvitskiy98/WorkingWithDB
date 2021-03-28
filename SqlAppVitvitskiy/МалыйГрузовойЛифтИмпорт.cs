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
    public partial class МалыйГрузовойЛифтИмпорт : Form
    {
        public МалыйГрузовойЛифтИмпорт()
        {
            InitializeComponent();
        }

        private void малыйГрузовойЛифтИмпортBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.малыйГрузовойЛифтИмпортBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void МалыйГрузовойЛифтИмпорт_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.МалыйГрузовойЛифтИмпорт". При необходимости она может быть перемещена или удалена.
            this.малыйГрузовойЛифтИмпортTableAdapter.Fill(this.factoryDBDataSet.МалыйГрузовойЛифтИмпорт);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (малыйГрузовойЛифтИмпортDataGridView.Rows.Count > 0)
            {
                малыйГрузовойЛифтИмпортDataGridView.AllowUserToAddRows = false;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < малыйГрузовойЛифтИмпортDataGridView.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = малыйГрузовойЛифтИмпортDataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < малыйГрузовойЛифтИмпортDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < малыйГрузовойЛифтИмпортDataGridView.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = малыйГрузовойЛифтИмпортDataGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                app.Columns.AutoFit();
                app.Rows.AutoFit();
                app.Visible = true;
                малыйГрузовойЛифтИмпортDataGridView.AllowUserToAddRows = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmallFreightElevatorImport smallimport = new SmallFreightElevatorImport();
            smallimport.Show();
        }
    }
}
