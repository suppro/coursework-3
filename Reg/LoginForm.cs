using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Reg
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private String getHash(String text)
        {
            byte[] hashenc, bytes = Encoding.ASCII.GetBytes(text);
            String result = "";

            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                hashenc = md5.ComputeHash(bytes);
                foreach (var b in hashenc)
                    result += b.ToString("x2");
            }

            return result;
        }

        private void loginUser(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrEmpty(login) || login.Equals("Логин"))
            {
                MessageBox.Show("Не введен логин", "Информация"); return;
            }
            else if (String.IsNullOrEmpty(password) || password.Equals("Пароль"))
            {
                MessageBox.Show("Не введен пароль", "Информация"); return;
            }

            password = getHash(getHash(password));

            Users user;
            bool userAuth = false;
            using (REGDBEntities db = new REGDBEntities())
            {
                user = db.Users.FirstOrDefault(u => u.login == login && u.pass == password);
                if (user != null)
                {
                    userAuth = true;
                }
            }
            if (!userAuth)
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }
            else
            {
                this.Visible = false;
                UserForm userForm = new UserForm(login);
                userForm.Show();
            }
        }

        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
