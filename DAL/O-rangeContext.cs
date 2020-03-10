using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
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
