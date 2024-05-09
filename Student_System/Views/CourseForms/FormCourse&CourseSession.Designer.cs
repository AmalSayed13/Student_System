namespace Student_System.Views.CourseForms
{
    partial class FormCourse_CourseSession
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
            dataGridView1 = new DataGridView();
            CmbInstName = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            btnDelete = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(775, 379);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 34;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumAquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(718, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 43);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1011, 204);
            dataGridView1.TabIndex = 32;
            // 
            // CmbInstName
            // 
            CmbInstName.FormattingEnabled = true;
            CmbInstName.Location = new Point(451, 25);
            CmbInstName.Name = "CmbInstName";
            CmbInstName.Size = new Size(252, 33);
            CmbInstName.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(184, 22);
            label3.Name = "label3";
            label3.Size = new Size(214, 32);
            label3.TabIndex = 35;
            label3.Text = "Instractor Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(402, 105);
            label5.Name = "label5";
            label5.Size = new Size(198, 38);
            label5.TabIndex = 37;
            label5.Text = "Show Courses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(335, 460);
            label1.Name = "label1";
            label1.Size = new Size(311, 38);
            label1.TabIndex = 40;
            label1.Text = "Show Courses sessions";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Location = new Point(775, 721);
            button2.Name = "button2";
            button2.Size = new Size(112, 62);
            button2.TabIndex = 39;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MediumAquamarine;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 511);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1011, 204);
            dataGridView2.TabIndex = 38;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(893, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 61);
            btnDelete.TabIndex = 50;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(893, 722);
            button3.Name = "button3";
            button3.Size = new Size(112, 61);
            button3.TabIndex = 51;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormCourse_CourseSession
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 822);
            Controls.Add(button3);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(CmbInstName);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "FormCourse_CourseSession";
            Text = "FormCourse_CourseSession";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private ComboBox CmbInstName;
        private Label label3;
        private Label label5;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView2;
        private Button btnDelete;
        private Button button3;
    }
}