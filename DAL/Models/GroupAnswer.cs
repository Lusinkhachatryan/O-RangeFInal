using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class GroupAnswer
    {
        public int ID { get; set; }
        public string GivenAnswer { get; set; }
        public int QuestionID { get; set; }
        public int GroupID { get; set; }
        public string CorrectAnswer { get; set; }
        public int Points { get; set; }

        public virtual Question Question { get; set; }
        public virtual Group Groups { get; set; }
    }
}