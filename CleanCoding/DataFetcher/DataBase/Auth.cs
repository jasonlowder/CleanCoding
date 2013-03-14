using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CleanCoding.DataFetcher.DataBase
{
    public class Auth : IAuthDataFetcher
    {
        public string ConnectionString { get; set; }

        public Auth(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public Models.Auth Get(string username)
        {
            Models.Auth auth = new Models.Auth();

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new Exception("Connection string was not initialized. Unable to connect");
            }
            else
            {
                DataSet ds = null;
                string sql = "SELECT UserName, Password FROM [User] WHERE UserName = '" + username + "'";
                SqlCommand cmd = new SqlCommand(sql, new SqlConnection(ConnectionString));
                DBAccess.ConnectionManger cm = new DBAccess.ConnectionManger(cmd);
                try
                {
                    ds = cm.ExecuteDataSet();
                }
                catch (Exception e)
                {
                    string temp = e.Message;
                }
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    auth.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                    auth.Password = ds.Tables[0].Rows[0]["Password"].ToString();
                }
            }

            return auth;
        }
    }
}