using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DAL
/// </summary>
public static class HELPER_SQL
{
    enum SP_SqlReturnValType { ExecuteNonQueryType, ExecuteScalarType, ExecuteReaderType, ExecuteDataTableType, ExecuteDataRowType };

    /// <summary>
    /// 
    /// </summary>
    /// <param name="SqlConnectionStringName"></param>
    /// <param name="SP_Name"></param>
    /// <param name="ParamsList"></param>
    /// <returns></returns>
    public static int ExecSP_NonQuery(String SqlConnectionStringName, String SP_Name, List<SqlParameter> ParamsList)
    {
        return Convert.ToInt32(ExecGeneralSP(SqlConnectionStringName, SP_Name, ParamsList, SP_SqlReturnValType.ExecuteNonQueryType));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="SqlConnectionStringName"></param>
    /// <param name="SP_Name"></param>
    /// <param name="ParamsList"></param>
    /// <returns></returns>
    public static object ExecSP_Scalar(String SqlConnectionStringName, String SP_Name, List<SqlParameter> ParamsList)
    {
        return ExecGeneralSP(SqlConnectionStringName, SP_Name, ParamsList, SP_SqlReturnValType.ExecuteScalarType);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="SqlConnectionStringName"></param>
    /// <param name="SP_Name"></param>
    /// <param name="ParamsList"></param>
    /// <returns></returns>
    public static DataTable ExecSP_DataTable(String SqlConnectionStringName, String SP_Name, List<SqlParameter> ParamsList)
    {
        return (DataTable)ExecGeneralSP(SqlConnectionStringName, SP_Name, ParamsList, SP_SqlReturnValType.ExecuteDataTableType);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="SqlConnectionStringName"></param>
    /// <param name="SP_Name"></param>
    /// <param name="ParamsList"></param>
    /// <returns></returns>
    public static DataRow ExecSP_DataRow(String SqlConnectionStringName, String SP_Name, List<SqlParameter> ParamsList)
    {
        return (DataRow)ExecGeneralSP(SqlConnectionStringName, SP_Name, ParamsList, SP_SqlReturnValType.ExecuteDataRowType);
    }


    /// <summary>
    /// Must Call This Function :
    /// using (SqlDataReader reader = HELPER_SQL.ExecSP_Reader(..,..,..)) 
    /// { 
    /// }
    /// </summary>
    /// <param name="SqlConnectionStringName"></param>
    /// <param name="SP_Name"></param>
    /// <param name="ParamsList"></param>
    /// <returns></returns>
    public static SqlDataReader ExecSP_Reader(String SqlConnectionStringName, String SP_Name, List<SqlParameter> ParamsList)
    {
        return (SqlDataReader)ExecGeneralSP(SqlConnectionStringName, SP_Name, ParamsList, SP_SqlReturnValType.ExecuteReaderType);
    }


    #region Private Functions
    /// <summary>
    /// Execute Stored Procedure and Return The Result As Object
    /// </summary>
    /// <param name="SqlDBName">SQL ConnectionString as in web.config</param>
    /// <param name="SP_Name">Stored Procedure to Execute against DB</param>
    /// <param name="ParamsList">Add Params to SP-Command, call with Null if Non-Params</param>
    /// <param name="returnType">On ExecuteNonQuery/ExecuteScalar Close Connection, On ExecuteReader Close Connection On Reader.Close()</param>
    /// <returns>Return Int, Scalar(object), SqlDataReader As Object</returns>
    private static object ExecGeneralSP(String SqlConnectionStringName, String SP_Name, List<SqlParameter> ParamsList, SP_SqlReturnValType returnType)
    {
        object SP_ReturnVal = null;

        /*********************************************************
        * Execute Scalar
        * OR
        * Execute NonQuery
        * ********************************************************/
        if ((returnType.Equals(SP_SqlReturnValType.ExecuteNonQueryType) || returnType.Equals(SP_SqlReturnValType.ExecuteScalarType)) || ((returnType.Equals(SP_SqlReturnValType.ExecuteDataTableType)) || (returnType.Equals(SP_SqlReturnValType.ExecuteDataRowType))))
        {
            using (SqlConnection _con = new SqlConnection(getConnectionString(SqlConnectionStringName)))
            {
                using (SqlCommand _cmd = new SqlCommand(SP_Name, _con))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;

                    if (ParamsList != null)
                        foreach (SqlParameter param in ParamsList)
                            _cmd.Parameters.Add(new SqlParameter(((param.ParameterName.Contains('@')) ? param.ParameterName : "@" + param.ParameterName), (param.Value == null) ? DBNull.Value : param.Value));

                    try
                    {

                        if ((returnType.Equals(SP_SqlReturnValType.ExecuteNonQueryType)) || (returnType.Equals(SP_SqlReturnValType.ExecuteScalarType)))
                        {
                            _con.Open();
                            SP_ReturnVal = (returnType.Equals(SP_SqlReturnValType.ExecuteNonQueryType)) ? _cmd.ExecuteNonQuery() : _cmd.ExecuteScalar();
                        }
                        else if ((returnType.Equals(SP_SqlReturnValType.ExecuteDataTableType)) || (returnType.Equals(SP_SqlReturnValType.ExecuteDataRowType)))
                        {
                            DataTable dt = new DataTable();
                            SqlDataAdapter myAdapter = new SqlDataAdapter(_cmd);
                            myAdapter.Fill(dt);

                            if (returnType.Equals(SP_SqlReturnValType.ExecuteDataTableType))
                                SP_ReturnVal = dt;
                            else if ((returnType.Equals(SP_SqlReturnValType.ExecuteDataRowType)) && (dt.Rows.Count != 0))
                                SP_ReturnVal = dt.Rows[0];
                        }

                    }
                    catch (Exception exc)
                    {
                        string CurrentURL = "SqlConnectionStringName: " + SqlConnectionStringName + ". ||| " + "SP_Name: " + SP_Name;

                        HttpContext.Current.Response.Write("SqlConnectionStringName: " + SqlConnectionStringName + "<br>");
                        HttpContext.Current.Response.Write("SP_Name: " + SP_Name + "<br>");
                        HttpContext.Current.Response.Write("ex.Message: " + exc.Message + "<br>");
                        HttpContext.Current.Response.End();
                    }

                }
            }


        }




        else if (returnType.Equals(SP_SqlReturnValType.ExecuteReaderType))
        {
            SqlConnection _con = new SqlConnection(getConnectionString(SqlConnectionStringName));

            using (SqlCommand _cmd = new SqlCommand(SP_Name, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                if (ParamsList != null)
                    foreach (SqlParameter param in ParamsList)
                        _cmd.Parameters.Add(param);

                try
                {
                    _con.Open();
                    SP_ReturnVal = _cmd.ExecuteReader(CommandBehavior.CloseConnection); // on reader.close() Close Connection
                }
                catch (Exception exc)
                {
                    ((SqlDataReader)SP_ReturnVal).Close();
                    _con.Close();

                    string CurrentURL = "SqlConnectionStringName: " + SqlConnectionStringName + ". ||| " + "SP_Name: " + SP_Name;

                    HttpContext.Current.Response.Write("SqlConnectionStringName: " + SqlConnectionStringName + "<br>");
                    HttpContext.Current.Response.Write("SP_Name: " + SP_Name + "<br>");
                    HttpContext.Current.Response.Write("ex.Message: " + exc.Message + "<br>");
                    HttpContext.Current.Response.End();
                }
            }

        }

        return SP_ReturnVal;
    }


    private static string getConnectionString(String SqlConnectionStringName)
    {
        return ConfigurationManager.ConnectionStrings[(SqlConnectionStringName != null) ? SqlConnectionStringName : "Canvas_DB"].ConnectionString;
    }
    #endregion
}

