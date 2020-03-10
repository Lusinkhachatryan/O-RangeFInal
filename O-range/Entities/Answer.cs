using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace O_range.Entities
{
    public class Answer
    {
        public int ID { get; set; }
        public string GivenAnswer { get; set; }
        public int QuestionID { get; set; }
        public int UserID { get; set; }
        public string CorrectAnswer { get; set; }
        public int Points { get; set; }

        public virtual Question Question { get; set; }
        public virtual User User { get; set; }
    }
}