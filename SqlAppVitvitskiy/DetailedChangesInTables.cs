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
    public partial class DetailedChangesInTables : Form
    {
        public DetailedChangesInTables()
        {
            InitializeComponent();
        }

        private void freightElevChangedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.freightElevChangedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.factoryDBDataSet);

        }

        private void DetailedChangesInTables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.PegasChanged". При необходимости она может быть перемещена или удалена.
            this.pegasChangedTableAdapter.Fill(this.factoryDBDataSet.PegasChanged);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.SmallElevChanged". При необходимости она может быть перемещена или удалена.
            this.smallElevChangedTableAdapter.Fill(this.factoryDBDataSet.SmallElevChanged);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.FreightElevChanged". При необходимости она может быть перемещена или удалена.
            this.freightElevChangedTableAdapter.Fill(this.factoryDBDataSet.FreightElevChanged);

        }
    }
}
