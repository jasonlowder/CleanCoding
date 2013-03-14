using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCoding.DataFetcher
{
    public class AuthDataFetcher
    {
        private IAuthDataFetcher authDataFetcher;

        public AuthDataFetcher(IAuthDataFetcher AuthDataFetcher)
        {
            this.authDataFetcher = AuthDataFetcher;
        }

        public Models.Auth Get(string username)
        {
            return authDataFetcher.Get(username);
        }
    }
}