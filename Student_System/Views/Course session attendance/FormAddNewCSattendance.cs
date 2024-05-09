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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Student_System.Views.Course_session_attendance
{
    public partial class FormAddNewCSattendance : Form
    {
        bool isNew;
        CourseSessionAttendance CourseSessionAttendance;
        MyDbContext db = new MyDbContext();
        public FormAddNewCSattendance()
        {
            InitializeComponent();
            LoadCourseSName();
            LoadStdName();
        }
        private void LoadCourseSName()
        {
            var courseS = db.CourseSessions.ToList();
            cmbCSName.DataSource = courseS;
            cmbCSName.DisplayMember = "Title";
            cmbCSName.ValueMember = "Id";
        }
        private void LoadStdName()
        {
            var Std = db.Students.ToList();
            cmbStdName.DataSource = Std;
            cmbStdName.DisplayMember = "FirstName";
            cmbStdName.ValueMember = "Id";
        }
        public FormAddNewCSattendance(int id) : this()
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
            var cS = (Entities.CourseSession)cmbCSName.SelectedItem;
            CourseSessionAttendance.CourseSessionId = cS.Id;
            var std = (Entities.Student)cmbStdName.SelectedItem;
            CourseSessionAttendance.StudentId = std.Id;
            CourseSessionAttendance.Grade = int.Parse(txtGrade.Text);
            CourseSessionAttendance.Notes = txtNotes.Text;
            if (IsNew)
                db.CourseSessionAttendances.Add(CourseSessionAttendance);

            await db.SaveChangesAsync();
            MessageBox.Show("Done!! Course session attendence Saved");
            IsNew = false;
        }
        void Load(int id)
        {

            CourseSessionAttendance = db.CourseSessionAttendances.First(c => c.Id == id);
            txtId.Text = CourseSessionAttendance.Id.ToString();
            txtGrade.Text = CourseSessionAttendance.Grade.ToString();
            txtNotes.Text = CourseSessionAttendance.Notes;

            IsNew = false;
        }
        void New()
        {
            CourseSessionAttendance = new CourseSessionAttendance();
            txtId.Text = "";
            txtGrade.Text = "";
            txtNotes.Text = "";
            IsNew = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.CourseSessionAttendances.Remove(CourseSessionAttendance);
            db.SaveChanges();
            MessageBox.Show("course session  attendance Deleted");
        }
    }
}
