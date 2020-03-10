using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace O_range.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsTeamLead { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}