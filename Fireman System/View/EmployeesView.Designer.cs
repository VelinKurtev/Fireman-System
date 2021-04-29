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
            this.gradientPanelEmployees = new Fireman_Systemn.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_employees = new System.Windows.Forms.Label();
            this.gradientPanelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelEmployees
            // 
            this.gradientPanelEmployees.Angle = 0F;
            this.gradientPanelEmployees.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelEmployees.BottomColor = System.Drawing.Color.DarkRed;
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
            this.lbl_employees.Size = new System.Drawing.Size(223, 42);
            this.lbl_employees.TabIndex = 2;
            this.lbl_employees.Text = "Служители ";
            this.lbl_employees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Text = "Fireman System - Служители";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gradientPanelEmployees.ResumeLayout(false);
            this.gradientPanelEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_employees;
        private GradientPanel gradientPanelEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}