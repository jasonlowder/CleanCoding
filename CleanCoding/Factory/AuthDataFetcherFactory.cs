using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCoding.Factory
{
    public class AuthDataFetcherFactory
    {
        public static DataFetcher.IAuthDataFetcher Create(Common.DataFetcherType type)
        {
            DataFetcher.IAuthDataFetcher df = null;
            switch (type)
            {
                case Common.DataFetcherType.DATABASE:
                    df = new DataFetcher.DataBase.Auth();
                    break;
                case Common.DataFetcherType.FILE:
                    df = new DataFetcher.File.Auth();
                    break;
                case Common.DataFetcherType.WEBSERVICE:
                    df = null;
                    break;
            }
            return df;
        }
    }
}