using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.ViewComponents.BList
{
    public class BListList:ViewComponent
    {
        BListManager bListManager = new BListManager(new EfBListDal());
        public IViewComponentResult Invoke()
        {
            var values = bListManager.TGetList();
            return View(values);
        }
    }
}
