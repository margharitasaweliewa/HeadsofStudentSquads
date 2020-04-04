using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeadsofStudentSquads.Models;
using HeadsofStudentSquads.ViewModels;

namespace HeadsofStudentSquads.Controllers
{
    public class SquadsController : Controller
    {
        // GET: Squads
        public ActionResult Squad()
        {
            var squad = new Squad() { Name = "Вместе Веселей!" };
            var members = new List<Member>
            {
                new Member { ExitReason="1 причина" },
                new Member { ExitReason ="2 причина"}
            };
            var viewModel = new AllMembersViewModel
            {
                Squad = squad,
                Members = members
            };
            return View(viewModel);
        }
    }
}