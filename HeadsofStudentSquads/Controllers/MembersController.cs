using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeadsofStudentSquads.Models;

namespace HeadsofStudentSquads.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult All()
        {
            var member = new Member() { ExitReason = "Собственное желание" };
            
            return View(member);
        }
        public ActionResult Edit(int id)
        {
            return Content("id"+Convert.ToString(id));
        }
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "ExitReason";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
            public ActionResult ById(int id)
        {
            return Content(Convert.ToString(id));
        }
    }
}