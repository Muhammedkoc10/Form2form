using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PersonelEkleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 mainForm;

        List<string> adSoyadListesi = new List<string>();
        List<string> birimListesi = new List<string>();
        List<string> TCNoListesi = new List<string>();
        List<string> dogumyeriListesi = new List<string>();
        List<string> dogumTarihiListesi = new List<string>();
        List<string> CinsiyetListesi = new List<string>();

        public void ListeleriAl(List<string> adSoyad, List<string> birim,List<string> tcNo, List<string> dogumYeri, List<string> dogumTarihi, List<string> cinsiyet,Form1 gelenAnaForm)
        {
            adSoyadListesi = adSoyad;
            birimListesi = birim;
            TCNoListesi = tcNo;
            dogumyeriListesi = dogumYeri;
            dogumTarihiListesi = dogumTarihi;
            CinsiyetListesi = cinsiyet;
            mainForm = gelenAnaForm;
        }
        int goruntelemeIndexi;
        private void Form2_Load(object sender, EventArgs e)
        {
            goruntelemeIndexi = adSoyadListesi.Count - 1;

            KaydiGoruntule();
        }

        private void KaydiGoruntule()
        {
            // Form açıldığında en son eklenen kaydı göster
            lblKayit.Text += "Adı Soyadı: " + adSoyadListesi[goruntelemeIndexi];
            lblKayit.Text += "\nBirim: " + birimListesi[goruntelemeIndexi];
            lblKayit.Text += "\nTC No: " + TCNoListesi[goruntelemeIndexi];
            lblKayit.Text += "\nDoğum Yeri: " + dogumyeriListesi[goruntelemeIndexi];
            lblKayit.Text += "\nDoğum Tarihi: " + dogumTarihiListesi[goruntelemeIndexi];
            lblKayit.Text += "\nCinsiyet: " + CinsiyetListesi[goruntelemeIndexi];

            ButonlariKontrolEt();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // TODO: Form 2 açılığında eklenen en son kayıt ile açılacak. eğer listede birden fazla giriş var ise Form açıldığunda Geri butonu aktif, İleri butonu pasif olacak. Geri butonuna tıklandığında bir önceki kayıda gidecek. Eğer listelerin en başına geldiyse geri butonu pasif olacak. İleri butonu aktif olacak. Arada bir yerlerde ise iki butonda aktif olacak.
            if (goruntelemeIndexi > 0)
                goruntelemeIndexi--; // Bir önceki elemanın indexi olsun
            else
                goruntelemeIndexi = 0; // Aksi halde en ilk elemandayım. Görüntüleme indexim ilk elemanın indexi olsun.
            
            KaydiGoruntule(); // İlgili elemanın içerisindeki değerleri Label'a yaz.
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (goruntelemeIndexi < adSoyadListesi.Count - 1)
                goruntelemeIndexi++;
            else
                goruntelemeIndexi = adSoyadListesi.Count - 1;
            KaydiGoruntule(); // İlgili görünteleme indexi ile birlikte kaydı görüntüle.
           
        }

        private void ButonlariKontrolEt()
        {
            if (goruntelemeIndexi ==0) // İlk kayıttaysak
            {
                btnGeri.Enabled = false;

                if (adSoyadListesi.Count > 1) // Birden fazla kayıt var ve son kayıttaysak.
                    btnIleri.Enabled = true;
                else
                    btnIleri.Enabled = false;
            }
            else if (goruntelemeIndexi == adSoyadListesi.Count-1) // Son kayıttaysak.
            {
                btnIleri.Enabled = false;

                if (adSoyadListesi.Count > 1) // Birden fazla kayıt var ve son kayıttaysak.
                    btnGeri.Enabled = true;
                else
                    btnGeri.Enabled =false;
            }
            else
            {
                //  İlk veya son kayıtta değilsek
                btnGeri.Enabled = true;
                btnIleri.Enabled = true;
            }
        }
        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            // TODO: Label'ın içeriğini temizleyecek
            lblKayit.Text = "";
            btnTemizle2.Enabled = btnGeri.Enabled = btnIleri.Enabled = false; // Ekranı temizlediği için hangi elemandan geri veya ileri gideceği belli değildir. Dolayısıyla butonları enabled özelliği false olsun.
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
