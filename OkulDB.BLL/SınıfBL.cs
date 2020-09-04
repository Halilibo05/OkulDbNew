using OkulDB.DAL;
using OkulDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulDB.BLL
{
    public class SınıfBL
    {
        
        public bool SnfKaydet(Sınıflar sınıf)
        {
            Helper helper = new Helper();
            SqlParameter[] p={
            new SqlParameter("@SınıfAd",sınıf.SınıfAd),
            new SqlParameter("@Kontenjan",sınıf.Kontenjan)
            };

           return helper.ExecuteNonQuery(p, "Insert into tblSınıflar Values(@SınıfAd,@Kontenjan)") > 0;

        }


    }
}
