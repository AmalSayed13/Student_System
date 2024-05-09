namespace Student_System.Views.Course_session_attendance
{
    partial class FormAddNewCSattendance
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
            cmbCSName = new ComboBox();
            cmbStdName = new ComboBox();
            txtGrade = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNotes = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(233, 39);
            label6.Name = "label6";
            label6.Size = new Size(498, 38);
            label6.TabIndex = 56;
            label6.Text = "Add New Course Session Attendance";
            // 
            // cmbCSName
            // 
            cmbCSName.FormattingEnabled = true;
            cmbCSName.Location = new Point(451, 313);
            cmbCSName.Name = "cmbCSName";
            cmbCSName.Size = new Size(308, 33);
            cmbCSName.TabIndex = 55;
            // 
            // cmbStdName
            // 
            cmbStdName.FormattingEnabled = true;
            cmbStdName.Location = new Point(233, 218);
            cmbStdName.Name = "cmbStdName";
            cmbStdName.Size = new Size(239, 33);
            cmbStdName.TabIndex = 54;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(616, 155);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(289, 31);
            txtGrade.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(165, 314);
            label5.Name = "label5";
            label5.Size = new Size(280, 32);
            label5.TabIndex = 52;
            label5.Text = "Course Session Name  :";
            // 
            // txtId
            // 
            txtId.Location = new Point(233, 155);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(239, 31);
            txtId.TabIndex = 51;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(567, 408);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 61);
            btnSave.TabIndex = 50;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(811, 460);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 49;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSeaGreen;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(373, 408);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 61);
            btnNew.TabIndex = 48;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(515, 221);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 47;
            label4.Text = "Notes :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(514, 155);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 46;
            label3.Text = "Grade :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(31, 221);
            label2.Name = "label2";
            label2.Size = new Size(196, 32);
            label2.TabIndex = 45;
            label2.Text = "Studend Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(89, 155);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 44;
            label1.Text = "ID :";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(616, 224);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(289, 31);
            txtNotes.TabIndex = 57;
            // 
            // FormAddNewCSattendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 597);
            Controls.Add(txtNotes);
            Controls.Add(label6);
            Controls.Add(cmbCSName);
            Controls.Add(cmbStdName);
            Controls.Add(txtGrade);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddNewCSattendance";
            Text = "FormAddNewCSattendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cmbCSName;
        private ComboBox cmbStdName;
        private TextBox txtGrade;
        private Label label5;
        private TextBox txtId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNotes;
    }
}