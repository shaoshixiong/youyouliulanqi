using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace USbrowser
{
   public  class SqlHelper
    {
       public static SqlConnection sqlcon = new SqlConnection("server=.;database=USServer;uid=sa;pwd=sasa");
       public static bool Update(string sql) 
       {
           try
           {
               sqlcon.Open();
               using (SqlCommand sqlcmd = new SqlCommand(sql, sqlcon))
               {
                   return sqlcmd.ExecuteNonQuery() > 0 ? true : false;
               }
           }
           catch (Exception)
           {

               return false;
           }
           finally 
           {
               sqlcon.Close();
           }
         
       }
    }
}
