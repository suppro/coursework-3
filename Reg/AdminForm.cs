using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;

namespace Reg
{
    public partial class AdminForm : Form
    {

        int currentWeek;
        string loginName;
        Teams teams = new Teams();
        Users users = new Users();
        Teams_Users teams_users = new Teams_Users();
        Payments payments = new Payments();
        Ranks ranks = new Ranks();
        public AdminForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataEmployeeAdd.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter2.Fill(this.dataEmployeeAdd.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataPayment.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.dataPayment.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataEmployeeTeam.Teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter3.Fill(this.dataEmployeeTeam.Teams);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataEmployeeRole.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.dataEmployeeRole.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataEmployeeRank.Ranks". При необходимости она может быть перемещена или удалена.
            this.ranksTableAdapter.Fill(this.dataEmployeeRank.Ranks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataEmployeeAdd.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter2.Fill(this.dataEmployeeAdd.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataTeamTable.Teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter2.Fill(this.dataTeamTable.Teams);
            this.dataTable1TableAdapter.Fill(this.dataPayment.DataTable1);
            this.dataTable1TableAdapter1.Fill(this.dataEmployee.DataTable1);
            this.teamsTableAdapter1.Fill(this.dataTeam.Teams);
            btnAdd.Enabled = false;
            btnCalcSalary.Enabled = false;
            btnClearEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            loadUserInfo();
            refreshForms();
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
                cmbTeams.SelectedIndex = cmbTeams.FindStringExact(model.Teams.team_name);
                if (model == null)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Ошибка");
                    return;
                }
            }

            using (REGDBEntities db = new REGDBEntities())
            {
                Payments model = (from u in db.Payments
                                  orderby u.current_week descending
                                  select u).FirstOrDefault();
                currentWeek = model.current_week;
                txtCurrentWeek.Text = currentWeek.ToString();
                if (model == null)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Ошибка");
                    return;
                }
            }
        }
        private void refreshForms()
        {
            string teamSelected = cmbTeams.GetItemText(cmbTeams.SelectedItem);
            dataPaymentBindingSource.Filter = $"team_name = '{teamSelected}' and current_week = '{currentWeek}'";
            dataEmployeeAddBindingSource.Filter = $"deleted = 0";
            dgvPayments.ClearSelection();
            this.dataTable1TableAdapter.Fill(this.dataPayment.DataTable1);
            this.teamsTableAdapter2.Fill(this.dataTeamTable.Teams);
        }

        private void refreshFormsAction(object sender, EventArgs e)
        {
            refreshForms();
            //loadUserInfo();
        }

