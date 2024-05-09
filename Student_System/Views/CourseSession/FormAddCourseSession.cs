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

namespace Student_System.Views.CourseSession
{
    public partial class FormAddCourseSession : Form
    {
        bool isNew;
        Entities.CourseSession courseSession;
        MyDbContext db = new MyDbContext();

        public FormAddCourseSession()
        {
            InitializeComponent();
            LoadInstractorsName();
            LoadCourseName();


        }
        private void LoadInstractorsName()
        {
            var instructors = db.Instructors.ToList();
            cmbInsId.DataSource = instructors;
            cmbInsId.DisplayMember = "FirstName";
            cmbInsId.ValueMember = "Id";
        }
        private void LoadCourseName()
        {
            var courses = db.Courses.ToList();
            cmbCourseName.DataSource = courses;
            cmbCourseName.DisplayMember = "Name";
            cmbCourseName.ValueMember = "Id";
        }
        public FormAddCourseSession(int id) : this()
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
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var course = (Course)cmbCourseName.SelectedItem;
            courseSession.CourseId = course.Id;
            var ins = (Instructor)cmbInsId.SelectedItem;
            courseSession.InstractorId = ins.Id;
            courseSession.Title = txtTitle.Text;
            courseSession.Date = Time.Value;
            if (IsNew)
                db.CourseSessions.Add(courseSession);

            await db.SaveChangesAsync();
            MessageBox.Show("Done!! Course session Saved");
            IsNew = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }
        void Load(int id)
        {

            courseSession = db.CourseSessions.First(c => c.Id == id);
            txtId.Text = courseSession.Id.ToString();
            txtTitle.Text = courseSession.Title;
            Time.Value = courseSession.Date;
            var ins = db.Instructors.First(i => i.Id == courseSession.InstractorId);
            cmbInsId.Text = ins.FirstName;
            var course = db.Courses.First(c => c.Id == courseSession.CourseId);
            cmbCourseName.Text = course.Name;
            IsNew = false;
        }
        void New()
        {
            courseSession = new Entities.CourseSession();
            txtId.Text = "";
            txtTitle.Text = "";
            IsNew = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            db.CourseSessions.Remove(courseSession);
            db.SaveChanges();
            MessageBox.Show("course session Deleted");
        }
    }
}
