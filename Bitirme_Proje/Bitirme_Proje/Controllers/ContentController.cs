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
    [Authorize(Roles = "Admin")]
    public class ContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        public IActionResult Index()
        {
           
            var values = contentManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddContent()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddContent(Content content)
        {
            contentManager.TAdd(content);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteContent(int id)
        {
            var values = contentManager.TGetByID(id);
            contentManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditContent(int id)
        {
           
            var values = contentManager.TGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditContent(Content content)
        {
            contentManager.TUpdate(content);
            return RedirectToAction("Index");
        }
    }
}
