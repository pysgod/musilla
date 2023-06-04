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
    public partial class adminpanelsanatci : UserControl
    {
        public adminpanelsanatci()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataAdapter adtr;
        OleDbDataReader oku;
         
        public void Sanatcilar()
        {
            baglan.Open();
            komut = new OleDbCommand("select Kimlik,kullaniciadi,ad,soyad,eposta,sifre FROM sanatcilar",baglan);
            oku = komut.ExecuteReader();
            while (oku.Read()) 
            {
                sanatcilarDGV.Rows.Add(oku["Kimlik"], oku["kullaniciadi"], oku["ad"], oku["soyad"], oku["eposta"], oku["sifre"]);
            }
            baglan.Close();
        }

        private void adminpanelsanatci_Load(object sender, EventArgs e)
        {
            Sanatcilar();
        }
    }
}
