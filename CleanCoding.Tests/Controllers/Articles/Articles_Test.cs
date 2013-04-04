using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCoding.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using CleanCoding.Models;
using System.Data;

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
            ViewResult result = controller.ArticleFull(3) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ArticlesFull_BadID_ReturnsIndex()
        {
            // Arrange
            ArticleController controller = new ArticleController();

            // Act
            ViewResult badResult = controller.ArticleFull(5) as ViewResult;
            ViewResult indexResult = controller.Index() as ViewResult;

            // Assert
            Assert.AreSame(badResult.View, indexResult.View);
        }

        [TestMethod]
        public void ConnectToDB_Default()
        {
            // Arrange
            ArticleController controller = new ArticleController();

            // Assert
            Assert.IsTrue(true, "Wouldn't reach here if DB connection was not made.");
        }

        [TestMethod]
        public void ConnectToDB_Argument()
        {
            // Arrange 
            ArticleController controller = new ArticleController(new CleanCodingDB());

            // Assert
            Assert.IsTrue(true, "Wouldn't reach here if DB connection was not made.");
        }

        [TestMethod]
        public void ArticleValidation()
        {
            Assert.Fail("Not Yet Implemented");
        }

        [TestMethod]
        public void AddArticleToDB()
        {
            Assert.Fail("Not Yet Implemented");
        }

        [TestMethod]
        public void EditArticleInDB()
        {
            Assert.Fail("Not Yet Implemented");
        }

        [TestMethod]
        public void DeleteArticleInDB()
        {
            Assert.Fail("Not Yet Implemented");
        }

    }
}
