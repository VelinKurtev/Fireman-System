namespace Fireman_Systemn
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lbl_main_menu = new System.Windows.Forms.Label();
            this.btn_view_teams = new System.Windows.Forms.Button();
            this.btn_view_cases = new System.Windows.Forms.Button();
            this.btn_view_firetrucks = new System.Windows.Forms.Button();
            this.btn_view_employees = new System.Windows.Forms.Button();
            this.btn_add_case = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_main_menu
            // 
            this.lbl_main_menu.AutoSize = true;
            this.lbl_main_menu.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_menu.ForeColor = System.Drawing.Color.Gold;
            this.lbl_main_menu.Location = new System.Drawing.Point(250, 40);
            this.lbl_main_menu.Name = "lbl_main_menu";
            this.lbl_main_menu.Size = new System.Drawing.Size(250, 42);
            this.lbl_main_menu.TabIndex = 2;
            this.lbl_main_menu.Text = "Главно меню";
            // 
            // btn_view_teams
            // 
            this.btn_view_teams.BackColor = System.Drawing.Color.Beige;
            this.btn_view_teams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_teams.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_teams.Location = new System.Drawing.Point(29, 126);
            this.btn_view_teams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view_teams.Name = "btn_view_teams";
            this.btn_view_teams.Size = new System.Drawing.Size(360, 52);
            this.btn_view_teams.TabIndex = 0;
            this.btn_view_teams.Text = "Преглед на екипите";
            this.btn_view_teams.UseVisualStyleBackColor = false;
            this.btn_view_teams.Click += new System.EventHandler(this.Btn_view_teams);
            // 
            // btn_view_cases
            // 
            this.btn_view_cases.BackColor = System.Drawing.Color.Beige;
            this.btn_view_cases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_cases.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_cases.Location = new System.Drawing.Point(29, 186);
            this.btn_view_cases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view_cases.Name = "btn_view_cases";
            this.btn_view_cases.Size = new System.Drawing.Size(360, 52);
            this.btn_view_cases.TabIndex = 1;
            this.btn_view_cases.Text = "Преглед на произшествията";
            this.btn_view_cases.UseVisualStyleBackColor = false;
            this.btn_view_cases.Click += new System.EventHandler(this.btn_view_cases_Click);
            // 
            // btn_view_firetrucks
            // 
            this.btn_view_firetrucks.BackColor = System.Drawing.Color.Beige;
            this.btn_view_firetrucks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_firetrucks.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_firetrucks.Location = new System.Drawing.Point(29, 247);
            this.btn_view_firetrucks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view_firetrucks.Name = "btn_view_firetrucks";
            this.btn_view_firetrucks.Size = new System.Drawing.Size(360, 52);
            this.btn_view_firetrucks.TabIndex = 3;
            this.btn_view_firetrucks.Text = "Преглед на автомобили";
            this.btn_view_firetrucks.UseVisualStyleBackColor = false;
            this.btn_view_firetrucks.Click += new System.EventHandler(this.btn_view_firetrucks_Click);
            // 
            // btn_view_employees
            // 
            this.btn_view_employees.BackColor = System.Drawing.Color.Beige;
            this.btn_view_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_employees.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_employees.Location = new System.Drawing.Point(29, 308);
            this.btn_view_employees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view_employees.Name = "btn_view_employees";
            this.btn_view_employees.Size = new System.Drawing.Size(360, 52);
            this.btn_view_employees.TabIndex = 4;
            this.btn_view_employees.Text = "Преглед на случжителите";
            this.btn_view_employees.UseVisualStyleBackColor = false;
            this.btn_view_employees.Click += new System.EventHandler(this.btn_view_employees_Click);
            // 
            // btn_add_case
            // 
            this.btn_add_case.BackColor = System.Drawing.Color.Beige;
            this.btn_add_case.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_case.Location = new System.Drawing.Point(29, 369);
            this.btn_add_case.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_case.Name = "btn_add_case";
            this.btn_add_case.Size = new System.Drawing.Size(360, 52);
            this.btn_add_case.TabIndex = 5;
            this.btn_add_case.Text = "Добави произшествие";
            this.btn_add_case.UseVisualStyleBackColor = false;
            this.btn_add_case.Click += new System.EventHandler(this.btn_add_case_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_add_case);
            this.Controls.Add(this.btn_view_employees);
            this.Controls.Add(this.btn_view_firetrucks);
            this.Controls.Add(this.btn_view_cases);
            this.Controls.Add(this.lbl_main_menu);
            this.Controls.Add(this.btn_view_teams);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Fireman System";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_main_menu;
        private System.Windows.Forms.Button btn_view_teams;
        private System.Windows.Forms.Button btn_view_cases;
        private System.Windows.Forms.Button btn_view_firetrucks;
        private System.Windows.Forms.Button btn_view_employees;
        private System.Windows.Forms.Button btn_add_case;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

