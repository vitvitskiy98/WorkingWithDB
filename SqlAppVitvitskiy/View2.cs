﻿using System;
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
    public partial class View2 : Form
    {
        public View2()
        {
            InitializeComponent();
        }

        private void View2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.ModelPegas". При необходимости она может быть перемещена или удалена.
            this.modelPegasTableAdapter.Fill(this.factoryDBDataSet.ModelPegas);

        }
    }
}
