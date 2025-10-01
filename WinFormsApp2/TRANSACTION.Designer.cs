namespace WinFormsApp2
{
    partial class TRANSACTION
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
            PrintListBox = new ListBox();
            SuspendLayout();
            // 
            // PrintListBox
            // 
            PrintListBox.FormattingEnabled = true;
            PrintListBox.ItemHeight = 15;
            PrintListBox.Location = new Point(121, 12);
            PrintListBox.Name = "PrintListBox";
            PrintListBox.Size = new Size(450, 754);
            PrintListBox.TabIndex = 0;
            // 
            // TRANSACTION
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 791);
            Controls.Add(PrintListBox);
            Name = "TRANSACTION";
            Text = "TRANSACTION";
            Load += TRANSACTION_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListBox PrintListBox;
        private ListBox listBox1;
    }
}