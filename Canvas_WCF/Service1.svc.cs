using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Canvas_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int GetOrder(OrderDetailes order)
        {
            return 0;
        }

        private static int insertClient(string eMail, string phone, string address, string fullName, string city, int zip, int POB)
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@EMail", eMail));
            _params.Add(new SqlParameter("@Phone", phone));
            _params.Add(new SqlParameter("@Address", address));
            _params.Add(new SqlParameter("@FullName", fullName));
            _params.Add(new SqlParameter("@City", city));
            _params.Add(new SqlParameter("@Zip", zip));
            _params.Add(new SqlParameter("@POB", POB));
            DataTable dt = HELPER_SQL.ExecSP_DataTable("Canvas_DB", "Canvas_DB_Client_Insert", _params);
            int res = -1;
            if (dt == null || dt.Rows.Count == 0)
                return res;
            int.TryParse(dt.Rows[0][0].ToString(), out res);
            return res;

        }
    }
}
