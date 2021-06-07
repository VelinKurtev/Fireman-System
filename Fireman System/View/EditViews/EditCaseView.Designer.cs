using System;

namespace Fireman_Systemn.View.EditViews
{
    partial class EditCaseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCaseView));
            this.gradientPanelAddCase = new Fireman_Systemn.GradientPanel();
            this.gradientPanelAddCases = new Fireman_Systemn.GradientPanel();
            this.nud_used_fuel = new System.Windows.Forms.NumericUpDown();
            this.lbl_used_fuel = new System.Windows.Forms.Label();
            this.nud_floor = new System.Windows.Forms.NumericUpDown();
            this.nup_Apartment = new System.Windows.Forms.NumericUpDown();
            this.lbl_used_water_resources = new System.Windows.Forms.Label();
            this.nud_Used_water_resources = new System.Windows.Forms.NumericUpDown();
            this.btn_submit_case = new System.Windows.Forms.Button();
            this.end_date_case_time_picker = new System.Windows.Forms.DateTimePicker();
            this.lbl_end_date_of_case = new System.Windows.Forms.Label();
            this.start_date_case_time_picker = new System.Windows.Forms.DateTimePicker();
            this.lbl_start_date_of_Case = new System.Windows.Forms.Label();
            this.cb_choosen_team = new System.Windows.Forms.ComboBox();
            this.lbl_chose_team = new System.Windows.Forms.Label();
            this.txt_box_dangerous_substances = new System.Windows.Forms.TextBox();
            this.lbl_dangerous_substances = new System.Windows.Forms.Label();
            this.txt_box_type_of_case = new System.Windows.Forms.TextBox();
            this.lbl_type_of_case = new System.Windows.Forms.Label();
            this.lbl_apartment = new System.Windows.Forms.Label();
            this.lbl_floor = new System.Windows.Forms.Label();
            this.lbl_building_number = new System.Windows.Forms.Label();
            this.nud_building_number = new System.Windows.Forms.NumericUpDown();
            this.txt_box_complex = new System.Windows.Forms.TextBox();
            this.lbl_complex = new System.Windows.Forms.Label();
            this.txt_box_street = new System.Windows.Forms.TextBox();
            this.lbl_street = new System.Windows.Forms.Label();
            this.txt_box_town = new System.Windows.Forms.TextBox();
            this.lbl_town = new System.Windows.Forms.Label();
            this.lbl_region = new System.Windows.Forms.Label();
            this.txt_box_region = new System.Windows.Forms.TextBox();
            this.lbl_add_cases = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_add_case = new System.Windows.Forms.Label();
            this.gradientPanelAddCase.SuspendLayout();
            this.gradientPanelAddCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_used_fuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Apartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Used_water_resources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_building_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelAddCase
            // 
            this.gradientPanelAddCase.Angle = 0F;
            this.gradientPanelAddCase.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelAddCase.Controls.Add(this.gradientPanelAddCases);
            this.gradientPanelAddCase.Controls.Add(this.textBox1);
            this.gradientPanelAddCase.Controls.Add(this.lbl_add_case);
            this.gradientPanelAddCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelAddCase.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelAddCase.Name = "gradientPanelAddCase";
            this.gradientPanelAddCase.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelAddCase.TabIndex = 5;
            this.gradientPanelAddCase.TopColor = System.Drawing.Color.Black;
            // 
            // gradientPanelAddCases
            // 
            this.gradientPanelAddCases.Angle = 0F;
            this.gradientPanelAddCases.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelAddCases.Controls.Add(this.nud_used_fuel);
            this.gradientPanelAddCases.Controls.Add(this.lbl_used_fuel);
            this.gradientPanelAddCases.Controls.Add(this.nud_floor);
            this.gradientPanelAddCases.Controls.Add(this.nup_Apartment);
            this.gradientPanelAddCases.Controls.Add(this.lbl_used_water_resources);
            this.gradientPanelAddCases.Controls.Add(this.nud_Used_water_resources);
            this.gradientPanelAddCases.Controls.Add(this.btn_submit_case);
            this.gradientPanelAddCases.Controls.Add(this.end_date_case_time_picker);
            this.gradientPanelAddCases.Controls.Add(this.lbl_end_date_of_case);
            this.gradientPanelAddCases.Controls.Add(this.start_date_case_time_picker);
            this.gradientPanelAddCases.Controls.Add(this.lbl_start_date_of_Case);
            this.gradientPanelAddCases.Controls.Add(this.cb_choosen_team);
            this.gradientPanelAddCases.Controls.Add(this.lbl_chose_team);
            this.gradientPanelAddCases.Controls.Add(this.txt_box_dangerous_substances);
            this.gradientPanelAddCases.Controls.Add(this.lbl_dangerous_substances);
            this.gradientPanelAddCases.Controls.Add(this.txt_box_type_of_case);
            this.gradientPanelAddCases.Controls.Add(this.lbl_type_of_case);
            this.gradientPanelAddCases.Controls.Add(this.lbl_apartment);
            this.gradientPanelAddCases.Controls.Add(this.lbl_floor);
            this.gradientPanelAddCases.Controls.Add(this.lbl_building_number);
            this.gradientPanelAddCases.Controls.Add(this.nud_building_number);
            this.gradientPanelAddCases.Controls.Add(this.txt_box_complex);
            this.gradientPanelAddCases.Controls.Add(this.lbl_complex);
            this.gradientPanelAddCases.Controls.Add(this.txt_box_street);
            this.gradientPanelAddCases.Controls.Add(this.lbl_street);
            this.gradientPanelAddCases.Controls.Add(this.txt_box_town);
            this.gradientPanelAddCases.Controls.Add(this.lbl_town);
            this.gradientPanelAddCases.Controls.Add(this.lbl_region);
            this.gradientPanelAddCases.Controls.Add(this.txt_box_region);
            this.gradientPanelAddCases.Controls.Add(this.lbl_add_cases);
            this.gradientPanelAddCases.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelAddCases.Controls.Add(this.btn_back);
            this.gradientPanelAddCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelAddCases.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelAddCases.Name = "gradientPanelAddCases";
            this.gradientPanelAddCases.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelAddCases.TabIndex = 23;
            this.gradientPanelAddCases.TopColor = System.Drawing.Color.Black;
            // 
            // nud_used_fuel
            // 
            this.nud_used_fuel.DecimalPlaces = 2;
            this.nud_used_fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_used_fuel.Location = new System.Drawing.Point(576, 183);
            this.nud_used_fuel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_used_fuel.Name = "nud_used_fuel";
            this.nud_used_fuel.Size = new System.Drawing.Size(168, 22);
            this.nud_used_fuel.TabIndex = 40;
            // 
            // lbl_used_fuel
            // 
            this.lbl_used_fuel.AutoSize = true;
            this.lbl_used_fuel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_used_fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_used_fuel.ForeColor = System.Drawing.Color.Gold;
            this.lbl_used_fuel.Location = new System.Drawing.Point(572, 157);
            this.lbl_used_fuel.Name = "lbl_used_fuel";
            this.lbl_used_fuel.Size = new System.Drawing.Size(204, 24);
            this.lbl_used_fuel.TabIndex = 39;
            this.lbl_used_fuel.Text = "Използвано гориво";
            // 
            // nud_floor
            // 
            this.nud_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_floor.Location = new System.Drawing.Point(170, 394);
            this.nud_floor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_floor.Name = "nud_floor";
            this.nud_floor.Size = new System.Drawing.Size(168, 22);
            this.nud_floor.TabIndex = 38;
            // 
            // nup_Apartment
            // 
            this.nup_Apartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_Apartment.Location = new System.Drawing.Point(361, 130);
            this.nup_Apartment.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup_Apartment.Name = "nup_Apartment";
            this.nup_Apartment.Size = new System.Drawing.Size(168, 22);
            this.nup_Apartment.TabIndex = 37;
            // 
            // lbl_used_water_resources
            // 
            this.lbl_used_water_resources.AutoSize = true;
            this.lbl_used_water_resources.BackColor = System.Drawing.Color.Transparent;
            this.lbl_used_water_resources.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_used_water_resources.ForeColor = System.Drawing.Color.Gold;
            this.lbl_used_water_resources.Location = new System.Drawing.Point(572, 105);
            this.lbl_used_water_resources.Name = "lbl_used_water_resources";
            this.lbl_used_water_resources.Size = new System.Drawing.Size(281, 24);
            this.lbl_used_water_resources.TabIndex = 36;
            this.lbl_used_water_resources.Text = "Използвани водни ресурси";
            // 
            // nud_Used_water_resources
            // 
            this.nud_Used_water_resources.DecimalPlaces = 2;
            this.nud_Used_water_resources.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Used_water_resources.Location = new System.Drawing.Point(576, 131);
            this.nud_Used_water_resources.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Used_water_resources.Name = "nud_Used_water_resources";
            this.nud_Used_water_resources.Size = new System.Drawing.Size(168, 22);
            this.nud_Used_water_resources.TabIndex = 35;
            this.nud_Used_water_resources.Tag = "";
            // 
            // btn_submit_case
            // 
            this.btn_submit_case.BackColor = System.Drawing.Color.Beige;
            this.btn_submit_case.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit_case.ForeColor = System.Drawing.Color.Black;
            this.btn_submit_case.Location = new System.Drawing.Point(170, 441);
            this.btn_submit_case.Name = "btn_submit_case";
            this.btn_submit_case.Size = new System.Drawing.Size(574, 47);
            this.btn_submit_case.TabIndex = 34;
            this.btn_submit_case.Text = "Редактирай";
            this.btn_submit_case.UseVisualStyleBackColor = false;
            this.btn_submit_case.Click += new System.EventHandler(this.btn_edit_case_Click);
            // 
            // end_date_case_time_picker
            // 
            this.end_date_case_time_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_case_time_picker.CustomFormat = "dd MMMM yyyy HH:mm";
            this.end_date_case_time_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_case_time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date_case_time_picker.Location = new System.Drawing.Point(361, 390);
            this.end_date_case_time_picker.Name = "end_date_case_time_picker";
            this.end_date_case_time_picker.Size = new System.Drawing.Size(167, 20);
            this.end_date_case_time_picker.TabIndex = 33;
            this.end_date_case_time_picker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_end_date_of_case
            // 
            this.lbl_end_date_of_case.AutoSize = true;
            this.lbl_end_date_of_case.BackColor = System.Drawing.Color.Transparent;
            this.lbl_end_date_of_case.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end_date_of_case.ForeColor = System.Drawing.Color.Gold;
            this.lbl_end_date_of_case.Location = new System.Drawing.Point(357, 364);
            this.lbl_end_date_of_case.Name = "lbl_end_date_of_case";
            this.lbl_end_date_of_case.Size = new System.Drawing.Size(268, 24);
            this.lbl_end_date_of_case.TabIndex = 32;
            this.lbl_end_date_of_case.Text = "Край на произшествието*";
            // 
            // start_date_case_time_picker
            // 
            this.start_date_case_time_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_case_time_picker.CustomFormat = "dd MMMM yyyy HH:mm";
            this.start_date_case_time_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_case_time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date_case_time_picker.Location = new System.Drawing.Point(361, 338);
            this.start_date_case_time_picker.Name = "start_date_case_time_picker";
            this.start_date_case_time_picker.Size = new System.Drawing.Size(167, 20);
            this.start_date_case_time_picker.TabIndex = 31;
            this.start_date_case_time_picker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_start_date_of_Case
            // 
            this.lbl_start_date_of_Case.AutoSize = true;
            this.lbl_start_date_of_Case.BackColor = System.Drawing.Color.Transparent;
            this.lbl_start_date_of_Case.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start_date_of_Case.ForeColor = System.Drawing.Color.Gold;
            this.lbl_start_date_of_Case.Location = new System.Drawing.Point(357, 314);
            this.lbl_start_date_of_Case.Name = "lbl_start_date_of_Case";
            this.lbl_start_date_of_Case.Size = new System.Drawing.Size(290, 24);
            this.lbl_start_date_of_Case.TabIndex = 30;
            this.lbl_start_date_of_Case.Text = "Начало на произшествието*";
            // 
            // cb_choosen_team
            // 
            this.cb_choosen_team.BackColor = System.Drawing.Color.White;
            this.cb_choosen_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_choosen_team.FormattingEnabled = true;
            this.cb_choosen_team.Location = new System.Drawing.Point(361, 287);
            this.cb_choosen_team.Name = "cb_choosen_team";
            this.cb_choosen_team.Size = new System.Drawing.Size(167, 23);
            this.cb_choosen_team.TabIndex = 29;
            // 
            // lbl_chose_team
            // 
            this.lbl_chose_team.AutoSize = true;
            this.lbl_chose_team.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chose_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chose_team.ForeColor = System.Drawing.Color.Gold;
            this.lbl_chose_team.Location = new System.Drawing.Point(357, 261);
            this.lbl_chose_team.Name = "lbl_chose_team";
            this.lbl_chose_team.Size = new System.Drawing.Size(155, 24);
            this.lbl_chose_team.TabIndex = 28;
            this.lbl_chose_team.Text = "Избран отбор*";
            // 
            // txt_box_dangerous_substances
            // 
            this.txt_box_dangerous_substances.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_dangerous_substances.Location = new System.Drawing.Point(361, 234);
            this.txt_box_dangerous_substances.Name = "txt_box_dangerous_substances";
            this.txt_box_dangerous_substances.Size = new System.Drawing.Size(167, 22);
            this.txt_box_dangerous_substances.TabIndex = 26;
            this.txt_box_dangerous_substances.Text = "Няма";
            // 
            // lbl_dangerous_substances
            // 
            this.lbl_dangerous_substances.AutoSize = true;
            this.lbl_dangerous_substances.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dangerous_substances.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangerous_substances.ForeColor = System.Drawing.Color.Gold;
            this.lbl_dangerous_substances.Location = new System.Drawing.Point(357, 208);
            this.lbl_dangerous_substances.Name = "lbl_dangerous_substances";
            this.lbl_dangerous_substances.Size = new System.Drawing.Size(185, 24);
            this.lbl_dangerous_substances.TabIndex = 25;
            this.lbl_dangerous_substances.Text = "Опасни вещества";
            // 
            // txt_box_type_of_case
            // 
            this.txt_box_type_of_case.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_type_of_case.Location = new System.Drawing.Point(361, 182);
            this.txt_box_type_of_case.Name = "txt_box_type_of_case";
            this.txt_box_type_of_case.Size = new System.Drawing.Size(167, 22);
            this.txt_box_type_of_case.TabIndex = 24;
            // 
            // lbl_type_of_case
            // 
            this.lbl_type_of_case.AutoSize = true;
            this.lbl_type_of_case.BackColor = System.Drawing.Color.Transparent;
            this.lbl_type_of_case.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type_of_case.ForeColor = System.Drawing.Color.Gold;
            this.lbl_type_of_case.Location = new System.Drawing.Point(357, 157);
            this.lbl_type_of_case.Name = "lbl_type_of_case";
            this.lbl_type_of_case.Size = new System.Drawing.Size(260, 24);
            this.lbl_type_of_case.TabIndex = 23;
            this.lbl_type_of_case.Text = "Вид на Произшествието*";
            // 
            // lbl_apartment
            // 
            this.lbl_apartment.AutoSize = true;
            this.lbl_apartment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apartment.ForeColor = System.Drawing.Color.Gold;
            this.lbl_apartment.Location = new System.Drawing.Point(357, 104);
            this.lbl_apartment.Name = "lbl_apartment";
            this.lbl_apartment.Size = new System.Drawing.Size(130, 24);
            this.lbl_apartment.TabIndex = 21;
            this.lbl_apartment.Text = "Апартамент";
            // 
            // lbl_floor
            // 
            this.lbl_floor.AutoSize = true;
            this.lbl_floor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_floor.ForeColor = System.Drawing.Color.Gold;
            this.lbl_floor.Location = new System.Drawing.Point(167, 365);
            this.lbl_floor.Name = "lbl_floor";
            this.lbl_floor.Size = new System.Drawing.Size(61, 24);
            this.lbl_floor.TabIndex = 19;
            this.lbl_floor.Text = "Етаж";
            // 
            // lbl_building_number
            // 
            this.lbl_building_number.AutoSize = true;
            this.lbl_building_number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_building_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_building_number.ForeColor = System.Drawing.Color.Gold;
            this.lbl_building_number.Location = new System.Drawing.Point(167, 313);
            this.lbl_building_number.Name = "lbl_building_number";
            this.lbl_building_number.Size = new System.Drawing.Size(185, 24);
            this.lbl_building_number.TabIndex = 18;
            this.lbl_building_number.Text = "Номер на сграда*";
            // 
            // nud_building_number
            // 
            this.nud_building_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_building_number.Location = new System.Drawing.Point(170, 339);
            this.nud_building_number.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_building_number.Name = "nud_building_number";
            this.nud_building_number.Size = new System.Drawing.Size(168, 22);
            this.nud_building_number.TabIndex = 17;
            this.nud_building_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_box_complex
            // 
            this.txt_box_complex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_complex.Location = new System.Drawing.Point(171, 287);
            this.txt_box_complex.Name = "txt_box_complex";
            this.txt_box_complex.Size = new System.Drawing.Size(167, 22);
            this.txt_box_complex.TabIndex = 16;
            // 
            // lbl_complex
            // 
            this.lbl_complex.AutoSize = true;
            this.lbl_complex.BackColor = System.Drawing.Color.Transparent;
            this.lbl_complex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complex.ForeColor = System.Drawing.Color.Gold;
            this.lbl_complex.Location = new System.Drawing.Point(167, 261);
            this.lbl_complex.Name = "lbl_complex";
            this.lbl_complex.Size = new System.Drawing.Size(192, 24);
            this.lbl_complex.TabIndex = 15;
            this.lbl_complex.Text = "Квартал/Комплекс";
            // 
            // txt_box_street
            // 
            this.txt_box_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_street.Location = new System.Drawing.Point(170, 235);
            this.txt_box_street.Name = "txt_box_street";
            this.txt_box_street.Size = new System.Drawing.Size(168, 22);
            this.txt_box_street.TabIndex = 14;
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.BackColor = System.Drawing.Color.Transparent;
            this.lbl_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_street.ForeColor = System.Drawing.Color.Gold;
            this.lbl_street.Location = new System.Drawing.Point(167, 209);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(77, 24);
            this.lbl_street.TabIndex = 13;
            this.lbl_street.Text = "Улица*";
            // 
            // txt_box_town
            // 
            this.txt_box_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_town.Location = new System.Drawing.Point(170, 183);
            this.txt_box_town.Name = "txt_box_town";
            this.txt_box_town.Size = new System.Drawing.Size(168, 22);
            this.txt_box_town.TabIndex = 12;
            // 
            // lbl_town
            // 
            this.lbl_town.AutoSize = true;
            this.lbl_town.BackColor = System.Drawing.Color.Transparent;
            this.lbl_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_town.ForeColor = System.Drawing.Color.Gold;
            this.lbl_town.Location = new System.Drawing.Point(167, 157);
            this.lbl_town.Name = "lbl_town";
            this.lbl_town.Size = new System.Drawing.Size(66, 24);
            this.lbl_town.TabIndex = 11;
            this.lbl_town.Text = "Град*";
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.BackColor = System.Drawing.Color.Transparent;
            this.lbl_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_region.ForeColor = System.Drawing.Color.Gold;
            this.lbl_region.Location = new System.Drawing.Point(167, 105);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(90, 24);
            this.lbl_region.TabIndex = 10;
            this.lbl_region.Text = "Област*";
            // 
            // txt_box_region
            // 
            this.txt_box_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_region.Location = new System.Drawing.Point(170, 131);
            this.txt_box_region.Name = "txt_box_region";
            this.txt_box_region.Size = new System.Drawing.Size(168, 22);
            this.txt_box_region.TabIndex = 9;
            // 
            // lbl_add_cases
            // 
            this.lbl_add_cases.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_add_cases.AutoSize = true;
            this.lbl_add_cases.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_cases.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_cases.ForeColor = System.Drawing.Color.Gold;
            this.lbl_add_cases.Location = new System.Drawing.Point(239, 43);
            this.lbl_add_cases.Name = "lbl_add_cases";
            this.lbl_add_cases.Size = new System.Drawing.Size(488, 42);
            this.lbl_add_cases.TabIndex = 2;
            this.lbl_add_cases.Text = "Редактирай произшествие";
            this.lbl_add_cases.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 382);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(125, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(399, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 22;
            // 
            // lbl_add_case
            // 
            this.lbl_add_case.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_add_case.AutoSize = true;
            this.lbl_add_case.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_case.ForeColor = System.Drawing.Color.Gold;
            this.lbl_add_case.Location = new System.Drawing.Point(239, 43);
            this.lbl_add_case.Name = "lbl_add_case";
            this.lbl_add_case.Size = new System.Drawing.Size(413, 42);
            this.lbl_add_case.TabIndex = 2;
            this.lbl_add_case.Text = "Добави произшествие";
            this.lbl_add_case.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditCaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelAddCase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditCaseView";
            this.Text = "Fireman System - Редактирай произшествие";
            this.Load += new System.EventHandler(this.Edit_Case_Load);
            this.gradientPanelAddCase.ResumeLayout(false);
            this.gradientPanelAddCase.PerformLayout();
            this.gradientPanelAddCases.ResumeLayout(false);
            this.gradientPanelAddCases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_used_fuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Apartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Used_water_resources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_building_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private GradientPanel gradientPanelAddCase;
        private System.Windows.Forms.Label lbl_add_case;
        private GradientPanel gradientPanelAddCases;
        private System.Windows.Forms.Label lbl_add_cases;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_submit_case;
        private System.Windows.Forms.NumericUpDown nud_used_fuel;
        private System.Windows.Forms.Label lbl_used_fuel;
        private System.Windows.Forms.NumericUpDown nud_floor;
        private System.Windows.Forms.NumericUpDown nup_Apartment;
        private System.Windows.Forms.Label lbl_used_water_resources;
        private System.Windows.Forms.NumericUpDown nud_Used_water_resources;
        private System.Windows.Forms.DateTimePicker end_date_case_time_picker;
        private System.Windows.Forms.Label lbl_end_date_of_case;
        private System.Windows.Forms.DateTimePicker start_date_case_time_picker;
        private System.Windows.Forms.Label lbl_start_date_of_Case;
        private System.Windows.Forms.ComboBox cb_choosen_team;
        private System.Windows.Forms.Label lbl_chose_team;
        private System.Windows.Forms.TextBox txt_box_dangerous_substances;
        private System.Windows.Forms.Label lbl_dangerous_substances;
        private System.Windows.Forms.TextBox txt_box_type_of_case;
        private System.Windows.Forms.Label lbl_type_of_case;
        private System.Windows.Forms.Label lbl_apartment;
        private System.Windows.Forms.Label lbl_floor;
        private System.Windows.Forms.Label lbl_building_number;
        private System.Windows.Forms.NumericUpDown nud_building_number;
        private System.Windows.Forms.TextBox txt_box_complex;
        private System.Windows.Forms.Label lbl_complex;
        private System.Windows.Forms.TextBox txt_box_street;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.TextBox txt_box_town;
        private System.Windows.Forms.Label lbl_town;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.TextBox txt_box_region;
    }
}
