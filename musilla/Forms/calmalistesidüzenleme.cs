using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace musilla
{
    public partial class calmalistesidüzenleme : Form
    {
        public calmalistesidüzenleme()
        {
            InitializeComponent();
        }
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbDataReader oku;
        OleDbCommand komut;
        string isim, aciklama;
        string id;
        public void Save()
        {
            id = kitaplik.clid;
            baglan.Open();
            komut = new OleDbCommand("Update playlistler set isim='" + cldcalmalistesiadi.Text + "',aciklama='" + cldcalmalistesiaciklamasi.Text + "' WHERE playlistID=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void NameAndExplanation()
        {
            id = kitaplik.clid;
            
            baglan.Open();
            komut = new OleDbCommand("Select isim ,aciklama from playlistler where playlistID="+ id +"", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                isim = oku["isim"].ToString();
                aciklama = oku["aciklama"].ToString();
                break;
            }
            baglan.Close();
            cldcalmalistesiadi.Text = isim;
            cldcalmalistesiaciklamasi.Text = aciklama;
        }
        private void calmalistesidüzenleme_Load(object sender, EventArgs e)
        {
            NameAndExplanation();
        }

        private void EditList_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
            (Application.OpenForms["kitaplik"] as kitaplik).Playlist();
        }
    }
}
