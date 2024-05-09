using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeptName{ get; set; }
        public int InsId { get; set; }
        public int Duration { get; set; }
        public Department Department { get; set; }
        public Instructor Instructor { get; set; }
        public List<Course_Student> Course_Students { get; set; }
        public List<CourseSession> courseSessions { get; set; }



    }
}
