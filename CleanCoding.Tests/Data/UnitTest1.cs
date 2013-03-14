using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace CleanCoding.Tests.Data
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthDataFetcherViaDB()
        {
            // arrange
            string username = "jason";
            string connectionString = ConfigurationManager.ConnectionStrings["C2KB"].ConnectionString;
            DataFetcher.DataBase.Auth dbAuthFetcher = new DataFetcher.DataBase.Auth(connectionString);
            DataFetcher.AuthDataFetcher adf = new DataFetcher.AuthDataFetcher(dbAuthFetcher);

            // act
            Models.Auth data = adf.Get(username);

            // assert
            Assert.IsInstanceOfType(data, typeof(Models.Auth));
        }

        [TestMethod]
        public void AuthDataFetcherViaFile()
        {
            // arrange
            string username = "jason";
            string filePath = @"C:\Users\jason\Documents\Visual Studio 2012\Projects\Tutorials\MVC\C2KB\C2KB.Tests\UserResults.txt";
            DataFetcher.File.Auth fileAuth = new DataFetcher.File.Auth(filePath);
            DataFetcher.AuthDataFetcher adf = new DataFetcher.AuthDataFetcher(fileAuth);

            // act
            Models.Auth data = adf.Get(username);

            // assert
            Assert.IsInstanceOfType(data, typeof(Models.Auth));
        }

        [TestMethod]
        public void AuthDataFetcherViaWebService()
        {
            // arrange
            string username = "jason";
            string url = @"C:\Users\jason\Documents\Visual Studio 2012\Projects\Tutorials\MVC\C2KB\C2KB.Tests\UserResults.html";
            DataFetcher.WebService.Auth wsAuthFether = new DataFetcher.WebService.Auth(url);
            DataFetcher.AuthDataFetcher adf = new DataFetcher.AuthDataFetcher(wsAuthFether);

            // act
            Models.Auth data = adf.Get(username);

            // assert
            Assert.IsInstanceOfType(data, typeof(Models.Auth));
        }

        [TestMethod]
        public void IsValid()
        {
            Auth auth = new Auth();

            Assert.IsTrue(auth.IsValid("jason", "myPass"));
        }

        [TestMethod]
        public void RegisterSetterViaDB()
        {
            // arrange
            int articleID = 1;
            string connectionString = ConfigurationManager.ConnectionStrings["C2KB"].ConnectionString;
            DataFetcher.DataBase.Article articleFetcher = new DataFetcher.DataBase.Article(connectionString);
            DataFetcher.ArticleDataFetcher adf = new DataFetcher.ArticleDataFetcher(articleFetcher);

            // act
            Models.Article data = adf.Get(articleID);

            // assert
            Assert.IsInstanceOfType(data, typeof(Models.Article));
        }

        [TestMethod]
        public void RegisterSetterViaFile()
        {
        }

        [TestMethod]
        public void RegisterSetterViaWS()
        {
        }

        [TestMethod]
        public void GetArticleViaDB()
        {
            // arrange
            string username = "jason";
            string connectionString = ConfigurationManager.ConnectionStrings["C2KB"].ConnectionString;
            DataFetcher.DataBase.Auth dbAuthFetcher = new DataFetcher.DataBase.Auth(connectionString);
            DataFetcher.AuthDataFetcher adf = new DataFetcher.AuthDataFetcher(dbAuthFetcher);

            // act
            Models.Auth data = adf.Get(username);

            // assert
            Assert.IsInstanceOfType(data, typeof(Models.Auth));
        }

        [TestMethod]
        public void GetArticleViaFile()
        {
        }

        [TestMethod]
        public void GetArticleViaWS()
        {
        }
    }
}
