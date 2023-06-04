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
    public partial class sanatcibilgileri : Form
    {
        public sanatcibilgileri()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        OleDbDataReader oku;
        arama arama = new arama();
        int sayacs = 0, sayaca = 0;
        public void Sanatci()
        {
            baglan.Open();
            komut = new OleDbCommand("select kullaniciadi from sanatcilar where Kimlik="+arama.aSanatci+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                NameLabel.Text = oku[0].ToString();
                AboutLabel.Text = oku[0].ToString();
                break;
            }
            baglan.Close();
        }
        public void Songs()
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT isim,sure FROM sarkilar WHERE sanatciid="+arama.aSanatci+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                songDGV.Rows.Add(oku["isim"], oku["sure"]);
                sayacs++;
            }
            AboutLabel.Text +=" • "+sayacs+" şarkı,";
            baglan.Close();
        }
        public void Albums()
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT isim FROM albumler WHERE sanatcilarid=" + arama.aSanatci + "", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                albumDGV.Rows.Add(oku["isim"]);
                sayaca++;
            }
            AboutLabel.Text += sayaca + " albüm";
            baglan.Close();
        }

        private void albumbilgilerigeri_Click(object sender, EventArgs e)
        {
            arama.Show();
            this.Close();
        }

        private void sanatcibilgileri_Load(object sender, EventArgs e)
        {
            Sanatci();
            Songs();
            Albums();
        }
    }
}
