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
            if (listBox1.SelectedItem != null)
            {
                selectedItem = listBox1.SelectedItem.ToString();

                //MessageBox.Show("Bạn đã chọn: " + selectedItem);
                popuppanel.Visible = true;
                label4.Text = selectedItem;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(selectedItem);

            listBox1.Items.Remove(selectedItem);
            popuppanel.Visible = false;
        }
    }
}
