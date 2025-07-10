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
        private Panel mainform;
        public Setting(Panel main)
        {
            InitializeComponent();
            mainform = main;
        }

        private void ChangeMenuBtn_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            MainHelper.ShowForm(hf, mainform);
        }
    }
}
