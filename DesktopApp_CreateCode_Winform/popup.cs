using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp_CreateCode_Winform
{
    public partial class popup : Form
    {

        public popup(string valueChonNhom, string valueChonLoai, string valueQuyCach, string valueImage,bool check)
        {
            InitializeComponent();
            this.valueChonNhom = valueChonNhom;
            this.valueChonLoai = valueChonLoai;
            this.valueQuyCach = valueQuyCach;
            this.valueImageLocation = valueImage;
            if (!check)
            {
                btnXacNhan.Visible = false;
            }
        }
    
        public string valueChonNhom { get; set; }
        public string valueChonLoai { get; set; }
        public string valueQuyCach { get; set; }
        public string valueImageLocation { get; set; }

        private void popup_Load(object sender, EventArgs e)
        {
            lblChonNhom.Text = valueChonNhom;
            lblChonLoai.Text = valueChonLoai;
            lblQuyCach.Text = valueQuyCach;
            imagePopup.ImageLocation = valueImageLocation;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void imagePopup_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            postDataAsync(valueChonNhom, valueChonLoai, valueQuyCach);
        }
        void postDataAsync(String classCode, String type, String size)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["class"] = classCode;
                data["type"] = type;
                data["size"] = size;
                var response = wb.UploadValues("http://covtest.hmcdat.xyz/add", "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
                this.Hide();
            }
        }
    }
}
