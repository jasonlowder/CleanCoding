using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCoding.Controllers;
using System.Web.Mvc;

namespace CleanCoding.Tests.Controllers.Articles
{
    [TestClass]
    public class Articles_Test
    {
        [TestMethod]
        public void ArticlesList()
        {
            // Arrange
            ArticleController controller = new ArticleController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ArticlesFull()
        {
            // Arrange
            ArticleController controller = new ArticleController();

            // Act
            ViewResult result = controller.ArticleFull(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
