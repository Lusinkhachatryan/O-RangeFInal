﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace O_range.Entities
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}