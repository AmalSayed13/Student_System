using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string DeptName { get; set; }
        public string HeadedBy { get; set; }
        public Department Department { get; set; }

        public List<Course> Courses { get; set; }
        public List<CourseSession> CourseSessions { get; set; }

    }
}
