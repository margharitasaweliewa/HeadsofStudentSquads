using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HeadsofStudentSquads.Models
{
    public class Member : DbContext
    {
        //Что-то изменяю
        public Guid Id {get;set;}
        public DateTime DateofEnter { get; set; }
        public DateTime DateofExit { get; set; }
        public string ExitReason { get; set; }
    }
}





