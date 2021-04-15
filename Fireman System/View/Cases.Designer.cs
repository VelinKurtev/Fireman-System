namespace Fireman_Systemn.View
{
    partial class Cases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cases));
            this.gradientPanel1 = new Fireman_Systemn.GradientPanel();
            this.dbViewCases = new System.Windows.Forms.DataGridView();
            this.btn_delete_case = new System.Windows.Forms.Button();
            this.lbl_cases = new System.Windows.Forms.Label();
            this.btn_update_table = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add_case = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_id_picker = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.BottomColor = System.Drawing.Color.DarkRed;
            this.gradientPanel1.Controls.Add(this.lbl_id_picker);
            this.gradientPanel1.Controls.Add(this.comboBox1);
            this.gradientPanel1.Controls.Add(this.dbViewCases);
            this.gradientPanel1.Controls.Add(this.btn_delete_case);
            this.gradientPanel1.Controls.Add(this.lbl_cases);
            this.gradientPanel1.Controls.Add(this.btn_update_table);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.btn_add_case);
            this.gradientPanel1.Controls.Add(this.btn_back);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(748, 512);
            this.gradientPanel1.TabIndex = 10;
            this.gradientPanel1.TopColor = System.Drawing.Color.Black;
            // 
            // dbViewCases
            // 
            this.dbViewCases.BackgroundColor = System.Drawing.Color.Beige;
            this.dbViewCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewCases.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dbViewCases.Location = new System.Drawing.Point(306, 124);
            this.dbViewCases.Name = "dbViewCases";
            this.dbViewCases.Size = new System.Drawing.Size(430, 376);
            this.dbViewCases.TabIndex = 5;
            // 
            // btn_delete_case
            // 
            this.btn_delete_case.BackColor = System.Drawing.Color.Beige;
            this.btn_delete_case.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_case.Location = new System.Drawing.Point(45, 208);
            this.btn_delete_case.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_case.Name = "btn_delete_case";
            this.btn_delete_case.Size = new System.Drawing.Size(206, 36);
            this.btn_delete_case.TabIndex = 9;
            this.btn_delete_case.Text = "Изтрий произшествие";
            this.btn_delete_case.UseVisualStyleBackColor = false;
            // 
            // lbl_cases
            // 
            this.lbl_cases.AutoSize = true;
            this.lbl_cases.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cases.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cases.Location = new System.Drawing.Point(248, 39);
            this.lbl_cases.Name = "lbl_cases";
            this.lbl_cases.Size = new System.Drawing.Size(276, 42);
            this.lbl_cases.TabIndex = 2;
            this.lbl_cases.Text = "Произшествия";
            // 
            // btn_update_table
            // 
            this.btn_update_table.BackColor = System.Drawing.Color.Beige;
            this.btn_update_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_table.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_table.Location = new System.Drawing.Point(45, 166);
            this.btn_update_table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update_table.Name = "btn_update_table";
            this.btn_update_table.Size = new System.Drawing.Size(206, 36);
            this.btn_update_table.TabIndex = 8;
            this.btn_update_table.Text = "Обнови таблицата";
            this.btn_update_table.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add_case
            // 
            this.btn_add_case.BackColor = System.Drawing.Color.Beige;
            this.btn_add_case.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_case.Location = new System.Drawing.Point(45, 124);
            this.btn_add_case.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_case.Name = "btn_add_case";
            this.btn_add_case.Size = new System.Drawing.Size(206, 36);
            this.btn_add_case.TabIndex = 0;
            this.btn_add_case.Text = "Добави произшествие";
            this.btn_add_case.UseVisualStyleBackColor = false;
            this.btn_add_case.Click += new System.EventHandler(this.btn_add_case_Click);
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
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // lbl_id_picker
            // 
            this.lbl_id_picker.AutoSize = true;
            this.lbl_id_picker.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_picker.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_picker.ForeColor = System.Drawing.Color.Gold;
            this.lbl_id_picker.Location = new System.Drawing.Point(54, 248);
            this.lbl_id_picker.Name = "lbl_id_picker";
            this.lbl_id_picker.Size = new System.Drawing.Size(187, 17);
            this.lbl_id_picker.TabIndex = 11;
            this.lbl_id_picker.Text = "Идентификационен номер:";
            // 
            // Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cases";
            this.Text = "Fireman System - Cases";
            this.Load += new System.EventHandler(this.Cases_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dbViewCases;
        private System.Windows.Forms.Label lbl_cases;
        private System.Windows.Forms.Button btn_add_case;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_update_table;
        private System.Windows.Forms.Button btn_delete_case;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lbl_id_picker;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}