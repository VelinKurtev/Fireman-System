
namespace Fireman_Systemn.View.Pop_Ups
{
    partial class EndCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndCase));
            this.gradientPanelInvalidInfo = new Fireman_Systemn.GradientPanel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_invalid_info = new System.Windows.Forms.Label();
            this.pictureBoxInvalidInfoIcon = new System.Windows.Forms.PictureBox();
            this.gradientPanelInvalidInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalidInfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelInvalidInfo
            // 
            this.gradientPanelInvalidInfo.Angle = 0F;
            this.gradientPanelInvalidInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanelInvalidInfo.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelInvalidInfo.Controls.Add(this.btn_ok);
            this.gradientPanelInvalidInfo.Controls.Add(this.lbl_invalid_info);
            this.gradientPanelInvalidInfo.Controls.Add(this.pictureBoxInvalidInfoIcon);
            this.gradientPanelInvalidInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelInvalidInfo.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelInvalidInfo.Name = "gradientPanelInvalidInfo";
            this.gradientPanelInvalidInfo.Size = new System.Drawing.Size(397, 222);
            this.gradientPanelInvalidInfo.TabIndex = 1;
            this.gradientPanelInvalidInfo.TopColor = System.Drawing.Color.Black;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(186, 115);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(126, 33);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_invalid_info
            // 
            this.lbl_invalid_info.AutoSize = true;
            this.lbl_invalid_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_invalid_info.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalid_info.ForeColor = System.Drawing.Color.Gold;
            this.lbl_invalid_info.Location = new System.Drawing.Point(134, 76);
            this.lbl_invalid_info.Name = "lbl_invalid_info";
            this.lbl_invalid_info.Size = new System.Drawing.Size(240, 22);
            this.lbl_invalid_info.TabIndex = 1;
            this.lbl_invalid_info.Text = "Край на произшествието";
            // 
            // pictureBoxInvalidInfoIcon
            // 
            this.pictureBoxInvalidInfoIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInvalidInfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInvalidInfoIcon.Image")));
            this.pictureBoxInvalidInfoIcon.Location = new System.Drawing.Point(21, 55);
            this.pictureBoxInvalidInfoIcon.Name = "pictureBoxInvalidInfoIcon";
            this.pictureBoxInvalidInfoIcon.Size = new System.Drawing.Size(98, 103);
            this.pictureBoxInvalidInfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInvalidInfoIcon.TabIndex = 0;
            this.pictureBoxInvalidInfoIcon.TabStop = false;
            // 
            // EndCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 222);
            this.Controls.Add(this.gradientPanelInvalidInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fireman System - Край на произшествие";
            this.gradientPanelInvalidInfo.ResumeLayout(false);
            this.gradientPanelInvalidInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalidInfoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelInvalidInfo;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_invalid_info;
        private System.Windows.Forms.PictureBox pictureBoxInvalidInfoIcon;
    }
}