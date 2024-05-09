namespace Student_System.Views.InstructorForms
{
    partial class FormViewAll
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
            label5 = new Label();
            button1 = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(392, 29);
            label5.Name = "label5";
            label5.Size = new Size(238, 38);
            label5.TabIndex = 51;
            label5.Text = "Show Instructors";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(447, 502);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 49;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumAquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(428, 184);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 62);
            btnSearch.TabIndex = 48;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(980, 204);
            dataGridView1.TabIndex = 46;
            // 
            // txtName
            // 
            txtName.Location = new Point(660, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 31);
            txtName.TabIndex = 55;
            // 
            // txtId
            // 
            txtId.Location = new Point(154, 126);
            txtId.Name = "txtId";
            txtId.Size = new Size(303, 31);
            txtId.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(543, 120);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 53;
            label2.Text = " Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(82, 123);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 52;
            label1.Text = "ID :";
            // 
            // FormViewAll
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 590);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "FormViewAll";
            Text = "FormViewAll";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button1;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtId;
        private Label label2;
        private Label label1;
    }
}