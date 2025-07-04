using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Menu_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowForm(Form f)
        {
            MainPanel.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(f);
            f.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Home_Click(object sender, EventArgs e)
        {
            ShowForm(new HomeForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Home_Click(sender, e);
        }

        private void Tables_Click(object sender, EventArgs e)
        {
            ShowForm(new TableForm());
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            ShowForm(new Setting());
        }
    }
}
