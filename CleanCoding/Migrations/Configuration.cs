namespace CleanCoding.Migrations
{
    using CleanCoding.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CleanCoding.Models.CleanCodingDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CleanCoding.Models.CleanCodingDB context)
        {
            context.Articles.AddOrUpdate(r => r.ArticleID,
                 new Article { ArticleID = 1, Title = "Default Article", Body = "Hey this is a default article! Cool eh?" },
                 new Article { ArticleID = 2, Title = "A Second Default Article", Body = "This is so much fun!" },
                 new Article
                 {
                     ArticleID = 3,
                     Title = "A Default Article With Comments!",
                     Body = "This was such a good article I had to add comments!",
                     Comments =
                         new List<Comment>
                        {
                            new Comment { ID = 1, UserID = 100, ArticleID = 3, Message = "This was really informative. Thanks!"},
                            new Comment { ID = 2, UserID = 101, ArticleID = 3, Message = "I disagree.  COMPLETELY!"},
                            new Comment { ID = 3, UserID = 100, ArticleID = 3, Message = "Well you're just dumb!"}
                        }

                 });
        }
    }
}
