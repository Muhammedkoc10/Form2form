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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[0];
        DateTime[] dogumTarihleri = new DateTime[0];
        
        string[] isimler2 = new string[0];
        DateTime[] dogumTarihleri2 = new DateTime[0];

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            if(frm2.ShowDialog() == DialogResult.OK)
            {
                frm2.MusteriBilgileriniGonder(out isimler, out dogumTarihleri);

                for (int i = 0; i < isimler.Length; i++)
                {
                    Array.Resize(ref isimler2, isimler2.Length + 1); // Bu formda kullanacağım isimler2 dizisinin boyutunu 1 arttırdım 
                    isimler2[isimler2.Length - 1] = isimler[i]; // Bu isimler 2 dizisinin son indexine Form2 den gelen isimlerin i. indexindeki elemanı attım.

                    Array.Resize(ref dogumTarihleri2, dogumTarihleri2.Length + 1);
                    dogumTarihleri2[dogumTarihleri2.Length - 1] = dogumTarihleri[i]; 
                }

                lbxMusteriler.Items.Clear();

                for (int i = 0; i < isimler2.Length; i++)
                {
                    // Bilge Adam -  25 => Yaş yıl bazında

                    int yas = DateTime.Now.Year - dogumTarihleri2[i].Year;

                    lbxMusteriler.Items.Add(isimler2[i] + " - " + yas);
                }
            }
        }
    }
}
