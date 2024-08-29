namespace EventManager
{
    public partial class GUI : Form
    {
        public GUI instance;
        List<Benutzer> users = new();
        public GUI()
        {
            instance = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Basics.OnStartup(this);
        }
        //idk

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            users = db.GetUsers(lastNameText.Text);
            peopleFoundListBox.DataSource = users;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

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
                case -1:
                    {
                        DataAccess db = new DataAccess();
                        users = db.GetUsers(lastNameText.Text);
                        peopleFoundListBox.DataSource = users;
                        peopleFoundListBox.DisplayMember = "FullInfo";
                        break;
                    }
            }
           
        }
    }
}
