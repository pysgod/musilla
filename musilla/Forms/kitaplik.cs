using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace musilla
{
    public partial class kitaplik : Form
    {
        public kitaplik()
        {
            InitializeComponent();
        }
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];

        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbDataReader oku;
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        DataSet ds;
        string mail, id;
        public static string clad, clid, claciklama;

        public void idbulma()
        {
            mail = frm1.grsmailbox.Text;
            baglan.Open();
            komut = new OleDbCommand("Select kullaniciID from kullanicilar where Eposta='" + mail + "'", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                id = oku[0].ToString();
                break;
            }
            baglan.Close();

        }
        public void calmalisteleri()
        {
            calmalisteleriDGV.Rows.Clear();
            mail = frm1.grsmailbox.Text;
            baglan.Open();
            komut = new OleDbCommand("SELECT isim ,aciklama ,playlistID FROM playlistler WHERE kullaniciid in (select kullaniciID from kullanicilar where Eposta = '" + mail + "')", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                calmalisteleriDGV.Rows.Add(oku["playlistID"], oku["isim"], oku["aciklama"]);
            }
            baglan.Close();
        }
        public void listeekle()
        {
            baglan.Open();
            komut = new OleDbCommand("insert into playlistler (isim,kullaniciid) values ('Yeni Çalma Listesi','" + id + "')",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            baglan.Close();
        }
        public void listesil()
        {
            baglan.Open();
            komut = new OleDbCommand("DELETE from playlistler WHERE playlistID=" + clid + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void kitaplik_Load(object sender, EventArgs e)
        {
            idbulma();
            calmalisteleri();

        }
        private void kitaplikyenile_Click(object sender, EventArgs e)
        {
            calmalisteleri();
        }

        private void kitapliklisteyiac_Click(object sender, EventArgs e)
        {
            if (clid != null)
            {
                calmalistesi calmalistesi = new calmalistesi();
                calmalistesi.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("BİR SEÇİM YAPIN PLS");
            }
        }
        private void kitapliklisteyisil_Click(object sender, EventArgs e)
        {
            if (clid != null)
            {
                listesil();
                calmalisteleri();
            }
            else
            {
                MessageBox.Show("BİR SEÇİM YAPIN PLSS");
            }
        }

        private void kitapliklisteekle_Click(object sender, EventArgs e)
        {
            listeekle();
            calmalisteleri();
        }

        private void calmalisteleriDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calmalisteleriDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clid = calmalisteleriDGV.SelectedRows[0].Cells["playlistID"].Value.ToString();
        }

        private void kitapliksecilenlisteyiduzenleme_Click(object sender, EventArgs e)
        {  
            if (clid != null)
            {
                calmalistesidüzenleme cld = new calmalistesidüzenleme();
                cld.ShowDialog();
            }
            else
            {
                MessageBox.Show("BİR SEÇİM YAPIN PLSS");
            }
        }

        private void kitaplikgeritus_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }
      
        private void calmalisteleriDGV_SelectionChanged(object sender, EventArgs e)
        {      

        }

        

        
    }
}
