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
            this.btn_view_teams_and_employees = new System.Windows.Forms.Button();
            this.btn_view_cases = new System.Windows.Forms.Button();
            this.lbl_main_menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_view_teams_and_employees
            // 
            this.btn_view_teams_and_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_view_teams_and_employees.Location = new System.Drawing.Point(89, 132);
            this.btn_view_teams_and_employees.Name = "btn_view_teams_and_employees";
            this.btn_view_teams_and_employees.Size = new System.Drawing.Size(113, 59);
            this.btn_view_teams_and_employees.TabIndex = 0;
            this.btn_view_teams_and_employees.Text = "Преглед на екипите и служителите";
            this.btn_view_teams_and_employees.UseVisualStyleBackColor = true;
            this.btn_view_teams_and_employees.Click += new System.EventHandler(this.btn_view_database_Click);
            // 
            // btn_view_cases
            // 
            this.btn_view_cases.Location = new System.Drawing.Point(89, 221);
            this.btn_view_cases.Name = "btn_view_cases";
            this.btn_view_cases.Size = new System.Drawing.Size(113, 48);
            this.btn_view_cases.TabIndex = 1;
            this.btn_view_cases.Text = "Преглед на произшествията";
            this.btn_view_cases.UseVisualStyleBackColor = true;
            // 
            // lbl_main_menu
            // 
            this.lbl_main_menu.AutoSize = true;
            this.lbl_main_menu.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_menu.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_main_menu.Location = new System.Drawing.Point(251, 44);
            this.lbl_main_menu.Name = "lbl_main_menu";
            this.lbl_main_menu.Size = new System.Drawing.Size(241, 41);
            this.lbl_main_menu.TabIndex = 2;
            this.lbl_main_menu.Text = "Главно меню";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.lbl_main_menu);
            this.Controls.Add(this.btn_view_cases);
            this.Controls.Add(this.btn_view_teams_and_employees);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Fireman System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view_teams_and_employees;
        private System.Windows.Forms.Button btn_view_cases;
        private System.Windows.Forms.Label lbl_main_menu;
    }
}

