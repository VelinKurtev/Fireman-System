namespace Fireman_Systemn
{
    partial class Teams_and_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teams_and_Employees));
            this.lbl_teams_and_employees = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_teams_and_employees
            // 
            this.lbl_teams_and_employees.AutoSize = true;
            this.lbl_teams_and_employees.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teams_and_employees.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_teams_and_employees.Location = new System.Drawing.Point(198, 53);
            this.lbl_teams_and_employees.Name = "lbl_teams_and_employees";
            this.lbl_teams_and_employees.Size = new System.Drawing.Size(352, 41);
            this.lbl_teams_and_employees.TabIndex = 2;
            this.lbl_teams_and_employees.Text = "Екипи и Служители";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(12, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(113, 59);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Обратно";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Teams_and_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_teams_and_employees);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teams_and_Employees";
            this.Text = "Fireman System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_teams_and_employees;
        private System.Windows.Forms.Button btn_back;
    }
}

