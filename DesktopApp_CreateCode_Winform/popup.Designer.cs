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
            this.imagePopup = new System.Windows.Forms.PictureBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblChonNhom = new System.Windows.Forms.Label();
            this.lblChonLoai = new System.Windows.Forms.Label();
            this.lblQuyCach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePopup)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePopup
            // 
            this.imagePopup.Location = new System.Drawing.Point(108, 119);
            this.imagePopup.Name = "imagePopup";
            this.imagePopup.Size = new System.Drawing.Size(341, 335);
            this.imagePopup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePopup.TabIndex = 3;
            this.imagePopup.TabStop = false;
            this.imagePopup.Click += new System.EventHandler(this.imagePopup_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(542, 533);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(243, 58);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // lblChonNhom
            // 
            this.lblChonNhom.AutoSize = true;
            this.lblChonNhom.Location = new System.Drawing.Point(588, 129);
            this.lblChonNhom.Name = "lblChonNhom";
            this.lblChonNhom.Size = new System.Drawing.Size(125, 25);
            this.lblChonNhom.TabIndex = 5;
            this.lblChonNhom.Text = "Chọn Nhóm";
            this.lblChonNhom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChonLoai
            // 
            this.lblChonLoai.AutoSize = true;
            this.lblChonLoai.Location = new System.Drawing.Point(588, 259);
            this.lblChonLoai.Name = "lblChonLoai";
            this.lblChonLoai.Size = new System.Drawing.Size(110, 25);
            this.lblChonLoai.TabIndex = 6;
            this.lblChonLoai.Text = "Chọn Loại";
            this.lblChonLoai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuyCach
            // 
            this.lblQuyCach.AutoSize = true;
            this.lblQuyCach.Location = new System.Drawing.Point(588, 377);
            this.lblQuyCach.Name = "lblQuyCach";
            this.lblQuyCach.Size = new System.Drawing.Size(107, 25);
            this.lblQuyCach.TabIndex = 7;
            this.lblQuyCach.Text = "Quy Cách";
            this.lblQuyCach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Text = "popup";
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