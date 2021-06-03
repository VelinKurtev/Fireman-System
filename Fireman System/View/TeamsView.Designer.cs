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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsView));
            this.btn_back = new System.Windows.Forms.Button();
            this.gradientPanelFireTrucks = new Fireman_Systemn.GradientPanel();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.btn_delete_team = new System.Windows.Forms.Button();
            this.btn_update_table = new System.Windows.Forms.Button();
            this.btn_add_team = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbl_teams = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gradientPanelFireTrucks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
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
            this.gradientPanelFireTrucks.Controls.Add(this.dgvTeams);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_delete_team);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_update_table);
            this.gradientPanelFireTrucks.Controls.Add(this.btn_add_team);
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
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeams.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvTeams.Location = new System.Drawing.Point(311, 124);
            this.dgvTeams.Name = "dgvTeams";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeams.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeams.RowHeadersWidth = 20;
            this.dgvTeams.Size = new System.Drawing.Size(538, 376);
            this.dgvTeams.TabIndex = 16;
            // 
            // btn_delete_team
            // 
            this.btn_delete_team.BackColor = System.Drawing.Color.Beige;
            this.btn_delete_team.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_team.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_team.Location = new System.Drawing.Point(36, 248);
            this.btn_delete_team.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_delete_team.Name = "btn_delete_team";
            this.btn_delete_team.Size = new System.Drawing.Size(259, 54);
            this.btn_delete_team.TabIndex = 15;
            this.btn_delete_team.Text = "Изтрий отбор";
            this.btn_delete_team.UseVisualStyleBackColor = false;
            this.btn_delete_team.Click += new System.EventHandler(this.btn_delete_team_Click);
            // 
            // btn_update_table
            // 
            this.btn_update_table.BackColor = System.Drawing.Color.Beige;
            this.btn_update_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_table.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_table.Location = new System.Drawing.Point(36, 186);
            this.btn_update_table.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_update_table.Name = "btn_update_table";
            this.btn_update_table.Size = new System.Drawing.Size(259, 54);
            this.btn_update_table.TabIndex = 14;
            this.btn_update_table.Text = "Редактирай таблицата";
            this.btn_update_table.UseVisualStyleBackColor = false;
            this.btn_update_table.Click += new System.EventHandler(this.btn_update_table_Click);
            // 
            // btn_add_team
            // 
            this.btn_add_team.BackColor = System.Drawing.Color.Beige;
            this.btn_add_team.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_team.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_team.Location = new System.Drawing.Point(36, 124);
            this.btn_add_team.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_add_team.Name = "btn_add_team";
            this.btn_add_team.Size = new System.Drawing.Size(259, 54);
            this.btn_add_team.TabIndex = 13;
            this.btn_add_team.Text = "Добави отбор";
            this.btn_add_team.UseVisualStyleBackColor = false;
            this.btn_add_team.Click += new System.EventHandler(this.btn_add_team_Click);
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
            // lbl_teams
            // 
            this.lbl_teams.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_teams.AutoSize = true;
            this.lbl_teams.BackColor = System.Drawing.Color.Transparent;
            this.lbl_teams.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teams.ForeColor = System.Drawing.Color.Gold;
            this.lbl_teams.Location = new System.Drawing.Point(366, 43);
            this.lbl_teams.Name = "lbl_teams";
            this.lbl_teams.Size = new System.Drawing.Size(125, 42);
            this.lbl_teams.TabIndex = 2;
            this.lbl_teams.Text = "Екипи";
            this.lbl_teams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            // 
            // TeamsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.gradientPanelFireTrucks);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeamsView";
            this.Text = "Fireman System - Екипи";
            this.Load += new System.EventHandler(this.Teams_and_Employees_Load);
            this.gradientPanelFireTrucks.ResumeLayout(false);
            this.gradientPanelFireTrucks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private GradientPanel gradientPanelFireTrucks;
        private System.Windows.Forms.Label lbl_teams;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Button btn_delete_team;
        private System.Windows.Forms.Button btn_update_table;
        private System.Windows.Forms.Button btn_add_team;
    }
}

