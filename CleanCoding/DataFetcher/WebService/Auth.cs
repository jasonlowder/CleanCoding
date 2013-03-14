using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace CleanCoding.DataFetcher.WebService
{
    public class Auth : IAuthDataFetcher
    {
        public string URL { get; set; }

        public Auth(string URL)
        {
            this.URL = URL;
        }

        public Models.Auth Get(string username)
        {
            Models.Auth auth = new Models.Auth();

            if (string.IsNullOrEmpty(URL))
            {
                throw new Exception("URL was not initialized. Unable to connect");
            }
            else
            {
                WebClient wc = new WebClient();
                auth.UserName = username;
                auth.Password = wc.DownloadString(URL);
            }

            return auth;
        }
    }
}