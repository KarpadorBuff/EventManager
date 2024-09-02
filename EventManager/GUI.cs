namespace EventManager
{
    public partial class GUI : Form
    {
        public GUI instance;
        List<Benutzer> users = new();
        DataAccess db;
        public GUI()
        {
            instance = this;
            InitializeComponent();
            db = new(instance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Basics.OnStartup(this);
        }
        //idk


        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dropDown.SelectedIndex)
            {
                case 0:
                    {
                        panelCREATE.Visible = true;
                        panelDELETE.Visible = false;
                        panelCHANGE.Visible = false;
                        panelREAD.Visible = false;
                        break;
                    }
                case 1:
                    {
                        panelCREATE.Visible = false;
                        panelDELETE.Visible = true;
                        panelCHANGE.Visible = false;
                        panelREAD.Visible = false;
                        break;
                    }
                case 2:
                    {
                        panelCREATE.Visible = false;
                        panelDELETE.Visible = false;
                        panelCHANGE.Visible = true;
                        panelREAD.Visible = false;
                        break;
                    }
                case 3:
                    {
                        panelCREATE.Visible = false;
                        panelDELETE.Visible = false;
                        panelCHANGE.Visible = false;
                        panelREAD.Visible = true;
                        break;
                    }
            }
        }


        private void buttonDeleteToggleEVENTUSER_Click(object sender, EventArgs e)
        {

        }

        private void ButtonREAD_Clicked(object sender, EventArgs e)
        {
            if (tbREADusername.Text != "") users = db.GetUserInformationFromUsername(tbREADusername.Text);
            else if (tbREADemail.Text != "") users = db.GetUserInformationFromEmail(tbREADemail.Text);
            else if (tbREADid.Text != "") users = db.GetUserInformationFromId(tbREADid.Text);
            listBoxREAD.DataSource = users;
            listBoxREAD.DisplayMember = "FullInfo";
            users = new();
        }
        private void buttonToggleTable_Click(object sender, EventArgs e)
        {
            switch (buttonToggleTable.Text)
            {
                case "Benutzer":
                    tbREADusername.Visible = false;
                    tbREADemail.Visible = false;
                    tbREADid.Visible = false;
                    buttonToggleTable.Text = "Event";
                    break;
                case "Event":
                    tbREADusername.Visible = true;
                    tbREADemail.Visible = true;
                    tbREADid.Visible = true;
                    buttonToggleTable.Text = "Benutzer";
                    break;
            }
        }

        private void tbREADusername_TextChanged(object sender, EventArgs e)
        {
            tbREADid.Text = "";
            tbREADemail.Text = "";
        }

        private void tbREADemail_TextChanged(object sender, EventArgs e)
        {
            tbREADusername.Text = "";
            tbREADid.Text = "";
        }

        private void tbREADid_TextChanged(object sender, EventArgs e)
        {
            tbREADemail.Text = "";
            tbREADusername.Text = "";
        }

        private void buttonREADallUsers_Click(object sender, EventArgs e)
        {
            users = db.getAllUsers();
            listBoxREAD.DataSource = users;
            listBoxREAD.DisplayMember = "FullInfo";
        }
    }
}
