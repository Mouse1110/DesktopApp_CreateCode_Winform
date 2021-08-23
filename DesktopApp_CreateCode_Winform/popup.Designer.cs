namespace DesktopApp_CreateCode_Winform
{
    partial class popup
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblChonNhom = new System.Windows.Forms.Label();
            this.lblChonLoai = new System.Windows.Forms.Label();
            this.lblQuyCach = new System.Windows.Forms.Label();
            this.imagePopup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePopup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(39)))), ((int)(((byte)(80)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(578, 517);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(270, 65);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.UseWaitCursor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblChonNhom
            // 
            this.lblChonNhom.AutoSize = true;
            this.lblChonNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNhom.Location = new System.Drawing.Point(571, 143);
            this.lblChonNhom.Name = "lblChonNhom";
            this.lblChonNhom.Size = new System.Drawing.Size(190, 37);
            this.lblChonNhom.TabIndex = 5;
            this.lblChonNhom.Text = "Chọn Nhóm";
            this.lblChonNhom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblChonNhom.UseWaitCursor = true;
            // 
            // lblChonLoai
            // 
            this.lblChonLoai.AutoSize = true;
            this.lblChonLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLoai.Location = new System.Drawing.Point(571, 259);
            this.lblChonLoai.Name = "lblChonLoai";
            this.lblChonLoai.Size = new System.Drawing.Size(164, 37);
            this.lblChonLoai.TabIndex = 6;
            this.lblChonLoai.Text = "Chọn Loại";
            this.lblChonLoai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblChonLoai.UseWaitCursor = true;
            // 
            // lblQuyCach
            // 
            this.lblQuyCach.AutoSize = true;
            this.lblQuyCach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyCach.Location = new System.Drawing.Point(576, 379);
            this.lblQuyCach.Name = "lblQuyCach";
            this.lblQuyCach.Size = new System.Drawing.Size(159, 37);
            this.lblQuyCach.TabIndex = 7;
            this.lblQuyCach.Text = "Quy Cách";
            this.lblQuyCach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuyCach.UseWaitCursor = true;
            // 
            // imagePopup
            // 
            this.imagePopup.Location = new System.Drawing.Point(100, 105);
            this.imagePopup.Name = "imagePopup";
            this.imagePopup.Size = new System.Drawing.Size(379, 379);
            this.imagePopup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePopup.TabIndex = 3;
            this.imagePopup.TabStop = false;
            this.imagePopup.UseWaitCursor = true;
            this.imagePopup.Click += new System.EventHandler(this.imagePopup_Click);
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 672);
            this.Controls.Add(this.lblQuyCach);
            this.Controls.Add(this.lblChonLoai);
            this.Controls.Add(this.lblChonNhom);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.imagePopup);
            this.Name = "popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popup";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePopup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imagePopup;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblChonNhom;
        private System.Windows.Forms.Label lblChonLoai;
        private System.Windows.Forms.Label lblQuyCach;
    }
}