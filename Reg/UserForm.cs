﻿using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reg
{
    public partial class UserForm : Form
    {
        Users model = new Users();
        string loginName;
        public UserForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.teamsTableAdapter.Fill(this.dataTeams.Teams);
            dgvPayments.AutoGenerateColumns = false;
            loadUserInfo();
            if (txtRole.Text == "employee") {
                btnAdminForm.Visible = false;
                cmbTeams.Enabled = false;
            }
                
            refreshForms();
            dgvPayments.Enabled = true;
        }

        private void loadUserInfo()
        {
            using (REGDBEntities db = new REGDBEntities())
            {
                Teams_Users model = (from u in db.Teams_Users
                               join q in db.Teams on u.team_id equals q.id
                               join v in db.Users on u.user_id equals v.id
                               select u).FirstOrDefault();
                txtUserName.Text = model.Users.name;
                txtRole.Text = model.Users.Role.role1;
                txtRank.Text = model.Users.Ranks.rank;
                txtWallet.Text = Convert.ToString(model.Users.wallet);
                cmbTeams.SelectedIndex = cmbTeams.FindStringExact(model.Teams.team_name);
                if (model == null)
                {
                    MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                    return;
                }
            }
        }

        private void refreshForms()
        {
            string teamSelected = cmbTeams.GetItemText(cmbTeams.SelectedItem);
            dataPaymentBindingSource.Filter = $"team_name = '{teamSelected}'";
            dataLineUpBindingSource.Filter = $"team_name = '{teamSelected}'";
            this.dataTable1TableAdapter1.Fill(this.dataLineUp.DataTable1);
            this.dataTable1TableAdapter.Fill(this.dataPayment.DataTable1);
            dgvPayments.ClearSelection();
            listBox1.ClearSelected();
        }

        private void refreshFormsAction(object sender, EventArgs e)
        {
            refreshForms();
        }


        private void exitButton(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Visible = true;
            this.Close();
        }

        private void manageButton(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void switchTab(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == btnNews.Name)
                tabPanel.SelectedTab = metroNews;
            else if(btn.Name == btnInfo.Name)
                tabPanel.SelectedTab = metroInfo;
            else if(btn.Name == btnPayments.Name)
                tabPanel.SelectedTab = metroPayments;
            else if(btn.Name == btnWithdrawal.Name)
                tabPanel.SelectedTab = metroWithdrawal;
            else
                MessageBox.Show("Кнопка не определена");
        }


        /*

private void regUser(object sender, EventArgs e)
{
model.FullName = txtFullName.Text.Trim();
model.Email = txtEmail.Text.Trim();
model.BrthDay = dtBrthDay.Text.Trim();
model.Address = txtAddress.Text.Trim();
model.PhoneNumber = txtPhone.Text.Trim();
model.Distance = cmbDistance.Text.Trim();
if (String.IsNullOrEmpty(model.FullName) || String.IsNullOrEmpty(model.Email)
|| String.IsNullOrEmpty(model.BrthDay) || String.IsNullOrEmpty(model.Address)
|| String.IsNullOrEmpty(model.PhoneNumber) || String.IsNullOrEmpty(model.Distance))
{
MessageBox.Show("Все поля должны быть заполненны"); return;
}

using (REGDBEntities db = new REGDBEntities())
{
if (model.ID == 0)
  db.Runners.Add(model);
else
  db.Entry(model).State = EntityState.Modified;
db.SaveChanges();
}
Clear();
if (logined) PopulateDataGridView();
MessageBox.Show("Вы были зарегистрированы");
}

private void deleteRunner(object sender, EventArgs e)
{
if (MessageBox.Show("Удалить эту запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
{
using (REGDBEntities db = new REGDBEntities())
{
  var entry = db.Entry(model);
  if (entry.State == EntityState.Detached)
      db.Runners.Attach(model);
  db.Runners.Remove(model);
  db.SaveChanges();
  PopulateDataGridView();
  Clear();
  MessageBox.Show("Удаление прошло успешно");
}
}
}

private void dgvListRunners_DoubleClick(object sender, EventArgs e)
{
if (dgvListRunners.CurrentRow.Index != -1)
{
model.ID = Convert.ToInt32(dgvListRunners.CurrentRow.Cells["ID"].Value);
using (REGDBEntities db = new REGDBEntities())
{
  model = db.Runners.Where(x => x.ID == model.ID).FirstOrDefault();
  txtFullName.Text = model.FullName;
  txtEmail.Text = model.Email;
  dtBrthDay.Text = model.BrthDay;
  txtAddress.Text = model.Address;
  txtPhone.Text = model.PhoneNumber;
  cmbDistance.Text = model.Distance;
}
btnReg.Text = "Обновить";
btnDelete.Enabled = true;
btnClear.Enabled = true;
}
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

Logins log;
bool userAuth = false;
using (REGDBEntities db = new REGDBEntities())
{
log = db.Logins.FirstOrDefault(u => u.Login == login && u.Password == password);
if (log != null)
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
MessageBox.Show("Вы вошли в систему как Администратор");
dgvListRunners.Enabled = true;
logined = true;
Clear();
PopulateDataGridView();
}
}

private void Clear()
{
txtFullName.Text = txtEmail.Text = dtBrthDay.Text = txtAddress.Text = txtPhone.Text = cmbDistance.Text = "";
btnClear.Enabled = false;
btnReg.Text = "Добавить участника";
model.ID = 0;
}

private void PopulateDataGridView()
{
dgvListRunners.AutoGenerateColumns = false;
using (REGDBEntities db = new REGDBEntities())
{
dgvListRunners.DataSource = db.Runners.ToList();
}
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

private void fieldsClear(object sender, EventArgs e)
{
Clear();
PopulateDataGridView();
}
*/
    }
}