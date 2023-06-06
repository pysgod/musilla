using System;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace musilla
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }


        #region  FormBorderStyle

        [DllImport("user32.DLL")]
        private extern static int SendMessage(System.IntPtr handle, int Msg, int one, int two);
        [DllImport("user32.DLL")]
        private extern static bool ReleaseCapture();
        private void FormBorderStylePanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ReleaseCapture())
                {
                    SendMessage(Handle, 0xA1, 0x2, 0);
                }
            }
        }

        #endregion


        public static string yol = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "/../../Debug/musillaDB.accdb";
        OleDbConnection baglan = new OleDbConnection(yol);
        OleDbCommand komut;
        OleDbDataReader oku;
        bool reapeting = false;
        public void Register()
        {
            string Mail = RegMailBox.Text;
            string[] et = Mail.Split('@');
            if (RegUserNameBox.Text == "")
            {
                RegAlertLabel.Text = "Kullanıcı adını doldur.";
            }
            else if (RegMailBox.Text == "")
            {
                RegAlertLabel.Text = "Eposta adresini doldur.";
            }
            else if (RegPassBox.Text == "")
            {
                RegAlertLabel.Text = "Şifre alanını doldur.";
            }
            else if (RegPassBoxAgain.Text == "")
            {
                RegAlertLabel.Text = "Şifreni tekrar alanını doldur.";
            }
            else if (RegPassBox.Text != RegPassBoxAgain.Text)
            {
                RegAlertLabel.Text = "Şifreler uyuşmuyor.";
            }
            else
            {
                if (et[1] == "gmail.com" || et[1] == "gmail.com.tr" || et[1] == "icloud.com" || et[1] == "outlook.com" || et[1] == "outlook.com.tr" || et[1] == "yandex.com")
                {
                    UserControl(); 
                    if (reapeting == false)
                    {
                        DataUserCreate();
                    }
                    else
                    {
                        RegAlertLabel.Text = "Eposta adresi zaten kayıtlı.";
                    }
                }
                else
                {
                    RegAlertLabel.Text = "Geçerli eposta adresi giriniz.";
                }
            }
        } //datausercreate ve usercontrol burada çağrılıyor (hepsini bir fonksiyonda yapmak daha düzenli gedi bana hocam)
        public void DataUserCreate()
        {
            baglan.Open();
            komut = new OleDbCommand("Insert Into kullanicilar (kullaniciadi,Eposta,sifre) Values ('" + RegUserNameBox.Text + "','" + RegMailBox.Text + "','" + RegPassBox.Text + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        public void UserControl()
        {
            baglan.Open();
            komut = new OleDbCommand("Select * from kullanicilar where Eposta ='" + RegMailBox.Text + "'", baglan);
            oku = komut.ExecuteReader();
            reapeting = false;
            if (oku.Read())
            {
                reapeting = true;

            }
            else
            {
                reapeting = false;
            }
            baglan.Close();

        }
        private void KayitForm_Load(object sender, EventArgs e)
        {

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegPassShow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RegPassShow.Checked == false)
            {
                RegPassBox.PasswordChar = '•';
                RegPassBoxAgain.PasswordChar = '•';
                RegPassShow.Text = "göster";
            }
            else
            {
                RegPassBox.PasswordChar = '\0';
                RegPassBoxAgain.PasswordChar = '\0';
                RegPassShow.Text = "gizle";

            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
