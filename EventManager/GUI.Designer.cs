namespace EventManager
{
    partial class GUI
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
            searchButton = new Button();
            peopleFoundListBox = new ListBox();
            lastNameText = new TextBox();
            dropDown = new ComboBox();
            panelRead = new Panel();
            panelRead.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new Point(452, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(91, 23);
            searchButton.TabIndex = 0;
            searchButton.Text = "button1";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // peopleFoundListBox
            // 
            peopleFoundListBox.FormattingEnabled = true;
            peopleFoundListBox.ItemHeight = 15;
            peopleFoundListBox.Location = new Point(14, 34);
            peopleFoundListBox.Name = "peopleFoundListBox";
            peopleFoundListBox.Size = new Size(529, 259);
            peopleFoundListBox.TabIndex = 1;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(14, 6);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(432, 23);
            lastNameText.TabIndex = 2;
            // 
            // dropDown
            // 
            dropDown.FormattingEnabled = true;
            dropDown.Location = new Point(12, 12);
            dropDown.Name = "dropDown";
            dropDown.Size = new Size(121, 23);
            dropDown.TabIndex = 3;
            dropDown.SelectedIndexChanged += dropDown_SelectedIndexChanged;
            // 
            // panelRead
            // 
            panelRead.Controls.Add(peopleFoundListBox);
            panelRead.Controls.Add(searchButton);
            panelRead.Controls.Add(lastNameText);
            panelRead.Location = new Point(12, 41);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(1141, 312);
            panelRead.TabIndex = 4;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 659);
            Controls.Add(panelRead);
            Controls.Add(dropDown);
            Name = "GUI";
            Text = "Form1";
            Load += Form1_Load;
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button searchButton;
        private ListBox peopleFoundListBox;
        private TextBox lastNameText;
        private Panel panelRead;
        public static ComboBox dropDown;
    }
}
