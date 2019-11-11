using BlogFall.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogFall.Areas.Admin.Controllers
{
    [BreadCrumb("Ana Sayfa")]
    public class DashboardController : AdminBaseController
    {
        // GET: Admin/Dashboard
        [BreadCrumb("İndeks")]
        public ActionResult Index()
        {
            return View();
        }
    }
}