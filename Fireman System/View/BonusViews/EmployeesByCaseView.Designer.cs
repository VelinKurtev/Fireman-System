
namespace Fireman_Systemn.View
{
    partial class EmployeesByCaseView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesByCaseView));
            this.gradientPanelEmployees = new Fireman_Systemn.GradientPanel();
            this.dgvEmployeesByCase = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfAnsweredCases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChoosenTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateVacation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateVacation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuisinessTripStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuisinessTripEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotWantedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_employees = new System.Windows.Forms.Label();
            this.gradientPanelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesByCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelEmployees
            // 
            this.gradientPanelEmployees.Angle = 0F;
            this.gradientPanelEmployees.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelEmployees.BottomColor = System.Drawing.Color.DarkRed;
            this.gradientPanelEmployees.Controls.Add(this.dgvEmployeesByCase);
            this.gradientPanelEmployees.Controls.Add(this.pictureBox1);
            this.gradientPanelEmployees.Controls.Add(this.btn_back);
            this.gradientPanelEmployees.Controls.Add(this.lbl_employees);
            this.gradientPanelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelEmployees.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelEmployees.Name = "gradientPanelEmployees";
            this.gradientPanelEmployees.Size = new System.Drawing.Size(722, 512);
            this.gradientPanelEmployees.TabIndex = 6;
            this.gradientPanelEmployees.TopColor = System.Drawing.Color.Black;
            // 
            // dgvEmployeesByCase
            // 
            this.dgvEmployeesByCase.AllowUserToAddRows = false;
            this.dgvEmployeesByCase.AllowUserToDeleteRows = false;
            this.dgvEmployeesByCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvEmployeesByCase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployeesByCase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesByCase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeesByCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeesByCase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.AmountOfAnsweredCases,
            this.ChoosenTeam,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Age,
            this.Rank,
            this.HomeAddress,
            this.PersonalPhoneNum,
            this.Email,
            this.StartDateVacation,
            this.EndDateVacation,
            this.BuisinessTripStartDate,
            this.BuisinessTripEndDate,
            this.NotWantedColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesByCase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeesByCase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvEmployeesByCase.Location = new System.Drawing.Point(172, 124);
            this.dgvEmployeesByCase.Name = "dgvEmployeesByCase";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesByCase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeesByCase.RowHeadersWidth = 20;
            this.dgvEmployeesByCase.Size = new System.Drawing.Size(538, 376);
            this.dgvEmployeesByCase.TabIndex = 16;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "employee_id";
            this.EmployeeID.HeaderText = "ИД на пожарникар";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 129;
            // 
            // AmountOfAnsweredCases
            // 
            this.AmountOfAnsweredCases.DataPropertyName = "number_of_answered_cases";
            this.AmountOfAnsweredCases.HeaderText = "Брой приети случаи";
            this.AmountOfAnsweredCases.Name = "AmountOfAnsweredCases";
            this.AmountOfAnsweredCases.Width = 132;
            // 
            // ChoosenTeam
            // 
            this.ChoosenTeam.DataPropertyName = "choosen_team";
            this.ChoosenTeam.HeaderText = "Избран отбор";
            this.ChoosenTeam.Name = "ChoosenTeam";
            this.ChoosenTeam.Width = 102;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "first_name";
            this.FirstName.HeaderText = "Име";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 54;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "middle_name";
            this.MiddleName.HeaderText = "Презиме";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Width = 78;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "last_name";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.Width = 81;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "age";
            this.Age.HeaderText = "Години";
            this.Age.Name = "Age";
            this.Age.Width = 68;
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "rank";
            this.Rank.HeaderText = "Чин";
            this.Rank.Name = "Rank";
            this.Rank.Width = 52;
            // 
            // HomeAddress
            // 
            this.HomeAddress.DataPropertyName = "home_address";
            this.HomeAddress.HeaderText = "Домашен адрес";
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.Width = 114;
            // 
            // PersonalPhoneNum
            // 
            this.PersonalPhoneNum.DataPropertyName = "personal_phone_number";
            this.PersonalPhoneNum.HeaderText = "Личен телефон";
            this.PersonalPhoneNum.Name = "PersonalPhoneNum";
            this.PersonalPhoneNum.Width = 109;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Имейл";
            this.Email.Name = "Email";
            this.Email.Width = 66;
            // 
            // StartDateVacation
            // 
            this.StartDateVacation.DataPropertyName = "vacation_start_date";
            this.StartDateVacation.HeaderText = "Начална дата на ваканцията";
            this.StartDateVacation.Name = "StartDateVacation";
            this.StartDateVacation.Width = 178;
            // 
            // EndDateVacation
            // 
            this.EndDateVacation.DataPropertyName = "vacation_end_date";
            this.EndDateVacation.HeaderText = "Крайна дата на ваканцията";
            this.EndDateVacation.Name = "EndDateVacation";
            this.EndDateVacation.Width = 172;
            // 
            // BuisinessTripStartDate
            // 
            this.BuisinessTripStartDate.DataPropertyName = "business_trip_start_date";
            this.BuisinessTripStartDate.HeaderText = "Начало на Командировка";
            this.BuisinessTripStartDate.Name = "BuisinessTripStartDate";
            this.BuisinessTripStartDate.Width = 162;
            // 
            // BuisinessTripEndDate
            // 
            this.BuisinessTripEndDate.DataPropertyName = "buisiness_trip_end_date";
            this.BuisinessTripEndDate.HeaderText = "Крайна дата командировка";
            this.BuisinessTripEndDate.Name = "BuisinessTripEndDate";
            this.BuisinessTripEndDate.Width = 172;
            // 
            // NotWantedColumn
            // 
            this.NotWantedColumn.DataPropertyName = "Teams";
            this.NotWantedColumn.HeaderText = "NotWantedColumn";
            this.NotWantedColumn.Name = "NotWantedColumn";
            this.NotWantedColumn.Visible = false;
            this.NotWantedColumn.Width = 127;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Beige;
            this.btn_back.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 42);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Обратно";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_employees
            // 
            this.lbl_employees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_employees.AutoSize = true;
            this.lbl_employees.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employees.ForeColor = System.Drawing.Color.Gold;
            this.lbl_employees.Location = new System.Drawing.Point(235, 43);
            this.lbl_employees.Name = "lbl_employees";
            this.lbl_employees.Size = new System.Drawing.Size(258, 42);
            this.lbl_employees.TabIndex = 2;
            this.lbl_employees.Text = "Пожарникари";
            this.lbl_employees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmployeesByCaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 512);
            this.Controls.Add(this.gradientPanelEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeesByCaseView";
            this.Text = "EmployeesByCase";
            this.Load += new System.EventHandler(this.EmployeesByCaseView_Load);
            this.gradientPanelEmployees.ResumeLayout(false);
            this.gradientPanelEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesByCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelEmployees;
        private System.Windows.Forms.DataGridView dgvEmployeesByCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfAnsweredCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChoosenTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateVacation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateVacation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuisinessTripStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuisinessTripEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotWantedColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_employees;
    }
}