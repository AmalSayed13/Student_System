using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Entities
{
    public class Department
    {
        [Key]
        public string Name { get; set; }
        public string Location { get; set; }
        public  List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }


    }
}
