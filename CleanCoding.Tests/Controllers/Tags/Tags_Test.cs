using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCoding.Controllers;
using System.Web.Mvc;
using CleanCoding.Models;

namespace CleanCoding.Tests.Controllers.Tags
{
    [TestClass]
    public class Tags_Test
    {
        [TestMethod]
        public void SerachByTag()
        {
            // Arrange
            ArticleController controller = new ArticleController();

            // Act
            ViewResult search = controller.TagSearch("") as ViewResult;

            // Assert
            Assert.AreEqual(0, search.ViewData.Values.Count, "" +search.ViewData.Values.Count);
        }

        [TestMethod]
        public void AddTag()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void DisplayTag()
        {
            // Arrange
            ArticleController controller = new ArticleController();
            ICleanCodingDB db = new CleanCodingDB();
            //var model =
            //    db.Query<Tag>()
            //        .Where(r => r.word.Equals("Tyrel") && r.articleID.Equals(1))
            //        .Take(10)
            //        .Select(r => new ArticleListViewModel
            //        {
            //            ArticleID = r.ArticleID,
            //            Title = r.Title,
            //            Body = r.Body,
            //            TagList = r.Tags,
            //            CommentCount = r.Comments.Count()
            //        });

            // Act
            Assert.IsFalse(false);
            
        }
    }
}
