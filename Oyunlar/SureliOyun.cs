using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient; //SQL Bağlantısı için gerekli kod.

namespace Oyunlar
{
    public partial class SureliOyun : Form
    {

        public int sayi, girilen, sure, baslangic, bitis;

        public SureliOyun()
        {
            InitializeComponent();
        }

        public void ResetIslemi()
        {
            //SonucLabel.Visible = false;
            TahminKutu.Enabled = true;
            TahminButon.Enabled = true;
            ResetButon.Enabled = false;

            sure = 60;
            
            GeriSayim.Interval = 1000;
            GeriSayim.Start();

            baslangic = 1; bitis = 100;

            Random s = new Random();
            sayi = s.Next(baslangic, bitis);
            SonucLabel.Text = sayi.ToString();

            MesajLabel.Text = "Bakalım sayıyı bulabilecek misiniz?";
            HakLabel.Text = "Kalan süreniz: " + sure.ToString();
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

                    
                        if (girilen != sayi)
                        {
                            MesajLabel.Text = "Bilemediniz!";
                            HakLabel.Text = "Kalan süreniz: " + sure.ToString();
                        }
                        else
                        {
                            GeriSayim.Stop();

                            MesajLabel.Text = "Tebrikler, sayıyı bildiniz!";
                            SonucLabel.Visible = true;
                            TahminKutu.Enabled = false;
                            TahminButon.Enabled = false;
                            ResetButon.Enabled = true;
                            ResetButon.Focus();

                            string ifade = Interaction.InputBox("Lütfen adınızı girin:", "Tebrikler, bildiniz!", "", 200, 200);
                            if (ifade.Length <= 0)
                            {
                                ifade = "Girilmemiş";
                            }

                            try
                            {
                                Ayarlar.BaglantiAc();
                                
                                SqlCommand komut = new SqlCommand("INSERT INTO PuanDurumu (Puan, Tip, Isim) VALUES (@Puan, @Tip, @Isim)", Ayarlar.baglanti);
                                
                                int puan = sure * 10;
                                
                                komut.Parameters.AddWithValue("@Puan", puan);
                                komut.Parameters.AddWithValue("@Tip", "Süreli");
                                komut.Parameters.AddWithValue("@Isim", ifade);

                                komut.ExecuteNonQuery();

                                Ayarlar.BaglantiKapat();
                                
                                MessageBox.Show("Puanınız: "+ puan);
                            }
                            catch(SqlException hata)
                            {
                                MessageBox.Show(hata.Message);
                            }
                            


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

        private void GeriSayim_Tick(object sender, EventArgs e)
        {

            if (sure > 0)
            {
                sure--;
                HakLabel.Text = "Kalan süreniz: " + sure.ToString();
            }
            else
            {
                GeriSayim.Stop();

                HakLabel.Text = "Hiç süreniz kalmadı!";
                MesajLabel.Text = "Bilmeniz gereken sayı:";
                SonucLabel.Visible = true;
                TahminButon.Enabled = false;
                TahminKutu.Enabled = false;
                ResetButon.Enabled = true;
                ResetButon.Focus();
            }


            
        }
    }
}
