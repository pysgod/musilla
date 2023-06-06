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
using System.Data;


namespace musilla.Forms
{
    public partial class PlayListSelecter : Form
    {
        public PlayListSelecter()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataReader oku;
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        private void ListBoxs()
        {
            baglan.Open();
            komut = new OleDbCommand("SELECT isim,playlistID FROM playlistler WHERE kullaniciid in (select kullaniciID from kullanicilar where Eposta='"+ frm1.grsmailbox.Text +"')",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Listeler.Items.Add(oku["isim"].ToString());
                idler.Items.Add(oku["playlistID"].ToString());
            }
            baglan.Close();
        }
        private void SongAdd()
        {
            baglan.Open();
            komut = new OleDbCommand("INSERT INTO playlistkayit (sarkilarID,playlistID) VALUES ('"+ arama.aSarki + "','" + idler.SelectedIndex.ToString()  +"')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void PlayListSelecter_Load(object sender, EventArgs e)
        {
            ListBoxs();
        }

        private void Listeler_Click(object sender, EventArgs e)
        {
            idler.SelectedIndex = Listeler.SelectedIndex ;
            SongAdd();
            MessageBox.Show("şarkı eklendi");
            this.Close();
        }
    }
}
