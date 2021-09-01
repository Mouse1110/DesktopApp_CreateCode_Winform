using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp_CreateCode_Winform
{
    public partial class ScreenShot : Form
    {
        public bool check;
        public ScreenShot( )
        {
            InitializeComponent();
            check = false;

        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(1000);
            Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(0, 0, 0, 0, bm.Size);
            
            pictureBox1.Image = (Image)bm;
            bm.Save("screenshot.png", ImageFormat.Png);
            check = true;
            this.Show();
        }


    }
}
