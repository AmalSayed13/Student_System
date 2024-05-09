using Microsoft.EntityFrameworkCore;
using Student_System.Entities;
using Student_System.Views.CourseForm;
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

namespace Student_System.Views.CourseForms
{
    public partial class FormCourse_CourseSession : Form
    {
        MyDbContext db = new MyDbContext();

        public FormCourse_CourseSession()
        {
            InitializeComponent();
            LoadInstractors();
        }
        private void LoadInstractors()
        {
            var departments = db.Instructors.ToList();
            CmbInstName.DataSource = departments;
            CmbInstName.DisplayMember = "FirstName";
            CmbInstName.ValueMember = "Id";
        }
        async void LoadIns()
        {
            btnSearch.Enabled = false;
            var insId = (Instructor)CmbInstName.SelectedItem;
            var ins = db.Instructors.Find(insId.Id);

            await db.Instructors
               .Entry(ins)
               .Collection(d => d.Courses)
               .LoadAsync();

            dataGridView1.DataSource = ins.Courses;

            await db.Instructors
              .Entry(ins)
              .Collection(d => d.CourseSessions)
              .LoadAsync();

            dataGridView2.DataSource = ins.CourseSessions;

            btnSearch.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course to edit.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Course course)
            {
                int id = course.Id;
                FormAddCourse frm = new FormAddCourse(id);
                frm.ShowDialog();
                LoadIns();

            }
            else
            {
                MessageBox.Show("Selected row does not contain a Course.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadIns();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course to edit.");
                return;
            }

            var selectedRow = dataGridView2.SelectedRows[0];
            if (selectedRow.DataBoundItem is Entities.CourseSession courseSession)
            {
                int id = courseSession.Id;
                FormAddCourseSession frm = new FormAddCourseSession(id);
                frm.ShowDialog();
                LoadIns();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a Course.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to Delete.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Course course)
            {
                db.Courses.Remove(course);
                db.SaveChanges();
                MessageBox.Show("course Deleted");

            }
            else
            {
                MessageBox.Show("Selected row does not contain a course.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course session to Delete.");
                return;
            }

            var selectedRow = dataGridView2.SelectedRows[0];
            if (selectedRow.DataBoundItem is Entities.CourseSession courseSession)
            {
                db.CourseSessions.Remove(courseSession);
                db.SaveChanges();
                MessageBox.Show("course session Deleted");
                LoadIns();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a course session.");
            }
        }
    }
}
