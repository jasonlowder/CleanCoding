using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.Tests.Factory
{
    public static class AuthDataFetcherFactory
    {
        public static DataFetcher.IAuthDataFetcher Create(Common.DataFetcherType Type, string connectionString)
        {
            DataFetcher.IAuthDataFetcher authFetcher = null;
            switch (Type)
            {
                case Common.DataFetcherType.DATABASE:
                    authFetcher = new DataFetcher.DataBase.Auth(connectionString);
                    break;
                case Common.DataFetcherType.FILE:
                    authFetcher = new DataFetcher.File.Auth(connectionString);
                    break;
                case Common.DataFetcherType.WEBSERVICE:
                    authFetcher = new DataFetcher.WebService.Auth(connectionString);
                    break;
            }
            return authFetcher;
        }
    }
}
