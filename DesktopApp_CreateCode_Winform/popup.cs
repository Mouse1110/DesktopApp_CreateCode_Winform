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
    public partial class popup : Form
    {
        public popup(string valueChonNhom, string valueChonLoai, string valueQuyCach, string valueImage, bool check)
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
        

        private void imagePopup_Click(object sender, EventArgs e)
        {

        }
        
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            postData(valueImageLocation, valueChonNhom, valueChonLoai, valueQuyCach);
            this.Close();
        }
        //Cách 1
        void postDataAsync(String classCode, String type, String size)
        {
            
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["class"] = classCode;
                data["type"] = type;
                data["size"] = size;

                //wb.Headers.Add("iamge", System.IO.Path.GetFileName(image));
                //wb.UploadFileAsync(uri, image);
                
                Upload(valueImageLocation);
                //MessageBox.Show();
                var response = wb.UploadValues("http://covtest.hmcdat.xyz/add", "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
                this.Hide();
            }
        }
        private void Upload(string fileName)
        {
            var client = new WebClient();
            var uri = new Uri("http://covtest.hmcdat.xyz/add");
            try
                {
                    client.Headers.Add("fileName", System.IO.Path.GetFileName(fileName));
                    client.UploadFileAsync(uri, fileName);
                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        ItemCustomFile.AllFile getFile = new ItemCustomFile.AllFile();
        void postData(string path, string classCode, string type, string size)
        {
            string url = getFile.readFile() + "/add";
            MultipartContent data = new MultipartContent() {
                { new StringContent(classCode), "class"},
                { new StringContent(type), "type"},
                { new StringContent(size), "size"},
                { new FileContent(path), "img", Path.GetFileName(path)}
            };

            var html = UploadData(null, url , data);
            MessageBox.Show(html);
        }


    }
}
