using BlogFall.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogFall.Areas.Admin.Controllers
{
    [BreadCrumb("Kullanıclar")]
    public class UsersController : AdminBaseController
    {
        [BreadCrumb("İndeks")]
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult ChangeStatus(string userId, bool isEnabled)
        {
            var user = db.Users.Find(userId);
            user.IsEnabled = isEnabled;
            db.SaveChanges();
            return Json(new { success = true });
        }
    }
}