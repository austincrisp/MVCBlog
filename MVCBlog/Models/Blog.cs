using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TeaserText { get; set; }
        public string Author { get; set; }
        public string Timestamp { get; set; }
        public string Body { get; set; }
    }

    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}