
namespace Fireman_Systemn.View.AddViews
{
    partial class AddEmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeView));
            this.gradientPanelAddTeam = new Fireman_Systemn.GradientPanel();
            this.btn_submit_team = new System.Windows.Forms.Button();
            this.nud_employees_in_team = new System.Windows.Forms.NumericUpDown();
            this.cb_choosen_fireTruck = new System.Windows.Forms.ComboBox();
            this.txt_box_team_name = new System.Windows.Forms.TextBox();
            this.lbl_team_name = new System.Windows.Forms.Label();
            this.lbl_add_team = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanelAddTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_employees_in_team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelAddTeam
            // 
            this.gradientPanelAddTeam.Angle = 0F;
            this.gradientPanelAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanelAddTeam.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelAddTeam.Controls.Add(this.btn_submit_team);
            this.gradientPanelAddTeam.Controls.Add(this.nud_employees_in_team);
            this.gradientPanelAddTeam.Controls.Add(this.cb_choosen_fireTruck);
            this.gradientPanelAddTeam.Controls.Add(this.txt_box_team_name);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_team_name);
            this.gradientPanelAddTeam.Controls.Add(this.lbl_add_team);
            this.gradientPanelAddTeam.Controls.Add(this.btn_back);
            this.gradientPanelAddTeam.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelAddTeam.Controls.Add(this.pictureBox1);
            this.gradientPanelAddTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelAddTeam.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelAddTeam.Name = "gradientPanelAddTeam";
            this.gradientPanelAddTeam.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelAddTeam.TabIndex = 9;
            this.gradientPanelAddTeam.TopColor = System.Drawing.Color.Black;
            // 
            // btn_submit_team
            // 
            this.btn_submit_team.BackColor = System.Drawing.Color.Beige;
            this.btn_submit_team.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_submit_team.ForeColor = System.Drawing.Color.Black;
            this.btn_submit_team.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_submit_team.Location = new System.Drawing.Point(170, 441);
            this.btn_submit_team.Name = "btn_submit_team";
            this.btn_submit_team.Size = new System.Drawing.Size(574, 47);
            this.btn_submit_team.TabIndex = 40;
            this.btn_submit_team.Text = "Добави ";
            this.btn_submit_team.UseVisualStyleBackColor = false;
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
            // cb_choosen_fireTruck
            // 
            this.cb_choosen_fireTruck.BackColor = System.Drawing.Color.White;
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
            // lbl_add_team
            // 
            this.lbl_add_team.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_add_team.AutoSize = true;
            this.lbl_add_team.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_team.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_add_team.ForeColor = System.Drawing.Color.Gold;
            this.lbl_add_team.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_add_team.Location = new System.Drawing.Point(257, 43);
            this.lbl_add_team.Name = "lbl_add_team";
            this.lbl_add_team.Size = new System.Drawing.Size(374, 42);
            this.lbl_add_team.TabIndex = 9;
            this.lbl_add_team.Text = "Добави пожарникар";
            this.lbl_add_team.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // AddEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelAddTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployeeView";
            this.Text = "Fireman System - Добави пожарникар";
            this.Load += new System.EventHandler(this.AddEmployeeView_Load);
            this.gradientPanelAddTeam.ResumeLayout(false);
            this.gradientPanelAddTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_employees_in_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelAddTeam;
        private System.Windows.Forms.Button btn_submit_team;
        private System.Windows.Forms.NumericUpDown nud_employees_in_team;
        private System.Windows.Forms.ComboBox cb_choosen_fireTruck;
        private System.Windows.Forms.TextBox txt_box_team_name;
        private System.Windows.Forms.Label lbl_team_name;
        private System.Windows.Forms.Label lbl_add_team;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}