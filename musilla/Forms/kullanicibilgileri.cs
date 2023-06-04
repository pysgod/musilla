using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace musilla.Forms
{
    public partial class kullanicibilgileri : Form
    {
        public kullanicibilgileri()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        OleDbDataReader oku;
        DataSet ds;
        arama arama = new arama();
        

        public void UserName()
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT kullaniciadi FROM kullanicilar WHERE kullaniciID=" + arama.aKullanici + "", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                NameLabel.Text = oku[0].ToString();
                break;
            }
            baglan.Close();
        }
        public void UserDetail()
        {
            int say = 0;
            baglan.Open();
            komut = new OleDbCommand("SELECT * FROM playlistler WHERE kullaniciid="+arama.aKullanici+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                say++;
            }
            AboutLabel.Text = say+" Çalma Listesi";
            baglan.Close();
        }
        public void UserPlaylist()
        {
            UserDGV.Rows.Clear();
            baglan.Open();
            komut = new OleDbCommand("SELECT isim, aciklama FROM playlistler where kullaniciid="+arama.aKullanici+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                UserDGV.Rows.Add(oku["isim"], oku["aciklama"]);
            }
            baglan.Close();
        }
        private void kullanicibilgileri_Load(object sender, EventArgs e)
        {
            UserName();
            UserDetail();
            UserPlaylist();
        }

        private void albumbilgilerigeri_Click(object sender, EventArgs e)
        {
            arama.Show();
            this.Close();
        }
    }
}
