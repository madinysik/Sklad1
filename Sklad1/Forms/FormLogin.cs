using Sklad1.Data;
using Sklad1.Forms;

namespace Sklad1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            lnkRegister.Click += new EventHandler(lnkRegister_Click);

        }

        private void lnkRegister_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите email и пароль!");
                return;
            }

            try
            {
                using (var bd = new Context())
                {
                    User user = null;
                    foreach (var u in bd.users)
                    {
                        if (u.email == txtEmail.Text && u.password_hash == txtPassword.Text)
                        {
                            user = u;
                            break;
                        }
                    }
                    if (user == null)
                    {
                        MessageBox.Show("Неверный email или пароль!");
                        return;
                    }

                    FormMain.UserRole = user.role;

                    FormMain mainForm = new FormMain();
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
