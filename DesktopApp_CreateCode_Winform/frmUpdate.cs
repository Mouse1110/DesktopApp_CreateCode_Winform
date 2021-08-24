using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace DesktopApp_CreateCode_Winform
{
    public partial class frmUpdate : Form
    {
        public string valueChonNhom { get; set; }
        public string valueChonLoai { get; set; }
        public string valueQuyCach { get; set; }
        public string valueImageLocation { get; set; }
        public string valueID { get; set; }

        ItemCustomFile.AllFile file;
        public frmUpdate(string id, string classCode,string type,string size,string img)
        {
            
            InitializeComponent();
            this.valueID = id;
            this.valueChonNhom = classCode;
            this.valueChonLoai = type;
            this.valueQuyCach = size;
            this.valueImageLocation = img;
            file = new ItemCustomFile.AllFile();
            picIndex.ImageLocation = file.readFile() + img;
            txtChonNhom.Text = classCode;
            cbChonLoai.Text = type;
            txtQuyCach.Text = size;
        }
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

        private void updateData(string classCode, string type, string size, string img, string id)
        {
            string url = file.readFile() + "/update/" + id;
            if (picIndex.ImageLocation != file.readFile() + img)
            {
                MultipartContent data = new MultipartContent() {
                    { new StringContent(classCode), "class"},
                    { new StringContent(type), "type"},
                    { new StringContent(size), "size"},
                    { new FileContent(picIndex.ImageLocation), "imgFix", "data.img"}
                };
                var res = UploadData(null, url, data);
                if (res == "true")
                {
                    MessageBox.Show("Cập nhật mã thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Mã của bạn chưa được cập nhật", "Thông báo");
                }
            }
            else
            {
                MultipartContent data = new MultipartContent() {
                    { new StringContent(classCode), "class"},
                    { new StringContent(type), "type"},
                    { new StringContent(size), "size"},
                    { new StringContent(img), "img"}
                };
                var res = UploadData(null, url, data);
                if (res == "true")
                {
                    MessageBox.Show("Cập nhật mã thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Mã của bạn chưa được cập nhật", "Thông báo");
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            updateData(txtChonNhom.Text, cbChonLoai.Text, txtQuyCach.Text, valueImageLocation, valueID);
        }

        String imageLocation = "";
        
        private void btnImageFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picIndex.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        
    }
}
