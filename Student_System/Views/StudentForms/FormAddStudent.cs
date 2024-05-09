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

namespace Student_System.Views
{
    public partial class FormAddStudent : Form
    {
        bool isNew;
        Student_System.Entities.Student student;
        MyDbContext db = new MyDbContext();

        public FormAddStudent()
        {
            InitializeComponent();
            New();

        }
        public FormAddStudent(int id) : this()
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
            student.FirstName = txtFname.Text;
            student.LastName = txtLname.Text;
            student.Phone = txtPhone.Text;
            if (IsNew)
                db.Students.Add(student);

            await db.SaveChangesAsync();
            MessageBox.Show("Done!! Student Saved");
            IsNew = false;
        }
        void Load(int id)
        {

            student = db.Students.First(c => c.Id == id);
            txtId.Text = student.Id.ToString();
            txtFname.Text = student.FirstName;
            txtLname.Text = student.LastName;
            txtPhone.Text = student.Phone;
            IsNew = false;
        }
        void New()
        {
            student = new Student_System.Entities.Student();
            txtId.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtPhone.Text = "";
            IsNew = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Students.Remove(student);
            db.SaveChanges();
            MessageBox.Show("Student Deleted");
        }
    }
}
