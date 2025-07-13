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
        Panel mainpanel;
        private BillForm billform;
        public Setting(Panel main, BillForm billform)
        {
            InitializeComponent();
            mainpanel = main;
            this.billform = billform;

        }

        private void ChangeMenuBtn_Click(object sender, EventArgs e)
        {
            ChangeMenuForm ChangeMenuForm = new ChangeMenuForm(mainpanel);
            MainHelper.ShowForm(ChangeMenuForm, mainpanel);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(billform);
            MainHelper.ShowForm(homeForm, mainpanel);
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            DeleteEmployeeButton addform = new DeleteEmployeeButton();
            MainHelper.ShowForm(addform, mainpanel);
        }
    }
}
