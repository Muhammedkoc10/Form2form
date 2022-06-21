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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = "";

        }
        public void KarsilamaMesajiniYaz (string kullaniciAdi)
        {
            lblKullaniciAdi.Text = "Hoşgeldiniz " + kullaniciAdi; 
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult Cikis;
            //Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            //if (Cikis == DialogResult.Yes)
            //{
                Application.Exit();
            //}
            //if (Cikis == DialogResult.No)
            //{
            //    Application.Run();
            //}
        }
    }
}
