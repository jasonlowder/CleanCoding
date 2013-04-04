using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CleanCoding.Models;
using System.Collections;

namespace CleanCoding.Controllers
{
    public class ArticleController : Controller
    {
        //private CleanCodingDB db = new CleanCodingDB();
        ICleanCodingDB db;

        public ArticleController()
        {
            db = new CleanCodingDB();
        }

        public ArticleController(ICleanCodingDB db)
        {
            this.db = db;
        }

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
                        TagList = r.Tags,
                        CommentCount = r.Comments.Count()
                    });

            return View(model);
        }

        public ActionResult TagSearch(String searchTerm)
        {
            System.Diagnostics.Debug.WriteLine("Searching for: " +searchTerm);
            var tags = new HashSet<int>(db.Query<Tag>().Where(t => t.word.Equals(searchTerm)).Select(t => t.ArticleID));
            IQueryable<ArticleListViewModel> articles = db.Query<Article>().Where(p => tags.Contains(p.ArticleID)).Take(10).Select( p => new ArticleListViewModel
                {
                    ArticleID = p.ArticleID,
                    Title = p.Title,
                    Body = p.Body,
                    TagList = p.Tags,
                    CommentCount = p.Comments.Count()                    
                });

            return View(articles);
        }

        public ActionResult ArticleFull(int id)
        {
            var article = db.Articles
                .Where(r => r.ArticleID == id)
                .Select(r => new ArticleListViewModel
                {
                    ArticleID = r.ArticleID,
                    Title = r.Title,
                    Body = r.Body
                });

            if (!article.Any())
            {
                RedirectToAction("Index");
            }
            return View(article.SingleOrDefault());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
//<<<<<<< HEAD
//        public ActionResult create(Article article)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Articles.Add(article);
//                db.SaveChanges();
//                return RedirectToAction("index");
//            }

//=======
        public ActionResult Create(ArticleListViewModel article)
        {
            if (ModelState.IsValid)
            {
                // Need to parse out the tags here?
                ArrayList articleTags = getTags(article.Tags);

                // Now need to put the ArticleListViewModel to an Article Model As well as the Tags returned from getTags into Tag Model objects

              //db.Articles.Add(article);
              //  db.SaveChanges();
                return RedirectToAction("Index");
            }

//>>>>>>> TyrelColt
            return View(article);
        }

        public ActionResult Edit(int id = 0)
        {
            var article = db.Articles
                .Where(r => r.ArticleID == id)
                .Select(r => new ArticleListViewModel
                {
                    ArticleID = r.ArticleID,
                    Title = r.Title,
                    Body = r.Body
                });

            if (!article.Any())
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
        // HI

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Article article)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(article).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(article);
        //}

        ////
        //// GET: /Article/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    Article article = db.Articles.Find(id);
        //    if (article == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(article);
        //}

        ////
        //// POST: /Article/Delete/5

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Article article = db.Articles.Find(id);
        //    db.Articles.Remove(article);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        private ArrayList getTags(String tags)
        {
            string[] tagList = tags.Split(',');
            ArrayList allTags = new ArrayList();

            foreach (string tag in tagList)
            {
                allTags.Add(tagList);
            }

            return allTags;
        }
    }
}