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

namespace Student_System.Views.InstructorForms
{
    public partial class FormAddInstractor : Form
    {
        bool isNew;
        Instructor instructor;
        MyDbContext db = new MyDbContext();
        public FormAddInstractor()
        {
            InitializeComponent();
            LoadDepartments();

        }
        public FormAddInstractor(int id) : this()
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
        private void LoadDepartments()
        {
            var departments = db.Departments.ToList();
            cmbDeprtName.DataSource = departments;
            cmbDeprtName.DisplayMember = "Name";
            cmbDeprtName.ValueMember = "Name";
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddInstractor_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (instructor == null) 
            {
                instructor = new Instructor(); 
            }

            instructor.DeptName = cmbDeprtName.Text;
            instructor.FirstName = txtFName.Text;
            instructor.LastName = txtLname.Text;
            instructor.Phone = txtPhone.Text;
            instructor.HeadedBy = txtHeaded.Text;

            if (IsNew)
            {
                db.Instructors.Add(instructor);
            }

            await db.SaveChangesAsync();
            MessageBox.Show("Done!! Instructor Saved");
            IsNew = false;

        }
        void Load(int id)
        {

            instructor = db.Instructors.First(c => c.Id == id);
            txtId.Text = instructor.Id.ToString();
            cmbDeprtName.Text = instructor.DeptName;
            txtFName.Text = instructor.FirstName ;
             txtLname.Text = instructor.LastName ;
             txtPhone.Text = instructor.Phone ;
            txtHeaded.Text = instructor.HeadedBy ;

            IsNew = false;
        }
        void New()
        {
            instructor = new Instructor();
            txtId.Text = "";
            txtFName.Text = "";
            txtLname.Text = "";
            txtPhone.Text ="";
            txtHeaded.Text = "";
            IsNew = true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();

        }
    }
}
