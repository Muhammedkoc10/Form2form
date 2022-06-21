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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkErkek.Checked = true;
            btnTemizle.Enabled = btnKaydiGoruntule.Enabled = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            /*foreach (Control item in this.Controls)*/// this.Controls => Bu formun kontrolleri
            foreach (Control item in grpPersonel.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                else if (item is CheckBox)
                {
                    if(((CheckBox)item).Name == "chkErkek")
                        ((CheckBox)item).Checked = true;
                }
                    
                else if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = DateTime.Now;
            }

            btnTemizle.Enabled = false; //Temizleme işlemi bittikten sonnra butonu pasife çekebiliriz. 
        }

        List<string> adSoyadList = new List<string>();
        List<string> birimList = new List<string>();
        List<string> TCNoList = new List<string>();
        List<string> dogumyeriList = new List<string>();
        List<string> dogumTarihiList = new List<string>();
        List<string> CinsiyetList = new List<string>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (BosAlanVarMi())
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }

            else
            {
            adSoyadList.Add(txtAdSoyad.Text);
            birimList.Add(txtBirim.Text);
            TCNoList.Add(txtTcNo.Text);
            dogumyeriList.Add(txtDogumYeri.Text);
            dogumTarihiList.Add(dtDogumTarihi.Text);
            CinsiyetList.Add(chkErkek.Checked ? "Erkek" : "Kadın");

            MessageBox.Show("Personel ekleme işlemi başarılı");

            btnTemizle.Enabled = btnKaydiGoruntule.Enabled = true;
            }
        }

        private bool BosAlanVarMi()
        {
            foreach (Control item in grpPersonel.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                        return true;
                }
                else if(item is DateTimePicker) // Sadece tarihler karşılaştırılıyor ve seçilen tarih bugün ile aynı ise 
                {
                    if (((DateTimePicker)item).Value.Date == DateTime.Now.Date)
                        return true;
                }
            }

            return false; // Yukarıdaki karar yapılarından herhangi bir return değeri geri döndürmez ise boş alan yoktur. False döndürür.
        }

        private void btnKaydiGoruntule_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ListeleriAl(adSoyadList,birimList,TCNoList, dogumyeriList, dogumTarihiList,CinsiyetList,this);
            frm.Show();
            this.Hide();
        }

        private void chkErkek_CheckedChanged(object sender, EventArgs e)
        {
            chkKadin.Checked = !chkErkek.Checked;
        }

        private void chkKadin_CheckedChanged(object sender, EventArgs e)
        {
            chkErkek.Checked = !chkKadin.Checked;
        }
    }
}
