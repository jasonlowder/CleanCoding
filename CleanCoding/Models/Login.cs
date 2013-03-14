using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCoding.Models
{
    public class Login : Auth
    {
        public bool RememberMe { get; set; }
    }
}