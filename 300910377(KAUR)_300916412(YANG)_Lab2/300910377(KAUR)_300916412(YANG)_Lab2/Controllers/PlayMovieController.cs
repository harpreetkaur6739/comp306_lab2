using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _300910377_KAUR__300916412_YANG__Lab2.Controllers
{
    public class PlayMovieController : Controller
    {
        // GET: PlayMovie
        public ActionResult Index()
        {
            return View();
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