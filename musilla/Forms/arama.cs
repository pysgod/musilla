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
using musilla.Forms;
using System.Diagnostics;

namespace musilla
{
    public partial class arama : Form
    {
        public arama()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        OleDbDataReader oku;
        DataSet ds;
        
        public static string aSarki,aSanatci,aAlbum,aKullanici,aTur;
        public static bool aramaSarkiForm =false;
        public int gidenveri = 1;

        //void
        public void sarkiarama()
        {
            baglan.Open();
            adtr = new OleDbDataAdapter("SELECT s.sarkiID,s.isim AS [Şarkılar], a.isim AS [Albümler], t.musictur AS [Türler], s.sure AS [🕒] FROM sarkilar AS s,albumler AS a, musictur AS t WHERE s.albumler = a.Kimlik and s.tur = t.Kimlik and s.isim LIKE '"+ aramatxt.Text +"%'",baglan);
            ds = new DataSet();
            adtr.Fill(ds,"sarkilar");
            sarkilarDGV.DataSource = ds.Tables["sarkilar"];
            sarkilarDGV.Columns[0].Visible=false;
            baglan.Close();
        }
        public void sanatciarama()
        {
            baglan.Open();
            adtr = new OleDbDataAdapter("SELECT Kimlik,kullaniciadi as [Sanatçılar],ad +' '+soyad as [Adı Soyadı] FROM sanatcilar Where kullaniciadi LIKE '"+aramatxt.Text+"%'", baglan);
            ds = new DataSet();
            adtr.Fill(ds, "sanatcilar");
            sanatcilarDGV.DataSource = ds.Tables["sanatcilar"];
            sanatcilarDGV.Columns[0].Visible = false;
            baglan.Close();
            for (int i = 0; i <= 1; i++)
            {
                sanatcilarDGV.Columns[i].Width = sanatcilarDGV.Width / 2;
            }
        }
        public void albumarama()
        {
            baglan.Open();
            adtr = new OleDbDataAdapter("SELECT a.Kimlik,a.isim as [Albümler],s.kullaniciadi as [Sanatçısı],a.albumyili as [Çıkış Tarihi] FROM albumler as a,sanatcilar as s Where a.sanatcilarid = s.Kimlik and a.isim LIKE '" + aramatxt.Text + "%'", baglan);
            ds = new DataSet();
            adtr.Fill(ds, "albumler");
            albumlerDGV.DataSource = ds.Tables["albumler"];
            baglan.Close();
            albumlerDGV.Columns[0].Visible = false;
            for (int i = 0; i <= 2; i++)
            {
                albumlerDGV.Columns[i].Width = albumlerDGV.Width / 3;
            }
        }
        public void kullaniciarama()
        {
            baglan.Open();
            adtr = new OleDbDataAdapter("SELECT kullaniciID,kullaniciadi as [Kullanıcılar] FROM kullanicilar WHERE kullaniciadi LIKE '" + aramatxt.Text + "%'", baglan);
            ds = new DataSet();
            adtr.Fill(ds, "kullanicilar");
            kullanicilarDGV.DataSource = ds.Tables["kullanicilar"];
            kullanicilarDGV.Columns[0].Visible = false;
            baglan.Close();
            kullanicilarDGV.Columns[0].Width = kullanicilarDGV.Width;
            
        }
        public void turkontrol()
        {
            baglan.Open();
            adtr = new OleDbDataAdapter("Select Kimlik,musictur as [Türler] FROM musictur", baglan);
            ds = new DataSet();
            adtr.Fill(ds,"musictur");
            turlerDGV.DataSource = ds.Tables["musictur"];
            turlerDGV.Columns[0].Visible = false;
            baglan.Close(); 
        }
        //void
        private void arama_Load(object sender, EventArgs e)
        {
            aramaSarkiForm = false;
            turkontrol();
        }
        private void aramabuton_Click(object sender, EventArgs e)
        {
            sarkiarama();
            sanatciarama();
            albumarama();
            kullaniciarama();

        }

        private void turlerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aTur = turlerDGV.SelectedRows[0].Cells["Kimlik"].Value.ToString();
        }

 

        private void sarkilarDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            sarkicalma sarkicalma = new sarkicalma(gidenveri);
            this.Close();
            sarkicalma.Show();
            

        }

        private void albumlerDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            albumbilgileri albumbilgileri = new albumbilgileri();
            albumbilgileri.Show();
            this.Close();
        }

        private void sanatcilarDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sanatcibilgileri sanatcibilgileri = new sanatcibilgileri();
            sanatcibilgileri.Show();
            this.Close();
        }

        private void kullanicilarDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            kullanicibilgileri kullanicibilgileri = new kullanicibilgileri();
            kullanicibilgileri.Show();
            this.Close();
        }

        private void sarkilarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sarkilarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aSarki = sarkilarDGV.SelectedRows[0].Cells["sarkiID"].Value.ToString();
        }

        private void sanatcilarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aSanatci = sanatcilarDGV.SelectedRows[0].Cells["Kimlik"].Value.ToString();
        }
        private void albumlerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aAlbum = albumlerDGV.SelectedRows[0].Cells["Kimlik"].Value.ToString();
        }
        private void kullanicilarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aKullanici = kullanicilarDGV.SelectedRows[0].Cells["kullaniciID"].Value.ToString();
        }

    }
}
