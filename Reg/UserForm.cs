using System;
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
        int role;
        string currentWeek;
        public UserForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.dataPayment.DataTable1);
            this.dataTable1TableAdapter.Fill(this.dataPayment.DataTable1);
            this.teamsTableAdapter.Fill(this.dataTeams.Teams);
            dgvPayments.AutoGenerateColumns = false;
            loadUserInfo();
            loadNumbersWeek();
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
                                     where u.Users.login == loginName
                                     select u).FirstOrDefault();
                role = model.Users.rank_id;
                txtUserName.Text = model.Users.name;
                txtRole.Text = model.Users.Role.role1;
                txtRank.Text = model.Users.Ranks.rank;
                cmbTeams.SelectedIndex = cmbTeams.FindStringExact(model.Teams.team_name);
                if (txtRole.Text == "Employee")
                {
                    cmbTeams.Enabled = false;
                }
                if (model == null)
                {
                    MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                    return;
                }
            }

            using (REGDBEntities db = new REGDBEntities())
            {
                Payments model = (from u in db.Payments
                                  orderby u.current_week descending
                                  select u).FirstOrDefault();
                currentWeek = model.current_week.ToString();
                txtCurrentWeek.Text = currentWeek;
                if (model == null)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Ошибка");
                    return;
                }
            }
        }

        private void loadNumbersWeek()
        {
            int weeks = Convert.ToInt32(currentWeek);
            for (int i = 1; i <= weeks; ++i)
            {
                cmbNumbersWeek.Items.Add(i);
            }
        }

        private void refreshForms()
        {

            int selectedWeek = Convert.ToInt32(cmbNumbersWeek.SelectedIndex) + 1;
            string teamSelected = cmbTeams.GetItemText(cmbTeams.SelectedItem);
            dataPaymentBindingSource.Filter = $"team_name = '{teamSelected}' and current_week = '{selectedWeek}'";
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

        private void filterWeek(object sender, EventArgs e)
        {

            string teamSelected = cmbTeams.GetItemText(cmbTeams.SelectedItem);


        }

        private void manageButton(object sender, EventArgs e)
        {
            if (role == 1)
            {
                AdminForm adminForm = new AdminForm(loginName);
                adminForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не имеете достаточно прав");
                return;
            }
        }

        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}