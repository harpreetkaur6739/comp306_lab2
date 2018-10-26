using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _300910377_KAUR__300916412_YANG__Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _300910377_KAUR__300916412_YANG__Lab2.Controllers
{
    public class PlayMovieController : Controller
    {

        private readonly _300910377_KAUR__300916412_YANG__Lab2Context _context;

        public PlayMovieController(_300910377_KAUR__300916412_YANG__Lab2Context context)
        {
            _context = context;
        }
            // GET: PlayMovie
            public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.MovieId == id);

            if (movie == null)
            {
                return NotFound();
            }

            // IEnumerable<Comment> comments =  _context.Comment.Where(x => _context.MovieComment.Any(m => m.CommentId == x.CommentId && m.MovieId == movie.MovieId));

            var userComments = from comment in _context.Comment
                               join movieComment in _context.MovieComment on comment.CommentId equals movieComment.CommentId
                               where movieComment.MovieId == movie.MovieId
                               join users in _context.Users on comment.UserId equals users.UserId 
                         
                         select new UserComments
                         {
                             CommentId = comment.CommentId,
                             Content = comment.Content,
                             Rating = comment.Rating,
                             UserId = comment.UserId,
                             User = users.UserName
                         };

            PlayMovie playMovieView = new PlayMovie();
            playMovieView.movie = movie;

            if (userComments != null) {
                playMovieView.userComments = userComments;
            }
            return View("PlayMovie", playMovieView);
        }

        // GET: PlayMovie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlayMovie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlayMovie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayMovie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayMovie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayMovie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayMovie/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}