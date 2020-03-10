using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Class1
    {
        static void Main(string[] args)
        {
            O_rangeContext context = new O_rangeContext();
            Course course = new Course() { Description = "Desc", Title = "Title1" };
            //context.Courses.Add(course);
           // context.SaveChanges();
            var c = context.Courses.ToList();
            
           
            //Topic topic = new Topic() { };
            //Question question = new Question() { };
           
        }
    }
}
