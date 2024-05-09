namespace Student_System.Views
{
    partial class FormAddStudent
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(82, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(82, 105);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 1;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(77, 176);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(78, 242);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 3;
            label4.Text = "Phone :";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSeaGreen;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ForeColor = SystemColors.ButtonHighlight;
            btnNew.Location = new Point(82, 313);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 61);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(414, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(229, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 61);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(263, 41);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(239, 31);
            txtId.TabIndex = 7;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(263, 100);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(239, 31);
            txtFname.TabIndex = 8;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(263, 168);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(239, 31);
            txtLname.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(263, 237);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 31);
            txtPhone.TabIndex = 10;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 477);
            Controls.Add(txtPhone);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtPhone;
    }
}