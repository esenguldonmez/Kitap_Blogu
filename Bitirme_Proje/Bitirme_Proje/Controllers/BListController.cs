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
    public class BListController : Controller
    {
        BListManager bListManager = new BListManager(new EfBListDal());
        public IActionResult Index()
        {
           
            var values = bListManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBList()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddBList(BList book)
        {
            bListManager.TAdd(book);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBList(int id)
        {
            var values = bListManager.TGetByID(id);
            bListManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditBList(int id)
        {

            var values = bListManager.TGetByID(id);

            return View(values);
        }
       
        [HttpPost]
         public IActionResult EditBList(BList book)
        {
            bListManager.TUpdate(book);
            return RedirectToAction("Index");
        }
    }
}
//public IActionResult YuzdeHesapla(int id, int Value, int Sayfa)
//{
//    var values = bListManager.TGetByID(id);
//    int sonuc = (int)(0.5f + ((100f * Value) / Sayfa));
//    //sonuc = sonuc + ((Value * 100) / (Sayfa));
//    return RedirectToAction("BList", "EditBList");
//}