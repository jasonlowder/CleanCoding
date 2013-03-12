//using CleanCoding.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace CleanCoding.Controllers
//{
//    public class ArticleController : Controller
//    {
//        CleanCodingDB _db = new CleanCodingDB();
//        //
//        // GET: /Article/

//        public ActionResult Index(string searchTerm = null)
//        {
//            var model =
//                _db.Articles
//                    .OrderBy(r => r.ArticleID)
//                    .Where(r => searchTerm == null || r.Title.StartsWith(searchTerm))
//                    .Take(10)
//                    .Select(r => new ArticleListViewModel
//                    {
//                        ArticleID = r.ArticleID,
//                        Title = r.Title,
//                        Body = r.Body,
//                        CommentCount = r.Comments.Count()
//                    });

//            return View(model);
//        }

//        //
//        // GET: /Article/Details/5

//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        //
//        // GET: /Article/Create

//        public ActionResult Create()
//        {
//            return View();
//        }

//        //
//        // POST: /Article/Create

//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Article/Edit/5

//        public ActionResult Edit(int id)
//        {
//            var article = _db.Articles.Single(r => r.ArticleID == id);
//            return View(article);
//        }

//        //
//        // POST: /Article/Edit/5

//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            var article = _db.Articles.Single(r => r.ArticleID == id);
//            if (TryUpdateModel(article))
//            {
//                // Save into DB! !!!!FIX!!!!
//                return RedirectToAction("Index");
//            }
//            return View(article);
//        }

//        public ActionResult ArticleFull(int id)
//        {
//            var article = _db.Articles.Single(r => r.ArticleID == id);
//            return View(article);
//        }

//        //
//        // GET: /Article/Delete/5

//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Article/Delete/5

//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
