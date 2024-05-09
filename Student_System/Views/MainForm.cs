using Microsoft.EntityFrameworkCore;
using Student_System.Entities;
using Student_System.Views;
using Student_System.Views.Course_session_attendance;
using Student_System.Views.course_Student;
using Student_System.Views.CourseForm;
using Student_System.Views.CourseForms;
using Student_System.Views.DepartmentForms;
using Student_System.Views.InstructorForms;
using Student_System.Views.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System
{
    public partial class MainForm : Form
    {
        private MyDbContext db = new MyDbContext();

        public MainForm()
        {
            InitializeComponent();
            Load();

        }

        private async void Load()
        {
            dataGridView1.DataSource = await db.Students.ToListAsync();
        }

        private async void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load();
        }

        private async void addNewStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormAddStudent add = new FormAddStudent())
            {
                if (add.ShowDialog() == DialogResult.Cancel)
                {
                    Load();
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCourse add = new FormAddCourse();
            add.ShowDialog();
        }

        private void viewAllCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewCourse view = new FormViewCourse();
            view.ShowDialog();
        }

        private void viewAllInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewAll view = new FormViewAll();
            view.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddInstractor add = new FormAddInstractor();
            add.ShowDialog();
        }

        private void addNewDeprtmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddDept add = new FormAddDept();
            add.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addNewCourseStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourse_student add = new FormCourse_student();
            add.ShowDialog();
        }

        private void seaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormListOfStudent view = new FormListOfStudent())
            {
                if (view.ShowDialog() == DialogResult.Cancel)
                {
                    Load();
                }
            }
        }

        private void addNewCourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCourse_student add = new FormCourse_student();
            add.ShowDialog();
        }

        private void addInstructorsOfAnyDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddInstractor add = new FormAddInstractor();
            add.ShowDialog();
        }

        private void viewAlkInstructonsInThisDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewInstractor view = new FormViewInstractor();
            view.ShowDialog();
        }

        private void viewAllCourseCourseSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourse_CourseSession courseSession = new FormCourse_CourseSession();
            courseSession.ShowDialog();
        }

        private void addNewInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddInstractor add = new FormAddInstractor();
            add.ShowDialog();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourseSeission_attendance formCourseSeission_Attendance = new FormCourseSeission_attendance();
            formCourseSeission_Attendance.ShowDialog();
        }
    }
}
