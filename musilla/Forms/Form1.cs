using musilla.Forms;
using System;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace musilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region  FormBorderStyle

        [DllImport("user32.DLL")]
        private extern static int SendMessage(System.IntPtr handle ,int Msg,int one , int two);
        [DllImport("user32.DLL")]
        private extern static bool ReleaseCapture();
        private void FormBorderStylePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ReleaseCapture())
                {
                    SendMessage(Handle, 0xA1,0x2,0);
                }
            }
        }

        #endregion

        public static string yol = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "/../../Debug/musillaDB.accdb";
        OleDbConnection baglan = new OleDbConnection(yol);
        OleDbCommand komut;
        OleDbDataReader oku;
        public void Login()
        {
            string mail = grsmailbox.Text;
            string[] et = mail.Split('@');

            if (grsmailbox.Text == "")
            {
                grsuyarilbl.Text = "Eposta alanını doldurunuz.";

            }
            else if (grspassbox.Text == "")
            {
                grsuyarilbl.Text = "Şifre alanını doldurunuz.";
            }
            else
            {
                if (et[1] == "gmail.com" || et[1] == "gmail.com.tr" || et[1] == "icloud.com" || et[1] == "outlook.com" || et[1] == "outlook.com.tr" || et[1] == "yandex.com")
                {
                    string email = "", sifre = "";
                    baglan.Open();
                    komut = new OleDbCommand("SELECT * FROM kullanicilar", baglan);
                    oku = komut.ExecuteReader();
                    bool eslesme = false;
                    while (oku.Read())
                    {
                        email = (oku["Eposta"]).ToString();
                        sifre = (oku["sifre"]).ToString();
                        if (email == grsmailbox.Text && sifre == grspassbox.Text)
                        {
                            eslesme = true;
                            break;
                        }
                    }
                    if (eslesme)
                    {
                        anasayfa anasayfa = new anasayfa();
                        anasayfa.Show();                    
                        this.Hide();
                       
                    }
                    else
                    {
                        grsuyarilbl.Text = "Eposta adresi ya da şifre hatalı.";
                    }
                    baglan.Close();
                }
                else
                {
                    grsuyarilbl.Text = "Geçerli bir eposta adresi giriniz.";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void PassShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (PassShowHide.Checked == false)
            {
                grspassbox.PasswordChar = '•';
                PassShowHide.Text = "göster";
            }
            else
            {
                grspassbox.PasswordChar = '\0';
                PassShowHide.Text = "gizle";

            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.Show();
            this.Hide();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormBorderStylePanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
