using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCoding.DataFetcher.DataBase
{
    class Article
    {
        private string connectionString;

        public Article(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
