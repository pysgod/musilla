using musilla.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
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
        private void OpenChildForm(Form childForm)
        {
            //open only form
            currentChildForm?.Close();
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PagesPanel.Controls.Add(childForm);
            PagesPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainPageButton_Click(object sender, EventArgs e)
        {
           
        }

        private void LibraryPageButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new kitaplik());
        }
    }
}
