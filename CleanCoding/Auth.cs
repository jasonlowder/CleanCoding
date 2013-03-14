using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCoding
{
    public class Auth
    {
        public bool IsValid(string username, string password)
        {
            DataFetcher.DataBase.Auth df = (DataFetcher.DataBase.Auth)Factory.AuthDataFetcherFactory.Create(Common.DataFetcherType.DATABASE);
            Models.Auth authModel = (Models.Auth)df.Get(username);
            return password == authModel.Password;
        }
    }
}