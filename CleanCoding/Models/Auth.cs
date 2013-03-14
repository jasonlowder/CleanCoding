using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCoding.Models
{
    public class Auth : Model
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}