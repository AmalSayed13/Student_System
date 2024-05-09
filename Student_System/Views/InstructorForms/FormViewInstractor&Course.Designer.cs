namespace Student_System.Views.InstructorForms
{
    partial class FormViewInstractor
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
            cmbDeptName = new ComboBox();
            button1 = new Button();
            btnSearch = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            btnDelete = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // cmbDeptName
            // 
            cmbDeptName.FormattingEnabled = true;
            cmbDeptName.Location = new Point(364, 35);
            cmbDeptName.Name = "cmbDeptName";
            cmbDeptName.Size = new Size(436, 33);
            cmbDeptName.TabIndex = 44;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(799, 376);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 42;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumAquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(817, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 48);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(98, 31);
            label4.Name = "label4";
            label4.Size = new Size(240, 32);
            label4.TabIndex = 38;
            label4.Text = "Department Name :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1028, 204);
            dataGridView1.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(421, 99);
            label5.Name = "label5";
            label5.Size = new Size(238, 38);
            label5.TabIndex = 45;
            label5.Text = "Show Instructors";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Location = new Point(799, 711);
            button2.Name = "button2";
            button2.Size = new Size(112, 62);
            button2.TabIndex = 47;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MediumAquamarine;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 501);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1011, 204);
            dataGridView2.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(421, 437);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 48;
            label1.Text = "Show Courses";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(917, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 49;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(917, 712);
            button3.Name = "button3";
            button3.Size = new Size(112, 61);
            button3.TabIndex = 50;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormViewInstractor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 785);
            Controls.Add(button3);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(cmbDeptName);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "FormViewInstractor";
            Text = "FormViewInstructor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDeptName;
        private Button button1;
        private Button btnSearch;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Button button2;
        private DataGridView dataGridView2;
        private Label label1;
        private Button btnDelete;
        private Button button3;
    }
}