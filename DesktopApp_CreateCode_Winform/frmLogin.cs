using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using xNet;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Specialized;

namespace DesktopApp_CreateCode_Winform
{
    public partial class frmLogin : Form
    {
        ItemCustomFile.AllFile itemCustomFile = new ItemCustomFile.AllFile();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
        string path = Environment.CurrentDirectory + "/" + "log.txt";
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtInputUsers.Text =="" || txtInputPass.Text=="")
            {
                MessageBox.Show("Bạn phải điền đủ thông tin !!!");
            }
            else
            {

                if (!File.Exists(path))
                {
                    frmSetting frmSetting = new frmSetting();
                    frmSetting.Show();
                }
                else
                {
                   
                    string url = itemCustomFile.readFile();
                    
                    string checkUrl = url + "/login?user="+txtInputUsers.Text+"&pass="+txtInputPass.Text;
                    
                    getLogin(checkUrl);

                    
                }

            }
        }
        private void getLogin(string link)
        {
            try
            {
                WebRequest request = WebRequest.Create(link);
                request.Credentials = CredentialCache.DefaultNetworkCredentials;

                WebResponse response = request.GetResponse();
               if (((HttpWebResponse)response).StatusDescription == "OK")
                {
                    using (Stream data = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(data);
                        string res = reader.ReadToEnd();
                        if (res == "true")
                        {
                            moveToHomeForm();
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
                        }
                    }
                } else
                {
                    frmSetting frmSetting = new frmSetting();
                    frmSetting.Show();
                }

                    }
            catch (Exception)
            {
                frmSetting frmSetting = new frmSetting();
                frmSetting.Show();
            }
        }
        void moveToHomeForm()
        {
            FrmIndex frmIndex = new FrmIndex();
            frmIndex.Show();
            this.Hide();
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            
               
        }
    }
}
