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
namespace DesktopApp_CreateCode_Winform
{
    public partial class FrmIndex : Form
    {
        #region Properties
        HttpRequest httpRequest;
        #endregion
        public FrmIndex()
        {
            InitializeComponent();
            httpRequest = new HttpRequest();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        String imageLocation = "";
        private void openFileDialog_Click(object sender, EventArgs e)
        {
           
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    saveImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Error");
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            popup frmPopups = new popup(cblChonNhom.Text, cblChonLoai.Text, txtQuyCach.Text, saveImage.ImageLocation);
            frmPopups.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1?fbclid=IwAR0w8i4vr1Y7ayvSE0UvYIR52tuVNJloCHXy0H3zNTTYHXpmURbDy0d3aSU";
            string html = GET(url);
            httpGET.Text = html;
        }

        #region Methods
        /// Lấy mã HTML từ address truyền vào
        string GET(string address)
        {
            string result = "";
            result = httpRequest.Get(address).ToString();
            return result;      
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string address = "https://www.howkteam.vn/account/login?ReturnUrl=%2F";
            string data = "";
            string contentType = "";

            string result = POST(address, data, contentType);

            httpGET.Text = result; 
        }
        #region Methods
        /// POST
        string POST(string address, string data, string contentType)
        {
            string result = "";
            result = httpRequest.Post(address, data, contentType).ToString();
            return result;
        }
        #endregion

        private void saveImage_Click(object sender, EventArgs e)
        {

        }
    }
}
