﻿using System;
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
            Form formBackground = new Form();
            try
            {
                using (popup frmPopups = new popup(cblChonNhom.Text, cblChonLoai.Text, txtQuyCach.Text, saveImage.ImageLocation, true))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    frmPopups.Owner = formBackground;
                    if (cblChonNhom.Text == "" || cblChonLoai.Text == ""|| imageLocation ==  "")
                    {
                        MessageBox.Show("Vui lòng điền đủ thông tin!!!");
                    }
                    else
                    {
                        frmPopups.ShowDialog();
                    }
                   

                    // Location lỗi popup không quay lại trang index
                    formBackground.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView.Controls.Clear();
            string url = "http://covtest.hmcdat.xyz/list";
            string getUrl = GET(url);
            string json = getUrl;
            string[] arrStr = json.Split('}');
            if (arrStr.Length > 0)
            {
                for (int i = 0; i < arrStr.Length - 1; i++)
                {

                    String jsonData = convertString(arrStr[i]);
                    ItemCustomList.PanelCustom panel = new ItemCustomList.PanelCustom(jsonData);
                    listView.Controls.Add(panel.create());
                }
            }
        }
        private String convertString(String arrStr)
        {
            String str = "";
            str = arrStr.Substring(1, arrStr.Length - 1) + "}";
            return str;
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
        }
        
        private void saveImage_Click(object sender, EventArgs e)
        {

        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
