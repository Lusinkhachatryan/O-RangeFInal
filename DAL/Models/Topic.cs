using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Topic
    {
        public int ID { get; set; }
        public string Title { get; set; }
        //  public int MaxCredits { get; set; }      pahi drutyamb stanal hashvetvutyan mej cuyc talu hamar
        public string Description { get; set; }
        public int CourseID { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}