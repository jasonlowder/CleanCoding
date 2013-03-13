using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CleanCoding.Models
{
    public interface ICleanCodingDB : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
    }

    public class CleanCodingDB : DbContext, ICleanCodingDB
    {
        public CleanCodingDB() : base("name=DefaultConnection")
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        IQueryable<T> ICleanCodingDB.Query<T>()
        {
            return Set<T>();
        }
    }
}