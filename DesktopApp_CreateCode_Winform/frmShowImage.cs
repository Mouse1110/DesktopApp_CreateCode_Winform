using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DesktopApp_CreateCode_Winform
{
    public partial class frmShowImage : Form
    {
        public frmShowImage(string picImage)
        {
            InitializeComponent();
            this.picImage = picImage;
            pictureImage.ImageLocation = picImage;
        }

        private string picImage { get; set; }
        private void btnKhungImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
