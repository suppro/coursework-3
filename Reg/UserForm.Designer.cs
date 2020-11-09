namespace Reg
{
    partial class UserForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTeams = new Reg.DataTeams();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.Label();
            this.txtWallet = new System.Windows.Forms.Label();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnAdminForm = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPanel = new MetroFramework.Controls.MetroTabControl();
            this.metroPayments = new MetroFramework.Controls.MetroTabPage();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sundayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summcoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataPayment = new Reg.DataPayment();
            this.metroNews = new MetroFramework.Controls.MetroTabPage();
            this.metroInfo = new MetroFramework.Controls.MetroTabPage();
            this.metroWithdrawal = new MetroFramework.Controls.MetroTabPage();
            this.dataTable1TableAdapter = new Reg.DataPaymentTableAdapters.DataTable1TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teamsTableAdapter = new Reg.DataTeamsTableAdapters.TeamsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataLineUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLineUp = new Reg.DataLineUp();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataTable1TableAdapter1 = new Reg.DataLineUpTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeams)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.metroPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(30, 178);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(124, 20);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.Text = "Имя работника";
            // 
            // cmbTeams
            // 
            this.cmbTeams.DataSource = this.teamsBindingSource;
            this.cmbTeams.DisplayMember = "team_name";
            this.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(178, 83);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(188, 28);
            this.cmbTeams.TabIndex = 17;
            this.cmbTeams.ValueMember = "id";
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.refreshFormsAction);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.dataTeams;
            // 
            // dataTeams
            // 
            this.dataTeams.DataSetName = "DataTeams";
            this.dataTeams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Роль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Звание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Баланс";
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Location = new System.Drawing.Point(70, 212);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(84, 13);
            this.txtRole.TabIndex = 22;
            this.txtRole.Text = "Название роли";
            // 
            // txtRank
            // 
            this.txtRank.AutoSize = true;
            this.txtRank.Location = new System.Drawing.Point(70, 236);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(96, 13);
            this.txtRank.TabIndex = 23;
            this.txtRank.Text = "Название звания";
            // 
            // txtWallet
            // 
            this.txtWallet.AutoSize = true;
            this.txtWallet.Location = new System.Drawing.Point(70, 259);
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.Size = new System.Drawing.Size(87, 13);
            this.txtWallet.TabIndex = 24;
            this.txtWallet.Text = "Сумма на счете";
            // 
            // btnNews
            // 
            this.btnNews.Location = new System.Drawing.Point(18, 291);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(140, 28);
            this.btnNews.TabIndex = 25;
            this.btnNews.Text = "Новости";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.switchTab);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(18, 325);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(140, 28);
            this.btnInfo.TabIndex = 26;
            this.btnInfo.Text = "Информация";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.switchTab);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(18, 393);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(140, 28);
            this.btnWithdrawal.TabIndex = 28;
            this.btnWithdrawal.Text = "Вывод средств";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.switchTab);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(18, 359);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(140, 28);
            this.btnPayments.TabIndex = 27;
            this.btnPayments.Text = "Таблица выплат";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.switchTab);
            // 
            // btnAdminForm
            // 
            this.btnAdminForm.Location = new System.Drawing.Point(18, 427);
            this.btnAdminForm.Name = "btnAdminForm";
            this.btnAdminForm.Size = new System.Drawing.Size(140, 28);
            this.btnAdminForm.TabIndex = 29;
            this.btnAdminForm.Text = "Управление";
            this.btnAdminForm.UseVisualStyleBackColor = true;
            this.btnAdminForm.Click += new System.EventHandler(this.manageButton);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(18, 464);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(140, 28);
            this.btnExit2.TabIndex = 30;
            this.btnExit2.Text = "Выход";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.exitButton);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 28);
            this.panel2.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1112, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 28);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitButton);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 28);
            this.panel1.TabIndex = 33;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.metroPayments);
            this.tabPanel.Controls.Add(this.metroNews);
            this.tabPanel.Controls.Add(this.metroInfo);
            this.tabPanel.Controls.Add(this.metroWithdrawal);
            this.tabPanel.Location = new System.Drawing.Point(420, 56);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(685, 442);
            this.tabPanel.Style = MetroFramework.MetroColorStyle.Purple;
            this.tabPanel.TabIndex = 34;
            this.tabPanel.UseSelectable = true;
            // 
            // metroPayments
            // 
            this.metroPayments.Controls.Add(this.dgvPayments);
            this.metroPayments.HorizontalScrollbarBarColor = true;
            this.metroPayments.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPayments.HorizontalScrollbarSize = 10;
            this.metroPayments.Location = new System.Drawing.Point(4, 38);
            this.metroPayments.Name = "metroPayments";
            this.metroPayments.Size = new System.Drawing.Size(677, 400);
            this.metroPayments.TabIndex = 4;
            this.metroPayments.Text = "Таблица выплат";
            this.metroPayments.VerticalScrollbarBarColor = true;
            this.metroPayments.VerticalScrollbarHighlightOnWheel = false;
            this.metroPayments.VerticalScrollbarSize = 10;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AutoGenerateColumns = false;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.mondayDataGridViewTextBoxColumn,
            this.tuesdayDataGridViewTextBoxColumn,
            this.wednesdayDataGridViewTextBoxColumn,
            this.thursdayDataGridViewTextBoxColumn,
            this.fridayDataGridViewTextBoxColumn,
            this.saturdayDataGridViewTextBoxColumn,
            this.sundayDataGridViewTextBoxColumn,
            this.summcoefDataGridViewTextBoxColumn,
            this.efficiencyDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dgvPayments.DataSource = this.dataPaymentBindingSource;
            this.dgvPayments.Location = new System.Drawing.Point(4, 26);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.Size = new System.Drawing.Size(677, 371);
            this.dgvPayments.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Звание";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            // 
            // mondayDataGridViewTextBoxColumn
            // 
            this.mondayDataGridViewTextBoxColumn.DataPropertyName = "monday";
            this.mondayDataGridViewTextBoxColumn.HeaderText = "Понедельник";
            this.mondayDataGridViewTextBoxColumn.Name = "mondayDataGridViewTextBoxColumn";
            // 
            // tuesdayDataGridViewTextBoxColumn
            // 
            this.tuesdayDataGridViewTextBoxColumn.DataPropertyName = "tuesday";
            this.tuesdayDataGridViewTextBoxColumn.HeaderText = "Вторник";
            this.tuesdayDataGridViewTextBoxColumn.Name = "tuesdayDataGridViewTextBoxColumn";
            // 
            // wednesdayDataGridViewTextBoxColumn
            // 
            this.wednesdayDataGridViewTextBoxColumn.DataPropertyName = "wednesday";
            this.wednesdayDataGridViewTextBoxColumn.HeaderText = "Среда";
            this.wednesdayDataGridViewTextBoxColumn.Name = "wednesdayDataGridViewTextBoxColumn";
            // 
            // thursdayDataGridViewTextBoxColumn
            // 
            this.thursdayDataGridViewTextBoxColumn.DataPropertyName = "thursday";
            this.thursdayDataGridViewTextBoxColumn.HeaderText = "Четверг";
            this.thursdayDataGridViewTextBoxColumn.Name = "thursdayDataGridViewTextBoxColumn";
            // 
            // fridayDataGridViewTextBoxColumn
            // 
            this.fridayDataGridViewTextBoxColumn.DataPropertyName = "friday";
            this.fridayDataGridViewTextBoxColumn.HeaderText = "Пятница";
            this.fridayDataGridViewTextBoxColumn.Name = "fridayDataGridViewTextBoxColumn";
            // 
            // saturdayDataGridViewTextBoxColumn
            // 
            this.saturdayDataGridViewTextBoxColumn.DataPropertyName = "saturday";
            this.saturdayDataGridViewTextBoxColumn.HeaderText = "Суббота";
            this.saturdayDataGridViewTextBoxColumn.Name = "saturdayDataGridViewTextBoxColumn";
            // 
            // sundayDataGridViewTextBoxColumn
            // 
            this.sundayDataGridViewTextBoxColumn.DataPropertyName = "sunday";
            this.sundayDataGridViewTextBoxColumn.HeaderText = "Воскресенье";
            this.sundayDataGridViewTextBoxColumn.Name = "sundayDataGridViewTextBoxColumn";
            // 
            // summcoefDataGridViewTextBoxColumn
            // 
            this.summcoefDataGridViewTextBoxColumn.DataPropertyName = "summ_coef";
            this.summcoefDataGridViewTextBoxColumn.HeaderText = "Сумма коэф.";
            this.summcoefDataGridViewTextBoxColumn.Name = "summcoefDataGridViewTextBoxColumn";
            // 
            // efficiencyDataGridViewTextBoxColumn
            // 
            this.efficiencyDataGridViewTextBoxColumn.DataPropertyName = "efficiency";
            this.efficiencyDataGridViewTextBoxColumn.HeaderText = "Эффективность";
            this.efficiencyDataGridViewTextBoxColumn.Name = "efficiencyDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // dataPaymentBindingSource
            // 
            this.dataPaymentBindingSource.DataMember = "DataTable1";
            this.dataPaymentBindingSource.DataSource = this.dataPayment;
            // 
            // dataPayment
            // 
            this.dataPayment.DataSetName = "DataPayment";
            this.dataPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroNews
            // 
            this.metroNews.HorizontalScrollbarBarColor = true;
            this.metroNews.HorizontalScrollbarHighlightOnWheel = false;
            this.metroNews.HorizontalScrollbarSize = 10;
            this.metroNews.Location = new System.Drawing.Point(4, 38);
            this.metroNews.Name = "metroNews";
            this.metroNews.Size = new System.Drawing.Size(677, 400);
            this.metroNews.TabIndex = 2;
            this.metroNews.Text = "Новости";
            this.metroNews.VerticalScrollbarBarColor = true;
            this.metroNews.VerticalScrollbarHighlightOnWheel = false;
            this.metroNews.VerticalScrollbarSize = 10;
            // 
            // metroInfo
            // 
            this.metroInfo.HorizontalScrollbarBarColor = true;
            this.metroInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.metroInfo.HorizontalScrollbarSize = 10;
            this.metroInfo.Location = new System.Drawing.Point(4, 38);
            this.metroInfo.Name = "metroInfo";
            this.metroInfo.Size = new System.Drawing.Size(677, 400);
            this.metroInfo.TabIndex = 3;
            this.metroInfo.Text = "Информация";
            this.metroInfo.VerticalScrollbarBarColor = true;
            this.metroInfo.VerticalScrollbarHighlightOnWheel = false;
            this.metroInfo.VerticalScrollbarSize = 10;
            // 
            // metroWithdrawal
            // 
            this.metroWithdrawal.HorizontalScrollbarBarColor = true;
            this.metroWithdrawal.HorizontalScrollbarHighlightOnWheel = false;
            this.metroWithdrawal.HorizontalScrollbarSize = 10;
            this.metroWithdrawal.Location = new System.Drawing.Point(4, 38);
            this.metroWithdrawal.Name = "metroWithdrawal";
            this.metroWithdrawal.Size = new System.Drawing.Size(677, 400);
            this.metroWithdrawal.TabIndex = 5;
            this.metroWithdrawal.Text = "Вывод средств";
            this.metroWithdrawal.VerticalScrollbarBarColor = true;
            this.metroWithdrawal.VerticalScrollbarHighlightOnWheel = false;
            this.metroWithdrawal.VerticalScrollbarSize = 10;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reg.Properties.Resources.logo_title;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.dataLineUpBindingSource;
            this.listBox1.DisplayMember = "name";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(178, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 344);
            this.listBox1.TabIndex = 35;
            // 
            // dataLineUpBindingSource
            // 
            this.dataLineUpBindingSource.DataMember = "DataTable1";
            this.dataLineUpBindingSource.DataSource = this.dataLineUp;
            // 
            // dataLineUp
            // 
            this.dataLineUp.DataSetName = "DataLineUp";
            this.dataLineUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Состав команды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(174, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Название команды";
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnAdminForm);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.txtWallet);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTeams);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booster Team";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeams)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.metroPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.Label txtRank;
        private System.Windows.Forms.Label txtWallet;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnAdminForm;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private MetroFramework.Controls.MetroTabControl tabPanel;
        private MetroFramework.Controls.MetroTabPage metroNews;
        private MetroFramework.Controls.MetroTabPage metroInfo;
        private MetroFramework.Controls.MetroTabPage metroPayments;
        private MetroFramework.Controls.MetroTabPage metroWithdrawal;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.BindingSource dataPaymentBindingSource;
        private DataPayment dataPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentweekDataGridViewTextBoxColumn;
        private DataPaymentTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sundayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summcoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private DataTeams dataTeams;
        private DataTeamsTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource dataLineUpBindingSource;
        private DataLineUp dataLineUp;
        private DataLineUpTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    }
}

