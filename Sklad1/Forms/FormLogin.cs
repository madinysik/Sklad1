using Sklad1.Data;
using Sklad1.Forms;
using Sklad1.Helpers;
using Sklad1.Properties;

namespace Sklad1
{
    /// <summary>
    /// Форма входа
    /// </summary>
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            lnkRegister.Click += lnkRegister_Click;
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
                MessageBox.Show(Resources.EnterEmailAndPassword);
                return;
            }
            try
            {
                using (var bd = new Context())
                {
                    var user = bd.Users.FirstOrDefault(u =>
                        u.Email == txtEmail.Text &&
                        u.PasswordHash == Password.HashPassword(txtPassword.Text));

                    if (user == null)
                    {
                        MessageBox.Show(Resources.WrongEmailOrPassword);
                        return;
                    }

                    FormMain.UserRole = user.Role;

                    var mainForm = new FormMain();
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"Ошибка при входе", ex);
                MessageBox.Show(Resources.ErrorSystem);
            }
        }
    }
}
