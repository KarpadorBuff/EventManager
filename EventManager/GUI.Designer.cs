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
            buttonSEARCH = new Button();
            listBoxREAD = new ListBox();
            tbREADusername = new TextBox();
            dropDown = new ComboBox();
            panelREAD = new Panel();
            buttonREADallUsers = new Button();
            label6 = new Label();
            tbREADid = new TextBox();
            label5 = new Label();
            tbREADemail = new TextBox();
            label4 = new Label();
            buttonToggleTable = new Button();
            panelCREATE = new Panel();
            buttonCREATE = new Button();
            tbEmailCREATE = new TextBox();
            tbuUsernameCREATE = new TextBox();
            listBoxCREATE = new ListBox();
            label1 = new Label();
            panelDELETE = new Panel();
            DELETElabelCurrentMode = new Label();
            buttonDeleteToggleEVENTUSER = new Button();
            buttonDELETE = new Button();
            listBoxDELETE = new ListBox();
            label2 = new Label();
            panelCHANGE = new Panel();
            buttonCHANGE = new Button();
            label3 = new Label();
            EmailChangeText = new TextBox();
            listBoxCHANGE = new ListBox();
            NameChangeText = new TextBox();
            panelREAD.SuspendLayout();
            panelCREATE.SuspendLayout();
            panelDELETE.SuspendLayout();
            panelCHANGE.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSEARCH
            // 
            buttonSEARCH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSEARCH.BackColor = SystemColors.ControlDarkDark;
            buttonSEARCH.FlatStyle = FlatStyle.Flat;
            buttonSEARCH.Location = new Point(405, 8);
            buttonSEARCH.Name = "buttonSEARCH";
            buttonSEARCH.Size = new Size(91, 51);
            buttonSEARCH.TabIndex = 0;
            buttonSEARCH.Text = "Search";
            buttonSEARCH.UseVisualStyleBackColor = false;
            buttonSEARCH.Click += ButtonREAD_Clicked;
            // 
            // listBoxREAD
            // 
            listBoxREAD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxREAD.BackColor = SystemColors.ControlDarkDark;
            listBoxREAD.BorderStyle = BorderStyle.FixedSingle;
            listBoxREAD.FormattingEnabled = true;
            listBoxREAD.ItemHeight = 15;
            listBoxREAD.Location = new Point(6, 105);
            listBoxREAD.Name = "listBoxREAD";
            listBoxREAD.Size = new Size(490, 467);
            listBoxREAD.TabIndex = 1;
            // 
            // tbREADusername
            // 
            tbREADusername.BackColor = SystemColors.Control;
            tbREADusername.BorderStyle = BorderStyle.None;
            tbREADusername.Location = new Point(222, 8);
            tbREADusername.Name = "tbREADusername";
            tbREADusername.Size = new Size(177, 16);
            tbREADusername.TabIndex = 2;
            tbREADusername.TextChanged += tbREADusername_TextChanged;
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
            panelREAD.Controls.Add(buttonREADallUsers);
            panelREAD.Controls.Add(label6);
            panelREAD.Controls.Add(tbREADid);
            panelREAD.Controls.Add(label5);
            panelREAD.Controls.Add(tbREADemail);
            panelREAD.Controls.Add(label4);
            panelREAD.Controls.Add(buttonToggleTable);
            panelREAD.Controls.Add(buttonSEARCH);
            panelREAD.Controls.Add(tbREADusername);
            panelREAD.Controls.Add(listBoxREAD);
            panelREAD.Location = new Point(12, 41);
            panelREAD.Name = "panelREAD";
            panelREAD.Size = new Size(502, 577);
            panelREAD.TabIndex = 4;
            panelREAD.Visible = false;
            // 
            // buttonREADallUsers
            // 
            buttonREADallUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonREADallUsers.BackColor = SystemColors.ControlDarkDark;
            buttonREADallUsers.FlatStyle = FlatStyle.Flat;
            buttonREADallUsers.Location = new Point(362, 65);
            buttonREADallUsers.Name = "buttonREADallUsers";
            buttonREADallUsers.Size = new Size(134, 34);
            buttonREADallUsers.TabIndex = 10;
            buttonREADallUsers.Text = "Show all Users";
            buttonREADallUsers.UseVisualStyleBackColor = false;
            buttonREADallUsers.Click += buttonREADallUsers_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 44);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 9;
            label6.Text = "id";
            // 
            // tbREADid
            // 
            tbREADid.BackColor = SystemColors.Control;
            tbREADid.BorderStyle = BorderStyle.None;
            tbREADid.Location = new Point(222, 44);
            tbREADid.Name = "tbREADid";
            tbREADid.Size = new Size(177, 16);
            tbREADid.TabIndex = 8;
            tbREADid.TextChanged += tbREADid_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 26);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "email";
            // 
            // tbREADemail
            // 
            tbREADemail.BackColor = SystemColors.Control;
            tbREADemail.BorderStyle = BorderStyle.None;
            tbREADemail.Location = new Point(222, 26);
            tbREADemail.Name = "tbREADemail";
            tbREADemail.Size = new Size(177, 16);
            tbREADemail.TabIndex = 6;
            tbREADemail.TextChanged += tbREADemail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 8);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "username";
            // 
            // buttonToggleTable
            // 
            buttonToggleTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonToggleTable.BackColor = SystemColors.ControlDarkDark;
            buttonToggleTable.FlatStyle = FlatStyle.Flat;
            buttonToggleTable.Location = new Point(6, 8);
            buttonToggleTable.Name = "buttonToggleTable";
            buttonToggleTable.Size = new Size(80, 26);
            buttonToggleTable.TabIndex = 4;
            buttonToggleTable.Text = "Benutzer";
            buttonToggleTable.UseVisualStyleBackColor = false;
            buttonToggleTable.Click += buttonToggleTable_Click;
            // 
            // panelCREATE
            // 
            panelCREATE.BackColor = SystemColors.ControlDark;
            panelCREATE.Controls.Add(buttonCREATE);
            panelCREATE.Controls.Add(panelDELETE);
            panelCREATE.Controls.Add(tbEmailCREATE);
            panelCREATE.Controls.Add(tbuUsernameCREATE);
            panelCREATE.Controls.Add(listBoxCREATE);
            panelCREATE.Controls.Add(label1);
            panelCREATE.Location = new Point(526, 41);
            panelCREATE.Name = "panelCREATE";
            panelCREATE.Size = new Size(541, 334);
            panelCREATE.TabIndex = 5;
            panelCREATE.Visible = false;
            // 
            // buttonCREATE
            // 
            buttonCREATE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCREATE.BackColor = SystemColors.ControlDarkDark;
            buttonCREATE.FlatStyle = FlatStyle.Flat;
            buttonCREATE.Location = new Point(442, 36);
            buttonCREATE.Name = "buttonCREATE";
            buttonCREATE.Size = new Size(93, 23);
            buttonCREATE.TabIndex = 4;
            buttonCREATE.Text = "Create";
            buttonCREATE.UseVisualStyleBackColor = false;
            // 
            // tbEmailCREATE
            // 
            tbEmailCREATE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEmailCREATE.BackColor = SystemColors.ControlDarkDark;
            tbEmailCREATE.BorderStyle = BorderStyle.None;
            tbEmailCREATE.Location = new Point(3, 58);
            tbEmailCREATE.Name = "tbEmailCREATE";
            tbEmailCREATE.Size = new Size(435, 16);
            tbEmailCREATE.TabIndex = 8;
            // 
            // tbuUsernameCREATE
            // 
            tbuUsernameCREATE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbuUsernameCREATE.BackColor = SystemColors.ControlDarkDark;
            tbuUsernameCREATE.BorderStyle = BorderStyle.None;
            tbuUsernameCREATE.Location = new Point(3, 36);
            tbuUsernameCREATE.Name = "tbuUsernameCREATE";
            tbuUsernameCREATE.Size = new Size(435, 16);
            tbuUsernameCREATE.TabIndex = 4;
            // 
            // listBoxCREATE
            // 
            listBoxCREATE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCREATE.BackColor = SystemColors.ControlDarkDark;
            listBoxCREATE.BorderStyle = BorderStyle.FixedSingle;
            listBoxCREATE.FormattingEnabled = true;
            listBoxCREATE.ItemHeight = 15;
            listBoxCREATE.Location = new Point(3, 80);
            listBoxCREATE.Name = "listBoxCREATE";
            listBoxCREATE.Size = new Size(532, 242);
            listBoxCREATE.TabIndex = 7;
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
            panelDELETE.Controls.Add(panelCHANGE);
            panelDELETE.Controls.Add(DELETElabelCurrentMode);
            panelDELETE.Controls.Add(buttonDeleteToggleEVENTUSER);
            panelDELETE.Controls.Add(buttonDELETE);
            panelDELETE.Controls.Add(listBoxDELETE);
            panelDELETE.Controls.Add(label2);
            panelDELETE.Location = new Point(0, 30);
            panelDELETE.Name = "panelDELETE";
            panelDELETE.Size = new Size(538, 334);
            panelDELETE.TabIndex = 6;
            panelDELETE.Visible = false;
            // 
            // DELETElabelCurrentMode
            // 
            DELETElabelCurrentMode.AutoSize = true;
            DELETElabelCurrentMode.Location = new Point(81, 17);
            DELETElabelCurrentMode.Name = "DELETElabelCurrentMode";
            DELETElabelCurrentMode.Size = new Size(30, 15);
            DELETElabelCurrentMode.TabIndex = 12;
            DELETElabelCurrentMode.Text = "User";
            // 
            // buttonDeleteToggleEVENTUSER
            // 
            buttonDeleteToggleEVENTUSER.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteToggleEVENTUSER.BackColor = SystemColors.ControlDarkDark;
            buttonDeleteToggleEVENTUSER.FlatStyle = FlatStyle.Flat;
            buttonDeleteToggleEVENTUSER.Location = new Point(52, 32);
            buttonDeleteToggleEVENTUSER.Name = "buttonDeleteToggleEVENTUSER";
            buttonDeleteToggleEVENTUSER.Size = new Size(91, 23);
            buttonDeleteToggleEVENTUSER.TabIndex = 11;
            buttonDeleteToggleEVENTUSER.Text = "Swap";
            buttonDeleteToggleEVENTUSER.UseVisualStyleBackColor = false;
            buttonDeleteToggleEVENTUSER.Click += buttonDeleteToggleEVENTUSER_Click;
            // 
            // buttonDELETE
            // 
            buttonDELETE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDELETE.BackColor = SystemColors.ControlDarkDark;
            buttonDELETE.FlatStyle = FlatStyle.Flat;
            buttonDELETE.Location = new Point(441, 32);
            buttonDELETE.Name = "buttonDELETE";
            buttonDELETE.Size = new Size(91, 23);
            buttonDELETE.TabIndex = 10;
            buttonDELETE.Text = "Delete";
            buttonDELETE.UseVisualStyleBackColor = false;
            // 
            // listBoxDELETE
            // 
            listBoxDELETE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxDELETE.BackColor = SystemColors.ControlDarkDark;
            listBoxDELETE.BorderStyle = BorderStyle.FixedSingle;
            listBoxDELETE.FormattingEnabled = true;
            listBoxDELETE.ItemHeight = 15;
            listBoxDELETE.Location = new Point(3, 58);
            listBoxDELETE.Name = "listBoxDELETE";
            listBoxDELETE.Size = new Size(529, 257);
            listBoxDELETE.TabIndex = 8;
            listBoxDELETE.TabStop = false;
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
            panelCHANGE.Controls.Add(buttonCHANGE);
            panelCHANGE.Controls.Add(label3);
            panelCHANGE.Controls.Add(EmailChangeText);
            panelCHANGE.Controls.Add(listBoxCHANGE);
            panelCHANGE.Controls.Add(NameChangeText);
            panelCHANGE.Location = new Point(0, 32);
            panelCHANGE.Name = "panelCHANGE";
            panelCHANGE.Size = new Size(538, 334);
            panelCHANGE.TabIndex = 6;
            panelCHANGE.Visible = false;
            // 
            // buttonCHANGE
            // 
            buttonCHANGE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCHANGE.BackColor = SystemColors.ControlDarkDark;
            buttonCHANGE.FlatStyle = FlatStyle.Flat;
            buttonCHANGE.Location = new Point(439, 51);
            buttonCHANGE.Name = "buttonCHANGE";
            buttonCHANGE.Size = new Size(91, 23);
            buttonCHANGE.TabIndex = 9;
            buttonCHANGE.Text = "Change";
            buttonCHANGE.UseVisualStyleBackColor = false;
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
            // listBoxCHANGE
            // 
            listBoxCHANGE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCHANGE.BackColor = SystemColors.ControlDarkDark;
            listBoxCHANGE.BorderStyle = BorderStyle.FixedSingle;
            listBoxCHANGE.FormattingEnabled = true;
            listBoxCHANGE.ItemHeight = 15;
            listBoxCHANGE.Location = new Point(3, 80);
            listBoxCHANGE.Name = "listBoxCHANGE";
            listBoxCHANGE.Size = new Size(529, 227);
            listBoxCHANGE.TabIndex = 12;
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
            ClientSize = new Size(1165, 721);
            Controls.Add(panelCREATE);
            Controls.Add(panelREAD);
            Controls.Add(dropDown);
            Name = "GUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventManagerUwU";
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

        private Button buttonSEARCH;
        private ListBox listBoxREAD;
        private TextBox tbREADusername;
        private Panel panelREAD;
        public ComboBox dropDown;
        private Label labelREAD;
        private Panel panelCREATE;
        private Label label1;
        private Panel panelDELETE;
        private Label label2;
        private Panel panelCHANGE;
        private Label label3;
        private TextBox tbuUsernameCREATE;
        private ListBox listBoxCREATE;
        private Button buttonCREATE;
        private TextBox tbEmailCREATE;
        private Button buttonCHANGE;
        private TextBox EmailChangeText;
        private ListBox listBoxCHANGE;
        private TextBox NameChangeText;
        private Button buttonDELETE;
        private ListBox listBoxDELETE;
        private Button buttonDeleteToggleEVENTUSER;
        private Label DELETElabelCurrentMode;
        private Button buttonToggleTable;
        private Label label5;
        private TextBox tbREADemail;
        private Label label4;
        private Label label6;
        private TextBox tbREADid;
        private Button buttonREADallUsers;
    }
}
