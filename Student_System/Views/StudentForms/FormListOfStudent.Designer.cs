namespace Student_System.Views.Student
{
    partial class FormListOfStudent
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
            dataGridView1 = new DataGridView();
            txtPhone = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumAquamarine;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(931, 204);
            dataGridView1.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(644, 104);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 31);
            txtPhone.TabIndex = 18;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(644, 38);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(239, 31);
            txtLname.TabIndex = 17;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(203, 99);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(239, 31);
            txtFname.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(203, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(239, 31);
            txtId.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(469, 101);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 14;
            label4.Text = "Phone :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(468, 35);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 13;
            label3.Text = "Last Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 12;
            label2.Text = "First Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 11;
            label1.Text = "ID :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumAquamarine;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(759, 150);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 62);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(406, 446);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 20;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormListOfStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 520);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(txtPhone);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormListOfStudent";
            Text = "ListOfStudent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtPhone;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private Button button1;
    }
}