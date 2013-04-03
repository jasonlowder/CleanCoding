using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCoding.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using CleanCoding.Models;

namespace CleanCoding.Tests.Controllers.Comments
{
    [TestClass]
    public class Comments_Test
    {
        CommentController controller;

        [TestMethod]
        public void ConnectToDB_Default()
        {
            // Arrange
            controller = new CommentController();

            // Assert
            Assert.IsTrue(true, "Wouldn't reach here if DB connection was not made.");
        }

        [TestMethod]
        public void ConnectToDB_Argument()
        {
            // Assert
            Assert.Fail("Not Yet Implemented");
        }

        [TestMethod]
        public void CommentValidation()
        {
            Assert.Fail("Not Yet Implemented");
        }

        [TestMethod]
        public void AddCommentToDB()
        {
            Assert.Fail("Not Yet Implemented");
        }

        [TestMethod]
        public void EditCommentInDB()
        {
            Assert.Fail("Not Yet Implemented");
        }

        [TestMethod]
        public void DeleteCommentInDB()
        {
            Assert.Fail("Not Yet Implemented");
        }

    }
}
