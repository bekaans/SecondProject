using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblOgrenci(OgrAd,OgrSoyad,OgrNumara,OgrFotograf,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)",SqlBaglanti.sql);
            if (komut1.Connection.State != ConnectionState.Open) {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            return komut1.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * from TblOgrenciler", SqlBaglanti.sql);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader sqlDataReader = komut2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                EntityOgrenci entity = new EntityOgrenci();
                entity.ID = Convert.ToInt32(sqlDataReader["OGRID"]);
                entity.AD = sqlDataReader["OgrAd"].ToString(); 
                entity.SOYAD = sqlDataReader["OgrSoyad"].ToString(); 
                entity.NUMARA = sqlDataReader["OgrNumara"].ToString(); 
                entity.FOTOGRAF = sqlDataReader["OgrFotograf"].ToString(); 
                entity.SIFRE = sqlDataReader["OgrSifre"].ToString(); 
             
                degerler.Add(entity);
            }
            sqlDataReader.Close();
            return degerler;
        }
    }
}
