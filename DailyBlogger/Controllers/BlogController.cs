using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyBlogger.Models;

namespace DailyBlogger.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _context;

        public BlogController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult list()
        {
            IEnumerable<BlogPost> posts = _context.blogPost.ToList<BlogPost>();
            return View();
        }
    }
}