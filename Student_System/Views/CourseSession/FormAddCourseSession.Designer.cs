namespace Student_System.Views.CourseSession
{
    partial class FormAddCourseSession
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
            label6 = new Label();
            cmbInsId = new ComboBox();
            cmbCourseName = new ComboBox();
            txtTitle = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Time = new DateTimePicker();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(319, 38);
            label6.Name = "label6";
            label6.Size = new Size(340, 38);
            label6.TabIndex = 42;
            label6.Text = "Add New Course Session";
            // 
            // cmbInsId
            // 
            cmbInsId.FormattingEnabled = true;
            cmbInsId.Location = new Point(445, 287);
            cmbInsId.Name = "cmbInsId";
            cmbInsId.Size = new Size(308, 33);
            cmbInsId.TabIndex = 41;
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(199, 190);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(239, 33);
            cmbCourseName.TabIndex = 40;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(603, 129);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(289, 31);
            txtTitle.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(225, 287);
            label5.Name = "label5";
            label5.Size = new Size(214, 32);
            label5.TabIndex = 38;
            label5.Text = "Instractor Name :";
            // 
            // txtId
            // 
            txtId.Location = new Point(199, 127);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(239, 31);
            txtId.TabIndex = 36;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(561, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 61);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(834, 428);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSeaGreen;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(367, 382);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 61);
            btnNew.TabIndex = 33;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(509, 195);
            label4.Name = "label4";
            label4.Size = new Size(81, 32);
            label4.TabIndex = 32;
            label4.Text = "Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(508, 129);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 31;
            label3.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 30;
            label2.Text = "Course Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(54, 126);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 29;
            label1.Text = "ID :";
            // 
            // Time
            // 
            Time.Location = new Point(596, 197);
            Time.Name = "Time";
            Time.Size = new Size(300, 31);
            Time.TabIndex = 43;
            // 
            // FormAddCourseSession
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 548);
            Controls.Add(Time);
            Controls.Add(label6);
            Controls.Add(cmbInsId);
            Controls.Add(cmbCourseName);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddCourseSession";
            Text = "FormAddCourseSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cmbInsId;
        private ComboBox cmbCourseName;
        private TextBox txtTitle;
        private Label label5;
        private TextBox txtId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker Time;
    }
}