using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _300910377_KAUR__300916412_YANG__Lab2.Models;
using Microsoft.AspNetCore.Http;

namespace _300910377_KAUR__300916412_YANG__Lab2.Controllers
{
    public class CommentsController : Controller
    {
        private readonly _300910377_KAUR__300916412_YANG__Lab2Context _context;

        public CommentsController(_300910377_KAUR__300916412_YANG__Lab2Context context)
        {
            _context = context;
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comment.ToListAsync());
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentId,Content,Rating")] Comment comment, [Bind("movieId")] int movieId)
        {
            if (ModelState.IsValid)
            {                
                if (HttpContext.Session.GetInt32("token") != null) {
                    
                    int userId = (Int32)HttpContext.Session.GetInt32("token");
                    comment.UserId = userId;
                }
               
                _context.Add(comment);
                await _context.SaveChangesAsync();

                MovieComment movieComment = new MovieComment();
                movieComment.CommentId = comment.CommentId;
                movieComment.MovieId = movieId;
                _context.MovieComment.Add(movieComment);
                await _context.SaveChangesAsync();               
   
                return RedirectToAction("Index","PlayMovie",new { id = movieId });
            }
            return View(comment);
        }

        // GET: Comments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommentId,Content,Rating,UserId")] Comment comment)
        {
            
            if (id != comment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();

                    var movieComment = _context.MovieComment.SingleOrDefault(mc => mc.CommentId == comment.CommentId);
                    return RedirectToAction("Index", "PlayMovie", new { id = movieComment.MovieId });
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.CommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
               
            }
            return View(comment);
        }

        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.Comment.FindAsync(id);
            var moviecomment = _context.MovieComment.SingleOrDefault(mc => mc.CommentId ==comment.CommentId );

            int movieId = moviecomment.MovieId;
            _context.MovieComment.Remove(moviecomment);
            await _context.SaveChangesAsync();

            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "PlayMovie", new { id = movieId });
        }

        private bool CommentExists(int id)
        {
            return _context.Comment.Any(e => e.CommentId == id);
        }
    }
}
