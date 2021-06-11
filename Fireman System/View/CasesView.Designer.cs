namespace Fireman_Systemn.View
{
    partial class CasesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasesView));
            this.gradientPanelCases = new Fireman_Systemn.GradientPanel();
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.CaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neighbohood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfTheCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DangerousSubstances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChosenTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartOfCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedWaterResources = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedOil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotWantedTeamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete_case = new System.Windows.Forms.Button();
            this.lbl_cases = new System.Windows.Forms.Label();
            this.btn_update_case = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btn_add_case = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.gradientPanelCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelCases
            // 
            this.gradientPanelCases.Angle = 0F;
            this.gradientPanelCases.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelCases.BottomColor = System.Drawing.Color.DarkRed;
            this.gradientPanelCases.Controls.Add(this.dgvCases);
            this.gradientPanelCases.Controls.Add(this.btn_delete_case);
            this.gradientPanelCases.Controls.Add(this.lbl_cases);
            this.gradientPanelCases.Controls.Add(this.btn_update_case);
            this.gradientPanelCases.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelCases.Controls.Add(this.btn_add_case);
            this.gradientPanelCases.Controls.Add(this.btn_back);
            this.gradientPanelCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelCases.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelCases.Name = "gradientPanelCases";
            this.gradientPanelCases.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelCases.TabIndex = 10;
            this.gradientPanelCases.TopColor = System.Drawing.Color.Black;
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseID,
            this.Town,
            this.Region,
            this.Street,
            this.Neighbohood,
            this.AddressNumber,
            this.Floor,
            this.Apartment,
            this.TypeOfTheCase,
            this.DangerousSubstances,
            this.ChosenTeam,
            this.StartOfCase,
            this.EndOfCase,
            this.UsedWaterResources,
            this.UsedOil,
            this.NotWantedTeamsColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvCases.Location = new System.Drawing.Point(311, 124);
            this.dgvCases.Name = "dgvCases";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCases.RowHeadersWidth = 20;
            this.dgvCases.Size = new System.Drawing.Size(538, 376);
            this.dgvCases.TabIndex = 12;
            // 
            // CaseID
            // 
            this.CaseID.DataPropertyName = "case_id";
            this.CaseID.HeaderText = "ИД на Случай";
            this.CaseID.Name = "CaseID";
            this.CaseID.Width = 102;
            // 
            // Town
            // 
            this.Town.DataPropertyName = "Town";
            this.Town.HeaderText = "Град";
            this.Town.Name = "Town";
            this.Town.Width = 56;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Област";
            this.Region.Name = "Region";
            this.Region.Width = 69;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Улица";
            this.Street.Name = "Street";
            this.Street.Width = 64;
            // 
            // Neighbohood
            // 
            this.Neighbohood.DataPropertyName = "Neighborhood";
            this.Neighbohood.HeaderText = "Квартал/Комплекс";
            this.Neighbohood.Name = "Neighbohood";
            this.Neighbohood.Width = 129;
            // 
            // AddressNumber
            // 
            this.AddressNumber.DataPropertyName = "Address_number";
            this.AddressNumber.HeaderText = "Номер на сграда";
            this.AddressNumber.Name = "AddressNumber";
            this.AddressNumber.Width = 119;
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Floor";
            this.Floor.HeaderText = "Етаж";
            this.Floor.Name = "Floor";
            this.Floor.Width = 58;
            // 
            // Apartment
            // 
            this.Apartment.DataPropertyName = "Apartment";
            this.Apartment.HeaderText = "Апартамент";
            this.Apartment.Name = "Apartment";
            this.Apartment.Width = 93;
            // 
            // TypeOfTheCase
            // 
            this.TypeOfTheCase.DataPropertyName = "Case_type";
            this.TypeOfTheCase.HeaderText = "Вид на произшествието";
            this.TypeOfTheCase.Name = "TypeOfTheCase";
            this.TypeOfTheCase.Width = 153;
            // 
            // DangerousSubstances
            // 
            this.DangerousSubstances.DataPropertyName = "Dangerous_substances_info";
            this.DangerousSubstances.HeaderText = "Опасни вещества";
            this.DangerousSubstances.Name = "DangerousSubstances";
            this.DangerousSubstances.Width = 123;
            // 
            // ChosenTeam
            // 
            this.ChosenTeam.DataPropertyName = "Selected_team";
            this.ChosenTeam.HeaderText = "Избран отбор";
            this.ChosenTeam.Name = "ChosenTeam";
            this.ChosenTeam.Width = 102;
            // 
            // StartOfCase
            // 
            this.StartOfCase.DataPropertyName = "Date_time_of_case";
            this.StartOfCase.HeaderText = "Начало на произшествието";
            this.StartOfCase.Name = "StartOfCase";
            this.StartOfCase.Width = 171;
            // 
            // EndOfCase
            // 
            this.EndOfCase.DataPropertyName = "End_date_time_of_case";
            this.EndOfCase.HeaderText = "Край на произшествието";
            this.EndOfCase.Name = "EndOfCase";
            this.EndOfCase.Width = 159;
            // 
            // UsedWaterResources
            // 
            this.UsedWaterResources.DataPropertyName = "Used_water_resources";
            this.UsedWaterResources.HeaderText = "Използвана вода";
            this.UsedWaterResources.Name = "UsedWaterResources";
            this.UsedWaterResources.Width = 121;
            // 
            // UsedOil
            // 
            this.UsedOil.DataPropertyName = "Used_fuel";
            this.UsedOil.HeaderText = "Използвано гориво";
            this.UsedOil.Name = "UsedOil";
            this.UsedOil.Width = 132;
            // 
            // NotWantedTeamsColumn
            // 
            this.NotWantedTeamsColumn.DataPropertyName = "Teams";
            this.NotWantedTeamsColumn.HeaderText = "NotWantedTeamsColumn";
            this.NotWantedTeamsColumn.Name = "NotWantedTeamsColumn";
            this.NotWantedTeamsColumn.Visible = false;
            this.NotWantedTeamsColumn.Width = 157;
            // 
            // btn_delete_case
            // 
            this.btn_delete_case.BackColor = System.Drawing.Color.Beige;
            this.btn_delete_case.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_case.Location = new System.Drawing.Point(36, 248);
            this.btn_delete_case.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_case.Name = "btn_delete_case";
            this.btn_delete_case.Size = new System.Drawing.Size(259, 54);
            this.btn_delete_case.TabIndex = 9;
            this.btn_delete_case.Text = "Изтрий произшествие";
            this.btn_delete_case.UseVisualStyleBackColor = false;
            this.btn_delete_case.Click += new System.EventHandler(this.btn_delete_case_Click);
            // 
            // lbl_cases
            // 
            this.lbl_cases.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_cases.AutoSize = true;
            this.lbl_cases.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cases.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cases.Location = new System.Drawing.Point(304, 43);
            this.lbl_cases.Name = "lbl_cases";
            this.lbl_cases.Size = new System.Drawing.Size(276, 42);
            this.lbl_cases.TabIndex = 2;
            this.lbl_cases.Text = "Произшествия";
            this.lbl_cases.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_update_case
            // 
            this.btn_update_case.BackColor = System.Drawing.Color.Beige;
            this.btn_update_case.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_case.Location = new System.Drawing.Point(36, 186);
            this.btn_update_case.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update_case.Name = "btn_update_case";
            this.btn_update_case.Size = new System.Drawing.Size(259, 54);
            this.btn_update_case.TabIndex = 8;
            this.btn_update_case.Text = "Редактирай произшествие";
            this.btn_update_case.UseVisualStyleBackColor = false;
            this.btn_update_case.Click += new System.EventHandler(this.btn_update_table_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 382);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(125, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btn_add_case
            // 
            this.btn_add_case.BackColor = System.Drawing.Color.Beige;
            this.btn_add_case.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_case.Location = new System.Drawing.Point(36, 124);
            this.btn_add_case.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_case.Name = "btn_add_case";
            this.btn_add_case.Size = new System.Drawing.Size(259, 54);
            this.btn_add_case.TabIndex = 0;
            this.btn_add_case.Text = "Добави произшествие";
            this.btn_add_case.UseVisualStyleBackColor = false;
            this.btn_add_case.Click += new System.EventHandler(this.btn_add_case_Click);
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
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CasesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelCases);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CasesView";
            this.Text = "Fireman System - Произшествия";
            this.Load += new System.EventHandler(this.Cases_Load);
            this.gradientPanelCases.ResumeLayout(false);
            this.gradientPanelCases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_cases;
        private System.Windows.Forms.Button btn_add_case;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btn_delete_case;
        private GradientPanel gradientPanelCases;
        private System.Windows.Forms.DataGridView dgvCases;
        private System.Windows.Forms.Button btn_update_case;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neighbohood;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfTheCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn DangerousSubstances;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChosenTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartOfCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedWaterResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedOil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotWantedTeamsColumn;
    }
}