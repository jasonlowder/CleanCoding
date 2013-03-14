using CleanCoding.Tests.Factory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CleanCoding.Tests.Data
{
    class Auth
    {
        internal bool IsValid(string UserName, string Password)
        {
            DataFetcher.DataBase.Auth df = 
                (DataFetcher.DataBase.Auth)AuthDataFetcherFactory.Create(
                                                Common.DataFetcherType.DATABASE,
                                                ConfigurationManager.ConnectionStrings["C2KB"].ConnectionString);
            Models.Auth auth = (Models.Auth)df.Get(UserName);
            return auth.Password == Password;
        }
    }
}
