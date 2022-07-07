using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje.ViewComponents.Content
{
    public class ContentList : ViewComponent
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        public IViewComponentResult Invoke()
        {
            var values = contentManager.TGetList();
            return View(values);
        }
    }

}
