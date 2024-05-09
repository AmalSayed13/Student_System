using Microsoft.EntityFrameworkCore;
using Student_System.Entities;
using Student_System.Views.CourseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System.Views.InstructorForms
{
    public partial class FormViewInstractor : Form
    {
        MyDbContext db = new MyDbContext();


        public FormViewInstractor()
        {
            InitializeComponent();
            LoadDepartments();

        }
        private void LoadDepartments()
        {
            var departments = db.Departments.ToList();
            cmbDeptName.DataSource = departments;
            cmbDeptName.DisplayMember = "Name";
            cmbDeptName.ValueMember = "Name";
        }
        async void LoadIns()
        {
            btnSearch.Enabled = false;

            //var instructor = db.Instructors.Where(x => x.Id > 0).AsQueryable();
            //var courses = db.Courses.Where(x => x.Id > 0).AsQueryable();
            var dep = db.Departments.Find(cmbDeptName.Text);

            await db.Departments
               .Entry(dep)
               .Collection(d => d.Instructors)
               .LoadAsync();

            dataGridView1.DataSource = dep.Instructors;

            await db.Departments
              .Entry(dep)
              .Collection(d => d.Courses)
              .LoadAsync();

            dataGridView2.DataSource = dep.Courses;

            btnSearch.Enabled = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadIns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Instrictor to edit.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Instructor instructor)
            {
                int id = instructor.Id;
                FormAddInstractor frm = new FormAddInstractor(id);
                frm.ShowDialog();
                LoadIns();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a Instructor.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course to edit.");
                return;
            }

            var selectedRow = dataGridView2.SelectedRows[0];
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a instructor to Delete.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Instructor instructor)
            {
                db.Instructors.Remove(instructor);
                db.SaveChanges();
                MessageBox.Show("instructor Deleted");

            }
            else
            {
                MessageBox.Show("Selected row does not contain a instructor.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Course to Delete.");
                return;
            }

            var selectedRow = dataGridView2.SelectedRows[0];
            if (selectedRow.DataBoundItem is Course course)
            {
                db.Courses.Remove(course);
                db.SaveChanges();
                MessageBox.Show("Course Deleted");

            }
            else
            {
                MessageBox.Show("Selected row does not contain a Course.");
            }

        }
    }
}
