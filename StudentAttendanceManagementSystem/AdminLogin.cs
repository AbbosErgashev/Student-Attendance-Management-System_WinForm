using StudentAttendanceManagementSystem;

namespace BookStoreManagmentSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UPasswordTb.Text == "useradmin")
            {
                Oliygoh books = new();
                books.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wring Password. Contact the Admin");
                UPasswordTb.Text = "";
            }
        }

        private void AdminLink_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            this.Hide();
        }
    }
}