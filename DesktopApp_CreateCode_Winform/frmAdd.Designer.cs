namespace DesktopApp_CreateCode_Winform
{
    partial class frmAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChomNhom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoMa = new System.Windows.Forms.Button();
            this.txtQuyCach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cblChonLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnID = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnID.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbChomNhom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTaoMa);
            this.panel1.Controls.Add(this.txtQuyCach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnScreenShot);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cblChonLoai);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.openFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 328);
            this.panel1.TabIndex = 12;
            // 
            // cbChomNhom
            // 
            this.cbChomNhom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbChomNhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbChomNhom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChomNhom.FormattingEnabled = true;
            this.cbChomNhom.Location = new System.Drawing.Point(54, 136);
            this.cbChomNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbChomNhom.Name = "cbChomNhom";
            this.cbChomNhom.Size = new System.Drawing.Size(326, 39);
            this.cbChomNhom.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "TẠO MÃ MỚI";
            // 
            // btnTaoMa
            // 
            this.btnTaoMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(39)))), ((int)(((byte)(80)))));
            this.btnTaoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMa.ForeColor = System.Drawing.Color.White;
            this.btnTaoMa.Location = new System.Drawing.Point(483, 210);
            this.btnTaoMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoMa.Name = "btnTaoMa";
            this.btnTaoMa.Size = new System.Drawing.Size(230, 69);
            this.btnTaoMa.TabIndex = 6;
            this.btnTaoMa.Text = "Tạo mã";
            this.btnTaoMa.UseVisualStyleBackColor = false;
            this.btnTaoMa.Click += new System.EventHandler(this.btnTaoMa_Click);
            // 
            // txtQuyCach
            // 
            this.txtQuyCach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuyCach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQuyCach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuyCach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyCach.Location = new System.Drawing.Point(440, 136);
            this.txtQuyCach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuyCach.Name = "txtQuyCach";
            this.txtQuyCach.Size = new System.Drawing.Size(320, 39);
            this.txtQuyCach.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn nhóm";
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScreenShot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnScreenShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenShot.ForeColor = System.Drawing.Color.Black;
            this.btnScreenShot.Location = new System.Drawing.Point(1073, 226);
            this.btnScreenShot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(207, 52);
            this.btnScreenShot.TabIndex = 10;
            this.btnScreenShot.Text = "Screen Shot";
            this.btnScreenShot.UseVisualStyleBackColor = false;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn Loại";
            // 
            // cblChonLoai
            // 
            this.cblChonLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cblChonLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cblChonLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblChonLoai.FormattingEnabled = true;
            this.cblChonLoai.Items.AddRange(new object[] {
            "BTP",
            "CS"});
            this.cblChonLoai.Location = new System.Drawing.Point(54, 239);
            this.cblChonLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cblChonLoai.Name = "cblChonLoai";
            this.cblChonLoai.Size = new System.Drawing.Size(326, 39);
            this.cblChonLoai.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quy cách";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(949, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chọn hình ảnh";
            // 
            // openFile
            // 
            this.openFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.ForeColor = System.Drawing.Color.Black;
            this.openFile.Location = new System.Drawing.Point(830, 226);
            this.openFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(207, 52);
            this.openFile.TabIndex = 8;
            this.openFile.Text = "Chọn hình ảnh";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnID
            // 
            this.pnID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnID.BackColor = System.Drawing.Color.Gainsboro;
            this.pnID.Controls.Add(this.txtID);
            this.pnID.Controls.Add(this.label2);
            this.pnID.Location = new System.Drawing.Point(202, 144);
            this.pnID.Name = "pnID";
            this.pnID.Size = new System.Drawing.Size(285, 171);
            this.pnID.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(92, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(110, 42);
            this.txtID.TabIndex = 16;
            this.txtID.Text = "A001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnID);
            this.panel2.Controls.Add(this.saveImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 455);
            this.panel2.TabIndex = 13;
            // 
            // saveImage
            // 
            this.saveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImage.Location = new System.Drawing.Point(726, 6);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(608, 437);
            this.saveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveImage.TabIndex = 11;
            this.saveImage.TabStop = false;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 783);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnID.ResumeLayout(false);
            this.pnID.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTaoMa;
        private System.Windows.Forms.TextBox txtQuyCach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cblChonLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnID;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox saveImage;
        private System.Windows.Forms.ComboBox cbChomNhom;
    }
}