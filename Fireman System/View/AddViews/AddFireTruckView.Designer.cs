
namespace Fireman_Systemn.View
{
    partial class AddFireTruckView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFireTruckView));
            this.gradientPanelFireTrucks = new Fireman_Systemn.GradientPanel();
            this.nud_fuel_capacity = new System.Windows.Forms.NumericUpDown();
            this.nud_available_fuel = new System.Windows.Forms.NumericUpDown();
            this.lbl_available_fuel = new System.Windows.Forms.Label();
            this.lbl_fuel_capacity = new System.Windows.Forms.Label();
            this.nud_available_water = new System.Windows.Forms.NumericUpDown();
            this.nud_water_capacity = new System.Windows.Forms.NumericUpDown();
            this.btn_submit_case = new System.Windows.Forms.Button();
            this.lbl_complex = new System.Windows.Forms.Label();
            this.lbl_town = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.txt_box_model = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbl_add_fire_truck = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanelFireTrucks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fuel_capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_available_fuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_available_water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_water_capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelFireTrucks
            // 
            this.gradientPanelFireTrucks.Angle = 0F;
            this.gradientPanelFireTrucks.BackColor = System.Drawing.Color.DarkRed;
            this.gradientPanelFireTrucks.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelFireTrucks.Controls.Add(this.nud_fuel_capacity);
            this.gradientPanelFireTrucks.Controls.Add(this.nud_available_fuel);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_available_fuel);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_fuel_capacity);
            this.gradientPanelFireTrucks.Controls.Add(this.nud_available_water);
            this.gradientPanelFireTrucks.Controls.Add(this.nud_water_capacity);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_submit_case);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_complex);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_town);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_model);
            this.gradientPanelFireTrucks.Controls.Add(this.txt_box_model);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_back);
            this.gradientPanelFireTrucks.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_add_fire_truck);
            this.gradientPanelFireTrucks.Controls.Add(this.pictureBox1);
            this.gradientPanelFireTrucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelFireTrucks.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelFireTrucks.Name = "gradientPanelFireTrucks";
            this.gradientPanelFireTrucks.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelFireTrucks.TabIndex = 8;
            this.gradientPanelFireTrucks.TopColor = System.Drawing.Color.Black;
            // 
            // nud_fuel_capacity
            // 
            this.nud_fuel_capacity.DecimalPlaces = 2;
            this.nud_fuel_capacity.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_fuel_capacity.Location = new System.Drawing.Point(406, 163);
            this.nud_fuel_capacity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_fuel_capacity.Name = "nud_fuel_capacity";
            this.nud_fuel_capacity.Size = new System.Drawing.Size(168, 23);
            this.nud_fuel_capacity.TabIndex = 50;
            // 
            // nud_available_fuel
            // 
            this.nud_available_fuel.DecimalPlaces = 2;
            this.nud_available_fuel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_available_fuel.Location = new System.Drawing.Point(405, 214);
            this.nud_available_fuel.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_available_fuel.Name = "nud_available_fuel";
            this.nud_available_fuel.Size = new System.Drawing.Size(168, 23);
            this.nud_available_fuel.TabIndex = 47;
            // 
            // lbl_available_fuel
            // 
            this.lbl_available_fuel.AutoSize = true;
            this.lbl_available_fuel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_available_fuel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_available_fuel.ForeColor = System.Drawing.Color.Gold;
            this.lbl_available_fuel.Location = new System.Drawing.Point(401, 188);
            this.lbl_available_fuel.Name = "lbl_available_fuel";
            this.lbl_available_fuel.Size = new System.Drawing.Size(188, 23);
            this.lbl_available_fuel.TabIndex = 44;
            this.lbl_available_fuel.Text = "Гориво в резервоара*";
            // 
            // lbl_fuel_capacity
            // 
            this.lbl_fuel_capacity.AutoSize = true;
            this.lbl_fuel_capacity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fuel_capacity.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fuel_capacity.ForeColor = System.Drawing.Color.Gold;
            this.lbl_fuel_capacity.Location = new System.Drawing.Point(400, 136);
            this.lbl_fuel_capacity.Name = "lbl_fuel_capacity";
            this.lbl_fuel_capacity.Size = new System.Drawing.Size(202, 23);
            this.lbl_fuel_capacity.TabIndex = 43;
            this.lbl_fuel_capacity.Text = "Капацитет на горивото*";
            // 
            // nud_available_water
            // 
            this.nud_available_water.DecimalPlaces = 2;
            this.nud_available_water.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_available_water.Location = new System.Drawing.Point(179, 269);
            this.nud_available_water.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_available_water.Name = "nud_available_water";
            this.nud_available_water.Size = new System.Drawing.Size(169, 23);
            this.nud_available_water.TabIndex = 41;
            // 
            // nud_water_capacity
            // 
            this.nud_water_capacity.DecimalPlaces = 2;
            this.nud_water_capacity.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_water_capacity.Location = new System.Drawing.Point(180, 214);
            this.nud_water_capacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_water_capacity.Name = "nud_water_capacity";
            this.nud_water_capacity.Size = new System.Drawing.Size(168, 23);
            this.nud_water_capacity.TabIndex = 39;
            // 
            // btn_submit_case
            // 
            this.btn_submit_case.BackColor = System.Drawing.Color.Beige;
            this.btn_submit_case.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit_case.ForeColor = System.Drawing.Color.Black;
            this.btn_submit_case.Location = new System.Drawing.Point(175, 453);
            this.btn_submit_case.Name = "btn_submit_case";
            this.btn_submit_case.Size = new System.Drawing.Size(590, 47);
            this.btn_submit_case.TabIndex = 35;
            this.btn_submit_case.Text = "Добави ";
            this.btn_submit_case.UseVisualStyleBackColor = false;
            this.btn_submit_case.Click += new System.EventHandler(this.btn_submit_case_Click);
            // 
            // lbl_complex
            // 
            this.lbl_complex.AutoSize = true;
            this.lbl_complex.BackColor = System.Drawing.Color.Transparent;
            this.lbl_complex.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complex.ForeColor = System.Drawing.Color.Gold;
            this.lbl_complex.Location = new System.Drawing.Point(175, 243);
            this.lbl_complex.Name = "lbl_complex";
            this.lbl_complex.Size = new System.Drawing.Size(168, 23);
            this.lbl_complex.TabIndex = 23;
            this.lbl_complex.Text = "Вода в цистерната*";
            // 
            // lbl_town
            // 
            this.lbl_town.AutoSize = true;
            this.lbl_town.BackColor = System.Drawing.Color.Transparent;
            this.lbl_town.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_town.ForeColor = System.Drawing.Color.Gold;
            this.lbl_town.Location = new System.Drawing.Point(176, 188);
            this.lbl_town.Name = "lbl_town";
            this.lbl_town.Size = new System.Drawing.Size(154, 23);
            this.lbl_town.TabIndex = 19;
            this.lbl_town.Text = "Воден капацитет*";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.BackColor = System.Drawing.Color.Transparent;
            this.lbl_model.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.ForeColor = System.Drawing.Color.Gold;
            this.lbl_model.Location = new System.Drawing.Point(176, 136);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(71, 23);
            this.lbl_model.TabIndex = 18;
            this.lbl_model.Text = "Марка*";
            // 
            // txt_box_model
            // 
            this.txt_box_model.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_model.Location = new System.Drawing.Point(179, 162);
            this.txt_box_model.Name = "txt_box_model";
            this.txt_box_model.Size = new System.Drawing.Size(168, 23);
            this.txt_box_model.TabIndex = 17;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Beige;
            this.btn_back.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 42);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Обратно";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 382);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(125, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lbl_add_fire_truck
            // 
            this.lbl_add_fire_truck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_add_fire_truck.AutoSize = true;
            this.lbl_add_fire_truck.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_fire_truck.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_fire_truck.ForeColor = System.Drawing.Color.Gold;
            this.lbl_add_fire_truck.Location = new System.Drawing.Point(258, 43);
            this.lbl_add_fire_truck.Name = "lbl_add_fire_truck";
            this.lbl_add_fire_truck.Size = new System.Drawing.Size(357, 42);
            this.lbl_add_fire_truck.TabIndex = 2;
            this.lbl_add_fire_truck.Text = "Добави Автомобил";
            this.lbl_add_fire_truck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // AddFireTruckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelFireTrucks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFireTruckView";
            this.Text = "Fireman System - Добави Автомобил";
            this.Load += new System.EventHandler(this.AddFireTruckView_Load);
            this.gradientPanelFireTrucks.ResumeLayout(false);
            this.gradientPanelFireTrucks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fuel_capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_available_fuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_available_water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_water_capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelFireTrucks;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lbl_add_fire_truck;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_complex;
        private System.Windows.Forms.Label lbl_town;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.TextBox txt_box_model;
        private System.Windows.Forms.Button btn_submit_case;
        private System.Windows.Forms.NumericUpDown nud_water_capacity;
        private System.Windows.Forms.NumericUpDown nud_available_water;
        private System.Windows.Forms.NumericUpDown nud_fuel_capacity;
        private System.Windows.Forms.NumericUpDown nud_available_fuel;
        private System.Windows.Forms.Label lbl_available_fuel;
        private System.Windows.Forms.Label lbl_fuel_capacity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}