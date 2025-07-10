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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            DatabaseHelper.LoadRoles(RoleComboBox);
            DatabaseHelper.ShowEmployee(EmployeeViewer);
        }
        private bool isValidInput()
        {
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(Fullname.Text) || GenderComboBox.SelectedItem == null || RoleComboBox.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        private bool isExist(string username)
        {
            using (SqlConnection sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                sqlcon.Open();
                string query = "SELECT COUNT(*) FROM Accounts WHERE UserName = @username";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@username", username);
                int count = (int)sqlcmd.ExecuteScalar();
                if (count > 0)
                {
                    return true; // Tài khoản hoặc tên đầy đủ đã tồn tại
                }
                else
                {
                    return false; // Tài khoản chưa tồn tại
                }
            }
        }
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            if (!isValidInput())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            string username = Username.Text.Trim();
            string fullname = Fullname.Text.Trim();
            if (isExist(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }
            using (SqlConnection sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                sqlcon.Open();
                string query = "INSERT INTO Accounts (UserName, Password, FullName, Gender, RoleID) VALUES\r\n(@username, @password, @FullName, @Gender, (SELECT RoleID FROM Roles WHERE RoleName= @RoleID))";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@FullName", Fullname.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Gender", GenderComboBox.SelectedItem.ToString().Trim());
                sqlcmd.Parameters.AddWithValue("@RoleID", RoleComboBox.SelectedItem.ToString().Trim());
                int rows = sqlcmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("Fail to add account");
                }
                else
                {
                    MessageBox.Show("Account added successfully");
                    DatabaseHelper.ShowEmployee(EmployeeViewer);
                    Username.Clear();
                    Password.Clear();
                    Fullname.Clear();
                }
            }
        }

        private void EmployeeViewer_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
