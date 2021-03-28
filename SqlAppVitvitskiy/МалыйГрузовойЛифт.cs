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
    public partial class МалыйГрузовойЛифт : Form
    {
        public МалыйГрузовойЛифт()
        {
            InitializeComponent();
        }

        private void малыйГрузовойЛифтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.малыйГрузовойЛифтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void Таблица_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.МалыйГрузовойЛифт". При необходимости она может быть перемещена или удалена.
            this.малыйГрузовойЛифтTableAdapter.Fill(this.factoryDBDataSet.МалыйГрузовойЛифт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (малыйГрузовойЛифтDataGridView.Rows.Count > 0)
            {
                малыйГрузовойЛифтDataGridView.AllowUserToAddRows = false;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < малыйГрузовойЛифтDataGridView.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = малыйГрузовойЛифтDataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < малыйГрузовойЛифтDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < малыйГрузовойЛифтDataGridView.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = малыйГрузовойЛифтDataGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                app.Columns.AutoFit();
                app.Rows.AutoFit();
                app.Visible = true;
                малыйГрузовойЛифтDataGridView.AllowUserToAddRows = true;
            }
        }
    }
}
