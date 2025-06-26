

namespace Menu_Management
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string user_regex = @"^[a-zA-Z0-9]{3,16}$"; // Username must be 3-16 alphanumeric characters
            string password_regex = "^.{8,}$"; // Password must be at least 8 characters long
            if (string.IsNullOrEmpty(User.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(ConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(!System.Text.RegularExpressions.Regex.IsMatch(User.Text, user_regex))
                {
                    MessageBox.Show("Username must be 3-16 alphanumeric characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(!System.Text.RegularExpressions.Regex.IsMatch(Password.Text, password_regex))
                {
                    MessageBox.Show("Password must be at least 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(Password.Text != ConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Registration logic here (e.g., save to database or file)
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the registration form after successful registration
                }
            }    
        }
    }
}
