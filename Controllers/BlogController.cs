using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleBlog.Data;
using SimpleBlog.Models;
using SimpleBlog.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace SimpleBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
    
        }

        // GET: Blog
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.BlogPost.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> ShowSearch(string SearchTerm)
        {

            return View("Index", await _context.BlogPost.Where(i => i.Title.Contains(SearchTerm)).ToListAsync());
        }
        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }
            var comments = _context.Comment.Where(x => x.BlogPostId == id).ToList();
            BlogViewModel blog = new BlogViewModel
            {
                BlogPosts = blogPost,
                Comments = comments
            };
           
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateComment([Bind("Id,Name,CommentBody,BlogPostId")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();

                int Id = (int) comment.BlogPostId;
               return RedirectToAction("Details", new { id = Id });
            }
            return View();
        }

        [Route("/error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
