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
using System.Runtime.InteropServices.ComTypes;
using musilla.Forms;

namespace musilla
{
    public partial class calmalistesi : Form
    {
        public calmalistesi()
        {
            InitializeComponent();
        }
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        kitaplik kitaplik = new kitaplik();

        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbDataReader oku;
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        DataSet ds;
        public static string ClSarki;
        public static bool clform;
        public int gidenveri = 0;

        public void clsarkilari() 
        {
            baglan.Open();
            adtr = new OleDbDataAdapter("SELECT s.sarkiID,s.isim as [Şarkılar], a.isim as [Albümler], s.sure as [🕒] FROM sarkilar AS s, albumler AS a WHERE s.albumler = a.Kimlik and sarkiID in (SELECT sarkilarID FROM playlistkayit WHERE playlistID = "+kitaplik.clid+ ");", baglan);
            ds = new DataSet();
            adtr.Fill(ds, "playlistkayit");
            sarkilarDGV.DataSource = ds.Tables["playlistkayit"];
            sarkilarDGV.Columns[0].Visible = false;
            baglan.Close();
        }
        public void listedencikar()
        {
            baglan.Open();
            komut = new OleDbCommand("Delete from sarkilar where sarkiID="+ClSarki+"",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void calmalistesi_Load(object sender, EventArgs e)
        { 
            clsarkilari();
        }

        private void clgeritus_Click(object sender, EventArgs e)
        {
            kitaplik kitaplik = new kitaplik();
            kitaplik.Show();
            this.Close();
        }

        private void sarkilarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sarkilarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClSarki = sarkilarDGV.SelectedRows[0].Cells["sarkiID"].Value.ToString();
        }
        private void sarkilarDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sarkicalma sarkicalma = new sarkicalma(gidenveri);
            sarkicalma.Show();
            this.Hide();
        }

        private void cikarbuton_Click(object sender, EventArgs e)
        {
            if (ClSarki != null)
            {
                listedencikar();
                clsarkilari();
            }
            else
            {
                MessageBox.Show("Lütfen Şarki Seçiniz.");
            }
        }
    }
}
