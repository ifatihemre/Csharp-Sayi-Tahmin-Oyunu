using System;
using System.Data;
using System.Data.SqlClient;

namespace Oyunlar
{
    class Ayarlar
    {

        public static SqlConnection baglanti;

        public static void BaglantiAc() 
        {
            baglanti = new SqlConnection("Data Source=FATIMRENER; Initial Catalog=ders;Integrated Security=true");
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        
        }

        public static void BaglantiKapat() 
        {
            baglanti.Close();
        }

    }
}
