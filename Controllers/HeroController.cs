using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superhero_App.Data;
using Superhero_App.Models;

namespace Superhero_App.Controllers
{
    public class HeroController : Controller
    {
        private readonly ApplicationDbContext db;
        
        public HeroController(ApplicationDbContext dbContext) 
        {
            db = dbContext;
        
        }
        // GET: Hero
        public ActionResult Index()
        {
            var thing = db.Superheroes.Where(s => s.SuperheroID > 0);
            return View(thing);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                Superhero thing = db.Superheroes.Where(s => s.SuperheroID == id).FirstOrDefault();

                return View(thing);
            }
            catch 
            {
                return View();
            }
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Hero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                db.Superheroes.Add(superhero);
                // TODO: Add insert logic here
               
                    
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero thing = db.Superheroes.Where(s => s.SuperheroID == id).FirstOrDefault();
            return View(thing);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                Superhero thing = db.Superheroes.Where(s => s.SuperheroID == s.SuperheroID).FirstOrDefault();
                thing = superhero;
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Superhero thing = db.Superheroes.Where(s => s.SuperheroID == id).FirstOrDefault();
                db.Remove(thing);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}