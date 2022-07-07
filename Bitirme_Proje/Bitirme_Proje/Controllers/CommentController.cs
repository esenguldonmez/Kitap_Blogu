using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.Controllers
{
    public class CommentController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
      [HttpPost]
        public IActionResult AddComment(EntityLayer.Concrete.Message m)
        {
            m.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m.Status = true;
            messageManager.TAdd(m);
            return RedirectToAction("Index", "Default");
        }

    }
}
