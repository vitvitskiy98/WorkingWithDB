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
    public partial class ГрузовойЛифт : Form
    {
        public ГрузовойЛифт()
        {
            InitializeComponent();
        }

        private void грузовойЛифтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.грузовойЛифтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void ГрузовойЛифт_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.ГрузовойЛифт". При необходимости она может быть перемещена или удалена.
            this.грузовойЛифтTableAdapter.Fill(this.factoryDBDataSet.ГрузовойЛифт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (грузовойЛифтDataGridView.Rows.Count > 0)
            {
                грузовойЛифтDataGridView.AllowUserToAddRows = false;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < грузовойЛифтDataGridView.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = грузовойЛифтDataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < грузовойЛифтDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < грузовойЛифтDataGridView.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = грузовойЛифтDataGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                app.Columns.AutoFit();
                app.Rows.AutoFit();
                app.Visible = true;
                грузовойЛифтDataGridView.AllowUserToAddRows = true;
            }
        }

        
    }
}
