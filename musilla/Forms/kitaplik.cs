using musilla.Forms;
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
        string mail, id, isim;
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
        public void Playlist()
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
        public void ListName()
        {
            baglan.Open();
            komut = new OleDbCommand("Select isim From playlistler where playlistID=" + clid + "",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                isim = oku[0].ToString();
                break;
            }
            baglan.Close();
            SelectedPlaylist.Text = isim;
        }
        public void AddList()
        {
            baglan.Open();
            komut = new OleDbCommand("insert into playlistler (isim,kullaniciid) values ('Yeni Çalma Listesi','" + id + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            baglan.Close();
        }
        public void DelList()
        {
            baglan.Open();
            komut = new OleDbCommand("DELETE from playlistler WHERE playlistID=" + clid + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void kitaplik_Load(object sender, EventArgs e)
        {
            idbulma();
            Playlist();
            calmalisteleriDGV.ClearSelection(); 
        }

        private void calmalisteleriDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clid = calmalisteleriDGV.SelectedRows[0].Cells["playlistID"].Value.ToString();
            ListName();
        }

        private void CreateList_Click(object sender, EventArgs e)
        {
            AddList();
            Playlist();

        }

        private void EditList_Click(object sender, EventArgs e)
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

        private void OpenList_Click(object sender, EventArgs e)
        {
            if (clid != null)
            {
                (Application.OpenForms["anasayfa"] as anasayfa).OpenChildForm(new calmalistesi());
            }
            else
            {
                MessageBox.Show("BİR SEÇİM YAPIN PLSS");
            }
        }

        private void RefreshList_Click(object sender, EventArgs e)
        {
            Playlist();

        }

        private void DeleteList_Click(object sender, EventArgs e)
        {
            if (clid != null)
            {
                DelList();
                Playlist();
            }
            else
            {
                MessageBox.Show("BİR SEÇİM YAPIN PLSS");
            }
        }

    }
}
