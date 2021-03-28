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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void грузовойЛифтИсторияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.грузовойЛифтИсторияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void History_Load(object sender, EventArgs e)
        {
            грузовойЛифтИсторияDataGridView.AllowUserToAddRows = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.ГрузовойЛифтИстория". При необходимости она может быть перемещена или удалена.
            this.грузовойЛифтИсторияTableAdapter.Fill(this.factoryDBDataSet.ГрузовойЛифтИстория);

        }
    }
}
