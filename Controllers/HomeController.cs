using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using restauranter.Models;
using System.Linq;

namespace restauranter.Controllers
{
    public class HomeController : Controller
    {
        private ReviewContext _context;

        public HomeController(ReviewContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Review newReview)
        {
            if(ModelState.IsValid){
                newReview.CreatedAt = DateTime.Now;
                newReview.UpdatedAt = DateTime.Now;
                _context.Add(newReview);
                _context.SaveChanges();
                return RedirectToAction("Display");
            } else {
                return View("Index");
            }
        }
        [HttpGet]
        [Route("display")]
        public IActionResult Display(){
            ViewBag.reviews = _context.reviews.OrderByDescending(r => r.CreatedAt);
            return View();
        }
    }
}