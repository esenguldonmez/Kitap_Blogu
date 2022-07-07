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
    public class UserCmController : Controller
    {
        //UserCmManager userCmManager = new UserCmManager(new EfUserCmDal());
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddUserCm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUserCm(Message p)
        {
            messageManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteUserCm(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUserCm(int id)
        {
            var values = messageManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditUserCm(Message message)
        {
            messageManager.TUpdate(message);
            return RedirectToAction("Index");
        }
    }
}
