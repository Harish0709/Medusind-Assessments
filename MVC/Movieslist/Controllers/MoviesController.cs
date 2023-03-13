using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Net;
using System.Data.Entity;


namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private MoviesDBEntities md = new MoviesDBEntities();
        public ActionResult Index()
        {
            List<TamilMovy> movies = md.TamilMovies.ToList(); // or any other method that returns a list of movies
            return View(movies);
        }
        public ActionResult Create()
        {
            return View();
        }

        //for insert new movies details
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult InsertMovie([Bind(Include = "Mid, Moviename, DateofRelease")] TamilMovy movie)
        {
            if (ModelState.IsValid)
            {
                md.TamilMovies.Add(movie);
                md.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TamilMovy movie = md.TamilMovies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mid, Moviename, DateofRelease")] TamilMovy movie)
        {
            if (ModelState.IsValid)
            {
                md.Entry(movie).State = EntityState.Modified;
                md.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TamilMovy movie = md.TamilMovies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            TamilMovy movie = md.TamilMovies.Find(id);
            md.TamilMovies.Remove(movie);
            md.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult FindMoviesByYear(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {


                int n = Convert.ToInt32(dateTime);
                IEnumerable<TamilMovy> movies = from m in md.TamilMovies
                                                where m.DateOfRelease.Equals(n)
                                                select m;
                return View(movies);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }



        }
    }
}