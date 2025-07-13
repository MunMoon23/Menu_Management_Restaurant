﻿using System;
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

        public BillForm billForm = new BillForm();
        SqlConnection sqlcon = null;
        public HomeForm homeForm;
        public MainForm(string User)
        {
            CheckConnection();
            InitializeComponent();
            CurrentUser.Text = User;
        }
        private void CheckConnection()
        {
            try
            {
                sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString());
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    return;
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
            MainHelper.ShowForm(homeForm, MainPanel);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            homeForm = new HomeForm(billForm); // chỉ khởi tạo 1 lần
            MainHelper.ShowForm(homeForm, MainPanel);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            MainHelper.ShowForm(billForm, MainPanel);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(MainPanel, billForm);
            MainHelper.ShowForm(setting, MainPanel);
        }
    }
}
