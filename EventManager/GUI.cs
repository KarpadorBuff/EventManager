namespace EventManager
{
    public partial class GUI : Form
    {
        List<Benutzer> users = new();
        public GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            users = db.GetUsers(lastNameText.Text);
            peopleFoundListBox.DataSource = users;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }
    }
}
