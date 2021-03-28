using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vijesti.Models;

namespace Vijesti.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Vijest/Vijest
        private ApplicationDbContext _context;
        public AdminController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var vijesti = _context.Vijesti.ToList();
            return View(vijesti);
        }

        public ActionResult Nova()
        {
            
            return View();
        }

        
        public ActionResult EditForm(int id)
        {
            var vijest = _context.Vijesti.SingleOrDefault(c => c.Id == id);
            if (vijest == null) return HttpNotFound();
            return View(vijest);
        }

        [HttpPost]
        public ActionResult Create(Vijest vijest)
        {

            if(!ModelState.IsValid)
            {
                var newVijest = new Vijest();
                return View("Nova", newVijest);
            }

            _context.Vijesti.Add(vijest);
            _context.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public ActionResult Edit(Vijest novaVijest)
        {

            if (!ModelState.IsValid)
            {
                var newVijest = new Vijest();
                return View("EditForm", newVijest);
            }

            var vijest = _context.Vijesti.SingleOrDefault(c => c.Id == novaVijest.Id);
            vijest.Naziv = novaVijest.Naziv;
            vijest.Naslov = novaVijest.Naslov;
            vijest.Sadrzaj = novaVijest.Sadrzaj;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id == null) return HttpNotFound();
            var vijest = _context.Vijesti.SingleOrDefault(c => c.Id == id);
            
            _context.Vijesti.Remove(vijest);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}