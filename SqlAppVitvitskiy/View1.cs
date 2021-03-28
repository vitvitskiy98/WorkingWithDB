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
    public partial class View1 : Form
    {
        public View1()
        {
            InitializeComponent();
        }

        private void View1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.FreightElevators". При необходимости она может быть перемещена или удалена.
            this.freightElevatorsTableAdapter.Fill(this.factoryDBDataSet.FreightElevators);

        }
    }
}
