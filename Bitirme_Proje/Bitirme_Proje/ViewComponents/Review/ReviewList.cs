using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.ViewComponents.Review
{
    public class ReviewList:ViewComponent
    {
        ReviewManager reviewManager = new ReviewManager (new EfReviewDal());
        public IViewComponentResult Invoke()
        {
            var values = reviewManager.TGetList();
            return View(values);
        }
    }
}
