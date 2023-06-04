using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace musilla.Forms
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataReader oku;
        OleDbDataAdapter adtr;
        DataSet ds;
        public static string apSanatci, apKullanici;
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
            anapanel.Controls.Add(childForm);
            anapanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void anapanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminsanatciayarlari());
        }
        
    }
}
