namespace Student_System.Views.Course_session_attendance
{
    partial class FormCourseSeission_attendance
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
            button3 = new Button();
            btnDelete = new Button();
            label1 = new Label();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            cmbCourseName = new ComboBox();
            button1 = new Button();
            btnSearch = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            lblCourse = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(948, 743);
            button3.Name = "button3";
            button3.Size = new Size(112, 61);
            button3.TabIndex = 61;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(942, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(65, 478);
            label1.Name = "label1";
            label1.Size = new Size(449, 38);
            label1.TabIndex = 59;
            label1.Text = "All Course session attendance to ";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Location = new Point(830, 742);
            button2.Name = "button2";
            button2.Size = new Size(112, 62);
            button2.TabIndex = 58;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MediumAquamarine;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(43, 532);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1011, 204);
            dataGridView2.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(395, 99);
            label5.Name = "label5";
            label5.Size = new Size(291, 38);
            label5.TabIndex = 56;
            label5.Text = "Show Course Session";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(322, 33);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(436, 33);
            cmbCourseName.TabIndex = 55;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(824, 371);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 54;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumAquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(775, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 48);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(135, 30);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 52;
            label4.Text = "Course Name :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1028, 204);
            dataGridView1.TabIndex = 51;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.ForeColor = Color.DarkCyan;
            lblCourse.Location = new Point(544, 478);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(0, 38);
            lblCourse.TabIndex = 62;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumAquamarine;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(690, 468);
            button4.Name = "button4";
            button4.Size = new Size(150, 48);
            button4.TabIndex = 63;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormCourseSeission_attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 820);
            Controls.Add(button4);
            Controls.Add(lblCourse);
            Controls.Add(button3);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(cmbCourseName);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "FormCourseSeission_attendance";
            Text = "FormCourseSeission_attendance";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button btnDelete;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView2;
        private Label label5;
        private ComboBox cmbCourseName;
        private Button button1;
        private Button btnSearch;
        private Label label4;
        private DataGridView dataGridView1;
        private Label lblCourse;
        private Button button4;
    }
}