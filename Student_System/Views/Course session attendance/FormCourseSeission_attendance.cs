using Student_System.Entities;
using Student_System.Views.CourseSession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System.Views.Course_session_attendance
{
    public partial class FormCourseSeission_attendance : Form
    {
        MyDbContext db = new MyDbContext();

        public FormCourseSeission_attendance()
        {
            InitializeComponent();
            LoadCourses();
        }
        private void LoadCourses()
        {
            var courses = db.Courses.ToList();
            cmbCourseName.DataSource = courses;
            cmbCourseName.DisplayMember = "Name";
            cmbCourseName.ValueMember = "Id";
        }
        async void Load()
        {
            btnSearch.Enabled = false;
            var course = (Course)cmbCourseName.SelectedItem;
            var course1 = db.Courses.Find(course.Id);

            await db.Courses
               .Entry(course1)
               .Collection(d => d.courseSessions)
               .LoadAsync();

            dataGridView1.DataSource = course1.courseSessions;


            btnSearch.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course Session to edit.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Entities.CourseSession courseSession)
            {
                int id = courseSession.Id;
                FormAddCourseSession frm = new FormAddCourseSession(id);
                frm.ShowDialog();
                Load();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a Course Session.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course session to Delete.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Entities.CourseSession courseSession)
            {
                db.CourseSessions.Remove(courseSession);
                db.SaveChanges();
                MessageBox.Show("course session Deleted");
                Load();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a course session.");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var couseSess = dataGridView1.SelectedRows[0].DataBoundItem as Entities.CourseSession;
            lblCourse.Text = couseSess.Title;

            await db.CourseSessions
              .Entry(couseSess)
              .Collection(d => d.courseSessionAttendances)
              .LoadAsync();

            dataGridView2.DataSource = couseSess.courseSessionAttendances;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course Session  Attendance to edit.");
                return;
            }

            var selectedRow = dataGridView2.SelectedRows[0];
            if (selectedRow.DataBoundItem is CourseSessionAttendance courseSessionAttendance)
            {
                int id = courseSessionAttendance.Id;
                FormAddNewCSattendance frm = new FormAddNewCSattendance(id);
                frm.ShowDialog();
                Load();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a Course Session Attendance.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course session  Attendance to Delete.");
                return;
            }

            var selectedRow = dataGridView2.SelectedRows[0];
            if (selectedRow.DataBoundItem is CourseSessionAttendance courseSessionAttendance)
            {
                db.CourseSessionAttendances.Remove(courseSessionAttendance);
                db.SaveChanges();
                MessageBox.Show("course session Attendance Deleted ");
                Load();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a course session Attendance.");
            }
        }
    }
}
