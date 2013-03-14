using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCoding.DataFetcher
{
    class ArticleDataFetcher
    {
        private DataBase.Article articleFetcher;

        public ArticleDataFetcher(DataBase.Article articleFetcher)
        {
            this.articleFetcher = articleFetcher;
        }

        internal Models.Article Get(int articleID)
        {
            throw new NotImplementedException();
        }
    }
}
