namespace Student_System.Views.CourseForm
{
    partial class FormViewCourse
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
            button1 = new Button();
            btnSearch = new Button();
            txtName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CmbInstName = new ComboBox();
            cmbDeptName = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(439, 586);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 31;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumAquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(821, 261);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 62);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 194);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 31);
            txtName.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.Location = new Point(134, 135);
            txtId.Name = "txtId";
            txtId.Size = new Size(239, 31);
            txtId.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(455, 196);
            label4.Name = "label4";
            label4.Size = new Size(240, 32);
            label4.TabIndex = 25;
            label4.Text = "Department Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(454, 130);
            label3.Name = "label3";
            label3.Size = new Size(214, 32);
            label3.TabIndex = 24;
            label3.Text = "Instractor Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(17, 199);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 23;
            label2.Text = " Name :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(28, 132);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 22;
            label1.Text = "ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1011, 204);
            dataGridView1.TabIndex = 21;
            // 
            // CmbInstName
            // 
            CmbInstName.FormattingEnabled = true;
            CmbInstName.Location = new Point(721, 133);
            CmbInstName.Name = "CmbInstName";
            CmbInstName.Size = new Size(252, 33);
            CmbInstName.TabIndex = 32;
            // 
            // cmbDeptName
            // 
            cmbDeptName.FormattingEnabled = true;
            cmbDeptName.Location = new Point(721, 200);
            cmbDeptName.Name = "cmbDeptName";
            cmbDeptName.Size = new Size(252, 33);
            cmbDeptName.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(439, 30);
            label5.Name = "label5";
            label5.Size = new Size(198, 38);
            label5.TabIndex = 34;
            label5.Text = "Show Courses";
            // 
            // FormViewCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 660);
            Controls.Add(label5);
            Controls.Add(cmbDeptName);
            Controls.Add(CmbInstName);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormViewCourse";
            Text = "FormViewCourse";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnSearch;
        private TextBox txtName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox CmbInstName;
        private ComboBox cmbDeptName;
        private Label label5;
    }
}