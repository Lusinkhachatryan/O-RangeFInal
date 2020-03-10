using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace O_range.Entities
{
    public class Question
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string OPA { get; set; }
        public string OPB { get; set; }
        public string OPC { get; set; }
        public string OPD { get; set; }
        public string COP { get; set; }
        public int TopicID { get; set; }

        public virtual Topic Topic { get; set; }
    }
}