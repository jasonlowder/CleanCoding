using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CleanCoding.DataFetcher.File
{
    public class Auth : IAuthDataFetcher
    {
        public string Path { get; set; }

        public Auth(string Path)
        {
            this.Path = Path;
        }

        public Models.Auth Get(string username)
        {
            Models.Auth auth = new Models.Auth();

            if (string.IsNullOrEmpty(Path))
            {
                throw new Exception("Path was not initialized. Unable to connect");
            }
            else
            {
                string currentLine;
                bool foundText = false;
                string searchString = "Username: " + username + " Password: ";
                StreamReader reader = new StreamReader(Path);
                do
                {
                    currentLine = reader.ReadLine();
                    if (!string.IsNullOrEmpty(currentLine))
                    {
                        foundText = currentLine.Contains(searchString);
                    }
                } while (!foundText);

                if (foundText)
                {
                    auth.UserName = username;
                    auth.Password = currentLine.Substring(searchString.Length);
                }

                reader.Close();
            }

            return auth;
        }
    }
}