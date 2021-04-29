namespace Fireman_Systemn.View
{
    partial class Add_Case_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Case_View));
            this.gradientPanelAddCase = new Fireman_Systemn.GradientPanel();
            this.lbl_add_case = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.gradientPanelAddCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelAddCase
            // 
            this.gradientPanelAddCase.Angle = 0F;
            this.gradientPanelAddCase.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelAddCase.Controls.Add(this.lbl_add_case);
            this.gradientPanelAddCase.Controls.Add(this.pictureBoxLogo);
            this.gradientPanelAddCase.Controls.Add(this.btn_back);
            this.gradientPanelAddCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelAddCase.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelAddCase.Name = "gradientPanelAddCase";
            this.gradientPanelAddCase.Size = new System.Drawing.Size(861, 512);
            this.gradientPanelAddCase.TabIndex = 5;
            this.gradientPanelAddCase.TopColor = System.Drawing.Color.Black;
            // 
            // lbl_add_case
            // 
            this.lbl_add_case.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_add_case.AutoSize = true;
            this.lbl_add_case.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_case.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_case.ForeColor = System.Drawing.Color.Gold;
            this.lbl_add_case.Location = new System.Drawing.Point(239, 43);
            this.lbl_add_case.Name = "lbl_add_case";
            this.lbl_add_case.Size = new System.Drawing.Size(413, 42);
            this.lbl_add_case.TabIndex = 2;
            this.lbl_add_case.Text = "Добави произшествие";
            this.lbl_add_case.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 382);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(125, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
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
            // Add_Case_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(861, 512);
            this.Controls.Add(this.gradientPanelAddCase);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Case_View";
            this.Text = "Fireman System - Добави произшествие";
            this.Load += new System.EventHandler(this.Add_Case_Load);
            this.gradientPanelAddCase.ResumeLayout(false);
            this.gradientPanelAddCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_back;
        #endregion

        private GradientPanel gradientPanelAddCase;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lbl_add_case;
    }
}
