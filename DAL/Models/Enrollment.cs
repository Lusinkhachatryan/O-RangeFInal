using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Enrollment
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public bool Confirmed { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}