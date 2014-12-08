using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyunlar
{
    public partial class SuresizOyun : Form
    {
        public int sayi, girilen, hak, baslangic, bitis;

        public SuresizOyun()
        {
            InitializeComponent();
        }

        public void ResetIslemi()
        {
            SonucLabel.Visible = false;
            TahminKutu.Enabled = true;
            TahminButon.Enabled = true;
            ResetButon.Enabled = false;

            hak = 5;
            baslangic = 1; bitis = 10;

            Random s = new Random();
            sayi = s.Next(baslangic, bitis);
            SonucLabel.Text = sayi.ToString();

            MesajLabel.Text = "Bakalım sayıyı bulabilecek misiniz?";
            HakLabel.Text = "Kalan hakkınız: " + hak.ToString();
            AralikLabel.Text = baslangic + " ile" + bitis + " arasında sayı girin.";
        }

        private void SureliOyun_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            ResetIslemi();

        }

        public void TahminIslemi() 
        {
            if (int.TryParse(TahminKutu.Text, out girilen))
            {
                if (girilen <= bitis && girilen >= baslangic)
                {
                    hak--;
                    if (hak > 0)
                    {
                        if (girilen != sayi)
                        {
                            MesajLabel.Text = "Bilemediniz!";
                            HakLabel.Text = "Kalan hakkınız: " + hak.ToString();
                        }
                        else
                        {
                            MesajLabel.Text = "Tebrikler, sayıyı bildiniz!";
                            SonucLabel.Visible = true;
                            TahminKutu.Enabled = false;
                            TahminButon.Enabled = false;
                            ResetButon.Enabled = true;
                            ResetButon.Focus();
                        }
                    }
                    else
                    {
                        HakLabel.Text = "Hiç hakkınız kalmadı!";
                        MesajLabel.Text = "Bilmeniz gereken sayı:";
                        SonucLabel.Visible = true;
                        TahminButon.Enabled = false;
                        TahminKutu.Enabled = false;
                        ResetButon.Enabled = true;
                        ResetButon.Focus();
                    }
                }
                else
                {
                    MesajLabel.Text = "Lütfen " + baslangic + " ile " + bitis + " arasında bir sayı girin.";
                }
            }
            else
            {
                MesajLabel.Text = "Lütfen sadece sayı girin.";
            }

            TahminKutu.Clear();
            TahminKutu.Focus();
        }

        private void TahminButon_Click(object sender, EventArgs e)
        {
            TahminIslemi();
        }

        private void ResetButon_Click(object sender, EventArgs e)
        {
            ResetIslemi();
        }

        private void TahminKutu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TahminIslemi();
            }
        }
    }
}
