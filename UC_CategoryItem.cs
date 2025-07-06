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
        public UC_CategoryItem(string name, Image image)
        {
            InitializeComponent();
            CategoryLabel.Text = name;
            CategoryImage.Image = image;
        }
    }
}
