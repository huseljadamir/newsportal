using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vijesti.Models;

namespace Vijesti.Controllers
{
    
    public class VijestController : Controller
    {
        // GET: Vijest/Vijest
        private ApplicationDbContext _context;
        public VijestController()
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

        

        public ActionResult Vijest(int id)
        {
            var vijest = _context.Vijesti.SingleOrDefault(c => c.Id == id);
            if (vijest == null) return HttpNotFound();
            return View(vijest);
        }

        public ActionResult Nova()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Vijest vijest)
        {
            _context.Vijesti.Add(vijest);
            _context.SaveChanges();
            return RedirectToAction("Index", "Vijest");
        }
    }
}