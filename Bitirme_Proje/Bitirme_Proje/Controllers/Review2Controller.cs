using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.Controllers
{
    public class Review2Controller : Controller
    {
        ReviewManager reviewManager = new ReviewManager(new EfReviewDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListReview()
        {
            var values = JsonConvert.SerializeObject(reviewManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddReview(Review p)
        {
            reviewManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ReviewID)
        {
            var v = reviewManager.TGetByID(ReviewID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteReview(int id)
        {
            var v = reviewManager.TGetByID(id);
            reviewManager.TDelete(v);
            return NoContent();
        }
        public IActionResult UpdateReview(Review p)
        {
            var v = reviewManager.TGetByID(p.ReviewID);
            reviewManager.TUpdate(v);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
