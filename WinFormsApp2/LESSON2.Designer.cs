namespace WinFormsApp2
{
    partial class LESSON2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            discountTxtbox = new Label();
            priceTxtbox = new Label();
            foodBrdbtn = new RadioButton();
            foodArdtn = new RadioButton();
            B_MediumPizzacheckBox = new CheckBox();
            B_FriescheckBox = new CheckBox();
            B_CarbonaracheckBox = new CheckBox();
            B_ChickencheckBox = new CheckBox();
            B_halohalocheckBox = new CheckBox();
            A_SpecialPizzacheckBox = new CheckBox();
            A_SidedishescheckBox = new CheckBox();
            A_CokecheckBox = new CheckBox();
            A_FriescheckBox = new CheckBox();
            A_ChickencheckBox = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            DisplayPictureBox = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(discountTxtbox);
            groupBox1.Controls.Add(priceTxtbox);
            groupBox1.Controls.Add(foodBrdbtn);
            groupBox1.Controls.Add(foodArdtn);
            groupBox1.Controls.Add(B_MediumPizzacheckBox);
            groupBox1.Controls.Add(B_FriescheckBox);
            groupBox1.Controls.Add(B_CarbonaracheckBox);
            groupBox1.Controls.Add(B_ChickencheckBox);
            groupBox1.Controls.Add(B_halohalocheckBox);
            groupBox1.Controls.Add(A_SpecialPizzacheckBox);
            groupBox1.Controls.Add(A_SidedishescheckBox);
            groupBox1.Controls.Add(A_CokecheckBox);
            groupBox1.Controls.Add(A_FriescheckBox);
            groupBox1.Controls.Add(A_ChickencheckBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(DisplayPictureBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 692);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // discountTxtbox
            // 
            discountTxtbox.AutoSize = true;
            discountTxtbox.Location = new Point(23, 263);
            discountTxtbox.Name = "discountTxtbox";
            discountTxtbox.Size = new Size(54, 15);
            discountTxtbox.TabIndex = 50;
            discountTxtbox.Text = "Discount";
            // 
            // priceTxtbox
            // 
            priceTxtbox.AutoSize = true;
            priceTxtbox.Location = new Point(23, 224);
            priceTxtbox.Name = "priceTxtbox";
            priceTxtbox.Size = new Size(33, 15);
            priceTxtbox.TabIndex = 1;
            priceTxtbox.Text = "Price";
            // 
            // foodBrdbtn
            // 
            foodBrdbtn.AccessibleDescription = "";
            foodBrdbtn.AccessibleName = "foodBrdbtn";
            foodBrdbtn.AutoSize = true;
            foodBrdbtn.Location = new Point(51, 139);
            foodBrdbtn.Name = "foodBrdbtn";
            foodBrdbtn.Size = new Size(102, 19);
            foodBrdbtn.TabIndex = 49;
            foodBrdbtn.TabStop = true;
            foodBrdbtn.Text = "Food Bundle B";
            foodBrdbtn.UseVisualStyleBackColor = true;
            foodBrdbtn.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // foodArdtn
            // 
            foodArdtn.AutoSize = true;
            foodArdtn.Location = new Point(51, 114);
            foodArdtn.Name = "foodArdtn";
            foodArdtn.Size = new Size(106, 19);
            foodArdtn.TabIndex = 48;
            foodArdtn.TabStop = true;
            foodArdtn.Text = "Food  Bundle A";
            foodArdtn.UseVisualStyleBackColor = true;
            foodArdtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // B_MediumPizzacheckBox
            // 
            B_MediumPizzacheckBox.AutoSize = true;
            B_MediumPizzacheckBox.FlatStyle = FlatStyle.Popup;
            B_MediumPizzacheckBox.Location = new Point(427, 529);
            B_MediumPizzacheckBox.Name = "B_MediumPizzacheckBox";
            B_MediumPizzacheckBox.Size = new Size(107, 19);
            B_MediumPizzacheckBox.TabIndex = 47;
            B_MediumPizzacheckBox.Text = "1 Medium Pizza";
            B_MediumPizzacheckBox.UseVisualStyleBackColor = true;
            // 
            // B_FriescheckBox
            // 
            B_FriescheckBox.AutoSize = true;
            B_FriescheckBox.FlatStyle = FlatStyle.Popup;
            B_FriescheckBox.Location = new Point(427, 492);
            B_FriescheckBox.Name = "B_FriescheckBox";
            B_FriescheckBox.Size = new Size(95, 19);
            B_FriescheckBox.TabIndex = 46;
            B_FriescheckBox.Text = "1 Family Fries";
            B_FriescheckBox.UseVisualStyleBackColor = true;
            // 
            // B_CarbonaracheckBox
            // 
            B_CarbonaracheckBox.AutoSize = true;
            B_CarbonaracheckBox.FlatStyle = FlatStyle.Popup;
            B_CarbonaracheckBox.Location = new Point(427, 456);
            B_CarbonaracheckBox.Name = "B_CarbonaracheckBox";
            B_CarbonaracheckBox.Size = new Size(126, 19);
            B_CarbonaracheckBox.TabIndex = 45;
            B_CarbonaracheckBox.Text = "1 Family Carbonara";
            B_CarbonaracheckBox.UseVisualStyleBackColor = true;
            // 
            // B_ChickencheckBox
            // 
            B_ChickencheckBox.AutoSize = true;
            B_ChickencheckBox.FlatStyle = FlatStyle.Popup;
            B_ChickencheckBox.Location = new Point(427, 420);
            B_ChickencheckBox.Name = "B_ChickencheckBox";
            B_ChickencheckBox.Size = new Size(97, 19);
            B_ChickencheckBox.TabIndex = 44;
            B_ChickencheckBox.Text = "6 pcs Chicken";
            B_ChickencheckBox.UseVisualStyleBackColor = true;
            // 
            // B_halohalocheckBox
            // 
            B_halohalocheckBox.AutoSize = true;
            B_halohalocheckBox.FlatStyle = FlatStyle.Popup;
            B_halohalocheckBox.Location = new Point(427, 382);
            B_halohalocheckBox.Name = "B_halohalocheckBox";
            B_halohalocheckBox.Size = new Size(112, 19);
            B_halohalocheckBox.TabIndex = 43;
            B_halohalocheckBox.Text = "4 Cups halo halo";
            B_halohalocheckBox.UseVisualStyleBackColor = true;
            // 
            // A_SpecialPizzacheckBox
            // 
            A_SpecialPizzacheckBox.AutoSize = true;
            A_SpecialPizzacheckBox.FlatStyle = FlatStyle.Popup;
            A_SpecialPizzacheckBox.Location = new Point(427, 261);
            A_SpecialPizzacheckBox.Name = "A_SpecialPizzacheckBox";
            A_SpecialPizzacheckBox.Size = new Size(90, 19);
            A_SpecialPizzacheckBox.TabIndex = 42;
            A_SpecialPizzacheckBox.Text = "Special Pizza";
            A_SpecialPizzacheckBox.UseVisualStyleBackColor = true;
            // 
            // A_SidedishescheckBox
            // 
            A_SidedishescheckBox.AutoSize = true;
            A_SidedishescheckBox.FlatStyle = FlatStyle.Popup;
            A_SidedishescheckBox.Location = new Point(427, 224);
            A_SidedishescheckBox.Name = "A_SidedishescheckBox";
            A_SidedishescheckBox.Size = new Size(91, 19);
            A_SidedishescheckBox.TabIndex = 41;
            A_SidedishescheckBox.Text = "4 Side dishes";
            A_SidedishescheckBox.UseVisualStyleBackColor = true;
            // 
            // A_CokecheckBox
            // 
            A_CokecheckBox.AutoSize = true;
            A_CokecheckBox.FlatStyle = FlatStyle.Popup;
            A_CokecheckBox.Location = new Point(427, 188);
            A_CokecheckBox.Name = "A_CokecheckBox";
            A_CokecheckBox.Size = new Size(69, 19);
            A_CokecheckBox.TabIndex = 40;
            A_CokecheckBox.Text = "1.5 Coke";
            A_CokecheckBox.UseVisualStyleBackColor = true;
            // 
            // A_FriescheckBox
            // 
            A_FriescheckBox.AutoSize = true;
            A_FriescheckBox.FlatStyle = FlatStyle.Popup;
            A_FriescheckBox.Location = new Point(427, 152);
            A_FriescheckBox.Name = "A_FriescheckBox";
            A_FriescheckBox.Size = new Size(89, 19);
            A_FriescheckBox.TabIndex = 39;
            A_FriescheckBox.Text = "2 Large Fries";
            A_FriescheckBox.UseVisualStyleBackColor = true;
            // 
            // A_ChickencheckBox
            // 
            A_ChickencheckBox.AutoSize = true;
            A_ChickencheckBox.FlatStyle = FlatStyle.Popup;
            A_ChickencheckBox.Location = new Point(427, 114);
            A_ChickencheckBox.Name = "A_ChickencheckBox";
            A_ChickencheckBox.Size = new Size(103, 19);
            A_ChickencheckBox.TabIndex = 38;
            A_ChickencheckBox.Text = "10 pcs Chicken";
            A_ChickencheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 350);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 37;
            label7.Text = "Food Bundles B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 559);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 36;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Location = new Point(15, 551);
            button3.Name = "button3";
            button3.Size = new Size(143, 53);
            button3.TabIndex = 35;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(194, 551);
            button2.Name = "button2";
            button2.Size = new Size(143, 53);
            button2.TabIndex = 34;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(33, 587);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 33;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 31;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BorderStyle = BorderStyle.Fixed3D;
            DisplayPictureBox.Location = new Point(94, 301);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(215, 197);
            DisplayPictureBox.TabIndex = 30;
            DisplayPictureBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 401);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 29;
            label5.Text = "Order Image";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 192);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 28;
            label4.Text = "Order Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 86);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 27;
            label3.Text = "Food Bundles A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 86);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 26;
            label2.Text = "Food Order Choices";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 15);
            label1.Name = "label1";
            label1.Size = new Size(576, 50);
            label1.TabIndex = 25;
            label1.Text = "4JEE Food Ordering Application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 719);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private GroupBox groupBox1;
        private RadioButton foodBrdbtn;
        private RadioButton foodArdtn;
        private CheckBox B_MediumPizzacheckBox;
        private CheckBox B_FriescheckBox;
        private CheckBox B_CarbonaracheckBox;
        private CheckBox B_ChickencheckBox;
        private CheckBox B_halohalocheckBox;
        private CheckBox A_SpecialPizzacheckBox;
        private CheckBox A_SidedishescheckBox;
        private CheckBox A_CokecheckBox;
        private CheckBox A_FriescheckBox;
        private CheckBox A_ChickencheckBox;
        private Label label7;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox DisplayPictureBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label discountTxtbox;
        private Label priceTxtbox;
    }
}
