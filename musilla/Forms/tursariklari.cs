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


namespace musilla
{
    public partial class tursariklari : Form
    {
        public tursariklari()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbDataReader oku;
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        DataSet ds;
        string tur, turad;
        public void tursarkilar()
        {
           // tur = turvearama.tlist;
            baglan.Open();
            adtr = new OleDbDataAdapter("Select s.isim as [Şarkılar],a.isim as [Albümler],s.sure as [🕒] from sarkilar as s,albumler as a WHERE s.albumler = a.Kimlik and s.tur in(select Kimlik from musictur where Kimlik="+tur+")",baglan);
            ds = new DataSet();
            adtr.Fill(ds, "sarkilar");
            tursarkilariDGV.DataSource = ds.Tables["sarkilar"];
            baglan.Close();
        }
        public void turadıtut() 
        {
            baglan.Open();
            komut = new OleDbCommand("select musictur from musictur where Kimlik="+tur+"",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                turad = oku[0].ToString();
                break;
            }
            baglan.Close();

        }



        private void tursariklari_Load(object sender, EventArgs e)
        {
            //tur = arama.tlist;
            tursarkilar();
            turadıtut();
            label2.Text = turad;
           
        }

        private void turlistgeritus_Click(object sender, EventArgs e)
        {
            //turvearama.Show();
            this.Close();
        }

        private void tsbegenilenlereeklebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
