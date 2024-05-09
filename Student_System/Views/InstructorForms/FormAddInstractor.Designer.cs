namespace Student_System.Views.InstructorForms
{
    partial class FormAddInstractor
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
            label1 = new Label();
            cmbDeprtName = new ComboBox();
            txtHeaded = new TextBox();
            label5 = new Label();
            txtFName = new TextBox();
            txtId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtLname = new TextBox();
            label8 = new Label();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(388, 25);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 0;
            label1.Text = "Add New Instructor";
            // 
            // cmbDeprtName
            // 
            cmbDeprtName.FormattingEnabled = true;
            cmbDeprtName.Location = new Point(759, 223);
            cmbDeprtName.Name = "cmbDeprtName";
            cmbDeprtName.Size = new Size(239, 33);
            cmbDeprtName.TabIndex = 39;
            // 
            // txtHeaded
            // 
            txtHeaded.Location = new Point(709, 159);
            txtHeaded.Name = "txtHeaded";
            txtHeaded.Size = new Size(289, 31);
            txtHeaded.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(520, 96);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 37;
            label5.Text = "Phone :";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(189, 159);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(289, 31);
            txtFName.TabIndex = 36;
            // 
            // txtId
            // 
            txtId.Location = new Point(189, 99);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(289, 31);
            txtId.TabIndex = 35;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(577, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 61);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(861, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSeaGreen;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(383, 361);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 61);
            btnNew.TabIndex = 32;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(25, 155);
            label4.Name = "label4";
            label4.Size = new Size(151, 32);
            label4.TabIndex = 31;
            label4.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(513, 159);
            label3.Name = "label3";
            label3.Size = new Size(150, 32);
            label3.TabIndex = 30;
            label3.Text = "Headed By :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(513, 224);
            label2.Name = "label2";
            label2.Size = new Size(240, 32);
            label2.TabIndex = 29;
            label2.Text = "Department Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(-79, 35);
            label6.Name = "label6";
            label6.Size = new Size(54, 32);
            label6.TabIndex = 28;
            label6.Text = "ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(32, 99);
            label7.Name = "label7";
            label7.Size = new Size(54, 32);
            label7.TabIndex = 41;
            label7.Text = "ID :";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(189, 223);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(289, 31);
            txtLname.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(25, 219);
            label8.Name = "label8";
            label8.Size = new Size(147, 32);
            label8.TabIndex = 42;
            label8.Text = "Last Name :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(709, 102);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(289, 31);
            txtPhone.TabIndex = 44;
            // 
            // FormAddInstractor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 501);
            Controls.Add(txtPhone);
            Controls.Add(txtLname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbDeprtName);
            Controls.Add(txtHeaded);
            Controls.Add(label5);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "FormAddInstractor";
            Text = "FormAddInstractor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDeprtName;
        private TextBox txtHeaded;
        private Label label5;
        private TextBox txtFName;
        private TextBox txtId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox txtLname;
        private Label label8;
        private TextBox txtPhone;
    }
}