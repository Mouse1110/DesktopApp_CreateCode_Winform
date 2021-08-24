namespace DesktopApp_CreateCode_Winform
{
    partial class PopupCheckID
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
            this.checkID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkID
            // 
            this.checkID.AutoSize = true;
            this.checkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkID.Location = new System.Drawing.Point(12, 41);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(48, 37);
            this.checkID.TabIndex = 0;
            this.checkID.Text = "ID";
            // 
            // PopupCheckID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 113);
            this.Controls.Add(this.checkID);
            this.Name = "PopupCheckID";
            this.Text = "PopupCheckID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkID;
    }
}