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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.password.UseSystemPasswordChar = true;

            password.Enter += password_Enter;
            password.Text = "Введите пароль";
            password.TextAlign = HorizontalAlignment.Left;
            
            login.Enter += login_Enter;
            login.Text = "Введите логин";
            login.TextAlign = HorizontalAlignment.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(login.Text))
            {
                MessageBox.Show("Не указан логин!", "Сообщение", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }   
                else if (String.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("Не указан пароль!", " Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if (login.Text == "Vlad" && password.Text == "1234")
            {
                MessageBox.Show("Вы успешно вошли в систему!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
                MessageBox.Show("У вас имеются права на запись/чтение данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (login.Text == "Admin" && password.Text == "1234")
            {
                MessageBox.Show("Вы успешно вошли в систему!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
                MessageBox.Show("У вас имеются права на запись/чтение данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(login.Text =="Сотрудник" && password.Text == "12345")
            {
                MessageBox.Show("Вы успешно вошли в систему!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
                menu.button1.Enabled = false;
                menu.button2.Enabled = false;
                MessageBox.Show("У вас имеются права на чтение данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         }

        private void login_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(login.Text))
            {
                errorProvider1.SetError(login, "Не указан логин!");
                MessageBox.Show("Не указан логин!", " Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            else
            {
                errorProvider1.Clear();
            }
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(password.Text))
            {
                errorProvider1.SetError(password, "Не указан пароль!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void login_Enter(object sender, EventArgs e)
        {
            login.ForeColor = SystemColors.WindowText;//Темный
            login.Text = "";
            login.TextAlign = HorizontalAlignment.Left;       
        }
        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.ForeColor = SystemColors.WindowFrame;//Серый
                password.UseSystemPasswordChar = false;
                login.Enter += login_Enter;
                login.Text = "Введите логин";
                login.TextAlign = HorizontalAlignment.Left;
            }
            else
                login.Enter -= login_Enter;
        }
        private void password_Enter(object sender, EventArgs e)
        {
            password.ForeColor = SystemColors.WindowText;//Темный
            password.Text = "";
            password.TextAlign = HorizontalAlignment.Left;
            password.UseSystemPasswordChar = true;
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.ForeColor = SystemColors.WindowFrame;//Серый
                password.UseSystemPasswordChar = true;
                password.Enter += password_Enter;
                password.Text = "Введите пароль";
                password.TextAlign = HorizontalAlignment.Left;
            }
            else
                password.Enter -= password_Enter;
        }
        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
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

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
 }

