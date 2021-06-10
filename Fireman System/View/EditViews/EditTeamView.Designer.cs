
namespace Fireman_Systemn.View.EditViews
{
    partial class EditTeamView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeamView));
            this.gradientPanelAddTeam = new Fireman_Systemn.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_edit_team = new System.Windows.Forms.Button();
            this.cb_buisiness = new System.Windows.Forms.ComboBox();
            this.lbl_buisiness = new System.Windows.Forms.Label();
            this.lbl_activity = new System.Windows.Forms.Label();
            this.cb_activity = new System.Windows.Forms.ComboBox();
            this.nud_employees_in_team = new System.Windows.Forms.NumericUpDown();
            this.lbl_employees_in_team = new System.Windows.Forms.Label();
            this.lbl_select_truck = new System.Windows.Forms.Label();
            this.cb_choosen_fireTruck = new System.Windows.Forms.ComboBox();
            this.txt_box_team_name = new System.Windows.Forms.TextBox();
            this.lbl_team_name = new System.Windows.Forms.Label();
            this.lbl_edit_team = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.gradientPanelAddTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_employees_in_team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelAddTeam
            // 
            this.gradientPanelAddTeam.Angle = 0F;
            this.gradientPanelAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanelAddTeam.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelAddTeam.Controls.Add(this.pictureBox1);
            this.gradientPanelAddTeam.Controls.Add(this.btn_edit_team);
            this.gradientPanelAddTeam.Controls.Add(this.cb_buisiness);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_buisiness);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_activity);
            this.gradientPanelAddTeam.Controls.Add(this.cb_activity);
            this.gradientPanelAddTeam.Controls.Add(this.nud_employees_in_team);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_employees_in_team);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_select_truck);
            this.gradientPanelAddTeam.Controls.Add(this.cb_choosen_fireTruck);
            this.gradientPanelAddTeam.Controls.Add(this.txt_box_team_name);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_team_name);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_edit_team);
            this.gradientPanelAddTeam.Controls.Add(this.btn_back);
            this.gradientPanelAddTeam.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelAddTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelAddTeam.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelAddTeam.Name = "gradientPanelAddTeam";
            this.gradientPanelAddTeam.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelAddTeam.TabIndex = 9;
            this.gradientPanelAddTeam.TopColor = System.Drawing.Color.Black;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(595, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btn_edit_team
            // 
            this.btn_edit_team.BackColor = System.Drawing.Color.Beige;
            this.btn_edit_team.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_edit_team.ForeColor = System.Drawing.Color.Black;
            this.btn_edit_team.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_edit_team.Location = new System.Drawing.Point(170, 441);
            this.btn_edit_team.Name = "btn_edit_team";
            this.btn_edit_team.Size = new System.Drawing.Size(574, 47);
            this.btn_edit_team.TabIndex = 40;
            this.btn_edit_team.Text = "Редактирай";
            this.btn_edit_team.UseVisualStyleBackColor = false;
            this.btn_edit_team.Click += new System.EventHandler(this.btn_edit_team_Click);
            // 
            // cb_buisiness
            // 
            this.cb_buisiness.BackColor = System.Drawing.Color.White;
            this.cb_buisiness.Font = new System.Drawing.Font("Candara", 9.75F);
            this.cb_buisiness.FormattingEnabled = true;
            this.cb_buisiness.Items.AddRange(new object[] {
            "Зает",
            "Свободен"});
            this.cb_buisiness.Location = new System.Drawing.Point(389, 218);
            this.cb_buisiness.Name = "cb_buisiness";
            this.cb_buisiness.Size = new System.Drawing.Size(168, 23);
            this.cb_buisiness.TabIndex = 39;
            // 
            // lbl_buisiness
            // 
            this.lbl_buisiness.AutoSize = true;
            this.lbl_buisiness.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buisiness.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_buisiness.ForeColor = System.Drawing.Color.Gold;
            this.lbl_buisiness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_buisiness.Location = new System.Drawing.Point(385, 192);
            this.lbl_buisiness.Name = "lbl_buisiness";
            this.lbl_buisiness.Size = new System.Drawing.Size(85, 23);
            this.lbl_buisiness.TabIndex = 38;
            this.lbl_buisiness.Text = "Заетост*";
            // 
            // lbl_activity
            // 
            this.lbl_activity.AutoSize = true;
            this.lbl_activity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_activity.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_activity.ForeColor = System.Drawing.Color.Gold;
            this.lbl_activity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_activity.Location = new System.Drawing.Point(385, 132);
            this.lbl_activity.Name = "lbl_activity";
            this.lbl_activity.Size = new System.Drawing.Size(102, 23);
            this.lbl_activity.TabIndex = 37;
            this.lbl_activity.Text = "Активност*";
            // 
            // cb_activity
            // 
            this.cb_activity.BackColor = System.Drawing.Color.White;
            this.cb_activity.Font = new System.Drawing.Font("Candara", 9.75F);
            this.cb_activity.FormattingEnabled = true;
            this.cb_activity.Items.AddRange(new object[] {
            "Активен",
            "Неактивен"});
            this.cb_activity.Location = new System.Drawing.Point(389, 158);
            this.cb_activity.Name = "cb_activity";
            this.cb_activity.Size = new System.Drawing.Size(168, 23);
            this.cb_activity.TabIndex = 36;
            // 
            // nud_employees_in_team
            // 
            this.nud_employees_in_team.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.nud_employees_in_team.Location = new System.Drawing.Point(186, 274);
            this.nud_employees_in_team.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_employees_in_team.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_employees_in_team.Name = "nud_employees_in_team";
            this.nud_employees_in_team.Size = new System.Drawing.Size(168, 23);
            this.nud_employees_in_team.TabIndex = 33;
            this.nud_employees_in_team.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_employees_in_team
            // 
            this.lbl_employees_in_team.AutoSize = true;
            this.lbl_employees_in_team.BackColor = System.Drawing.Color.Transparent;
            this.lbl_employees_in_team.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_employees_in_team.ForeColor = System.Drawing.Color.Gold;
            this.lbl_employees_in_team.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_employees_in_team.Location = new System.Drawing.Point(182, 248);
            this.lbl_employees_in_team.Name = "lbl_employees_in_team";
            this.lbl_employees_in_team.Size = new System.Drawing.Size(163, 23);
            this.lbl_employees_in_team.TabIndex = 32;
            this.lbl_employees_in_team.Text = "Служители в екип*";
            // 
            // lbl_select_truck
            // 
            this.lbl_select_truck.AutoSize = true;
            this.lbl_select_truck.BackColor = System.Drawing.Color.Transparent;
            this.lbl_select_truck.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_select_truck.ForeColor = System.Drawing.Color.Gold;
            this.lbl_select_truck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_select_truck.Location = new System.Drawing.Point(182, 188);
            this.lbl_select_truck.Name = "lbl_select_truck";
            this.lbl_select_truck.Size = new System.Drawing.Size(157, 23);
            this.lbl_select_truck.TabIndex = 31;
            this.lbl_select_truck.Text = "Избор на камион*";
            // 
            // cb_choosen_fireTruck
            // 
            this.cb_choosen_fireTruck.BackColor = System.Drawing.Color.White;
            this.cb_choosen_fireTruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_choosen_fireTruck.Font = new System.Drawing.Font("Rockwell", 9F);
            this.cb_choosen_fireTruck.FormattingEnabled = true;
            this.cb_choosen_fireTruck.Location = new System.Drawing.Point(186, 214);
            this.cb_choosen_fireTruck.Name = "cb_choosen_fireTruck";
            this.cb_choosen_fireTruck.Size = new System.Drawing.Size(168, 22);
            this.cb_choosen_fireTruck.TabIndex = 30;
            // 
            // txt_box_team_name
            // 
            this.txt_box_team_name.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.txt_box_team_name.Location = new System.Drawing.Point(186, 157);
            this.txt_box_team_name.Name = "txt_box_team_name";
            this.txt_box_team_name.Size = new System.Drawing.Size(168, 23);
            this.txt_box_team_name.TabIndex = 12;
            // 
            // lbl_team_name
            // 
            this.lbl_team_name.AutoSize = true;
            this.lbl_team_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_team_name.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_team_name.ForeColor = System.Drawing.Color.Gold;
            this.lbl_team_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_team_name.Location = new System.Drawing.Point(182, 130);
            this.lbl_team_name.Name = "lbl_team_name";
            this.lbl_team_name.Size = new System.Drawing.Size(118, 23);
            this.lbl_team_name.TabIndex = 11;
            this.lbl_team_name.Text = "Име на екип*";
            // 
            // lbl_edit_team
            // 
            this.lbl_edit_team.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_edit_team.AutoSize = true;
            this.lbl_edit_team.BackColor = System.Drawing.Color.Transparent;
            this.lbl_edit_team.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_edit_team.ForeColor = System.Drawing.Color.Gold;
            this.lbl_edit_team.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_edit_team.Location = new System.Drawing.Point(287, 45);
            this.lbl_edit_team.Name = "lbl_edit_team";
            this.lbl_edit_team.Size = new System.Drawing.Size(318, 42);
            this.lbl_edit_team.TabIndex = 9;
            this.lbl_edit_team.Text = "Редактирай екип";
            this.lbl_edit_team.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Beige;
            this.btn_back.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 42);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Обратно";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 382);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(125, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // EditTeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelAddTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTeamView";
            this.Text = "Fireman System - Редактирай екип";
            this.Load += new System.EventHandler(this.EditTeamView_Load);
            this.gradientPanelAddTeam.ResumeLayout(false);
            this.gradientPanelAddTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_employees_in_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelAddTeam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_edit_team;
        private System.Windows.Forms.ComboBox cb_buisiness;
        private System.Windows.Forms.Label lbl_buisiness;
        private System.Windows.Forms.Label lbl_activity;
        private System.Windows.Forms.ComboBox cb_activity;
        private System.Windows.Forms.NumericUpDown nud_employees_in_team;
        private System.Windows.Forms.Label lbl_employees_in_team;
        private System.Windows.Forms.Label lbl_select_truck;
        private System.Windows.Forms.ComboBox cb_choosen_fireTruck;
        private System.Windows.Forms.TextBox txt_box_team_name;
        private System.Windows.Forms.Label lbl_team_name;
        private System.Windows.Forms.Label lbl_edit_team;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}