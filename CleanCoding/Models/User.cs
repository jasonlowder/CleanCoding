using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCoding.Models
{
    public class User : Model
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<Security> AccountVerification { get; set; }
    }

    public class Security
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}