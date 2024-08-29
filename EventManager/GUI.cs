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
            dropDown.Items.Add("Create");
            dropDown.Items.Add("Delete");
            dropDown.Items.Add("Change");
            dropDown.Items.Add("Read");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (dropDown.SelectedIndex)
            {
                case 0:
                    {
                        DataAccess db = new DataAccess();
                        users = db.GetUsers(lastNameText.Text);
                        peopleFoundListBox.DataSource = users;
                        peopleFoundListBox.DisplayMember = "FullInfo";
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
           
        }
    }
}
