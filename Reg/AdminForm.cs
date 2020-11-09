using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Reg
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataNews.News". При необходимости она может быть перемещена или удалена.
            this.newsTableAdapter.Fill(this.dataNews.News);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataTeams.Teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.dataTeams.Teams);
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
                cmbTeams.SelectedIndex = cmbTeams.FindStringExact(model.Teams.team_name);
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
            dataPaymentBindingSource.Filter = $"team_name = '{teamSelected}'";
            this.dataTable1TableAdapter.Fill(this.dataPayment.DataTable1);
            dgvPayments.ClearSelection();
        }
    }
}
