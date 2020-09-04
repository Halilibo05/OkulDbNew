using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulDB.DAL
{
    public class Helper
    {
        public int ExecuteNonQuery(SqlParameter[] p, String cmdtext)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["vtbaglantim"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                {

                    
                    cn.Open();
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    return cmd.ExecuteNonQuery();
                }


            }

        }
    }
}
