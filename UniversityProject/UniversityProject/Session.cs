using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Models;

namespace UniversityProject
{
    public static  class Session
    {
        public static int LoggedInUserId { get; set; }

        public static List<Event>
        UserEvents
        { get; set; } = new List<Event>();


    }
}
