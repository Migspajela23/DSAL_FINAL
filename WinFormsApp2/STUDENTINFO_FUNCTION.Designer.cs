namespace WinFormsApp2
{
    partial class STUDENTINFO_FUNCTION
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
            browseBtn = new Button();
            picpathTxtBox = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            griddisplay = new DataGridView();
            newBtn = new Button();
            deleteBtn = new Button();
            cancelBtn = new Button();
            SearchBtn = new Button();
            editBtn = new Button();
            saveBtn = new Button();
            departmentTxtBox = new TextBox();
            studentNameTxtBox = new TextBox();
            studentNumTxtBox = new TextBox();
            Department = new Label();
            student_Name = new Label();
            student_Number = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)griddisplay).BeginInit();
            SuspendLayout();
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(355, 672);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(140, 50);
            browseBtn.TabIndex = 35;
            browseBtn.Text = "BROWSE";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // picpathTxtBox
            // 
            picpathTxtBox.Location = new Point(950, 85);
            picpathTxtBox.Name = "picpathTxtBox";
            picpathTxtBox.Size = new Size(302, 23);
            picpathTxtBox.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(164, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(590, 530);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
        
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(619, 36);
            label2.Name = "label2";
            label2.Size = new Size(254, 37);
            label2.TabIndex = 32;
            label2.Text = "Student Information";
            // 
            // griddisplay
            // 
            griddisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            griddisplay.Location = new Point(829, 250);
            griddisplay.Name = "griddisplay";
            griddisplay.Size = new Size(491, 275);
            griddisplay.TabIndex = 31;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(1180, 652);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(140, 50);
            newBtn.TabIndex = 30;
            newBtn.Text = "NEW";
            newBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(1180, 574);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(140, 50);
            deleteBtn.TabIndex = 29;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(1008, 652);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(140, 50);
            cancelBtn.TabIndex = 28;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(1008, 574);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(140, 50);
            SearchBtn.TabIndex = 27;
            SearchBtn.Text = "SEARCH";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(823, 652);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(140, 50);
            editBtn.TabIndex = 26;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(823, 574);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(140, 50);
            saveBtn.TabIndex = 25;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // departmentTxtBox
            // 
            departmentTxtBox.Location = new Point(1008, 208);
            departmentTxtBox.Name = "departmentTxtBox";
            departmentTxtBox.Size = new Size(266, 23);
            departmentTxtBox.TabIndex = 24;
            // 
            // studentNameTxtBox
            // 
            studentNameTxtBox.Location = new Point(1008, 170);
            studentNameTxtBox.Name = "studentNameTxtBox";
            studentNameTxtBox.Size = new Size(266, 23);
            studentNameTxtBox.TabIndex = 23;
            // 
            // studentNumTxtBox
            // 
            studentNumTxtBox.Location = new Point(1008, 132);
            studentNumTxtBox.Name = "studentNumTxtBox";
            studentNumTxtBox.Size = new Size(266, 23);
            studentNumTxtBox.TabIndex = 22;
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(890, 208);
            Department.Name = "Department";
            Department.Size = new Size(73, 15);
            Department.TabIndex = 21;
            Department.Text = "Department:";
            // 
            // student_Name
            // 
            student_Name.AutoSize = true;
            student_Name.Location = new Point(890, 173);
            student_Name.Name = "student_Name";
            student_Name.Size = new Size(86, 15);
            student_Name.TabIndex = 20;
            student_Name.Text = "Student Name:";
            // 
            // student_Number
            // 
            student_Number.AutoSize = true;
            student_Number.Location = new Point(890, 135);
            student_Number.Name = "student_Number";
            student_Number.Size = new Size(98, 15);
            student_Number.TabIndex = 19;
            student_Number.Text = "Student Number:";
            // 
            // STUDENTINFO_FUNCTION
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 759);
            Controls.Add(browseBtn);
            Controls.Add(picpathTxtBox);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(griddisplay);
            Controls.Add(newBtn);
            Controls.Add(deleteBtn);
            Controls.Add(cancelBtn);
            Controls.Add(SearchBtn);
            Controls.Add(editBtn);
            Controls.Add(saveBtn);
            Controls.Add(departmentTxtBox);
            Controls.Add(studentNameTxtBox);
            Controls.Add(studentNumTxtBox);
            Controls.Add(Department);
            Controls.Add(student_Name);
            Controls.Add(student_Number);
            Name = "STUDENTINFO_FUNCTION";
            Text = "STUDENTINFO_FUNCTION";
            Load += STUDENTINFO_FUNCTION_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)griddisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseBtn;
        private TextBox picpathTxtBox;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView griddisplay;
        private Button newBtn;
        private Button deleteBtn;
        private Button cancelBtn;
        private Button SearchBtn;
        private Button editBtn;
        private Button saveBtn;
        private TextBox departmentTxtBox;
        private TextBox studentNameTxtBox;
        private TextBox studentNumTxtBox;
        private Label Department;
        private Label student_Name;
        private Label student_Number;
    }
}