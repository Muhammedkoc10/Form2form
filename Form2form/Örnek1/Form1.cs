using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> kullaniciAdlari = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';


            kullaniciAdlari.Add("admin");
            kullaniciAdlari.Add("modarator");
            kullaniciAdlari.Add("bilgeadam");
            kullaniciAdlari.Add("kullanici");
            kullaniciAdlari.Add("yonetici");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı yukarıdaki listede varsa ve şifre 1234 ise giriş yapma işlemi başarılı olsun. Form2'ye geçsin. Aksi halde, bir mesaj kutusu ile kullanıcı adı veya şifre hatalı  bilgi mesajını versin. Mesaj kutusundan ilgili butona basıldığında da Form1'deki textBoxları temizlesin.

            if (kullaniciAdlari.Contains(txtKullaniciAdi.Text) && txtSifre.Text == "1234")
            {
                Form2 frm = new Form2();  // Form 2'nin bir örneği alınır.
                frm.Show();  // Form 2 gösterilir
                this.Hide(); //  Form1'i (bu formu) gizler. Eğer Close() dersek uygulama kapanır. Çünkü uygulamanın ana formu Form1'dir.
                //this.Close();
                frm.KarsilamaMesajiniYaz(txtKullaniciAdi.Text);
            }
            else
            {
                DialogResult result = MessageBox.Show("Kullanıcı adı veya şifreniz yanlıştır!", "Uyarı Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK) // MessageBox'tan Tamam butonuna basıldığında metin kutularını temizlesin.
                {
                    txtKullaniciAdi.Text = string.Empty;
                    txtSifre.Text = "";
                }
            }
        }

        private void chkSıfreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSıfreGoster.Checked)
                txtSifre.PasswordChar = '\0';
            else
                txtSifre.PasswordChar = '*';
        }

        // Kaçış karakterleri nedir? Ne için kullanıllır? Açıklamalı araştırınız.

    }
}
