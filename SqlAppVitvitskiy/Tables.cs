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
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
            
        } 

        private void Tables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "factoryDBDataSet.ГрузовойЛифт". При необходимости она может быть перемещена или удалена.
            this.грузовойЛифтTableAdapter.Fill(this.factoryDBDataSet.ГрузовойЛифт);
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        
                        ГрузовойЛифт лифт = new ГрузовойЛифт();
                        лифт.Show();
                        break;
                    }
                case 1:
                     {
                        
                        МалыйГрузовойЛифт табл = new МалыйГрузовойЛифт();
                        табл.Show();
                        break;
                    }
                case 2:
                    {
                        МодельныйРядПегас pegas = new МодельныйРядПегас();
                        pegas.Show();
                        break;
                    }
                case 3:
                    {
                        ГрузовойЛифтИмпорт import = new ГрузовойЛифтИмпорт();
                        import.Show();
                        break;
                    }
                case 4:
                    {
                        МалыйГрузовойЛифтИмпорт smallimport = new МалыйГрузовойЛифтИмпорт();
                        smallimport.Show();
                        break;
                    }
                case 5:
                    {
                        МодельныйРядПегасИмпорт pegasimport = new МодельныйРядПегасИмпорт();
                        pegasimport.Show();
                        break;
                    }
                default:
                    break;
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
        Point lastPoint;
        private void Tables_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Tables_MouseDown(object sender, MouseEventArgs e)
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
    }
}
