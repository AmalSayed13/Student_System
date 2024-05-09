using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Student_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_System.Views.course_Student
{
    public partial class FormCourse_student : Form
    {
        Course_Student course;
        MyDbContext db = new MyDbContext();
        public FormCourse_student()
        {
            InitializeComponent();
            loadCourseId();
            loadStudentId();
            Display();


        }
        async void Display()
        {
            dataGridView1.DataSource = await db.CourseStudents.ToListAsync();
        }
        private void loadCourseId()
        {
            var c = db.Courses.ToList();
            cmbCourseId.DataSource = c;
            cmbCourseId.DisplayMember = "Name";
            cmbCourseId.ValueMember = "Id";
        }
        private void loadStudentId()
        {
            var student = db.Students.ToList();
            cmbStudentId.DataSource = student;
            cmbStudentId.DisplayMember = "FirstName";
            cmbStudentId.ValueMember = "Id";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void btnNew_Click(object sender, EventArgs e)
        {
          
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
               

                if (cmbStudentId.SelectedItem == null || cmbCourseId.SelectedItem == null)
                {
                    MessageBox.Show("Please select both a student and a course.");
                    return;
                }
                if (course == null)
                {
                    course = new Course_Student();
                }
                var courseId = (Course)cmbCourseId.SelectedItem;
                var studentId = (Entities.Student)cmbStudentId.SelectedItem;

                course.StudentId = courseId.Id;
                course.CourseId = studentId.Id;

                    db.CourseStudents.Add(course);
                    //MessageBox.Show("hhho");

                await db.SaveChangesAsync();
                MessageBox.Show($"Done!! course {cmbCourseId.Text} of student {cmbStudentId.Text} Saved");
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }



        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course of student to Delete.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Course_Student course_Student)
            {
                db.CourseStudents.Remove(course_Student);
                db.SaveChanges();
                MessageBox.Show("Course of student Deleted");
                Display();

            }
            else
            {
                MessageBox.Show("Selected row does not contain a Course of student.");
            }
        }
    }
}
