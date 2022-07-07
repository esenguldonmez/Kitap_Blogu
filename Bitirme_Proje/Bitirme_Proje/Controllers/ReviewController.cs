using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.Controllers
{
   [Authorize(Roles ="Admin")]
    public class ReviewController : Controller
    {
        ReviewManager reviewManager = new ReviewManager(new EfReviewDal());
        public IActionResult Index()
        {
           
            var values = reviewManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            reviewManager.TAdd(review);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteReview(int id)
        {
            var values = reviewManager.TGetByID(id);
            reviewManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditReview(int id)
        {
            
            var values = reviewManager.TGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditReview(Review review)
        {
            reviewManager.TUpdate(review);
            return RedirectToAction("Index");
        }
    }
}
