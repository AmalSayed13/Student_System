namespace Student_System.Views.course_Student
{
    partial class FormCourse_student
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
            dataGridView1 = new DataGridView();
            label6 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            label4 = new Label();
            label3 = new Label();
            cmbCourseId = new ComboBox();
            cmbStudentId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(130, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(441, 144);
            dataGridView1.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(151, 18);
            label6.Name = "label6";
            label6.Size = new Size(382, 38);
            label6.TabIndex = 52;
            label6.Text = "Add New Course of Student";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(558, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 61);
            btnSave.TabIndex = 49;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(546, 452);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSeaGreen;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(410, 195);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 61);
            btnNew.TabIndex = 47;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(164, 89);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 46;
            label4.Text = "Course :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(164, 141);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 45;
            label3.Text = "Student :";
            // 
            // cmbCourseId
            // 
            cmbCourseId.FormattingEnabled = true;
            cmbCourseId.Location = new Point(293, 92);
            cmbCourseId.Name = "cmbCourseId";
            cmbCourseId.Size = new Size(229, 33);
            cmbCourseId.TabIndex = 55;
            // 
            // cmbStudentId
            // 
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Location = new Point(293, 144);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(229, 33);
            cmbStudentId.TabIndex = 56;
            cmbStudentId.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // FormCourse_student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 576);
            Controls.Add(cmbStudentId);
            Controls.Add(cmbCourseId);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "FormCourse_student";
            Text = "FormCourse_student";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label6;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Label label4;
        private Label label3;
        private ComboBox cmbCourseId;
        private ComboBox cmbStudentId;
    }
}