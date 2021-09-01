using System;
using System.Collections.Generic;
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
   
    public partial class frmAdd : Form
    {
        List<ItemCustomFile.OptionOTD> option;
        public frmAdd(bool check)
        {
            InitializeComponent();
            if(!check)
            {
                pnID.Visible = false;

            }
            ItemCustomFile.AllFile file = new ItemCustomFile.AllFile();
            string json = GET(file.readFile() + "/option");
           
            option = getOption(json);
            
            for (int i=0; i<option.Count; i++)
            {
                cbChomNhom.Items.Add(option[i].code + ": " + option[i].note);
            }
        }
        private List<ItemCustomFile.OptionOTD> getOption(string json)
        {
            
            string[] arr = json.Split('}');
            List<ItemCustomFile.OptionOTD> arrOption = new List<ItemCustomFile.OptionOTD>();

            for (int i = 0; i < arr.Length-1 ; i++)
            {
                string value = "";
                
                value = arr[i].Substring(1, arr[i].Length-1) + "}";
                
                ItemCustomFile.OptionOTD option = new ItemCustomFile.OptionOTD(value);
   
                arrOption.Add(option);
            }
            
            return arrOption;
        }

        public string GET(string address)
        {


            WebRequest request = WebRequest.Create(address);
            request.Credentials = CredentialCache.DefaultNetworkCredentials;
            try
            {
                WebResponse response = request.GetResponse();

                if (((HttpWebResponse)response).StatusDescription == "OK")
                {
                    using (Stream data = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(data);
                        string res = reader.ReadToEnd();
                        return res;
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại");
                return "";
            }
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {

             if (cbChomNhom.Text == "" || cblChonLoai.Text == "" || txtQuyCach.Text == "" || imageLocation =="")
             {
                 MessageBox.Show("Vui lòng nhập đủ thông tin !!!");
             }
             else
             {
                 postData(saveImage.ImageLocation, cbChomNhom.Text[0].ToString(), cblChonLoai.Text, txtQuyCach.Text);
             }
             

        }

        String imageLocation = "";
        private void openFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    saveImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }


        // POST DATA
        string UploadData(HttpRequest http, string url, MultipartContent data = null, string userArgent = "")
        {
            string html = "";
            if (http == null)
            {
                http = new HttpRequest();
            }

            if (!string.IsNullOrEmpty(userArgent))
            {
                http.UserAgent = userArgent;
            }
            try
            {
                html = http.Post(url, data).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại");
            }
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
                { new FileContent(path), "img", "data.img"}
            };

            var res = UploadData(null, url, data);
            if (res != "") {
                if (res != "false")
                {
                    MessageBox.Show("Tạo mã thành công");
                    txtID.Text = res;
                    pnID.Visible = true;
                }
                else
                {
                    MessageBox.Show("Mã của bạn chưa được tạo", "Xin hãy kiểm tra lại quá trình", MessageBoxButtons.OK);
                }
            }
        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            ScreenShot frmScreenShot = new ScreenShot();
            frmScreenShot.ShowDialog();
            saveImage.ImageLocation = frmScreenShot.check ? Environment.CurrentDirectory + "/" + "screenshot.png" : null;
            imageLocation = frmScreenShot.check ? Environment.CurrentDirectory + "/" + "screenshot.png" : "";
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
                if (imageLocation != "")
                {
                    frmShowImage frmShowImage = new frmShowImage(saveImage.ImageLocation);
                    frmShowImage.Show();
                }
                
        }
        
    }
}
