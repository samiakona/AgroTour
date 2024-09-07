using AgroTour_AggregateRoot.Entities;
using AgroTour_Repository.Data;
using Microsoft.AspNetCore.Mvc;

namespace AgroTour.Controllers
{
    public class LocationController : Controller
    {
        private readonly ApplicationDbContext _db;

        // Constructor with correct syntax
        public LocationController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Action method
        public IActionResult Index()
        {
            var location = _db.Locations.ToList();
            return View(location);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Location obj)
        {
            if (ModelState.IsValid)
            {
                _db.Locations.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
         
        }

        public IActionResult Update(int LocationId)
        {
            Location? obj = _db.Locations.FirstOrDefault(u=>u.Id==LocationId);
            if (obj ==null)
            {
                return RedirectToAction("Error", "Home");

            }
            return View(obj);
        }

        public IActionResult Update(Location obj)
        {
            if (ModelState.IsValid)
            {
                _db.Locations.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }

    }
}
