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
            panelREAD = new Panel();
            labelREAD = new Label();
            panelCREATE = new Panel();
            label1 = new Label();
            panelDELETE = new Panel();
            label2 = new Label();
            panelCHANGE = new Panel();
            label3 = new Label();
            panelREAD.SuspendLayout();
            panelCREATE.SuspendLayout();
            panelDELETE.SuspendLayout();
            panelCHANGE.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.ControlDarkDark;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Location = new Point(441, 36);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(91, 23);
            searchButton.TabIndex = 0;
            searchButton.Text = "button1";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // peopleFoundListBox
            // 
            peopleFoundListBox.BackColor = SystemColors.ControlDarkDark;
            peopleFoundListBox.BorderStyle = BorderStyle.FixedSingle;
            peopleFoundListBox.FormattingEnabled = true;
            peopleFoundListBox.ItemHeight = 15;
            peopleFoundListBox.Location = new Point(3, 65);
            peopleFoundListBox.Name = "peopleFoundListBox";
            peopleFoundListBox.Size = new Size(529, 257);
            peopleFoundListBox.TabIndex = 1;
            // 
            // lastNameText
            // 
            lastNameText.BackColor = SystemColors.ControlDarkDark;
            lastNameText.BorderStyle = BorderStyle.None;
            lastNameText.Location = new Point(3, 36);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(432, 16);
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
            panelREAD.BackColor = SystemColors.ControlDark;
            panelREAD.Controls.Add(labelREAD);
            panelREAD.Controls.Add(peopleFoundListBox);
            panelREAD.Controls.Add(searchButton);
            panelREAD.Controls.Add(lastNameText);
            panelREAD.Location = new Point(12, 41);
            panelREAD.Name = "panelRead";
            panelREAD.Size = new Size(538, 334);
            panelREAD.TabIndex = 4;
            panelREAD.Visible = false;
            // 
            // labelREAD
            // 
            labelREAD.AutoSize = true;
            labelREAD.Location = new Point(3, 0);
            labelREAD.Name = "labelREAD";
            labelREAD.Size = new Size(36, 15);
            labelREAD.TabIndex = 3;
            labelREAD.Text = "READ";
            // 
            // panelCREATE
            // 
            panelCREATE.Controls.Add(label1);
            panelCREATE.Location = new Point(537, 547);
            panelCREATE.Name = "panelCREATE";
            panelCREATE.Size = new Size(200, 100);
            panelCREATE.TabIndex = 5;
            panelCREATE.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "CREATE";
            // 
            // panelDELETE
            // 
            panelDELETE.Controls.Add(label2);
            panelDELETE.Location = new Point(743, 547);
            panelDELETE.Name = "panelDELETE";
            panelDELETE.Size = new Size(200, 100);
            panelDELETE.TabIndex = 6;
            panelDELETE.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 8);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "DELETE";
            // 
            // panelCHANGE
            // 
            panelCHANGE.Controls.Add(label3);
            panelCHANGE.Location = new Point(949, 547);
            panelCHANGE.Name = "panelCHANGE";
            panelCHANGE.Size = new Size(200, 100);
            panelCHANGE.TabIndex = 6;
            panelCHANGE.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "CHANGE";
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 659);
            Controls.Add(panelCHANGE);
            Controls.Add(panelDELETE);
            Controls.Add(panelCREATE);
            Controls.Add(panelREAD);
            Controls.Add(dropDown);
            Name = "GUI";
            Text = "Form1";
            Load += Form1_Load;
            panelREAD.ResumeLayout(false);
            panelREAD.PerformLayout();
            panelCREATE.ResumeLayout(false);
            panelCREATE.PerformLayout();
            panelDELETE.ResumeLayout(false);
            panelDELETE.PerformLayout();
            panelCHANGE.ResumeLayout(false);
            panelCHANGE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button searchButton;
        private ListBox peopleFoundListBox;
        private TextBox lastNameText;
        private Panel panelREAD;
        public ComboBox dropDown;
        private Label labelREAD;
        private Panel panelCREATE;
        private Label label1;
        private Panel panelDELETE;
        private Label label2;
        private Panel panelCHANGE;
        private Label label3;
    }
}
