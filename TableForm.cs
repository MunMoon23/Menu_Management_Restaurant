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

namespace Menu_Management
{
    public partial class TableForm : Form
    {

        string selectedItem;
        public TableForm()
        {

            InitializeComponent();
            popuppanel.Visible = false;
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableTable.SelectedItem != null)
            {
                selectedItem = AvailableTable.SelectedItem.ToString();
                NameTxt.Text = "";
                NumberOrderTxt.Text = "";
                popuppanel.Visible = true;
                label4.Text = selectedItem;
                Accept.Visible = true;
                vacantAccept.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VacanTable.Items.Add(selectedItem);

            AvailableTable.Items.Remove(selectedItem);
            popuppanel.Visible = false;
        }

        private void VacanTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VacanTable.SelectedItem != null)
            {
                selectedItem = VacanTable.SelectedItem.ToString();

                popuppanel.Visible = true;
                label4.Text = selectedItem;
                vacantAccept.Visible = true;
                Accept.Visible = false;
            }
        }

        private void vacantAccept_Click(object sender, EventArgs e)
        {
            AvailableTable.Items.Add(selectedItem);

            VacanTable.Items.Remove(selectedItem);
            popuppanel.Visible = false;
        }

        private void ExitPopup_Click(object sender, EventArgs e)
        {
            popuppanel.Visible = false;
        }
    }
}
