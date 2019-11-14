using BlogFall.Areas.Admin.ViewModels;
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
            var model = new DashboardIndexViewModel
            {
                CategoryCount = db.Categories.Count(),
                PostCount = db.Posts.Count(),
                UserCount = db.Users.Count(),
                CommentCount = db.Comments.Count(),
            };
            return View(model);
        }
    }
}