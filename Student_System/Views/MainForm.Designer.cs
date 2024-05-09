namespace Student_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            seaToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem1 = new ToolStripMenuItem();
            addNewCourseToolStripMenuItem1 = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            addNewDeprtmentToolStripMenuItem = new ToolStripMenuItem();
            addInstructorsOfAnyDepartmentToolStripMenuItem = new ToolStripMenuItem();
            viewAlkInstructonsInThisDepartmentToolStripMenuItem = new ToolStripMenuItem();
            instructorToolStripMenuItem = new ToolStripMenuItem();
            viewAllInstructorsToolStripMenuItem = new ToolStripMenuItem();
            viewAllCourseCourseSeToolStripMenuItem = new ToolStripMenuItem();
            addNewInstructorToolStripMenuItem = new ToolStripMenuItem();
            courseToolStripMenuItem = new ToolStripMenuItem();
            viewAllCoursesToolStripMenuItem = new ToolStripMenuItem();
            addNewCourseToolStripMenuItem = new ToolStripMenuItem();
            viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, departmentToolStripMenuItem, instructorToolStripMenuItem, courseToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(679, 34);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, addNewStudentToolStripMenuItem1, addNewCourseToolStripMenuItem1 });
            studentToolStripMenuItem.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            studentToolStripMenuItem.ForeColor = Color.DarkCyan;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(95, 30);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seaToolStripMenuItem });
            addNewStudentToolStripMenuItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            addNewStudentToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(411, 38);
            addNewStudentToolStripMenuItem.Text = "View All Student";
            addNewStudentToolStripMenuItem.Click += addNewStudentToolStripMenuItem_Click;
            // 
            // seaToolStripMenuItem
            // 
            seaToolStripMenuItem.Name = "seaToolStripMenuItem";
            seaToolStripMenuItem.Size = new Size(314, 38);
            seaToolStripMenuItem.Text = "search of student list";
            seaToolStripMenuItem.Click += seaToolStripMenuItem_Click;
            // 
            // addNewStudentToolStripMenuItem1
            // 
            addNewStudentToolStripMenuItem1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            addNewStudentToolStripMenuItem1.ForeColor = Color.LightSeaGreen;
            addNewStudentToolStripMenuItem1.Name = "addNewStudentToolStripMenuItem1";
            addNewStudentToolStripMenuItem1.Size = new Size(411, 38);
            addNewStudentToolStripMenuItem1.Text = "Add New Student";
            addNewStudentToolStripMenuItem1.Click += addNewStudentToolStripMenuItem1_Click;
            // 
            // addNewCourseToolStripMenuItem1
            // 
            addNewCourseToolStripMenuItem1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            addNewCourseToolStripMenuItem1.ForeColor = Color.LightSeaGreen;
            addNewCourseToolStripMenuItem1.Name = "addNewCourseToolStripMenuItem1";
            addNewCourseToolStripMenuItem1.Size = new Size(411, 38);
            addNewCourseToolStripMenuItem1.Text = "Add New Course of any student";
            addNewCourseToolStripMenuItem1.Click += addNewCourseToolStripMenuItem1_Click;
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDeprtmentToolStripMenuItem, addInstructorsOfAnyDepartmentToolStripMenuItem, viewAlkInstructonsInThisDepartmentToolStripMenuItem });
            departmentToolStripMenuItem.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            departmentToolStripMenuItem.ForeColor = Color.DarkCyan;
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(128, 30);
            departmentToolStripMenuItem.Text = "Department";
            // 
            // addNewDeprtmentToolStripMenuItem
            // 
            addNewDeprtmentToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            addNewDeprtmentToolStripMenuItem.Name = "addNewDeprtmentToolStripMenuItem";
            addNewDeprtmentToolStripMenuItem.Size = new Size(469, 34);
            addNewDeprtmentToolStripMenuItem.Text = "Add New Deprtment";
            addNewDeprtmentToolStripMenuItem.Click += addNewDeprtmentToolStripMenuItem_Click;
            // 
            // addInstructorsOfAnyDepartmentToolStripMenuItem
            // 
            addInstructorsOfAnyDepartmentToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            addInstructorsOfAnyDepartmentToolStripMenuItem.Name = "addInstructorsOfAnyDepartmentToolStripMenuItem";
            addInstructorsOfAnyDepartmentToolStripMenuItem.Size = new Size(469, 34);
            addInstructorsOfAnyDepartmentToolStripMenuItem.Text = "Add Instructors of any Department";
            addInstructorsOfAnyDepartmentToolStripMenuItem.Click += addInstructorsOfAnyDepartmentToolStripMenuItem_Click;
            // 
            // viewAlkInstructonsInThisDepartmentToolStripMenuItem
            // 
            viewAlkInstructonsInThisDepartmentToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            viewAlkInstructonsInThisDepartmentToolStripMenuItem.Name = "viewAlkInstructonsInThisDepartmentToolStripMenuItem";
            viewAlkInstructonsInThisDepartmentToolStripMenuItem.Size = new Size(469, 34);
            viewAlkInstructonsInThisDepartmentToolStripMenuItem.Text = "View Instucrors && Courses in Department";
            viewAlkInstructonsInThisDepartmentToolStripMenuItem.Click += viewAlkInstructonsInThisDepartmentToolStripMenuItem_Click;
            // 
            // instructorToolStripMenuItem
            // 
            instructorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllInstructorsToolStripMenuItem, viewAllCourseCourseSeToolStripMenuItem, addNewInstructorToolStripMenuItem });
            instructorToolStripMenuItem.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            instructorToolStripMenuItem.ForeColor = Color.DarkCyan;
            instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            instructorToolStripMenuItem.Size = new Size(112, 30);
            instructorToolStripMenuItem.Text = "Instructor";
            instructorToolStripMenuItem.Click += instructorToolStripMenuItem_Click;
            // 
            // viewAllInstructorsToolStripMenuItem
            // 
            viewAllInstructorsToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            viewAllInstructorsToolStripMenuItem.Name = "viewAllInstructorsToolStripMenuItem";
            viewAllInstructorsToolStripMenuItem.Size = new Size(511, 34);
            viewAllInstructorsToolStripMenuItem.Text = "View All Instructors";
            viewAllInstructorsToolStripMenuItem.Click += viewAllInstructorsToolStripMenuItem_Click;
            // 
            // viewAllCourseCourseSeToolStripMenuItem
            // 
            viewAllCourseCourseSeToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            viewAllCourseCourseSeToolStripMenuItem.Name = "viewAllCourseCourseSeToolStripMenuItem";
            viewAllCourseCourseSeToolStripMenuItem.Size = new Size(511, 34);
            viewAllCourseCourseSeToolStripMenuItem.Text = "view all course && course session by instructor";
            viewAllCourseCourseSeToolStripMenuItem.Click += viewAllCourseCourseSeToolStripMenuItem_Click;
            // 
            // addNewInstructorToolStripMenuItem
            // 
            addNewInstructorToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            addNewInstructorToolStripMenuItem.Name = "addNewInstructorToolStripMenuItem";
            addNewInstructorToolStripMenuItem.Size = new Size(511, 34);
            addNewInstructorToolStripMenuItem.Text = "Add new Instructor";
            addNewInstructorToolStripMenuItem.Click += addNewInstructorToolStripMenuItem_Click;
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllCoursesToolStripMenuItem, addNewCourseToolStripMenuItem, viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem });
            courseToolStripMenuItem.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            courseToolStripMenuItem.ForeColor = Color.DarkCyan;
            courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            courseToolStripMenuItem.Size = new Size(90, 30);
            courseToolStripMenuItem.Text = "Course";
            // 
            // viewAllCoursesToolStripMenuItem
            // 
            viewAllCoursesToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            viewAllCoursesToolStripMenuItem.Name = "viewAllCoursesToolStripMenuItem";
            viewAllCoursesToolStripMenuItem.Size = new Size(582, 34);
            viewAllCoursesToolStripMenuItem.Text = "View All Courses";
            viewAllCoursesToolStripMenuItem.Click += viewAllCoursesToolStripMenuItem_Click;
            // 
            // addNewCourseToolStripMenuItem
            // 
            addNewCourseToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            addNewCourseToolStripMenuItem.Name = "addNewCourseToolStripMenuItem";
            addNewCourseToolStripMenuItem.Size = new Size(582, 34);
            addNewCourseToolStripMenuItem.Text = "Add New Course";
            addNewCourseToolStripMenuItem.Click += addNewCourseToolStripMenuItem_Click;
            // 
            // viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem
            // 
            viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem.ForeColor = Color.LightSeaGreen;
            viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem.Name = "viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem";
            viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem.Size = new Size(582, 34);
            viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem.Text = "View course session and his attendance of this course";
            viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem.Click += viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            closeToolStripMenuItem.ForeColor = Color.DarkCyan;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(77, 30);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkCyan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(6, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(666, 324);
            dataGridView1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 406);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem instructorToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem1;
        private ToolStripMenuItem viewAllCoursesToolStripMenuItem;
        private ToolStripMenuItem addNewCourseToolStripMenuItem;
        private ToolStripMenuItem viewAllInstructorsToolStripMenuItem;
        private ToolStripMenuItem addNewDeprtmentToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem seaToolStripMenuItem;
        private ToolStripMenuItem addNewCourseToolStripMenuItem1;
        private ToolStripMenuItem addInstructorsOfAnyDepartmentToolStripMenuItem;
        private ToolStripMenuItem viewAlkInstructonsInThisDepartmentToolStripMenuItem;
        private ToolStripMenuItem viewAllCourseCourseSeToolStripMenuItem;
        private ToolStripMenuItem addNewInstructorToolStripMenuItem;
        private ToolStripMenuItem viewCourseSessionAndHisAttendanceOfThisCourseToolStripMenuItem;
    }
}