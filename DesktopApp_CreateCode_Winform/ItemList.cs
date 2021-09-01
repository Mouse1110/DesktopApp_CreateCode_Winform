using DesktopApp_CreateCode_Winform;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemCustomList
{

    class DataCode
    {
        public String id;
        public String classCode;
        public String type;
        public String size;
        public String image;
        public DataCode(String json)
        {
            String[] data = json.Split(':');
            id = data[1].Split(',')[0].Substring(1, data[1].Split(',')[0].Length - 2);
            classCode = data[2].Split(',')[0].Substring(1, data[2].Split(',')[0].Length - 2);
            type = data[3].Split(',')[0].Substring(1, data[3].Split(',')[0].Length - 2);
            size = data[4].Split(',')[0].Substring(1, data[4].Split(',')[0].Length - 2);
           
            ItemCustomFile.AllFile file = new ItemCustomFile.AllFile();
            image =data[5].Substring(1, data[5].Length - 3);
        }
    }

    class PanelCustom
    {
        FlowLayoutPanel panel;
        TextBox tbID;
        TextBox tbClass;
        TextBox tbType;
        TextBox tbSize;
        DataCode data;
        Button btn;

        public PanelCustom(String jsonData)
        {
            data = new DataCode(jsonData);

            panel = new FlowLayoutPanel();
            customTextBox(ref tbID, 100, data.id);

            customTextBox(ref tbClass, 150, data.classCode);

            customTextBox(ref tbType, 100, data.type);

            customTextBox(ref tbSize, 100, data.size);
            buttonPress();
            addPanel();
        }

        private void customTextBox(ref TextBox tb, int width, String text)
        {
            tb = new TextBox();
            tb.BackColor = Color.FromArgb(224, 224, 224);
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Enabled = false;
            tb.ReadOnly = true;
            tb.Font = new Font(tb.Font.Name, 8, FontStyle.Bold);
            tb.ForeColor = Color.FromArgb(0, 0, 0);
            tb.Height = 2;
            tb.Margin = new System.Windows.Forms.Padding(15, 5, 65, 0);
            tb.Width = width;
            tb.TextAlign = HorizontalAlignment.Center;
            tb.Text = text;
        }

        private void buttonPress()
        {
            btn = new Button();
            btn.Width = 100;
            btn.Height = 25;
            btn.Text = "Hiển thị";
            btn.Click += Btn_Click;
        }



        private void addPanel()
        {
            panel.Controls.Add(tbID);
            panel.Controls.Add(tbClass);
            panel.Controls.Add(tbType);
            panel.Controls.Add(tbSize);
            panel.Controls.Add(btn);
        }

        public Panel create()
        {
            panel.Width = 900;
            panel.Height = 40;
            panel.BackColor = Color.FromArgb(255, 255, 255);
            panel.Padding = new System.Windows.Forms.Padding(5);
            panel.Dock = DockStyle.Top;
            return panel;
        }
        /// <summary>
        /// Button Press Show Popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            try
            {
                using (frmPopup frmPopup = new frmPopup(data.classCode, data.type, data.size, data.image, data.id, true))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    frmPopup.Owner = formBackground;
                    frmPopup.ShowDialog();
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Close();
            }
           
        }
    }
}
