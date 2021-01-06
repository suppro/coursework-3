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
            this.txtRole = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPanel = new MetroFramework.Controls.MetroTabControl();
            this.metroPayments = new MetroFramework.Controls.MetroTabPage();
            this.txtCurrentWeek = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNumbersWeek = new System.Windows.Forms.ComboBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.dataPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataPayment = new Reg.DataPayment();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teamsTableAdapter = new Reg.DataTeamsTableAdapters.TeamsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataLineUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLineUp = new Reg.DataLineUp();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataTable1TableAdapter1 = new Reg.DataLineUpTableAdapters.DataTable1TableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataTable1TableAdapter = new Reg.DataPaymentTableAdapters.DataTable1TableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summcoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeams)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.metroPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.txtUserName.Location = new System.Drawing.Point(171, 29);
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
            this.cmbTeams.Location = new System.Drawing.Point(12, 38);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(196, 28);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(346, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Роль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(504, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Звание";
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRole.Location = new System.Drawing.Point(394, 29);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(83, 20);
            this.txtRole.TabIndex = 22;
            this.txtRole.Text = "Название";
            // 
            // txtRank
            // 
            this.txtRank.AutoSize = true;
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRank.Location = new System.Drawing.Point(575, 29);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(83, 20);
            this.txtRank.TabIndex = 23;
            this.txtRank.Text = "Название";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 28);
            this.panel1.TabIndex = 33;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.metroPayments);
            this.tabPanel.Location = new System.Drawing.Point(226, 109);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(909, 398);
            this.tabPanel.Style = MetroFramework.MetroColorStyle.Purple;
            this.tabPanel.TabIndex = 34;
            this.tabPanel.UseSelectable = true;
            // 
            // metroPayments
            // 
            this.metroPayments.Controls.Add(this.txtCurrentWeek);
            this.metroPayments.Controls.Add(this.label8);
            this.metroPayments.Controls.Add(this.label7);
            this.metroPayments.Controls.Add(this.cmbNumbersWeek);
            this.metroPayments.Controls.Add(this.dgvPayments);
            this.metroPayments.HorizontalScrollbarBarColor = true;
            this.metroPayments.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPayments.HorizontalScrollbarSize = 10;
            this.metroPayments.Location = new System.Drawing.Point(4, 38);
            this.metroPayments.Name = "metroPayments";
            this.metroPayments.Size = new System.Drawing.Size(901, 356);
            this.metroPayments.TabIndex = 4;
            this.metroPayments.Text = "Таблица выплат";
            this.metroPayments.VerticalScrollbarBarColor = true;
            this.metroPayments.VerticalScrollbarHighlightOnWheel = false;
            this.metroPayments.VerticalScrollbarSize = 10;
            // 
            // txtCurrentWeek
            // 
            this.txtCurrentWeek.AutoSize = true;
            this.txtCurrentWeek.BackColor = System.Drawing.Color.White;
            this.txtCurrentWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCurrentWeek.Location = new System.Drawing.Point(477, 11);
            this.txtCurrentWeek.Name = "txtCurrentWeek";
            this.txtCurrentWeek.Size = new System.Drawing.Size(140, 24);
            this.txtCurrentWeek.TabIndex = 42;
            this.txtCurrentWeek.Text = "Номер недели";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(310, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Текущая неделя - ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Номер недели";
            // 
            // cmbNumbersWeek
            // 
            this.cmbNumbersWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumbersWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbNumbersWeek.FormattingEnabled = true;
            this.cmbNumbersWeek.Location = new System.Drawing.Point(149, 11);
            this.cmbNumbersWeek.Name = "cmbNumbersWeek";
            this.cmbNumbersWeek.Size = new System.Drawing.Size(122, 28);
            this.cmbNumbersWeek.TabIndex = 38;
            this.cmbNumbersWeek.SelectedIndexChanged += new System.EventHandler(this.refreshFormsAction);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AutoGenerateColumns = false;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.summcoefDataGridViewTextBoxColumn,
            this.efficiencyDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvPayments.DataSource = this.dataPaymentBindingSource;
            this.dgvPayments.Location = new System.Drawing.Point(3, 45);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.Size = new System.Drawing.Size(895, 315);
            this.dgvPayments.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reg.Properties.Resources.logo_title;
            this.pictureBox1.Location = new System.Drawing.Point(0, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 106);
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
            this.listBox1.Location = new System.Drawing.Point(12, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 284);
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
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Состав команды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Название команды";
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 28);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtRole);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtRank);
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 78);
            this.panel3.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(125, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Имя";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1013, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Переход к управлению";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.manageButton);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cmbTeams);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(0, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 398);
            this.panel4.TabIndex = 40;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя работника";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Звание";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            // 
            // summcoefDataGridViewTextBoxColumn
            // 
            this.summcoefDataGridViewTextBoxColumn.DataPropertyName = "summ_coef";
            this.summcoefDataGridViewTextBoxColumn.HeaderText = "Сумма коэффициентов";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "current_week";
            this.dataGridViewTextBoxColumn1.HeaderText = "current_week";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "team_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "team_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 541);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booster Team";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeams)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.metroPayments.ResumeLayout(false);
            this.metroPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineUp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.Label txtRank;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tabPanel;
        private MetroFramework.Controls.MetroTabPage metroPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mondayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sundayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private DataTeams dataTeams;
        private DataTeamsTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource dataLineUpBindingSource;
        private DataLineUp dataLineUp;
        private DataLineUpTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtCurrentWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNumbersWeek;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource dataPaymentBindingSource;
        private DataPayment dataPayment;
        private DataPaymentTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summcoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

