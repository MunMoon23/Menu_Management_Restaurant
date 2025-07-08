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
        public event EventHandler OnCategorySelect; //Khai báo 1 sự kiện
        string CategoryID;
        Color ColorChanged = Color.Gray;
        public UC_CategoryItem(string name, Image image, string categoryID)
        {
            InitializeComponent();
            CategoryLabel.Text = name;
            CategoryImage.Image = image;
            CategoryID=categoryID;
            this.CategoryID = categoryID;
        }

        private void UC_CategoryItem_Click(object sender, EventArgs e) //sự kiện nhấp này là để thông báo kích hoạt sự kiện OnCategorySelect
        {
            OnCategorySelect.Invoke(this, e); //gọi sự kiện CategorySelect khi người dùng nhấp vào điều khiển này
        }

        private void CategoryImage_Click(object sender, EventArgs e)
        {
            OnCategorySelect.Invoke(this, e);
        }

        private void CategoryImage_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = ColorChanged; //đổi màu nền của ảnh khi hover chuột vào
        }

        private void CategoryImage_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent; //trả về màu nền ban đầu khi chuột rời khỏi ảnh
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = ColorChanged; //đổi màu nền của panel khi hover chuột vào
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent; //trả về màu nền ban đầu khi chuột rời khỏi panel
        }

        private void CategoryLabel_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = ColorChanged; //đổi màu nền của label khi hover chuột vào
        }

        private void CategoryLabel_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent; //trả về màu nền ban đầu khi chuột rời khỏi label
        }
    }
}
