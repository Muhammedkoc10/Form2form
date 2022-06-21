using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriEkleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] isimler = new string[0];
        DateTime[] dogumTarihleri = new DateTime[0];
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "")
            {
                Array.Resize(ref isimler, isimler.Length + 1); // İsimler dizisinin yeni boyutu, şu ankinden 1 fazla olsun. Resize et!
                isimler[isimler.Length - 1] = txtAdSoyad.Text; // isimler dizisinin son indexine  (yani yeni açılmış olan alana) textBoxtan gelen  değeri at.

                Array.Resize(ref dogumTarihleri, dogumTarihleri.Length + 1);
                dogumTarihleri[dogumTarihleri.Length - 1] = dtDogumTarihi.Value; //dogumTarihleri dizisinin içinde son indexe dtDogumTarihi'ndeki değeri at. (Value property'si o an seçilen tarih bilgisini DateTime türünde tutar.)

                MessageBox.Show("Müşteri kaydı başarılı");
            }
            else
                MessageBox.Show("Lütfen Ad Soyad bilgisi giriniz");
        }

        public void MusteriBilgileriniGonder (out string[] musteriIsimler, out DateTime [] musteriDogumTarihleri)
        {
            //Form1'den bu metot tetiklendiğinde bu form için oluşturulup içeriği doldurulan diziler dışarıya fırlatılsın. (Form 1'e)
            musteriIsimler = isimler;
            musteriDogumTarihleri = dogumTarihleri;
        }

        private void btnListeyeDon_Click(object sender, EventArgs e)
        {
            // DialogResult cevabını kendi oluşturduğumuz butona tıklandığında ele alacağız. Bu sebeple Form2 formu DialogForm olarak açılmalıdır.
            DialogResult = DialogResult.OK;
        }
    }
}
