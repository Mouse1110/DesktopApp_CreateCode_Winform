using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp_CreateCode_Winform
{
    public partial class popup : Form
    {

        public popup(string valueChonNhom, string valueChonLoai, string valueQuyCach, string valueImage)
        {
            InitializeComponent();
            this.ValueChonNhom = valueChonNhom;
            this.ValueChonLoai = valueChonLoai;
            this.ValueQuyCach = valueQuyCach;
            this.ValueImageLocation = valueImage;
        }
    
        public string ValueChonNhom { get; set; }
        public string ValueChonLoai { get; set; }
        public string ValueQuyCach { get; set; }
        public string ValueImageLocation { get; set; }

        private void popup_Load(object sender, EventArgs e)
        {
            lblChonNhom.Text = ValueChonNhom;
            lblChonLoai.Text = ValueChonLoai;
            lblQuyCach.Text = ValueQuyCach;
            imagePopup.ImageLocation = ValueImageLocation;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void imagePopup_Click(object sender, EventArgs e)
        {

        }

    
    }
}
