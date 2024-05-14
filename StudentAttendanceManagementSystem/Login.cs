using StudentAttendanceManagementSystem;

namespace BookStoreManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void AdminLink_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new();
            adminLogin.Show();
            this.Hide();
        }

        private void UserLogin()
        {
            if (UNameTb.Text == "" || UPasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                if (UNameTb.Text == "Username" && UPasswordTb.Text == "Password")
                {
                    Abiturient st = new();
                    st.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                    UNameTb.Text = "";
                    UPasswordTb.Text = "";
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserLogin();
        }
    }
}