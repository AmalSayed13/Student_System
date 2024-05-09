using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Entities
{
    public class Course_Student
    {
        //public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Course course { get; set; }
        public Student student { get; set; }


    }
}
