namespace Fireman_Systemn.View
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_employees = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Fireman_Systemn.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_employees.AutoSize = true;
            this.lbl_employees.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employees.ForeColor = System.Drawing.Color.Gold;
            this.lbl_employees.Location = new System.Drawing.Point(248, 39);
            this.lbl_employees.Name = "lbl_employees";
            this.lbl_employees.Size = new System.Drawing.Size(223, 42);
            this.lbl_employees.TabIndex = 2;
            this.lbl_employees.Text = "Служители ";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.BottomColor = System.Drawing.Color.DarkRed;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.btn_back);
            this.gradientPanel1.Controls.Add(this.lbl_employees);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(748, 512);
            this.gradientPanel1.TabIndex = 5;
            this.gradientPanel1.TopColor = System.Drawing.Color.Black;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 170);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Employees";
            this.Text = "Fireman System - Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_employees;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}