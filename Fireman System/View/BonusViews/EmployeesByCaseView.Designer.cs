
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesByCaseView));
            this.gradientPanelEmployees = new Fireman_Systemn.GradientPanel();
            this.dgvEmployeesByCase = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_employees = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfAnsweredCases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChoosenTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotWantedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesByCase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployeesByCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeesByCase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.AmountOfAnsweredCases,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Rank,
            this.Age,
            this.ChoosenTeam,
            this.HomeAddress,
            this.PersonalPhoneNum,
            this.Email,
            this.NotWantedColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesByCase.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployeesByCase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvEmployeesByCase.Location = new System.Drawing.Point(172, 124);
            this.dgvEmployeesByCase.Name = "dgvEmployeesByCase";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesByCase.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployeesByCase.RowHeadersWidth = 20;
            this.dgvEmployeesByCase.Size = new System.Drawing.Size(538, 376);
            this.dgvEmployeesByCase.TabIndex = 16;
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
            this.lbl_employees.Location = new System.Drawing.Point(144, 51);
            this.lbl_employees.Name = "lbl_employees";
            this.lbl_employees.Size = new System.Drawing.Size(502, 42);
            this.lbl_employees.TabIndex = 2;
            this.lbl_employees.Text = "Класация по произшествия";
            this.lbl_employees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.HomeAddress.Visible = false;
            this.HomeAddress.Width = 114;
            // 
            // PersonalPhoneNum
            // 
            this.PersonalPhoneNum.DataPropertyName = "personal_phone_number";
            this.PersonalPhoneNum.HeaderText = "Личен телефон";
            this.PersonalPhoneNum.Name = "PersonalPhoneNum";
            this.PersonalPhoneNum.Visible = false;
            this.PersonalPhoneNum.Width = 109;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Имейл";
            this.Email.Name = "Email";
            this.Email.Visible = false;
            this.Email.Width = 66;
            // 
            // NotWantedColumn
            // 
            this.NotWantedColumn.DataPropertyName = "Teams";
            this.NotWantedColumn.HeaderText = "NotWantedColumn";
            this.NotWantedColumn.Name = "NotWantedColumn";
            this.NotWantedColumn.Visible = false;
            this.NotWantedColumn.Width = 127;
            // 
            // EmployeesByCaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 512);
            this.Controls.Add(this.gradientPanelEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeesByCaseView";
            this.Text = "Fireman System - Класация на произшествията за пожарникарите";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfAnsweredCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChoosenTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotWantedColumn;
    }
}