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
    public partial class ГрузовойЛифтИмпорт : Form
    {
        public ГрузовойЛифтИмпорт()
        {
            InitializeComponent();
        }

        private void грузовойЛифтТестBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.грузовойЛифтТестBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void ГрузовойЛифтИмпорт_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.ГрузовойЛифтТест". При необходимости она может быть перемещена или удалена.
            this.грузовойЛифтТестTableAdapter.Fill(this.factoryDBDataSet.ГрузовойЛифтТест);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (грузовойЛифтТестDataGridView.Rows.Count > 0)
            {
                грузовойЛифтТестDataGridView.AllowUserToAddRows = false;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < грузовойЛифтТестDataGridView.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = грузовойЛифтТестDataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < грузовойЛифтТестDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < грузовойЛифтТестDataGridView.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = грузовойЛифтТестDataGridView.Rows[i].Cells[j].Value.ToString();

                    }
                }
                app.Columns.AutoFit();
                app.Rows.AutoFit();
                app.Visible = true;
                грузовойЛифтТестDataGridView.AllowUserToAddRows = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FreightElevatorImport freightElevator = new FreightElevatorImport();
            freightElevator.Show();
        }
    }
}
