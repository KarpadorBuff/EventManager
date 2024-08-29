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
            Createbutton = new Button();
            EmailText = new TextBox();
            NameText = new TextBox();
            CreateListBox = new ListBox();
            label1 = new Label();
            panelDELETE = new Panel();
            deletebutton = new Button();
            DeleteListbox = new ListBox();
            DeleteText = new TextBox();
            label2 = new Label();
            panelCHANGE = new Panel();
            changeButton = new Button();
            label3 = new Label();
            EmailChangeText = new TextBox();
            changeTextbox = new ListBox();
            NameChangeText = new TextBox();
            panelREAD.SuspendLayout();
            panelCREATE.SuspendLayout();
            panelDELETE.SuspendLayout();
            panelCHANGE.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            peopleFoundListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            lastNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            // panelREAD
            // 
            panelREAD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelREAD.BackColor = SystemColors.ControlDark;
            panelREAD.Controls.Add(labelREAD);
            panelREAD.Controls.Add(searchButton);
            panelREAD.Controls.Add(lastNameText);
            panelREAD.Controls.Add(peopleFoundListBox);
            panelREAD.Location = new Point(12, 41);
            panelREAD.Name = "panelREAD";
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
            panelCREATE.BackColor = SystemColors.ControlDark;
            panelCREATE.Controls.Add(Createbutton);
            panelCREATE.Controls.Add(EmailText);
            panelCREATE.Controls.Add(NameText);
            panelCREATE.Controls.Add(CreateListBox);
            panelCREATE.Controls.Add(label1);
            panelCREATE.Location = new Point(12, 41);
            panelCREATE.Name = "panelCREATE";
            panelCREATE.Size = new Size(538, 334);
            panelCREATE.TabIndex = 5;
            panelCREATE.Visible = false;
            // 
            // Createbutton
            // 
            Createbutton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Createbutton.BackColor = SystemColors.ControlDarkDark;
            Createbutton.FlatStyle = FlatStyle.Flat;
            Createbutton.Location = new Point(441, 36);
            Createbutton.Name = "Createbutton";
            Createbutton.Size = new Size(91, 23);
            Createbutton.TabIndex = 4;
            Createbutton.Text = "button1";
            Createbutton.UseVisualStyleBackColor = false;
            // 
            // EmailText
            // 
            EmailText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailText.BackColor = SystemColors.ControlDarkDark;
            EmailText.BorderStyle = BorderStyle.None;
            EmailText.Location = new Point(3, 58);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(432, 16);
            EmailText.TabIndex = 8;
            // 
            // NameText
            // 
            NameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameText.BackColor = SystemColors.ControlDarkDark;
            NameText.BorderStyle = BorderStyle.None;
            NameText.Location = new Point(3, 36);
            NameText.Name = "NameText";
            NameText.Size = new Size(432, 16);
            NameText.TabIndex = 4;
            // 
            // CreateListBox
            // 
            CreateListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateListBox.BackColor = SystemColors.ControlDarkDark;
            CreateListBox.BorderStyle = BorderStyle.FixedSingle;
            CreateListBox.FormattingEnabled = true;
            CreateListBox.ItemHeight = 15;
            CreateListBox.Location = new Point(3, 80);
            CreateListBox.Name = "CreateListBox";
            CreateListBox.Size = new Size(529, 242);
            CreateListBox.TabIndex = 7;
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
            panelDELETE.BackColor = SystemColors.ControlDark;
            panelDELETE.Controls.Add(deletebutton);
            panelDELETE.Controls.Add(DeleteListbox);
            panelDELETE.Controls.Add(DeleteText);
            panelDELETE.Controls.Add(label2);
            panelDELETE.Location = new Point(12, 41);
            panelDELETE.Name = "panelDELETE";
            panelDELETE.Size = new Size(538, 334);
            panelDELETE.TabIndex = 6;
            panelDELETE.Visible = false;
            // 
            // deletebutton
            // 
            deletebutton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deletebutton.BackColor = SystemColors.ControlDarkDark;
            deletebutton.FlatStyle = FlatStyle.Flat;
            deletebutton.Location = new Point(441, 32);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(91, 23);
            deletebutton.TabIndex = 10;
            deletebutton.Text = "button1";
            deletebutton.UseVisualStyleBackColor = false;
            // 
            // DeleteListbox
            // 
            DeleteListbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteListbox.BackColor = SystemColors.ControlDarkDark;
            DeleteListbox.BorderStyle = BorderStyle.FixedSingle;
            DeleteListbox.FormattingEnabled = true;
            DeleteListbox.ItemHeight = 15;
            DeleteListbox.Location = new Point(3, 58);
            DeleteListbox.Name = "DeleteListbox";
            DeleteListbox.Size = new Size(529, 257);
            DeleteListbox.TabIndex = 8;
            // 
            // DeleteText
            // 
            DeleteText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeleteText.BackColor = SystemColors.ControlDarkDark;
            DeleteText.BorderStyle = BorderStyle.None;
            DeleteText.Location = new Point(3, 36);
            DeleteText.Name = "DeleteText";
            DeleteText.Size = new Size(432, 16);
            DeleteText.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "DELETE";
            // 
            // panelCHANGE
            // 
            panelCHANGE.AutoSize = true;
            panelCHANGE.BackColor = SystemColors.ControlDark;
            panelCHANGE.Controls.Add(changeButton);
            panelCHANGE.Controls.Add(label3);
            panelCHANGE.Controls.Add(EmailChangeText);
            panelCHANGE.Controls.Add(changeTextbox);
            panelCHANGE.Controls.Add(NameChangeText);
            panelCHANGE.Location = new Point(12, 41);
            panelCHANGE.Name = "panelCHANGE";
            panelCHANGE.Size = new Size(538, 334);
            panelCHANGE.TabIndex = 6;
            panelCHANGE.Visible = false;
            // 
            // changeButton
            // 
            changeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            changeButton.BackColor = SystemColors.ControlDarkDark;
            changeButton.FlatStyle = FlatStyle.Flat;
            changeButton.Location = new Point(441, 36);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(91, 23);
            changeButton.TabIndex = 9;
            changeButton.Text = "button1";
            changeButton.UseVisualStyleBackColor = false;
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
            // EmailChangeText
            // 
            EmailChangeText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailChangeText.BackColor = SystemColors.ControlDarkDark;
            EmailChangeText.BorderStyle = BorderStyle.None;
            EmailChangeText.Location = new Point(3, 58);
            EmailChangeText.Name = "EmailChangeText";
            EmailChangeText.Size = new Size(432, 16);
            EmailChangeText.TabIndex = 13;
            // 
            // changeTextbox
            // 
            changeTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            changeTextbox.BackColor = SystemColors.ControlDarkDark;
            changeTextbox.BorderStyle = BorderStyle.FixedSingle;
            changeTextbox.FormattingEnabled = true;
            changeTextbox.ItemHeight = 15;
            changeTextbox.Location = new Point(3, 80);
            changeTextbox.Name = "changeTextbox";
            changeTextbox.Size = new Size(529, 227);
            changeTextbox.TabIndex = 12;
            // 
            // NameChangeText
            // 
            NameChangeText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameChangeText.BackColor = SystemColors.ControlDarkDark;
            NameChangeText.BorderStyle = BorderStyle.None;
            NameChangeText.Location = new Point(3, 36);
            NameChangeText.Name = "NameChangeText";
            NameChangeText.Size = new Size(432, 16);
            NameChangeText.TabIndex = 10;
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
            PerformLayout();
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
        private TextBox NameText;
        private ListBox CreateListBox;
        private Button Createbutton;
        private TextBox EmailText;
        private ListBox DeleteListbox;
        private TextBox DeleteText;
        private Button changeButton;
        private TextBox EmailChangeText;
        private ListBox changeTextbox;
        private TextBox NameChangeText;
        private Button deletebutton;
    }
}
