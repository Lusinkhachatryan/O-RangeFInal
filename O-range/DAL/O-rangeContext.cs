using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using O_range.Entities;

namespace O_range.DAL
{
    public class O_rangeContext : DbContext
    {
        public O_rangeContext() : base("name=O-range")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Group> Groupes { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}