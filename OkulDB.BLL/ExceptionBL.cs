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
    public class ExceptionBL
    {
        public bool ExceptionEkle(Exceptions ex)
        {
            SqlParameter[] p = {
            new SqlParameter("@Message",ex.Message),
            new SqlParameter("@StackTrace",ex.StackTrace),
            new SqlParameter("@Date",ex.Date)
            };

            Helper helper = new Helper();
            return helper.ExecuteNonQuery(p, "Insert into tblExceptions Values(@Message,@StackTrace,@Date)") > 0;

            
        }
    }
}
