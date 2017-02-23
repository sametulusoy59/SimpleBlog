using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.admin.Controllers
{
    public class UserController : Controller
    {
        // GET: admin/User
        public ActionResult Index()
        {
            return Content("Admin area users controller ındex action");
        }
        public ActionResult List()
        {
            return Content("Admin area users controller list action");
        }
        public ActionResult edit(int id=0)
        {
            return Content("Admin area users controller edit action with parameter : "+id.ToString());
        }
    }
}