        private void selectTable(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow.Index != -1)
            {

                payments.id = Convert.ToInt32(dgvPayments.CurrentRow.Cells["idDataGridViewTextBoxColumn2"].Value);
                using (REGDBEntities db = new REGDBEntities())
                {
                    payments = db.Payments.Where(x => x.id == payments.id).FirstOrDefault();
                    txtNameTeam.Text = payments.user_id.ToString();
                    txtNameEmployee.Text = payments.team_id.ToString();
                    txtSalary.Text = payments.salary.ToString();
                }
                btnAdd.Enabled = true;
                btnCalcSalary.Enabled = true;
            }
        }

        private void addTable(object sender, EventArgs e)
        {
            payments.user_id = Convert.ToInt32(txtNameEmployee.Text.Trim());
            payments.team_id = Convert.ToInt32(txtNameTeam.Text.Trim());
            payments.summ_coef = Convert.ToInt32(txtSumCoef.Text.Trim());
            payments.efficiency = Convert.ToInt32(txtEff.Text.Trim());
            payments.salary = (int)Math.Round(Convert.ToDouble(txtSalary.Text.Trim()));
            payments.current_week = currentWeek;

            if (String.IsNullOrEmpty(payments.summ_coef.ToString()) || String.IsNullOrEmpty(payments.efficiency.ToString()))
            {
                MessageBox.Show("Поле должно быть заполненно");
                return;
            }


            using (REGDBEntities db = new REGDBEntities())
            {
                db.Entry(payments).State = EntityState.Modified;
                db.SaveChanges();
            }
            btnAdd.Enabled = false;
            btnCalcSalary.Enabled = false;
            refreshForms();
            MessageBox.Show("Данные успешно добавлены");
            txtNameEmployee.Text = txtNameTeam.Text = txtSalary.Text = txtSumCoef.Text = txtEff.Text = "";
        }

        private void calcSalary(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSumCoef.Text) || String.IsNullOrEmpty(txtEff.Text))
            {
                MessageBox.Show("Поле должно быть заполненно");
                return;
            }
            int rankID;
            int sumCoef = Convert.ToInt32(txtSumCoef.Text.Trim());
            int eff = Convert.ToInt32(txtEff.Text.Trim());
            int teamID = payments.team_id;
            using (REGDBEntities db = new REGDBEntities())
            {
                users = db.Users.Where(x => x.id == payments.user_id).FirstOrDefault();
                rankID = users.rank_id;
            }

            double salary = 0;
            if (rankID == 1)
                salary = 70 * sumCoef * eff * 1.22;
            else if (rankID == 2)
                salary = 70 * sumCoef * eff * 1.18;
            else if (rankID == 3)
                salary = 70 * sumCoef * eff * 1.14;
            else if (rankID == 4)
                salary = 70 * sumCoef * eff * 1.11;
            else if (rankID == 5)
                salary = 70 * sumCoef * eff * 1.05;
            else if (rankID == 6)
                salary = 70 * sumCoef * eff * 1;
            else if (rankID == 7)
                salary = 70 * sumCoef * eff * 0.5;
            
            txtSalary.Text = salary.ToString();
        }


        private void addTeam(object sender, EventArgs e)
        {
            teams.team_name = txtTeamName.Text.Trim();
            if (String.IsNullOrEmpty(teams.team_name))
            {
                MessageBox.Show("Поле должно быть заполненно");
                return;
            }
            var regexName = @"^([А-Я]{1}[а-яё]{1,23}|[A-Z]{1}[a-z]{1,23})$";
            if (!Regex.IsMatch(txtTeamName.Text, regexName))
            {
                MessageBox.Show("Название команды несоответсвует "); return;
            }
            using (REGDBEntities db = new REGDBEntities())
            {
                db.Teams.Add(teams);
                db.SaveChanges();
            }
            refreshForms();
        }

        private void addEmployee(object sender, EventArgs e)
        {
            users.name = txtEmployeeName.Text.Trim();
            users.login = txtEmployeeLogin.Text.Trim();
            users.pass = getHash(getHash(txtEmployeePassword.Text.Trim()));
            users.rank_id = Convert.ToInt32(cmbEmployeeRank.SelectedValue);
            users.role_id = Convert.ToInt32(cmbEmployeeRole.SelectedValue);
            teams_users.team_id = Convert.ToInt32(cmbTeamEmployee.SelectedValue);
            users.deleted = 0;

            if (String.IsNullOrEmpty(users.name) || String.IsNullOrEmpty(users.login) || String.IsNullOrEmpty(users.pass) || String.IsNullOrEmpty(users.rank_id.ToString()) || String.IsNullOrEmpty(users.role_id.ToString()))
            {
                MessageBox.Show("Все поля должны быть заполненны");
                return;
            }

            if(users.id == 0)
            {
                using (REGDBEntities db = new REGDBEntities())
                {
                    db.Users.Add(users);
                    db.SaveChanges();
                }
                //users.id = 0;
                using (REGDBEntities db = new REGDBEntities())
                {
                    Users model = (from u in db.Users
                                   orderby u.id descending
                                   select u).FirstOrDefault();
                    teams_users.user_id = model.id;
                }
                using (REGDBEntities db = new REGDBEntities())
                {
                    db.Teams_Users.Add(teams_users);
                    db.SaveChanges();
                }

                ClearEmployee();
                MessageBox.Show("Новый сотрудник успешно добавлен");
            }
            else
            {
                using (REGDBEntities db = new REGDBEntities())
                {
                    db.Entry(users).State = EntityState.Modified;
                    db.SaveChanges();
                }

                using (REGDBEntities db = new REGDBEntities())
                {
                    Users model = (from u in db.Users
                                   orderby u.id descending
                                   select u).FirstOrDefault();
                    teams_users.user_id = model.id;
                }
                using (REGDBEntities db = new REGDBEntities())
                {
                    db.Entry(teams_users).State = EntityState.Modified;
                    db.SaveChanges();
                }
                ClearEmployee();
                MessageBox.Show("Данные сотрудника успешно обновлены");
            }
        }
        
        private void selectEmployee(object sender, EventArgs e)
        {
            txtEmployeePassword.Enabled = false;
            if (dgvPayments.CurrentRow.Index != -1)
            {
                
                users.id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
                using (REGDBEntities db = new REGDBEntities())
                {
                    users = db.Users.Where(x => x.id == users.id).FirstOrDefault();
                    teams_users = db.Teams_Users.Where(x => x.user_id == users.id).FirstOrDefault();
                    txtEmployeeName.Text = users.name;
                    cmbTeamEmployee.SelectedIndex = teams_users.team_id - 1;
                    cmbEmployeeRole.SelectedIndex = users.role_id - 1;
                    cmbEmployeeRank.SelectedIndex = users.rank_id - 1;
                    txtEmployeeLogin.Text = users.login;
                    txtEmployeePassword.Text = users.pass;
                }
                btnClearEmployee.Enabled = true;
                btnDeleteEmployee.Enabled = true;
            }
        }
        private void deleteEmployee(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (REGDBEntities db = new REGDBEntities())
                {
                    users.deleted = 1;
                    db.Entry(users).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            ClearEmployee();
            MessageBox.Show("Удаление прошло успешно");
        }

        private void ClearEmployeeBtn(object sender, EventArgs e)
        {
            ClearEmployee();
        }

        private void ClearEmployee()
        {
            this.dataTable1TableAdapter2.Fill(this.dataEmployeeAdd.DataTable1);
            txtEmployeeName.Text = cmbTeamEmployee.Text = cmbEmployeeRole.Text = cmbEmployeeRank.Text = txtEmployeeLogin.Text = txtEmployeePassword.Text = "";
            btnAddEmployee.Text = "Добавить запись";
            txtEmployeePassword.Enabled = true;
            btnClearEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            users.id = 0;
        }

        private void nextWeek(object sender, EventArgs e)
        {
            int idCount;
            using (REGDBEntities db = new REGDBEntities())
            {
                Users model = (from u in db.Users
                               orderby u.id descending
                               select u).FirstOrDefault();
                idCount = model.id;
            }
            for (int i = 1; i <= idCount; ++i)
            {
                using (REGDBEntities db = new REGDBEntities())
                {
                    users = db.Users.Where(x => x.id == i).FirstOrDefault();
                    if (users == null) continue;
                    teams_users = db.Teams_Users.Where(x => x.user_id == i).FirstOrDefault();
                    payments.salary = 0;
                    payments.user_id = users.id;
                    payments.team_id = teams_users.team_id;
                    payments.current_week = currentWeek + 1;
                }

                using (REGDBEntities db = new REGDBEntities())
                {
                    db.Payments.Add(payments);
                    db.SaveChanges();
                }
            }
            currentWeek++;
            refreshForms();
            loadUserInfo();
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

        private void backButton(object sender, EventArgs e)
        {
              UserForm userForm = new UserForm(loginName);
              userForm.Show();
              this.Close();
               userForm.Show();
        }
        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
