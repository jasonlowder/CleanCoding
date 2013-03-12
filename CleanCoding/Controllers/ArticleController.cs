using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CleanCoding.Models;

namespace CleanCoding.Controllers
{
    public class ArticleController : Controller
    {
        private CleanCodingDB db = new CleanCodingDB();

        //
        // GET: /Article/

        public ActionResult Index(String searchTerm = null)
        {
            var model =
                db.Articles
                    .OrderBy(r => r.ArticleID)
                    .Where(r => searchTerm == null || r.Title.StartsWith(searchTerm))
                    .Take(10)
                    .Select(r => new ArticleListViewModel
                    {
                        ArticleID = r.ArticleID,
                        Title = r.Title,
                        Body = r.Body,
                        CommentCount = r.Comments.Count()
                    });

            return View(model);
        }

        public ActionResult ArticleFull(int id)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return Index();
            }
            article = db.Articles.Single(r => r.ArticleID == id);
            return View(article);
        }

        //
        // GET: /Article/Details/5

        public ActionResult Details(int id = 0)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // GET: /Article/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Article/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(article);
        }

        //
        // GET: /Article/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        //
        // GET: /Article/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /Article/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}