using musilla.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace musilla
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
        #region FormBorderStyle
        [DllImport("user32.DLL")]
        private extern static int SendMessage(System.IntPtr handle, int Msg, int one, int two);
        [DllImport("user32.DLL")]
        private extern static bool ReleaseCapture();
        private void FormBorderStyle_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (ReleaseCapture())
                {
                    SendMessage(Handle, 0xA1, 0x2, 0);
                }
            }
        }
        private void FormBorderStyle2_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (ReleaseCapture())
                {
                    SendMessage(Handle, 0xA1, 0x2, 0);
                }
            }
        }
        #endregion
        public void OpenChildForm(Form childForm)
        {
            //open only form
            currentChildForm?.Close();
            currentChildForm?.Dispose();
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PagesPanel.Controls.Add(childForm);
            PagesPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            PageNameLabel.Text = "Ana Sayfa";
            currentChildForm?.Close();
            currentChildForm?.Dispose();
        }

        private void LibraryPageButton_Click(object sender, EventArgs e)
        {
            PageNameLabel.Text = "Kitaplık";
            OpenChildForm(new kitaplik());
        }

        private void SearchPageButton_Click(object sender, EventArgs e)
        {
            PageNameLabel.Text = "Arama";
            OpenChildForm(new arama());
        }

        private void SettingsPageButton_Click(object sender, EventArgs e)
        {
            PageNameLabel.Text = "Ayarlar";
            OpenChildForm(new kullaniciayarlari());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseAccountButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void PagesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
