using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Menu_Management
{
    public partial class ChangeMenuForm : Form
    {
        Panel mainpanel;
        SqlConnection sqlcon = null;
        public ChangeMenuForm(Panel mainpanel)
        {
            InitializeComponent();
            this.mainpanel=mainpanel;
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlterBtn_Click(object sender, EventArgs e)
        {

            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeMenuForm_Load(object sender, EventArgs e)
        {
            string[] st = { "Foods", "Drinks" };
            foreach (string s in st)
            {
                CategoryCBB.Items.Add(s);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(mainpanel);
            MainHelper.ShowForm(setting, mainpanel);
        }
    }
}
