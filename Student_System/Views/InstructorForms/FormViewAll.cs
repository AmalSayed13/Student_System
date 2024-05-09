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
using System.Xml.Linq;

namespace Student_System.Views.InstructorForms
{
    public partial class FormViewAll : Form
    {
        MyDbContext db = new MyDbContext();

        async void Display()
        {
            dataGridView1.DataSource = await db.Instructors.ToListAsync();
        }
        public FormViewAll()
        {

            InitializeComponent();
            Display();

        }
        async void LoadIns()
        {
            btnSearch.Enabled = false;

            var instructor = db.Instructors.Where(x => x.Id > 0).AsQueryable();

            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                instructor = instructor.Where(x => x.Id == id);
            }
            else if (txtName.Text.Length > 0)
            {
                instructor = instructor.Where(x => x.FirstName.Contains(txtName.Text.Trim()));
            }
            dataGridView1.DataSource = await instructor.ToListAsync();
            btnSearch.Enabled = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadIns();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
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
    }
}
