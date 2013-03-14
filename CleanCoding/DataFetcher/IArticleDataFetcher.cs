using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCoding.DataFetcher
{
    public interface IArticleDataFetcher
    {
        Models.Article Get(int articleID);
    }
}