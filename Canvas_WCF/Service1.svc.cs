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
            int client = -1, newOrder = -1;

            client = insertClient(order.clientID, order.phone, order.address, order.fullName, order.city, order.zipCode, order.POB);
            if (client > 0)
            {
                newOrder = insertOrder(order.amount, order.pattern, client, order.deliveryMethod);
                if (newOrder > 0)
                {
                    for (int i = 0; i < order.textsList.Count; i++)
                        insertText(newOrder, order.textsList[i].fontFamily, order.textsList[i].textBody, order.textsList[i].fontColor, order.textsList[i].fontSize, order.textsList[i].top, order.textsList[i].left, order.textsList[i].angle);
                    for (int i = 0; i < order.picturesList.Count; i++)
                        insertPicture(newOrder, order.picturesList[i].fileName, order.picturesList[i].fileBody, (int)order.picturesList[i].fileSize, order.picturesList[i].size, (int)order.picturesList[i].top, (int)order.picturesList[i].left, order.picturesList[i].angle);
                    
                }
            }
               
            return newOrder;
        }

        private static int insertClient(string eMail, string phone, string address, string fullName, string city, int zip, int POB)
        {
            //List<SqlParameter> _params = new List<SqlParameter>();
            //_params.Add(new SqlParameter("@EMail", eMail));
            //_params.Add(new SqlParameter("@Phone", phone));
            //_params.Add(new SqlParameter("@Address", address));
            //_params.Add(new SqlParameter("@FullName", fullName));
            //_params.Add(new SqlParameter("@City", city));
            //_params.Add(new SqlParameter("@Zip", zip));
            //_params.Add(new SqlParameter("@POB", POB));
            //DataTable dt = HELPER_SQL.ExecSP_DataTable("Canvas_DB", "Canvas_DB_Client_Insert", _params);
            //int res = -1;
            //if (dt == null || dt.Rows.Count == 0)
            //    return res;
            //int.TryParse(dt.Rows[0][0].ToString(), out res);

            //return res;

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Data Source=DESKTOP-BUV55UA; Initial Catalog=Canvas_DB; Integrated Security=true; ";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "Canvas_DB_Client_Insert";
            cmd.Parameters.Add(new SqlParameter("@EMail", eMail));
            cmd.Parameters.Add(new SqlParameter("@Phone", phone));
            cmd.Parameters.Add(new SqlParameter("@Address", address));
            cmd.Parameters.Add(new SqlParameter("@FullName", fullName));
            cmd.Parameters.Add(new SqlParameter("@City", city));
            cmd.Parameters.Add(new SqlParameter("@Zip", zip));
            cmd.Parameters.Add(new SqlParameter("@POB", POB));

            con.Open();
            int res = (int)cmd.ExecuteScalar();
            con.Close();
            return res;
        }

        private static int insertOrder(int amount, int pattern, int client, int delivery)
        {
            //List<SqlParameter> _params = new List<SqlParameter>();
            //_params.Add(new SqlParameter("@OrderDate", DateTime.Now));
            //_params.Add(new SqlParameter("@Amount", amount));
            //_params.Add(new SqlParameter("@Pattern", pattern));
            //_params.Add(new SqlParameter("@Client", client));
            //_params.Add(new SqlParameter("@Delivery", delivery));
            //DataTable dt = HELPER_SQL.ExecSP_DataTable("Canvas_DB", "Canvas_DB_Order_Insert", _params);
            //int res = -1;
            //if (dt == null || dt.Rows.Count == 0)
            //    return res;
            //int.TryParse(dt.Rows[0][0].ToString(), out res);

            //return res;

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Data Source=DESKTOP-BUV55UA; Initial Catalog=Canvas_DB; Integrated Security=true; ";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "Canvas_DB_Order_Insert";
            cmd.Parameters.Add(new SqlParameter("@OrderDate", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@Amount", amount));
            cmd.Parameters.Add(new SqlParameter("@Pattern", pattern));
            cmd.Parameters.Add(new SqlParameter("@Client", client));
            cmd.Parameters.Add(new SqlParameter("@Delivery", delivery));

            con.Open();
          //  int res = (int)cmd.ExecuteScalar();
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return res;
        }

        private static int insertPicture(int ord_ID, string fileName, byte[] fileBody, int fileSize,  float size, int top, int left, float angle)
        {
            //List <SqlParameter> _params = new List<SqlParameter>();
            //_params.Add(new SqlParameter("@ORD_ID", ord_ID));
            //_params.Add(new SqlParameter("@FileName", fileName));
            //_params.Add(new SqlParameter("@FileBody", fileBody));
            //_params.Add(new SqlParameter("@FileSize", fileSize));
            //_params.Add(new SqlParameter("@Size", size));
            //_params.Add(new SqlParameter("@Top", top));
            //_params.Add(new SqlParameter("@Left", left));
            //_params.Add(new SqlParameter("@Angle", angle));
            //DataTable dt = HELPER_SQL.ExecSP_DataTable("Canvas_DB", "Canvas_DB_Picture_Insert", _params);
            //int res = -1;
            //if (dt == null || dt.Rows.Count == 0)
            //    return res;
            //int.TryParse(dt.Rows[0][0].ToString(), out res);
            //return res;

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Data Source=DESKTOP-BUV55UA; Initial Catalog=Canvas_DB; Integrated Security=true; ";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "Canvas_DB_Picture_Insert";
            cmd.Parameters.Add(new SqlParameter("@OrderID", ord_ID));
            cmd.Parameters.Add(new SqlParameter("@FileName", fileName));
            cmd.Parameters.Add(new SqlParameter("@FileBody", fileBody));
            cmd.Parameters.Add(new SqlParameter("@FileSize", fileSize));
            cmd.Parameters.Add(new SqlParameter("@Size", size));
            cmd.Parameters.Add(new SqlParameter("@Top", top));
            cmd.Parameters.Add(new SqlParameter("@Left", left));
            cmd.Parameters.Add(new SqlParameter("@Angle", angle));

            con.Open();
           // int res = (int)cmd.ExecuteScalar();
           int res = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            return res;
        }

        private static int insertText(int ord_ID, string font, string body, string color, int size, float top, float left, float angle)
        {
            //List<SqlParameter> _params = new List<SqlParameter>();
            //_params.Add(new SqlParameter("@ORD_ID", ord_ID));
            //_params.Add(new SqlParameter("@Font", font));
            //_params.Add(new SqlParameter("@Body", body));
            //_params.Add(new SqlParameter("@Color", color));
            //_params.Add(new SqlParameter("@Size", size));
            //_params.Add(new SqlParameter("@Top", top));
            //_params.Add(new SqlParameter("@Left", left));
            //_params.Add(new SqlParameter("@Angle", angle));
            //DataTable dt = HELPER_SQL.ExecSP_DataTable("Canvas_DB", "Canvas_DB_Text_Insert", _params);
            //int res = -1;
            //if (dt == null || dt.Rows.Count == 0)
            //    return res;
            //int.TryParse(dt.Rows[0][0].ToString(), out res);
            //return res;

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Data Source=DESKTOP-BUV55UA; Initial Catalog=Canvas_DB; Integrated Security=true; ";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "Canvas_DB_Text_Insert";
            cmd.Parameters.Add(new SqlParameter("@OrderID", ord_ID));
            cmd.Parameters.Add(new SqlParameter("@Font", font));
            cmd.Parameters.Add(new SqlParameter("@Body", body));
            cmd.Parameters.Add(new SqlParameter("@Color", color));
            cmd.Parameters.Add(new SqlParameter("@Size", size));
            cmd.Parameters.Add(new SqlParameter("@Top", top));
            cmd.Parameters.Add(new SqlParameter("@Left", left));
            cmd.Parameters.Add(new SqlParameter("@Angle", angle));

            con.Open();
            // int res = (int)cmd.ExecuteScalar();
            int res = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return res;
        }
    }
}
