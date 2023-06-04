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
    public partial class adminsanatciayarlari : Form
    {
        public adminsanatciayarlari()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        OleDbDataReader oku;
        string salist;

        public void sanatcilar()
        {
            sanatcilarDGV.Rows.Clear();
            baglan.Open();
            komut = new OleDbCommand("SELECT Kimlik,kullaniciadi,ad,soyad,eposta,sifre from sanatcilar",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sanatcilarDGV.Rows.Add(oku["Kimlik"], oku["kullaniciadi"], oku["ad"], oku["soyad"], oku["eposta"], oku["sifre"]);   
            }
            baglan.Close();
        }
        public void duzenleme()
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT kullaniciadi,ad,soyad,eposta,sifre from sanatcilar where Kimlik="+salist+"", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                dkullaniciadi.Text = oku["kullaniciadi"].ToString();
                d1.Text = oku["ad"].ToString();
                d2.Text = oku["soyad"].ToString();
                d3.Text = oku["eposta"].ToString();
                d4.Text = oku["sifre"].ToString();

            }
            baglan.Close();
        }
        public void kaydet()
        {
            baglan.Open();
            komut = new OleDbCommand("Update sanatcilar set kullaniciadi='"+dkullaniciadi.Text+"', ad='"+d1.Text+"',soyad='"+d2.Text+"',eposta='"+d3.Text+"',sifre='"+d4.Text+"'",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        public void ekle()
        {
            baglan.Open();
            komut = new OleDbCommand("Insert Into sanatcilar (kullaniciadi,ad,soyad,eposta,sifre) values ('"+addk.Text+ "','"+add1.Text+ "','"+add2.Text+ "','"+add3.Text+ "','"+add4.Text+ "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        public void sil()
        {
            baglan.Open();
            komut = new OleDbCommand("DELETE FROM sanatcilar where Kimlik="+salist+"", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void adminsanatciayarlari_Load(object sender, EventArgs e)
        {
            sanatcilar();
            sanatcieklebuton.Enabled = false;
        }

        private void sanatcilarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            salist = sanatcilarDGV.SelectedRows[0].Cells["ID"].Value.ToString();
        }

        private void sanatcilarDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            duzenleme();
            sanatcilar();
        }

        private void dsave_Click(object sender, EventArgs e)
        {
            if (dkullaniciadi.Text == "" && d1.Text == "" && d2.Text == "" && d3.Text == "" && d4.Text == "")
            {
                MessageBox.Show("Kaydedilemedi.");
            }
            else
            {
                MessageBox.Show("Kaydedildi.");
                kaydet();
                sanatcilar();
            }
            
        }

        private void sanatcieklebuton_Click(object sender, EventArgs e)
        {
            ekle();
            add1.Text = "";
            add2.Text = "";
            add3.Text = "";
            add4.Text = "";
            addk.Text = "";
            sanatcilar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (salist!=null)
            {
                sil();
                sanatcilar();
            }
            else
            {
                MessageBox.Show("SEÇİM YAPINIZ");
            }
        }

        private void addk_TextChanged(object sender, EventArgs e)
        {
            sanatcieklebuton.Enabled = true;
        }
    }
}
