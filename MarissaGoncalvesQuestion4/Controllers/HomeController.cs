using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarissaGoncalvesQuestion4.Controllers
{
    public class HomeController : Controller
    {
        Models.PostsEntities database = new Models.PostsEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View(database.Posts);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.Post newPost = new Models.Post
                {
                    author = collection["author"],
                    message = collection["message"]
                };

                database.Posts.Add(newPost);
                database.SaveChanges();
              
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            Models.Post thePost = database.Posts.SingleOrDefault(p => p.post_id == id);
            return View(thePost);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Models.Post thePost = database.Posts.SingleOrDefault(p => p.post_id == id);

                thePost.author = collection["author"];
                thePost.message = collection["message"];

                database.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            Models.Post thePost = database.Posts.SingleOrDefault(p => p.post_id == id);
            return View(thePost);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Models.Post thePost = database.Posts.SingleOrDefault(p => p.post_id == id);
                database.Posts.Remove(thePost);
                database.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
