using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var toplamkitapsayisi = c.Portfolios.Count();
            ViewBag.toplamkitapsayisi = toplamkitapsayisi;
            var toplamiceriksayisi = c.Reviews.Count();
            ViewBag.toplamiceriksayisi = toplamiceriksayisi;
            return View();
        }
    }
}
