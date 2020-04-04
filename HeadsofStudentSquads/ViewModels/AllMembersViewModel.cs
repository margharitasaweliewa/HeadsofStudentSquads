using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HeadsofStudentSquads.Models;

namespace HeadsofStudentSquads.ViewModels
{
    public class AllMembersViewModel
    {
        public Squad Squad  { get; set; }
        public List<Member> Members { get; set; }
    }
}