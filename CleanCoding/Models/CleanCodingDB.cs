using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CleanCoding.Models
{
    public class CleanCodingDB : DbContext, ICleanCodingDB
    {
        public CleanCodingDB()
            : base("name=DefaultConnection")
        {

        }

        IQueryable<T> ICleanCodingDB.Query<T>()
        {
            return Set<T>();
        }

        public Type ElementType { get; set; }
        public System.Linq.Expressions.Expression Expression { get; set; }
        public IQueryProvider Provider { get; set; }

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tag { get; set; }
        
        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public System.Data.Entity.Infrastructure.DbEntityEntry Entry<T>(T entity) where T : class
        {
            return base.Entry<T>(entity);
        }
    }
}