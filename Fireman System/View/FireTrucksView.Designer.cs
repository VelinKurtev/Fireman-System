namespace Fireman_Systemn.View
{
    partial class FireTrucksView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireTrucksView));
            this.gradientPanelFireTrucks = new Fireman_Systemn.GradientPanel();
            this.dgvFireTrucks = new System.Windows.Forms.DataGridView();
            this.btn_delete_fire_truck = new System.Windows.Forms.Button();
            this.btn_update_table = new System.Windows.Forms.Button();
            this.btn_add_fire_truck = new System.Windows.Forms.Button();
            this.lbl_Fire_Trucks = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.FireTruckID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnsweredCases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaterCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotWantedTeamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradientPanelFireTrucks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFireTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelFireTrucks
            // 
            this.gradientPanelFireTrucks.Angle = 0F;
            this.gradientPanelFireTrucks.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelFireTrucks.Controls.Add(this.dgvFireTrucks);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_delete_fire_truck);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_update_table);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_add_fire_truck);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_Fire_Trucks);
            this.gradientPanelFireTrucks.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_back);
            this.gradientPanelFireTrucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelFireTrucks.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanelFireTrucks.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelFireTrucks.Name = "gradientPanelFireTrucks";
            this.gradientPanelFireTrucks.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelFireTrucks.TabIndex = 6;
            this.gradientPanelFireTrucks.TopColor = System.Drawing.Color.Black;
            // 
            // dgvFireTrucks
            // 
            this.dgvFireTrucks.AllowUserToAddRows = false;
            this.dgvFireTrucks.AllowUserToDeleteRows = false;
            this.dgvFireTrucks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvFireTrucks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFireTrucks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFireTrucks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFireTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFireTrucks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FireTruckID,
            this.AnsweredCases,
            this.Model,
            this.WaterCapacity,
            this.AvailableWater,
            this.FuelCapacity,
            this.AvailableFuel,
            this.NotWantedTeamColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFireTrucks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFireTrucks.Location = new System.Drawing.Point(311, 124);
            this.dgvFireTrucks.Name = "dgvFireTrucks";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFireTrucks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFireTrucks.RowHeadersWidth = 20;
            this.dgvFireTrucks.Size = new System.Drawing.Size(538, 376);
            this.dgvFireTrucks.TabIndex = 12;
            // 
            // btn_delete_fire_truck
            // 
            this.btn_delete_fire_truck.BackColor = System.Drawing.Color.Beige;
            this.btn_delete_fire_truck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_fire_truck.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_fire_truck.Location = new System.Drawing.Point(36, 248);
            this.btn_delete_fire_truck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_fire_truck.Name = "btn_delete_fire_truck";
            this.btn_delete_fire_truck.Size = new System.Drawing.Size(259, 54);
            this.btn_delete_fire_truck.TabIndex = 15;
            this.btn_delete_fire_truck.Text = "Изтрий пожарен автомобил";
            this.btn_delete_fire_truck.UseVisualStyleBackColor = false;
            this.btn_delete_fire_truck.Click += new System.EventHandler(this.btn_delete_fire_truck_Click);
            // 
            // btn_update_table
            // 
            this.btn_update_table.BackColor = System.Drawing.Color.Beige;
            this.btn_update_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_table.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_table.Location = new System.Drawing.Point(36, 186);
            this.btn_update_table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update_table.Name = "btn_update_table";
            this.btn_update_table.Size = new System.Drawing.Size(259, 54);
            this.btn_update_table.TabIndex = 14;
            this.btn_update_table.Text = "Редактирай таблицата";
            this.btn_update_table.UseVisualStyleBackColor = false;
            this.btn_update_table.Click += new System.EventHandler(this.btn_update_table_Click);
            // 
            // btn_add_fire_truck
            // 
            this.btn_add_fire_truck.BackColor = System.Drawing.Color.Beige;
            this.btn_add_fire_truck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_fire_truck.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_fire_truck.Location = new System.Drawing.Point(36, 124);
            this.btn_add_fire_truck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_fire_truck.Name = "btn_add_fire_truck";
            this.btn_add_fire_truck.Size = new System.Drawing.Size(259, 54);
            this.btn_add_fire_truck.TabIndex = 13;
            this.btn_add_fire_truck.Text = "Добави пожарен автомобил";
            this.btn_add_fire_truck.UseVisualStyleBackColor = false;
            this.btn_add_fire_truck.Click += new System.EventHandler(this.btn_add_fire_truck_Click);
            // 
            // lbl_Fire_Trucks
            // 
            this.lbl_Fire_Trucks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Fire_Trucks.AutoSize = true;
            this.lbl_Fire_Trucks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fire_Trucks.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fire_Trucks.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Fire_Trucks.Location = new System.Drawing.Point(304, 43);
            this.lbl_Fire_Trucks.Name = "lbl_Fire_Trucks";
            this.lbl_Fire_Trucks.Size = new System.Drawing.Size(268, 42);
            this.lbl_Fire_Trucks.TabIndex = 2;
            this.lbl_Fire_Trucks.Text = "Пожарни коли";
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
            // FireTruckID
            // 
            this.FireTruckID.DataPropertyName = "fire_truck_id";
            this.FireTruckID.HeaderText = "ИД на пожарна";
            this.FireTruckID.Name = "FireTruckID";
            this.FireTruckID.Width = 111;
            // 
            // AnsweredCases
            // 
            this.AnsweredCases.DataPropertyName = "answered_cases";
            this.AnsweredCases.HeaderText = "Приети случаи";
            this.AnsweredCases.Name = "AnsweredCases";
            this.AnsweredCases.Width = 106;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "model";
            this.Model.HeaderText = "Марка";
            this.Model.Name = "Model";
            this.Model.Width = 65;
            // 
            // WaterCapacity
            // 
            this.WaterCapacity.DataPropertyName = "water_capacity";
            this.WaterCapacity.HeaderText = "Воден капацитет";
            this.WaterCapacity.Name = "WaterCapacity";
            this.WaterCapacity.Width = 118;
            // 
            // AvailableWater
            // 
            this.AvailableWater.DataPropertyName = "available_water";
            this.AvailableWater.HeaderText = "Налична вода";
            this.AvailableWater.Name = "AvailableWater";
            this.AvailableWater.Width = 102;
            // 
            // FuelCapacity
            // 
            this.FuelCapacity.DataPropertyName = "fuel_capacity";
            this.FuelCapacity.HeaderText = "Горивен капацитет";
            this.FuelCapacity.Name = "FuelCapacity";
            this.FuelCapacity.Width = 129;
            // 
            // AvailableFuel
            // 
            this.AvailableFuel.DataPropertyName = "available_fuel";
            this.AvailableFuel.HeaderText = "Налично гориво";
            this.AvailableFuel.Name = "AvailableFuel";
            this.AvailableFuel.Width = 113;
            // 
            // NotWantedTeamColumn
            // 
            this.NotWantedTeamColumn.DataPropertyName = "Teams";
            this.NotWantedTeamColumn.HeaderText = "NotWantedTeamColumn";
            this.NotWantedTeamColumn.Name = "NotWantedTeamColumn";
            this.NotWantedTeamColumn.Visible = false;
            this.NotWantedTeamColumn.Width = 152;
            // 
            // FireTrucksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelFireTrucks);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FireTrucksView";
            this.Text = "Fireman System - Пожарникарски автомобили";
            this.Load += new System.EventHandler(this.FireTrucks_Load);
            this.gradientPanelFireTrucks.ResumeLayout(false);
            this.gradientPanelFireTrucks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFireTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private GradientPanel gradientPanelFireTrucks;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lbl_Fire_Trucks;
        private System.Windows.Forms.Button btn_delete_fire_truck;
        private System.Windows.Forms.Button btn_update_table;
        private System.Windows.Forms.Button btn_add_fire_truck;
        private System.Windows.Forms.DataGridView dgvFireTrucks;
        private System.Windows.Forms.DataGridViewTextBoxColumn FireTruckID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnsweredCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaterCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableFuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotWantedTeamColumn;
    }
}