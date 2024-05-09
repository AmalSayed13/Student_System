namespace Student_System.Views.DepartmentForms
{
    partial class FormAddDept
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
            txtLocation = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(144, 28);
            label6.Name = "label6";
            label6.Size = new Size(306, 38);
            label6.TabIndex = 42;
            label6.Text = "Add New Department";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(210, 174);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(289, 31);
            txtLocation.TabIndex = 39;
            // 
            // txtName
            // 
            txtName.Location = new Point(210, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(289, 31);
            txtName.TabIndex = 37;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(486, 222);
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
            btnDelete.Location = new Point(474, 479);
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
            btnNew.Location = new Point(338, 222);
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
            label4.Location = new Point(96, 116);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 32;
            label4.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(74, 171);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 31;
            label3.Text = "Location :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(441, 144);
            dataGridView1.TabIndex = 43;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSeaGreen;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(300, 479);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 61);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormAddDept
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 551);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(txtLocation);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "FormAddDept";
            Text = "FormAddDept";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtLocation;
        private TextBox txtName;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnUpdate;
    }
}