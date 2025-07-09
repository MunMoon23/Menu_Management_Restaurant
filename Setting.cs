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
    public partial class Setting : Form
    {
        public Setting()
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

        private void ChangeMenuBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new ChangeMenuForm());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new HomeForm());
        }
    }
}
