using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;


namespace Menu_Management
{
    public partial class MainForm : Form
    {
        SqlConnection sqlcon = null;
        public MainForm()
        {
            CheckConnection();
            InitializeComponent();
        }
        private void CheckConnection()
        {
            try
            {
                sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString());
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    MessageBox.Show("Database connection successful!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Home_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();

            MainHelper.ShowForm(hf, MainPanel);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Home_Click(sender, e);
        }


        private void Settings_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(MainPanel);
            MainHelper.ShowForm(setting, MainPanel);
        }
    }
}
