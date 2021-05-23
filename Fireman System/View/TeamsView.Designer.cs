namespace Fireman_Systemn.View
{
    partial class TeamsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsView));
            this.btn_back = new System.Windows.Forms.Button();
            this.gradientPanelFireTrucks = new Fireman_Systemn.GradientPanel();
            this.lbl_teams = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gradientPanelFireTrucks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
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
            // gradientPanelFireTrucks
            // 
            this.gradientPanelFireTrucks.Angle = 0F;
            this.gradientPanelFireTrucks.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelFireTrucks.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelFireTrucks.Controls.Add(this.lbl_teams);
            this.gradientPanelFireTrucks.Controls.Add(this.button1);
            this.gradientPanelFireTrucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelFireTrucks.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelFireTrucks.Name = "gradientPanelFireTrucks";
            this.gradientPanelFireTrucks.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelFireTrucks.TabIndex = 7;
            this.gradientPanelFireTrucks.TopColor = System.Drawing.Color.Black;
            // 
            // lbl_teams
            // 
            this.lbl_teams.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_teams.AutoSize = true;
            this.lbl_teams.BackColor = System.Drawing.Color.Transparent;
            this.lbl_teams.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teams.ForeColor = System.Drawing.Color.Gold;
            this.lbl_teams.Location = new System.Drawing.Point(366, 44);
            this.lbl_teams.Name = "lbl_teams";
            this.lbl_teams.Size = new System.Drawing.Size(125, 42);
            this.lbl_teams.TabIndex = 2;
            this.lbl_teams.Text = "Екипи";
            this.lbl_teams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            // 
            // TeamsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.gradientPanelFireTrucks);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeamsView";
            this.Text = "Fireman System - Екипи";
            this.Load += new System.EventHandler(this.Teams_and_Employees_Load);
            this.gradientPanelFireTrucks.ResumeLayout(false);
            this.gradientPanelFireTrucks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private GradientPanel gradientPanelFireTrucks;
        private System.Windows.Forms.Label lbl_teams;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button button1;
    }
}

