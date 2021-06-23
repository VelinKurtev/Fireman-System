namespace Fireman_Systemn.View
{
    partial class EmployeesView
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

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientPanelEmployees = new Fireman_Systemn.GradientPanel();
            this.btn_firemen_by_case = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btn_add_employee = new System.Windows.Forms.Button();
            this.btn_delete_employee = new System.Windows.Forms.Button();
            this.btn_update_employee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_employees = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChoosenTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfAnsweredCases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotWantedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradientPanelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_firemen_by_case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelEmployees
            // 
            this.gradientPanelEmployees.Angle = 0F;
            this.gradientPanelEmployees.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelEmployees.BottomColor = System.Drawing.Color.DarkRed;
            this.gradientPanelEmployees.Controls.Add(this.btn_firemen_by_case);
            this.gradientPanelEmployees.Controls.Add(this.button1);
            this.gradientPanelEmployees.Controls.Add(this.dgvEmployees);
            this.gradientPanelEmployees.Controls.Add(this.btn_add_employee);
            this.gradientPanelEmployees.Controls.Add(this.btn_delete_employee);
            this.gradientPanelEmployees.Controls.Add(this.btn_update_employee);
            this.gradientPanelEmployees.Controls.Add(this.pictureBox1);
            this.gradientPanelEmployees.Controls.Add(this.btn_back);
            this.gradientPanelEmployees.Controls.Add(this.lbl_employees);
            this.gradientPanelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelEmployees.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelEmployees.Name = "gradientPanelEmployees";
            this.gradientPanelEmployees.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelEmployees.TabIndex = 5;
            this.gradientPanelEmployees.TopColor = System.Drawing.Color.Black;
            // 
            // btn_firemen_by_case
            // 
            this.btn_firemen_by_case.BackColor = System.Drawing.Color.White;
            this.btn_firemen_by_case.Image = ((System.Drawing.Image)(resources.GetObject("btn_firemen_by_case.Image")));
            this.btn_firemen_by_case.Location = new System.Drawing.Point(224, 418);
            this.btn_firemen_by_case.Name = "btn_firemen_by_case";
            this.btn_firemen_by_case.Size = new System.Drawing.Size(71, 70);
            this.btn_firemen_by_case.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_firemen_by_case.TabIndex = 17;
            this.btn_firemen_by_case.TabStop = false;
            this.btn_firemen_by_case.Click += new System.EventHandler(this.btn_firemen_by_case_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 87);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Rank,
            this.Age,
            this.ChoosenTeam,
            this.HomeAddress,
            this.PersonalPhoneNum,
            this.Email,
            this.AmountOfAnsweredCases,
            this.NotWantedColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvEmployees.Location = new System.Drawing.Point(311, 124);
            this.dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.RowHeadersWidth = 20;
            this.dgvEmployees.Size = new System.Drawing.Size(538, 376);
            this.dgvEmployees.TabIndex = 16;
            // 
            // btn_add_employee
            // 
            this.btn_add_employee.BackColor = System.Drawing.Color.Beige;
            this.btn_add_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_employee.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_employee.Location = new System.Drawing.Point(36, 124);
            this.btn_add_employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_employee.Name = "btn_add_employee";
            this.btn_add_employee.Size = new System.Drawing.Size(259, 54);
            this.btn_add_employee.TabIndex = 15;
            this.btn_add_employee.Text = "Добави пожарникар";
            this.btn_add_employee.UseVisualStyleBackColor = false;
            this.btn_add_employee.Click += new System.EventHandler(this.btn_add_employee_Click);
            // 
            // btn_delete_employee
            // 
            this.btn_delete_employee.BackColor = System.Drawing.Color.Beige;
            this.btn_delete_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_employee.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_employee.Location = new System.Drawing.Point(36, 248);
            this.btn_delete_employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_employee.Name = "btn_delete_employee";
            this.btn_delete_employee.Size = new System.Drawing.Size(259, 54);
            this.btn_delete_employee.TabIndex = 14;
            this.btn_delete_employee.Text = "Изтрий пожарникар";
            this.btn_delete_employee.UseVisualStyleBackColor = false;
            this.btn_delete_employee.Click += new System.EventHandler(this.btn_delete_employee_Click);
            // 
            // btn_update_employee
            // 
            this.btn_update_employee.BackColor = System.Drawing.Color.Beige;
            this.btn_update_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_employee.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_employee.Location = new System.Drawing.Point(36, 186);
            this.btn_update_employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update_employee.Name = "btn_update_employee";
            this.btn_update_employee.Size = new System.Drawing.Size(259, 54);
            this.btn_update_employee.TabIndex = 13;
            this.btn_update_employee.Text = "Редактирай пожарникар";
            this.btn_update_employee.UseVisualStyleBackColor = false;
            this.btn_update_employee.Click += new System.EventHandler(this.btn_update_employee_Click);
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
            this.lbl_employees.Location = new System.Drawing.Point(304, 43);
            this.lbl_employees.Name = "lbl_employees";
            this.lbl_employees.Size = new System.Drawing.Size(258, 42);
            this.lbl_employees.TabIndex = 2;
            this.lbl_employees.Text = "Пожарникари";
            this.lbl_employees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "employee_id";
            this.EmployeeID.HeaderText = "ИД на пожарникар";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 129;
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
            // Rank
            // 
            this.Rank.DataPropertyName = "rank";
            this.Rank.HeaderText = "Чин";
            this.Rank.Name = "Rank";
            this.Rank.Width = 52;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "age";
            this.Age.HeaderText = "Години";
            this.Age.Name = "Age";
            this.Age.Width = 68;
            // 
            // ChoosenTeam
            // 
            this.ChoosenTeam.DataPropertyName = "choosen_team";
            this.ChoosenTeam.HeaderText = "Избран отбор";
            this.ChoosenTeam.Name = "ChoosenTeam";
            this.ChoosenTeam.Width = 102;
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
            // AmountOfAnsweredCases
            // 
            this.AmountOfAnsweredCases.DataPropertyName = "number_of_answered_cases";
            this.AmountOfAnsweredCases.HeaderText = "Брой приети случаи";
            this.AmountOfAnsweredCases.Name = "AmountOfAnsweredCases";
            this.AmountOfAnsweredCases.Width = 132;
            // 
            // NotWantedColumn
            // 
            this.NotWantedColumn.DataPropertyName = "Teams";
            this.NotWantedColumn.HeaderText = "NotWantedColumn";
            this.NotWantedColumn.Name = "NotWantedColumn";
            this.NotWantedColumn.Visible = false;
            this.NotWantedColumn.Width = 127;
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelEmployees);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeesView";
            this.Text = "Fireman System - Пожарникари";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gradientPanelEmployees.ResumeLayout(false);
            this.gradientPanelEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_firemen_by_case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_employees;
        private GradientPanel gradientPanelEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_delete_employee;
        private System.Windows.Forms.Button btn_update_employee;
        private System.Windows.Forms.Button btn_add_employee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.PictureBox btn_firemen_by_case;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChoosenTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfAnsweredCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotWantedColumn;
    }
}