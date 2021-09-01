using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace DesktopApp_CreateCode_Winform
{
    public partial class frmUpdateTeamcs : Form
    {
        List<ItemCustomFile.OptionOTD> option;

        public frmUpdateTeamcs()
        {
            InitializeComponent();
            ItemCustomFile.AllFile file = new ItemCustomFile.AllFile();
            DesktopApp_CreateCode_Winform.frmAdd frmAdd = new DesktopApp_CreateCode_Winform.frmAdd(true);
            string json = frmAdd.GET(file.readFile() + "/option");
            option = getOption(json);

            for (int i = 0; i < option.Count; i++)
            {
                cbChonNhom.Items.Add(option[i].code + ": " + option[i].note);

            }

        }
        private List<ItemCustomFile.OptionOTD> getOption(string json)
        {

            string[] arr = json.Split('}');
            List<ItemCustomFile.OptionOTD> arrOption = new List<ItemCustomFile.OptionOTD>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                string value = "";

                value = arr[i].Substring(1, arr[i].Length - 1) + "}";

                ItemCustomFile.OptionOTD option = new ItemCustomFile.OptionOTD(value);

                arrOption.Add(option);

            }

            return arrOption;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            postData();
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
        void postData()
        {
            // link + "/option/:code"
            // body { "note":"DA>Daas"} 
            string url = getFile.readFile() + "/option/"+ txtKytu.Text;
            MessageBox.Show(url);
            MultipartContent data = new MultipartContent() {
                { new StringContent(txtGhichu.Text), "note"},
            };

            var res = UploadData(null, url, data);
            if (res != "")
            {
                if (res != "false")
                {
                    MessageBox.Show("Gửi thành công");
                }
                else
                {
                    MessageBox.Show("Chưa gửi được", "Xin hãy kiểm tra lại quá trình", MessageBoxButtons.OK);
                }
            }
        }

        private void cbChonNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKytu.Text = option[cbChonNhom.SelectedIndex].code;
            txtGhichu.Text = option[cbChonNhom.SelectedIndex].note;
        }

        private void txtKytu_TextChanged(object sender, EventArgs e)
        {
            // Chỉ cho nhập 1 ký tự. Nếu mà dài quá thì lấy kí tự đầu.
            //in hoa ký tự đầu lên.
            if (txtKytu.Text.Length >= 1)
            {
                txtKytu.Text = txtKytu.Text[0].ToString();
            }
        }

        private void frmUpdateTeamcs_Load(object sender, EventArgs e)
        {

        }
    }
}
