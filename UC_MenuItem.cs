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
        string DishID;
        string DishTypeID;
        Color colorChanged = Color.Gray;
        public UC_MenuItem(string name, float price, Image img, string ID, string dishTypeID)
        {
            InitializeComponent();
            DishName.Text = name;
            DishPrice.Text = price.ToString();
            DishImage.Image = img;
            this.DishID = ID;
            this.DishTypeID = dishTypeID;
        }
    }
}
