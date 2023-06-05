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
        
        public static string aSarki,aSanatci,aKullanici;
        public static bool aramaSarkiForm =false;
        public int gidenveri = 1;

        //void
        public void SearchSong()
        {
            sarkilarDGV.Rows.Clear();
            baglan.Open();
            komut = new OleDbCommand("SELECT s.sarkiID,s.isim,sa.kullaniciadi, a.isim as [albümler] , t.musictur, s.sure FROM sarkilar AS s,albumler AS a, musictur AS t,sanatcilar as sa WHERE s.albumler = a.Kimlik and s.sanatciid = sa.Kimlik and s.tur = t.Kimlik and s.isim LIKE '"+ SearchBox.Text +"%'",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sarkilarDGV.Rows.Add(oku["sarkiID"], oku["isim"], oku["kullaniciadi"], oku["albümler"], oku["musictur"], oku["sure"]);
            }
            baglan.Close();
        }
        public void SearchArtist()
        {
            sanatcilarDGV.Rows.Clear();
            baglan.Open();
            komut = new OleDbCommand("SELECT Kimlik,kullaniciadi,ad +' '+soyad as [Adı Soyadı] FROM sanatcilar Where kullaniciadi LIKE '"+SearchBox.Text+"%'", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sanatcilarDGV.Rows.Add(oku["Kimlik"], oku["kullaniciadi"], oku["Adı Soyadı"]);
            }
            baglan.Close();
        }
        public void SearchUser()
        {
            kullanicilarDGV.Rows.Clear();
            baglan.Open();
            komut = new OleDbCommand("SELECT kullaniciID,kullaniciadi FROM kullanicilar WHERE kullaniciadi LIKE '" + SearchBox.Text + "%'", baglan);
            oku=komut.ExecuteReader();
            while (oku.Read())
            {
                kullanicilarDGV.Rows.Add(oku["kullaniciID"], oku["kullaniciadi"]);
            }
            baglan.Close();
            
        }
        //void
        private void arama_Load(object sender, EventArgs e)
        {
            aramaSarkiForm = false;
            sanatcilarDGV.ClearSelection();
            kullanicilarDGV.ClearSelection();
            sarkilarDGV.ClearSelection();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text=="")
            {
                MessageBox.Show("Arama yapılamadı.");
            }
            else
            {
                SearchUser();
                SearchArtist();
                SearchSong();
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sarkilarDGV_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            sarkicalma sarkicalma = new sarkicalma(gidenveri);
            sarkicalma.Show();
            this.Close();
        }
        private void sanatcilarDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            aSanatci = sanatcilarDGV.SelectedRows[0].Cells["Kimlik"].Value.ToString();
        }
        private void sarkilarDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            aSarki = sarkilarDGV.SelectedRows[0].Cells["sarkiID"].Value.ToString();
        }

        private void kullanicilarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aKullanici = kullanicilarDGV.SelectedRows[0].Cells["kullaniciID"].Value.ToString();
        }

    }
}
