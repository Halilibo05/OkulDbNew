using OkulDB.DAL;
using OkulDB.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulDB.BLL
{
    public class OgrenciBL
    {
        public bool kaydet(Ogrenci ogrenci)
        {
            if (ogrenci == null)
            {
                throw new NullReferenceException("Öğrenci nesnesi türetilemedi");
            }

            Helper helper = new Helper();
            SqlParameter[] p = {
                        new SqlParameter("@Ad",ogrenci.Ad),
                        new SqlParameter("@Soyad",ogrenci.Soyad),
                        new SqlParameter("@Numara",ogrenci.Numara)

                    };
            return helper.ExecuteNonQuery(p, "Insert into tblStudents Values(@Ad,@Soyad,@Numara)") > 0;
        }


    }
}
