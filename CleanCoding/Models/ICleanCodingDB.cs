using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.Models
{
    public interface ICleanCodingDB : IDisposable, IQueryable
    {
        DbSet<Article> Articles { get; set; }
        DbSet<Comment> Comments { get; set; }
        IQueryable<T> Query<T>() where T : class;

        void SaveChanges();

        System.Data.Entity.Infrastructure.DbEntityEntry Entry<T>(T entity) where T : class;
    }
}
