using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Entities
{
    public class CourseSession
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public int InstractorId { get; set; }
        public Instructor instructor { get; set; }
        public Course course { get; set; }
        public List<CourseSessionAttendance> courseSessionAttendances { get; set; }



    }
}
