using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Management
{
    public partial class UC_CategoryItem : UserControl
    {
        public event EventHandler CategorySelect;
        string CategoryID;
        public UC_CategoryItem(string name, Image image, string categoryID)
        {
            InitializeComponent();
            CategoryLabel.Text = name;
            CategoryImage.Image = image;
            CategoryID=categoryID;
            this.CategoryID = categoryID;
        }

        private void UC_CategoryItem_Click(object sender, EventArgs e)
        {
            CategorySelect.Invoke(this, e);
        }

        private void CategoryImage_Click(object sender, EventArgs e)
        {
            CategorySelect.Invoke(this, e);
        }
    }
}
