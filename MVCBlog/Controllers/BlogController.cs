using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Blog
        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Blog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

        public ActionResult Read(int? id)
        {
            Blog blog = db.Blogs.Find(id);
            return View(blog);
        }
    }
}