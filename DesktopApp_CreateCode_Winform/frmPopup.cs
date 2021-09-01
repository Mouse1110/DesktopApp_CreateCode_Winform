using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace DesktopApp_CreateCode_Winform
{
    public partial class frmPopup : Form
    {
        public frmPopup(string valueChonNhom, string valueChonLoai, string valueQuyCach, string valueImage,string id, bool check)
        {
            InitializeComponent();
            this.valueChonNhom = valueChonNhom;
            this.valueChonLoai = valueChonLoai;
            this.valueQuyCach = valueQuyCach;
            this.valueImageLocation = valueImage;
            this.valueID = id;

            lblChonNhom.Text = valueChonNhom;
            lblChonLoai.Text = valueChonLoai;
            lblQuyCach.Text = valueQuyCach;
            imagePopup.ImageLocation = !check?valueImageLocation: getFile.readFile() + valueImageLocation;
        }
    
        public string valueChonNhom { get; set; }
        public string valueChonLoai { get; set; }
        public string valueQuyCach { get; set; }
        public string valueImageLocation { get; set; }
        public string valueID { get; set; }
 
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //postData(valueImageLocation, valueChonNhom, valueChonLoai, valueQuyCach);
            //this.Hide();
        }

        //Cách 2
        string UploadData(HttpRequest http, string url, MultipartContent data = null, string userArgent = "")
        {
            if (http == null)
            {
                http = new HttpRequest();
            }

            if (!string.IsNullOrEmpty(userArgent))
            {
                http.UserAgent = userArgent;
            }

            string html = http.Post(url, data).ToString();
            return html;
        }


        //void postData(string path, string classCode, string type, string size)
        //{
        //    string url = getFile.readFile() + "/add";
        //    MultipartContent data = new MultipartContent() {
        //        { new StringContent(classCode), "class"},
        //        { new StringContent(type), "type"},
        //        { new StringContent(size), "size"},
        //        { new FileContent(path), "img", "data.img"}
        //    };

        //    var res = UploadData(null, url, data);
        //    if (res != "false")
        //    {
        //        MessageBox.Show(res, "Mã vừa được khởi tạo là", MessageBoxButtons.OK);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Mã của bạn chưa được tạo", "Xin hãy kiểm tra lại quá trình", MessageBoxButtons.OK);
        //    }

        //}


        ItemCustomFile.AllFile getFile = new ItemCustomFile.AllFile();
        private void deleteData(string id)
        {
            string url = getFile.readFile() + "/delete/" + id;
            MultipartContent data = new MultipartContent() ;
            var res = UploadData(null, url, data);
            if (res == "true")
            {
                MessageBox.Show("Xóa mã thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã của bạn chưa được xóa", "Thông báo");
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate(valueID,valueChonNhom,valueChonLoai,valueQuyCach,valueImageLocation);
            update.Show();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            deleteData(valueID);
            this.Close();
        }
    }
}
