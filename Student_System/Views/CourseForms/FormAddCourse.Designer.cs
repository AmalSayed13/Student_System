namespace Student_System.Views.CourseForm
{
    partial class FormAddCourse
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
            components = new System.ComponentModel.Container();
            txtId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtDuration = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmbDeprtName = new ComboBox();
            txtName = new TextBox();
            cmbInsId = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(279, 92);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(239, 31);
            txtId.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(492, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 61);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(839, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSeaGreen;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(298, 359);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 61);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(568, 155);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 14;
            label4.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(567, 89);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 13;
            label3.Text = "Duration :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(33, 153);
            label2.Name = "label2";
            label2.Size = new Size(240, 32);
            label2.TabIndex = 12;
            label2.Text = "Department Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(33, 86);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 11;
            label1.Text = "ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(204, 247);
            label5.Name = "label5";
            label5.Size = new Size(214, 32);
            label5.TabIndex = 22;
            label5.Text = "Instractor Name :";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(703, 92);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(289, 31);
            txtDuration.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cmbDeprtName
            // 
            cmbDeprtName.FormattingEnabled = true;
            cmbDeprtName.Location = new Point(279, 155);
            cmbDeprtName.Name = "cmbDeprtName";
            cmbDeprtName.Size = new Size(239, 33);
            cmbDeprtName.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.Location = new Point(703, 150);
            txtName.Name = "txtName";
            txtName.Size = new Size(289, 31);
            txtName.TabIndex = 21;
            // 
            // cmbInsId
            // 
            cmbInsId.FormattingEnabled = true;
            cmbInsId.Location = new Point(424, 247);
            cmbInsId.Name = "cmbInsId";
            cmbInsId.Size = new Size(308, 33);
            cmbInsId.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(409, 9);
            label6.Name = "label6";
            label6.Size = new Size(235, 38);
            label6.TabIndex = 28;
            label6.Text = "Add New Course";
            // 
            // FormAddCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 450);
            Controls.Add(label6);
            Controls.Add(cmbInsId);
            Controls.Add(cmbDeprtName);
            Controls.Add(txtDuration);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddCourse";
            Text = "FormAddCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtDuration;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cmbDeprtName;
        private TextBox txtName;
        private ComboBox cmbInsId;
        private Label label6;
    }
}