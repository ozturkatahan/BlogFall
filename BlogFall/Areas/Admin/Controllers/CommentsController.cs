using BlogFall.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogFall.Areas.Admin.Controllers
{
    [BreadCrumb("Yorumlar")]
    public class CommentsController : AdminBaseController
    {
        // GET: Admin/Comments
        [BreadCrumb("İndeks")]
        public ActionResult Index()
        {
            return View(db.Comments.ToList());
        }
    }
}