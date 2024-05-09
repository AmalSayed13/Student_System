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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Student_System.Views.Student
{
    public partial class FormListOfStudent : Form
    {
        public FormListOfStudent()
        {
            InitializeComponent();
        }
        async void LoadStudent()
        {
            btnSearch.Enabled = false;

            MyDbContext db = new MyDbContext();
            var students = db.Students.Where(x => x.Id > 0).AsQueryable();

            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                students = students.Where(x => x.Id == id);
            }
            else if (txtFname.Text.Length > 0 && txtLname.Text.Length == 0)
            {
                students = students.Where(x => x.FirstName.Contains(txtFname.Text.Trim()));
            }
            else if (txtLname.Text.Length > 0 && txtFname.Text.Length == 0)
            {
                students = students.Where(x => x.LastName.Contains(txtLname.Text.Trim()));

            }
            else if (txtLname.Text.Length > 0 && txtFname.Text.Length > 0)
            {
                students = students.Where(x => x.LastName.Contains(txtLname.Text.Trim()) && x.FirstName.Contains(txtFname.Text.Trim()));

            }
            else if (txtPhone.Text.Length > 0)
            {
                students = students.Where(x => x.Phone.Contains(txtPhone.Text.Trim()));

            }

            dataGridView1.DataSource = await students.ToListAsync();
            btnSearch.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.DataBoundItem is Entities.Student student)
            {
                int id = student.Id;
                FormAddStudent frm = new FormAddStudent(id); 
                frm.ShowDialog();
                LoadStudent();
            }
            else
            {
                MessageBox.Show("Selected row does not contain a student.");
            }
        }
    }
}
