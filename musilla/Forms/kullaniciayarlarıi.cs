using System.Data.OleDb;
using System.Windows.Forms;

namespace musilla.Forms
{
    public partial class kullaniciayarlari : Form
    {
        public kullaniciayarlari()
        {
            InitializeComponent();
        }
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        OleDbConnection baglan = new OleDbConnection(Form1.yol);
        OleDbCommand komut;
        OleDbDataReader oku;
        public static bool isClicked = false, isPassButonClicked = false, mail = false;
        public static bool usedmail = false;
        public static string password;
        public static bool PassMatch = false;

        //pass setting
        public void PasswordFormOpens()
        {
            passuyarilbl.Text = "";
            NewPassword.Enabled = false;
            NewPasswordAgain.Enabled = false;
            OldPassword.Enabled = false;
            NewPassword.Text = "";
            NewPasswordAgain.Text = "";
            OldPassword.Text = "";
            NewPassButon.Text = "Düzenle";
        }
        public void PassEditing()
        {
            NewPassword.Enabled = true;
            NewPasswordAgain.Enabled = true;
            OldPassword.Enabled = true;
            NewPassButon.Text = "Kaydet";
            isPassButonClicked = true;
        }
        public void PasswordChecking()
        {
            password = "";
            baglan.Open();
            komut = new OleDbCommand("SELECT sifre FROM kullanicilar WHERE Eposta='" + frm1.grsmailbox.Text + "'", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                password = oku["sifre"].ToString();
                break;
            }
            baglan.Close();
            if (OldPassword.Text == password)
            {
                if (NewPassword.Text == NewPasswordAgain.Text)
                {
                    PassSave();
                    PasswordFormOpens();
                    MessageBox.Show("Şifreniz değiştirildi.");
                }
                else
                {
                    passuyarilbl.Text = "Girdiğiniz şifreler uyuşmuyor.";
                }
            }
            else
            {
                passuyarilbl.Text = "Şifreniz doğru olmadığından kaydedilmedi.";
            }
        }
        public void PassSave()
        {
            baglan.Open();
            komut = new OleDbCommand("UPDATE kullanicilar SET sifre='" + NewPassword.Text + "' WHERE Eposta='" + frm1.grsmailbox.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            isPassButonClicked = false;
        }
        //-------------------------------|
        //user setting-------------------|
        public void UserFormOpens()
        {
            baglan.Open();
            komut = new OleDbCommand("Select ad,soyad,kullaniciadi,Eposta from kullanicilar where Eposta='" + frm1.grsmailbox.Text + "'", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SettingNameBox.Text = oku["ad"].ToString();
                SettingSurnameBox.Text = oku["soyad"].ToString();
                SettingUserNameBox.Text = oku["kullaniciadi"].ToString();
                SettingMailBox.Text = oku["Eposta"].ToString();
                break;
            }
            baglan.Close();
            SettingNameBox.Enabled = false;
            SettingSurnameBox.Enabled = false;
            SettingUserNameBox.Enabled = false;
            SettingMailBox.Enabled = false;
            SettingPassBox.Enabled = false;
            SettingSaveButon.Text = "Düzenle";
            SettingPassBox.Text = "";
            setuyarilbl.Text = "";

        }
        public void UserEditing()
        {
            SettingNameBox.Enabled = true;
            SettingSurnameBox.Enabled = true;
            SettingUserNameBox.Enabled = true;
            SettingPassBox.Enabled = true;
            SettingSaveButon.Text = "Kaydet";
            isClicked = true;
        }
        public void UserPasswordChecking()
        {
            password = "";
            baglan.Open();
            komut = new OleDbCommand("SELECT sifre FROM kullanicilar WHERE Eposta='" + frm1.grsmailbox.Text + "'", baglan);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                password = oku["sifre"].ToString();
                break;
            }
            baglan.Close();
            if (SettingPassBox.Text == password)
            {
                UserSave();
                UserFormOpens();
                MessageBox.Show("Hesap bilgileri düzenlendi.");
            }
            else
            {
                setuyarilbl.Text = "Şifreniz doğru olmadığından kaydedilmedi.";
            }
        }
        public void UserSave()
        {
            baglan.Open();
            komut = new OleDbCommand("UPDATE kullanicilar SET ad='" + SettingNameBox.Text + "', soyad='" + SettingSurnameBox.Text + "', kullaniciadi='" + SettingUserNameBox.Text + "' Where Eposta='" + frm1.grsmailbox.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            isClicked = false;
        }

        private void kullaniciayarlarıi_Load(object sender, System.EventArgs e)
        {
            UserFormOpens();
            PasswordFormOpens();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
                this.Close();
        }

        private void NewPassButon_Click(object sender, System.EventArgs e)
        {
            if (isPassButonClicked == false)
            {
                PassEditing();
            }
            else
            {
                PasswordChecking();
            }
        }

        private void SettingSaveButon_Click(object sender, System.EventArgs e)
        {
            if (isClicked == false)
            {
                UserEditing();
            }
            else
            {
                UserPasswordChecking();

            }
        }
    }
}
