using Microsoft.EntityFrameworkCore;
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
    public partial class FormViewCourse : Form
    {
        MyDbContext db = new MyDbContext();
         async void Display ()
        {
            dataGridView1.DataSource = await db.Courses.ToListAsync();
        }

        public FormViewCourse()
        {
            InitializeComponent();
            LoadDepartments();
            LoadInstractors();
            Display();
        }
        private void LoadInstractors()
        {
            var departments = db.Instructors.ToList();
            CmbInstName.DataSource = departments;
            CmbInstName.DisplayMember = "FirstName";
            CmbInstName.ValueMember = "Id";
        }
        private void LoadDepartments()
        {
            var departments = db.Departments.ToList();
            cmbDeptName.DataSource = departments;
            cmbDeptName.DisplayMember = "Name";
            cmbDeptName.ValueMember = "Name";
        }
        async void LoadCourse()
        {
            btnSearch.Enabled = false;

            var courses = db.Courses.Where(x => x.Id > 0).AsQueryable();

            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                courses = courses.Where(x => x.Id == id);
            }
            else if (txtName.Text.Length > 0)
            {
                courses = courses.Where(x => x.Name.Contains(txtName.Text.Trim()));
            }
            else if (cmbDeptName.Text.Length > 0)
            {
                courses = courses.Where(x => x.DeptName.Contains(cmbDeptName.Text));
            }
            else if (CmbInstName.Text.Length > 0)
            {
                var insId = (Instructor)CmbInstName.SelectedItem;
                var instructor = db.Instructors.FirstOrDefault(insId);
                if (instructor != null)
                {
                    courses = courses.Where(x => x.InsId == instructor.Id);
                }
            }

            dataGridView1.DataSource = await courses.ToListAsync();
            btnSearch.Enabled = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCourse();
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
                LoadCourse();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a Course.");
            }
        }
    }
}
