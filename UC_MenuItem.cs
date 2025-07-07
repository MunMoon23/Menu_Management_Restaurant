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
    public partial class UC_MenuItem : UserControl
    {
        public UC_MenuItem(string name, float price, Image img)
        {
            InitializeComponent();
            DishName.Text = name;
            DishPrice.Text = price.ToString();
            DishImage.Image = img;
        }
    }
}
