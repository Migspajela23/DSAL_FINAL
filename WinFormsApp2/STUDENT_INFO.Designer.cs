namespace WinFormsApp2
{
    partial class STUDENT_INFO
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
            student_Number = new Label();
            student_Name = new Label();
            Department = new Label();
            studentNumTxtBox = new TextBox();
            studentNameTxtBox = new TextBox();
            departmentTxtBox = new TextBox();
            saveBtn = new Button();
            editBtn = new Button();
            SearchBtn = new Button();
            cancelBtn = new Button();
            deleteBtn = new Button();
            newBtn = new Button();
            griddisplay = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            picpathTxtBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)griddisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // student_Number
            // 
            student_Number.AutoSize = true;
            student_Number.Location = new Point(750, 135);
            student_Number.Name = "student_Number";
            student_Number.Size = new Size(98, 15);
            student_Number.TabIndex = 1;
            student_Number.Text = "Student Number:";
            // 
            // student_Name
            // 
            student_Name.AutoSize = true;
            student_Name.Location = new Point(750, 173);
            student_Name.Name = "student_Name";
            student_Name.Size = new Size(86, 15);
            student_Name.TabIndex = 2;
            student_Name.Text = "Student Name:";
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(750, 208);
            Department.Name = "Department";
            Department.Size = new Size(73, 15);
            Department.TabIndex = 3;
            Department.Text = "Department:";
            // 
            // studentNumTxtBox
            // 
            studentNumTxtBox.Location = new Point(868, 132);
            studentNumTxtBox.Name = "studentNumTxtBox";
            studentNumTxtBox.Size = new Size(266, 23);
            studentNumTxtBox.TabIndex = 4;
            // 
            // studentNameTxtBox
            // 
            studentNameTxtBox.Location = new Point(868, 170);
            studentNameTxtBox.Name = "studentNameTxtBox";
            studentNameTxtBox.Size = new Size(266, 23);
            studentNameTxtBox.TabIndex = 5;
            // 
            // departmentTxtBox
            // 
            departmentTxtBox.Location = new Point(868, 208);
            departmentTxtBox.Name = "departmentTxtBox";
            departmentTxtBox.Size = new Size(266, 23);
            departmentTxtBox.TabIndex = 6;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(683, 574);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(140, 50);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(683, 652);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(140, 50);
            editBtn.TabIndex = 9;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(868, 574);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(140, 50);
            SearchBtn.TabIndex = 10;
            SearchBtn.Text = "SEARCH";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(868, 652);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(140, 50);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(1040, 574);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(140, 50);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(1040, 652);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(140, 50);
            newBtn.TabIndex = 13;
            newBtn.Text = "NEW";
            newBtn.UseVisualStyleBackColor = true;
            // 
            // griddisplay
            // 
            griddisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            griddisplay.Location = new Point(689, 250);
            griddisplay.Name = "griddisplay";
            griddisplay.Size = new Size(491, 275);
            griddisplay.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(479, 36);
            label2.Name = "label2";
            label2.Size = new Size(254, 37);
            label2.TabIndex = 15;
            label2.Text = "Student Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(24, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(586, 567);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // picpathTxtBox
            // 
            picpathTxtBox.Location = new Point(810, 85);
            picpathTxtBox.Name = "picpathTxtBox";
            picpathTxtBox.Size = new Size(302, 23);
            picpathTxtBox.TabIndex = 17;
            // 
            // STUDENT_INFO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 747);
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
            Name = "STUDENT_INFO";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)griddisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label student_Number;
        private Label student_Name;
        private Label Department;
        private TextBox studentNumTxtBox;
        private TextBox studentNameTxtBox;
        private TextBox departmentTxtBox;
        private Button saveBtn;
        private Button editBtn;
        private Button SearchBtn;
        private Button cancelBtn;
        private Button deleteBtn;
        private Button newBtn;
        private DataGridView griddisplay;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox picpathTxtBox;
    }
}