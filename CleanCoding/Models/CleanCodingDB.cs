using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CleanCoding.Models
{
    public class CleanCodingDB : DbContext
    {
        public CleanCodingDB() : base("name=DefaultConnection")
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}