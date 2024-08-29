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

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new();
            users = db.GetUsers(lastNameText.Text);
            peopleFoundListBox.DataSource = users;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastNameText.Text = $"Selected Index: {dropDown.SelectedIndex}";
        }
    }
}
