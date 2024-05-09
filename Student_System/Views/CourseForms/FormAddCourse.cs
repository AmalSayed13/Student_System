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

namespace Student_System.Views.CourseForm
{
    public partial class FormAddCourse : Form
    {
        bool isNew;
        Course course;
        MyDbContext db = new MyDbContext();

        public FormAddCourse()
        {
            InitializeComponent();
            LoadDepartments();
            LoadInstractorsName();
            New();
        }
        private void LoadInstractorsName()
        {
            var instructors = db.Instructors.ToList();
            cmbInsId.DataSource = instructors;
            cmbInsId.DisplayMember = "FirstName";
            cmbInsId.ValueMember = "Id";
        }
        private void LoadDepartments()
        {
            var departments = db.Departments.ToList();
            cmbDeprtName.DataSource = departments;
            cmbDeprtName.DisplayMember = "Name";
            cmbDeprtName.ValueMember = "Name";
        }
        public FormAddCourse(int id) : this()
        {
            Load(id);
        }
        public bool IsNew
        {
            get => isNew; set
            {
                isNew = value;
                btnSave.Text = isNew ? "Add" : "Update";
                btnDelete.Enabled = !isNew;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            course.DeptName = cmbDeprtName.SelectedValue.ToString();
            course.Name = txtName.Text;
            course.Duration = int.Parse(txtDuration.Text);
            var ins = (Instructor)cmbInsId.SelectedItem;
            course.InsId = ins.Id;
            if (IsNew)
                db.Courses.Add(course);

            await db.SaveChangesAsync();
            MessageBox.Show("Done!! Course Saved");
            IsNew = false;
        }
        void Load(int id)
        {

            course = db.Courses.First(c => c.Id == id);
            txtId.Text = course.Id.ToString();
            txtName.Text = course.Name;
            txtDuration.Text = course.Duration.ToString();
            var ins = db.Instructors.First(i => i.Id == course.InsId);
            cmbInsId.Text = ins.FirstName;
            var dep = db.Departments.First(d => d.Name == course.DeptName);
            cmbDeprtName.Text = dep.Name;
            IsNew = false;
        }
        void New()
        {
            course = new Course();
            txtId.Text = "";
            txtName.Text = "";
            txtDuration.Text = "";
            IsNew = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Courses.Remove(course);
            db.SaveChanges();
            MessageBox.Show("course Deleted");
        }

        private void FormAddCourse_Load(object sender, EventArgs e)
        {

        }

        private void FormAddCourse_Load_1(object sender, EventArgs e)
        {

        }

        private void FormAddCourse_Load_2(object sender, EventArgs e)
        {

        }
    }
}
