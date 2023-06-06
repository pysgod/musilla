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
using System.Drawing.Imaging;

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
            calmalistesiDGV.Rows.Clear();   
            baglan.Open();
            komut = new OleDbCommand("SELECT s.sarkiID,s.isim,sa.kullaniciadi, a.isim as [albümler] , t.musictur, s.sure FROM sarkilar AS s,albumler AS a, musictur AS t,sanatcilar as sa WHERE s.albumler = a.Kimlik and s.sanatciid = sa.Kimlik and s.tur = t.Kimlik and sarkiID in ( select sarkilarID from playlistkayit where playlistID="+ kitaplik.clid +")", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                calmalistesiDGV.Rows.Add(oku["sarkiID"], oku["isim"], oku["kullaniciadi"], oku["albümler"], oku["musictur"], oku["sure"]);
            }
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
        private void sarkilarDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void DeleteFromList_Click(object sender, EventArgs e)
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

        private void calmalistesiDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClSarki = calmalistesiDGV.SelectedRows[0].Cells["sarkiID"].Value.ToString();
        }

        private void calmalistesiDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            (Application.OpenForms["anasayfa"] as anasayfa).OpenChildForm(new sarkicalma(gidenveri));
        }
    }
}
