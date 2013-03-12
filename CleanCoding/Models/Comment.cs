using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CleanCoding.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ArticleID { get; set; }
        public String Message { get; set; }
    }
}