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
using System.Runtime.CompilerServices;

namespace musilla
{
    public partial class albumbilgileri : Form
    {
        public albumbilgileri()
        {
            InitializeComponent();
        }
        arama arama = new arama();
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        OleDbDataReader oku;
        DataSet ds;
        int sayac = 0,dakika,saniye;
        string SarkiOynat,aAlbum;
        
        public void AlbumDetail()
        {
            baglan.Open();
            //sanatci
            komut = new OleDbCommand("SELECT s.kullaniciadi FROM albumler as a,sanatcilar as s WHERE a.sanatcilarid = s.Kimlik and a.Kimlik = " +arama.aAlbum+ "",baglan);
            oku = komut.ExecuteReader();
            while(oku.Read())
            {
                AboutLabel.Text = oku[0].ToString();
                break;
            }
            //çıkışyılı
            komut = new OleDbCommand("SELECT albumyili FROM albumler WHERE Kimlik=" + arama.aAlbum + "", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                AboutLabel.Text +=" • "+oku[0].ToString();
                break;
            }
            //şarkısayısı
            komut = new OleDbCommand("SELECT * FROM sarkilar WHERE albumler=" + arama.aAlbum + "", baglan);
            oku = komut.ExecuteReader();
            sayac = 0;
            while (oku.Read())
            {
                sayac += 1;
            }
            AboutLabel.Text += " • " + sayac.ToString()+" şarkı";
            //sürei
            komut = new OleDbCommand("SELECT * FROM sarkilar WHERE albumler=" + arama.aAlbum + "", baglan);
            oku = komut.ExecuteReader();
            dakika = 0;
            saniye = 0;
            while (oku.Read())
            {
                string[] et = oku["sure"].ToString().Split(':');
                dakika += Convert.ToInt32(et[0]);
                saniye += Convert.ToInt32(et[1]);

            }
            dakika += saniye / 60;
            saniye = saniye % 60;
            AboutLabel.Text += " • " + dakika + " dk. "+saniye+" sn";

            baglan.Close();
        }
        public void AlbumName()
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT isim FROM albumler WHERE Kimlik="+arama.aAlbum+"",baglan);
            oku =komut.ExecuteReader();
            while(oku.Read()) 
            {
                NameLabel.Text = oku[0].ToString();
                break;
            }
            baglan.Close();
        }
        public void AlbumSongs()
        {
            AlbumSongDGV.Rows.Clear();
            baglan.Open();
            komut = new OleDbCommand("SELECT s.sarkiID,s.isim,sa.kullaniciadi,t.musictur,s.sure FROM sarkilar as s,sanatcilar as sa,musictur as t WHERE s.sanatciid = sa.Kimlik and s.tur = t.Kimlik and s.albumler="+arama.aAlbum+"", baglan);
            oku = komut.ExecuteReader();
            if(oku.HasRows)
            {
                while (oku.Read())
                {
                    AlbumSongDGV.Rows.Add(oku["isim"], oku["kullaniciadi"], oku["musictur"], oku["sure"]);
                }
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Bu Albüme ait bir şarkı bulunamadı.");
            }
        }
        private void albumbilgileri_Load(object sender, EventArgs e)
        {
            AlbumDetail();
            AlbumName();
            AlbumSongs();

        }

        private void aSarkiCal_Click(object sender, EventArgs e)
        {
            if (SarkiOynat != null)
            {
                MessageBox.Show(SarkiOynat);
            }
            else
            {
                MessageBox.Show("Şarkı Seçiniz");
            }
            
        }

        private void AlbumSongDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SarkiOynat =AlbumSongDGV.SelectedRows[0].Cells["sarkiID"].Value.ToString();
        }

        private void AlbumSongDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void albumbilgilerigeri_Click(object sender, EventArgs e)
        {
            arama arama = new arama();
            arama.Show();
            this.Close();
        }
    }
}
