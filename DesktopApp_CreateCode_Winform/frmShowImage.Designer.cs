namespace DesktopApp_CreateCode_Winform
{
    partial class frmShowImage
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
            this.btnKhungImage = new System.Windows.Forms.Button();
            this.pictureImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKhungImage
            // 
            this.btnKhungImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKhungImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhungImage.Location = new System.Drawing.Point(0, 0);
            this.btnKhungImage.Name = "btnKhungImage";
            this.btnKhungImage.Size = new System.Drawing.Size(1082, 571);
            this.btnKhungImage.TabIndex = 0;
            this.btnKhungImage.UseVisualStyleBackColor = false;
            this.btnKhungImage.Click += new System.EventHandler(this.btnKhungImage_Click);
            // 
            // pictureImage
            // 
            this.pictureImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureImage.Location = new System.Drawing.Point(149, 76);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(772, 410);
            this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImage.TabIndex = 1;
            this.pictureImage.TabStop = false;
            // 
            // frmShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 571);
            this.Controls.Add(this.pictureImage);
            this.Controls.Add(this.btnKhungImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowImage";
            this.Text = "ShowImage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKhungImage;
        private System.Windows.Forms.PictureBox pictureImage;
    }
}