
namespace Fireman_Systemn.View.Pop_Ups
{
    partial class DeleteRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRow));
            this.gradientPanelInvalidInfo = new Fireman_Systemn.GradientPanel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_invalid_info = new System.Windows.Forms.Label();
            this.pictureBoxDeletedRow = new System.Windows.Forms.PictureBox();
            this.gradientPanelInvalidInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeletedRow)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelInvalidInfo
            // 
            this.gradientPanelInvalidInfo.Angle = 0F;
            this.gradientPanelInvalidInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanelInvalidInfo.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelInvalidInfo.Controls.Add(this.btn_ok);
            this.gradientPanelInvalidInfo.Controls.Add(this.lbl_invalid_info);
            this.gradientPanelInvalidInfo.Controls.Add(this.pictureBoxDeletedRow);
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
            this.btn_ok.Location = new System.Drawing.Point(226, 125);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(126, 33);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_invalid_info
            // 
            this.lbl_invalid_info.AutoSize = true;
            this.lbl_invalid_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_invalid_info.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalid_info.ForeColor = System.Drawing.Color.Gold;
            this.lbl_invalid_info.Location = new System.Drawing.Point(139, 84);
            this.lbl_invalid_info.Name = "lbl_invalid_info";
            this.lbl_invalid_info.Size = new System.Drawing.Size(246, 50);
            this.lbl_invalid_info.TabIndex = 1;
            this.lbl_invalid_info.Text = "Успешно изтрит запис !\r\n\r\n";
            // 
            // pictureBoxDeletedRow
            // 
            this.pictureBoxDeletedRow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDeletedRow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDeletedRow.Image")));
            this.pictureBoxDeletedRow.Location = new System.Drawing.Point(21, 55);
            this.pictureBoxDeletedRow.Name = "pictureBoxDeletedRow";
            this.pictureBoxDeletedRow.Size = new System.Drawing.Size(106, 103);
            this.pictureBoxDeletedRow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeletedRow.TabIndex = 0;
            this.pictureBoxDeletedRow.TabStop = false;
            // 
            // DeleteRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 222);
            this.Controls.Add(this.gradientPanelInvalidInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteRow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fireman System - Успешно изтрит запис";
            this.gradientPanelInvalidInfo.ResumeLayout(false);
            this.gradientPanelInvalidInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeletedRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelInvalidInfo;
        private System.Windows.Forms.Label lbl_invalid_info;
        private System.Windows.Forms.PictureBox pictureBoxDeletedRow;
        private System.Windows.Forms.Button btn_ok;
    }
}