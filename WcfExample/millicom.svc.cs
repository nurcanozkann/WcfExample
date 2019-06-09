using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "millicom" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select millicom.svc or millicom.svc.cs at the Solution Explorer and start debugging.
    public class millicom : Imillicom
    {
        public void DoWork()
        {
        }

        public DataSet getTemp()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Misc;user=sa;password=123456";
            SqlDataAdapter da = new SqlDataAdapter("selet * from ThoiTiet",con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
