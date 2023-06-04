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

namespace musilla
{
    public partial class calmalistesidüzenleme : Form
    {
        public calmalistesidüzenleme()
        {
            InitializeComponent();
        }
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        kitaplik kitaplik = new kitaplik();
        OleDbConnection baglan =new OleDbConnection(Form1.yol);
        OleDbDataAdapter adtr;
        OleDbDataReader oku;
        OleDbCommand komut;

        string id;
        public void kaydet() 
        {
            id = kitaplik.clid;
            baglan.Open();
            komut = new OleDbCommand("Update playlistler set isim='"+cldcalmalistesiadi.Text+"',aciklama='"+cldcalmalistesiaciklamasi.Text+"' WHERE playlistID="+id+"",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void calmalistesidüzenleme_Load(object sender, EventArgs e)
        {
            cldcalmalistesiadi.Text = kitaplik.clad;
            cldcalmalistesiaciklamasi.Text = kitaplik.claciklama;
        }

        private void cldkaydetbtn_Click(object sender, EventArgs e)
        {
            kaydet();
            this.Close();
        }
    }
}
