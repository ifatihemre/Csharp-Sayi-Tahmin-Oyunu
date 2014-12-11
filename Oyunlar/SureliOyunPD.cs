using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; // SQL bağlantısı için gerekli olan namespace

namespace Oyunlar
{
    public partial class SureliOyunPD : Form
    {
        
        public SureliOyunPD()
        {
            InitializeComponent();
        }

        private void SureliOyunPD_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            PuanDurumu();
        }

        public void PuanDurumu()
        {

            DataTable veriler = new DataTable();

            
            Liste.View = View.Details;

            Liste.Columns.Clear();
            Liste.Columns.Add("Sıra", 30, HorizontalAlignment.Left);
            Liste.Columns.Add("İsim", 50, HorizontalAlignment.Left);
            Liste.Columns.Add("Puan", 40, HorizontalAlignment.Left);
            Liste.Columns.Add("Tarih", 83, HorizontalAlignment.Left);

            try
            {
                Ayarlar.BaglantiAc();

                SqlCommand komut = new SqlCommand("SELECT TOP 10 ROW_NUMBER() OVER(ORDER BY Puan DESC,Tarih DESC) as Sıra, Isim, Puan, Tarih FROM PuanDurumu WHERE Tip = 'Süreli'", Ayarlar.baglanti);

                SqlDataAdapter tablo = new SqlDataAdapter(komut);

                tablo.Fill(veriler);

                Liste.Items.Clear();

                for (int i = 0; i < veriler.Rows.Count; i++)
                {
                    DataRow satir = veriler.Rows[i];

                    if (satir.RowState != DataRowState.Deleted)
                    {
                        ListViewItem item = new ListViewItem(satir["Sıra"].ToString());
                        item.SubItems.Add(satir["Isim"].ToString());
                        item.SubItems.Add(satir["Puan"].ToString());
                        item.SubItems.Add(satir["Tarih"].ToString());

                        Liste.Items.Add(item);
                    }
                }

                Ayarlar.BaglantiKapat();

            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

        }
        
        public void Sifirla()
        {

            if (MessageBox.Show("Puanları sıfırlamak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Ayarlar.BaglantiAc();

                    SqlCommand sifirla = new SqlCommand("DELETE FROM PuanDurumu WHERE Tip = 'Süreli'", Ayarlar.baglanti);

                    sifirla.ExecuteNonQuery();

                    Ayarlar.BaglantiKapat();

                    PuanDurumu();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message);
                }
                
            }

        }

        private void SifirlaButon_Click(object sender, EventArgs e)
        {
            Sifirla();
        }

       
        
    }
}
