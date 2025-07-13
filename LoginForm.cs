using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private bool isValidInput()
        {
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                return false;
            }
            return true;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(!isValidInput())
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                using(SqlConnection sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts WHERE UserName = @username AND Password = @password", sqlcon);
                    cmd.Parameters.AddWithValue("@username", Username.Text);
                    cmd.Parameters.AddWithValue("@password", Password.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Login.User = reader["UserName"].ToString();
                        Login.Fullname = reader["FullName"].ToString();
                        int RoleID = Convert.ToInt32(reader["RoleID"]);
                        Login.Role = Login.GetRole(RoleID);
                        this.Hide();
                        MainForm mainForm = new MainForm(Login.Fullname);
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }    
        }
    }
}
