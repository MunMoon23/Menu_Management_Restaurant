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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Home_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            HomeForm hf = new HomeForm();
            hf.TopLevel = false;
            hf.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(hf);
            hf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            HomeForm hf = new HomeForm();
            hf.TopLevel = false;
            hf.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(hf);
            hf.Show();
        }
    }
}
