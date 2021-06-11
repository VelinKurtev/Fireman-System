
using System.Globalization;

namespace Fireman_Systemn.View.AddViews
{
    partial class AddTeamView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeamView));
            this.gradientPanelAddTeam = new Fireman_Systemn.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_submit_team = new System.Windows.Forms.Button();
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
            this.lbl_add_team = new System.Windows.Forms.Label();
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
            this.gradientPanelAddTeam.Controls.Add(this.btn_submit_team);
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
            this.gradientPanelAddTeam.Controls.Add(this.lbl_add_team);
            this.gradientPanelAddTeam.Controls.Add(this.btn_back);
            this.gradientPanelAddTeam.Controls.Add(this.pictureBoxLogo);
            resources.ApplyResources(this.gradientPanelAddTeam, "gradientPanelAddTeam");
            this.gradientPanelAddTeam.Name = "gradientPanelAddTeam";
            this.gradientPanelAddTeam.TopColor = System.Drawing.Color.Black;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_submit_team
            // 
            this.btn_submit_team.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_submit_team, "btn_submit_team");
            this.btn_submit_team.ForeColor = System.Drawing.Color.Black;
            this.btn_submit_team.Name = "btn_submit_team";
            this.btn_submit_team.UseVisualStyleBackColor = false;
            this.btn_submit_team.Click += new System.EventHandler(this.btn_submit_team_Click);
            // 
            // cb_buisiness
            // 
            this.cb_buisiness.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cb_buisiness, "cb_buisiness");
            this.cb_buisiness.FormattingEnabled = true;
            this.cb_buisiness.Items.AddRange(new object[] {
            resources.GetString("cb_buisiness.Items"),
            resources.GetString("cb_buisiness.Items1")});
            this.cb_buisiness.Name = "cb_buisiness";
            // 
            // lbl_buisiness
            // 
            resources.ApplyResources(this.lbl_buisiness, "lbl_buisiness");
            this.lbl_buisiness.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buisiness.ForeColor = System.Drawing.Color.Gold;
            this.lbl_buisiness.Name = "lbl_buisiness";
            // 
            // lbl_activity
            // 
            resources.ApplyResources(this.lbl_activity, "lbl_activity");
            this.lbl_activity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_activity.ForeColor = System.Drawing.Color.Gold;
            this.lbl_activity.Name = "lbl_activity";
            // 
            // cb_activity
            // 
            this.cb_activity.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cb_activity, "cb_activity");
            this.cb_activity.FormattingEnabled = true;
            this.cb_activity.Items.AddRange(new object[] {
            resources.GetString("cb_activity.Items"),
            resources.GetString("cb_activity.Items1")});
            this.cb_activity.Name = "cb_activity";
            // 
            // nud_employees_in_team
            // 
            resources.ApplyResources(this.nud_employees_in_team, "nud_employees_in_team");
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
            this.nud_employees_in_team.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_employees_in_team
            // 
            resources.ApplyResources(this.lbl_employees_in_team, "lbl_employees_in_team");
            this.lbl_employees_in_team.BackColor = System.Drawing.Color.Transparent;
            this.lbl_employees_in_team.ForeColor = System.Drawing.Color.Gold;
            this.lbl_employees_in_team.Name = "lbl_employees_in_team";
            // 
            // lbl_select_truck
            // 
            resources.ApplyResources(this.lbl_select_truck, "lbl_select_truck");
            this.lbl_select_truck.BackColor = System.Drawing.Color.Transparent;
            this.lbl_select_truck.ForeColor = System.Drawing.Color.Gold;
            this.lbl_select_truck.Name = "lbl_select_truck";
            // 
            // cb_choosen_fireTruck
            // 
            this.cb_choosen_fireTruck.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.cb_choosen_fireTruck, "cb_choosen_fireTruck");
            this.cb_choosen_fireTruck.FormattingEnabled = true;
            this.cb_choosen_fireTruck.Name = "cb_choosen_fireTruck";
            // 
            // txt_box_team_name
            // 
            resources.ApplyResources(this.txt_box_team_name, "txt_box_team_name");
            this.txt_box_team_name.Name = "txt_box_team_name";
            // 
            // lbl_team_name
            // 
            resources.ApplyResources(this.lbl_team_name, "lbl_team_name");
            this.lbl_team_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_team_name.ForeColor = System.Drawing.Color.Gold;
            this.lbl_team_name.Name = "lbl_team_name";
            // 
            // lbl_add_team
            // 
            resources.ApplyResources(this.lbl_add_team, "lbl_add_team");
            this.lbl_add_team.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_team.ForeColor = System.Drawing.Color.Gold;
            this.lbl_add_team.Name = "lbl_add_team";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_back, "btn_back");
            this.btn_back.Name = "btn_back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // AddTeamView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradientPanelAddTeam);
            this.Name = "AddTeamView";
            this.Load += new System.EventHandler(this.AddTeamView_Load);
            this.gradientPanelAddTeam.ResumeLayout(false);
            this.gradientPanelAddTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_employees_in_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_submit_team;
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
        private System.Windows.Forms.Label lbl_add_team;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private GradientPanel gradientPanelAddTeam;
    }
}