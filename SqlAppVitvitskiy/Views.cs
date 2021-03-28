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
    public partial class Views : Form
    {
        public Views()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {

                        View1 freightElevator = new View1();
                        freightElevator.Show();
                        break;
                    }
                case 1:
                    {
                        View2 pegas = new View2();
                        pegas.Show();
                        break;
                    }
                case 2:
                    {

                        ГрузовойЛифт lift = new ГрузовойЛифт();
                        lift.Show();
                        lift.грузовойЛифтDataGridView.AllowUserToAddRows = false;
                        lift.грузовойЛифтDataGridView.AllowUserToDeleteRows = false;
                        lift.bindingNavigatorAddNewItem.Visible = false;
                        lift.bindingNavigatorDeleteItem.Visible = false;
                        lift.грузовойЛифтBindingNavigatorSaveItem.Visible = false;
                        break;
                    }
                case 3:
                    {
                        МалыйГрузовойЛифт smalllift = new МалыйГрузовойЛифт();
                        smalllift.Show();
                        smalllift.малыйГрузовойЛифтDataGridView.AllowUserToAddRows = false;
                        smalllift.малыйГрузовойЛифтDataGridView.AllowUserToDeleteRows = false;
                        smalllift.bindingNavigatorAddNewItem.Visible = false;
                        smalllift.bindingNavigatorDeleteItem.Visible = false;
                        smalllift.малыйГрузовойЛифтBindingNavigatorSaveItem.Visible = false;

                        break;
                    }
                case 4:
                    {

                        ГрузовойЛифтИмпорт liftimport = new ГрузовойЛифтИмпорт();
                        liftimport.Show();
                        liftimport.button1.Visible = false;
                        liftimport.грузовойЛифтТестDataGridView.AllowUserToAddRows = false;
                        liftimport.грузовойЛифтТестDataGridView.AllowUserToDeleteRows = false;
                        liftimport.bindingNavigatorAddNewItem.Visible = false;
                        liftimport.bindingNavigatorDeleteItem.Visible = false;
                        liftimport.грузовойЛифтТестBindingNavigatorSaveItem.Visible = false;

                        break;
                    }
                case 5:
                    {
                        МалыйГрузовойЛифтИмпорт smallliftimport = new МалыйГрузовойЛифтИмпорт();
                        smallliftimport.Show();
                        smallliftimport.button1.Visible = false;
                        smallliftimport.малыйГрузовойЛифтИмпортDataGridView.AllowUserToAddRows = false;
                        smallliftimport.малыйГрузовойЛифтИмпортDataGridView.AllowUserToDeleteRows = false;
                        smallliftimport.bindingNavigatorAddNewItem.Visible = false;
                        smallliftimport.bindingNavigatorDeleteItem.Visible = false;
                        smallliftimport.малыйГрузовойЛифтИмпортBindingNavigatorSaveItem.Visible = false;
                        break;
                    }
                case 6:
                    {
                        МодельныйРядПегасИмпорт pegasimport = new МодельныйРядПегасИмпорт();
                        pegasimport.Show();
                        pegasimport.button1.Visible = false;
                        pegasimport.модельныйРядПегасИмпортDataGridView.AllowUserToAddRows = false;
                        pegasimport.модельныйРядПегасИмпортDataGridView.AllowUserToDeleteRows = false;
                        pegasimport.bindingNavigatorAddNewItem.Visible = false;
                        pegasimport.bindingNavigatorDeleteItem.Visible = false;
                        pegasimport.модельныйРядПегасИмпортBindingNavigatorSaveItem.Visible = false;
                        break;
                    }
                default:
                    break;
            }
        }
        Point lastPoint;
        private void Views_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Views_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Views_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        View1 predstavlenie = new View1();
                        predstavlenie.Show();
                        predstavlenie.Hide();
                        predstavlenie.freightElevatorsDataGridView.Visible = true;
                        predstavlenie.freightElevatorsDataGridView.Enabled = true;
                        if (predstavlenie.freightElevatorsDataGridView.Rows.Count > 0)
                        {
                           
                            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                            app.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < predstavlenie.freightElevatorsDataGridView.Columns.Count + 1; i++)
                            {
                                app.Cells[1, i] = predstavlenie.freightElevatorsDataGridView.Columns[i - 1].HeaderText;
                            }

                            for (int i = 0; i < predstavlenie.freightElevatorsDataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < predstavlenie.freightElevatorsDataGridView.Columns.Count; j++)
                                {
                                    app.Cells[i + 2, j + 1] = predstavlenie.freightElevatorsDataGridView.Rows[i].Cells[j].Value.ToString();

                                }
                            }
                            app.Columns.AutoFit();
                            app.Rows.AutoFit();
                            app.Visible = true;
                            
                        }

                        break;
                    }
                case 1:
                    {
                        View2 predstavlenie = new View2();
                        predstavlenie.Show();
                        predstavlenie.Hide();
                        predstavlenie.modelPegasDataGridView.Visible = true;
                        predstavlenie.modelPegasDataGridView.Enabled = true;
                        if (predstavlenie.modelPegasDataGridView.Rows.Count > 0)
                        {

                            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                            app.Application.Workbooks.Add(Type.Missing);
                            for (int i = 1; i < predstavlenie.modelPegasDataGridView.Columns.Count + 1; i++)
                            {
                                app.Cells[1, i] = predstavlenie.modelPegasDataGridView.Columns[i - 1].HeaderText;
                            }

                            for (int i = 0; i < predstavlenie.modelPegasDataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < predstavlenie.modelPegasDataGridView.Columns.Count; j++)
                                {
                                    app.Cells[i + 2, j + 1] = predstavlenie.modelPegasDataGridView.Rows[i].Cells[j].Value.ToString();

                                }
                            }
                            app.Columns.AutoFit();
                            app.Rows.AutoFit();
                            app.Visible = true;

                        }

                        break;
                    }
                
                default:
                    break;
            }
        }
    }
}
