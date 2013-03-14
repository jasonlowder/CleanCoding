using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.DataFetcher
{
    public interface IAuthDataFetcher
    {
        Models.Auth Get(string username);
    }
}
