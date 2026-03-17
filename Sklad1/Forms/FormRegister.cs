using Sklad1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad1.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            try
            {
                using (var bd = new Context())
                {
                    bool emailExists = false;

                    foreach (var u in bd.users)
                    {
                        if (u.email == txtEmail.Text)
                        {
                            emailExists = true;
                            break;
                        }
                    }

                    if (emailExists)
                    {
                        MessageBox.Show("Такой email уже есть!");
                        return;
                    }

                    var newUser = new User
                    {
                        last_name = txtLastName.Text,
                        first_name = txtFirstName.Text,
                        middle_name = txtMiddleName.Text,
                        email = txtEmail.Text,
                        password_hash = txtPassword.Text,
                        role = "Кладовщик"
                    };

                    bd.users.Add(newUser);
                    bd.SaveChanges();

                    MessageBox.Show("Регистрация прошла успешно!");

                    FormLogin login = new FormLogin();
                    login.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
