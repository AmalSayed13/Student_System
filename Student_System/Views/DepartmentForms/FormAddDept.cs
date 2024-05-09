using Microsoft.EntityFrameworkCore;
using Student_System.Entities;
using Student_System.Views.CourseForm;
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

namespace Student_System.Views.DepartmentForms
{
    public partial class FormAddDept : Form
    {
        bool isNew;
        Department department;
        MyDbContext db = new MyDbContext();
        public FormAddDept()
        {
            InitializeComponent();
            Display();
            New();
        }
        async void Display()
        {
            dataGridView1.DataSource = await db.Departments.ToListAsync();
        }
        public bool IsNew
        {
            get => isNew; set
            {
                isNew = value;
                btnSave.Text = isNew ? "Add" : "Update";
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            department.Name = txtName.Text;
            department.Location = txtLocation.Text;
            if (IsNew)
                db.Departments.Add(department);

            await db.SaveChangesAsync();
            btnUpdate.Enabled = true;
            MessageBox.Show("Done!! Department Saved");
            IsNew = false;
            Display();
        }
        void Load(string name)
        {

            department = db.Departments.First(c => c.Name == name);
            txtName.Text = department.Name;
            txtLocation.Text = department.Location;
            txtName.Enabled = false;
            IsNew = false;
            btnUpdate.Enabled = false;
        }
        void New()
        {
            department = new Department();
            txtName.Text = "";
            txtName.Enabled = true;
            txtLocation.Text = "";
            IsNew = true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Department to Delete.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Department department)
            {
                db.Departments.Remove(department);
                db.SaveChanges();
                MessageBox.Show("department Deleted");
                Display();

            }
            else
            {
                MessageBox.Show("Selected row does not contain a Department.");
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Department to edit.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Department department)
            {
                string name = department.Name;
                Load(name);
                Display();
              
            }
            else
            {
                MessageBox.Show("Selected row does not contain a Department.");
            }
        }
    }
}
