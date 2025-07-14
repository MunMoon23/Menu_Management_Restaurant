using Azure.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Management.Class
{
    internal class Login
    {
        public static string User;
        public static string Fullname;
        public static string Role;


        public static void PhanQuyen(Form form, string role)
        {
            if(form is Setting settingform)
            {
                if(role != "Admin")
                {
                    settingform.addEmployeeBtn.Enabled = false;
                    settingform.changeMenuBtn.Enabled = false;
                    settingform.admincheckout.Enabled = false;
                }    
            }
        }
        public static string GetRole(int RoleID)
        {
            using (SqlConnection sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT RoleName FROM Roles WHERE RoleID = @RoleID", sqlcon);
                cmd.Parameters.AddWithValue("@RoleID", RoleID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["RoleName"].ToString();
                }
                else
                {
                    return "Unknown Role";
                }
            }    
        }
    }

}


