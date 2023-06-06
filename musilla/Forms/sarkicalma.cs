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
using System.Security.Cryptography;

namespace musilla.Forms
{
    public partial class sarkicalma : Form
    {
        int gveri;
        public sarkicalma(int gelenveri)
        {
            InitializeComponent();
            gveri = gelenveri;
        }

        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataReader oku;
        OleDbDataAdapter adtr;
        public string url,GenelSarkiArama;
        public string sure;
        public string[] conv;

        public void GenelArama()
        {
            if (gveri == 1) 
            {
                GenelSarkiArama = arama.aSarki;
            }
            else if (gveri == 0)
            {
                GenelSarkiArama = calmalistesi.ClSarki;
            }

        }
        public void SongName()
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT isim FROM sarkilar WHERE sarkiID="+GenelSarkiArama+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                NameLabel.Text = oku[0].ToString();
            }
            baglan.Close();
        }
        public void SongPlay()
        {    
            baglan.Open();
            komut = new OleDbCommand("SELECT url FROM sarkilar WHERE sarkiID="+GenelSarkiArama+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                url = oku[0].ToString();
            }
            baglan.Close();
        }
        public void SongDetail() 
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT sa.kullaniciadi FROM sarkilar as s,sanatcilar as sa WHERE s.sanatciid = sa.Kimlik and s.sarkiID="+GenelSarkiArama+"", baglan);
            oku=komut.ExecuteReader();
            while (oku.Read())
            {
                AboutLabel.Text = oku[0].ToString();
            }

            komut = new OleDbCommand("SELECT sure From sarkilar where sarkiID="+GenelSarkiArama+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                AboutLabel.Text += " • " + oku[0].ToString();
            }
            baglan.Close();
        }
        public void SongLength()
        {

            baglan.Open();
            komut = new OleDbCommand("SELECT sure From sarkilar WHERE sarkiID="+GenelSarkiArama+"",baglan);
            oku=komut.ExecuteReader();
            while (oku.Read())
            {
                sure = oku[0].ToString();
                conv = sure.Split(':');
                break;
            }
            int saniye = (Convert.ToInt16(conv[0])*60)+ Convert.ToInt16(conv[1]);
            MessageBox.Show(saniye.ToString());
            baglan.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void sıradakimusic_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            if (gveri == 0)
            {
                (Application.OpenForms["anasayfa"] as anasayfa).OpenChildForm(new calmalistesi());
            }
            else if (gveri == 1)
            {
                (Application.OpenForms["anasayfa"] as anasayfa).OpenChildForm(new arama());
            }
        }

        private void sarkicalma_Load(object sender, EventArgs e)
        {
            GenelArama();
            SongPlay();
            SongName();
            SongDetail();
            SongLength();
            sarkicalmaui.Navigate(new Uri(url));

        }
    }
}
