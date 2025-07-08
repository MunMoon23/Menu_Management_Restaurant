using Microsoft.Data.SqlClient;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            CategoryLabel.Text = "All";
            DatabaseHelper.ShowCategory(CategoryFlowPanel, DishFlowPanel);
            DatabaseHelper.ShowDishes(DishFlowPanel);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                DishFlowPanel.Controls.Clear(); // Xóa tất cả các điều khiển trong DishFlowPanel nếu không có từ khóa tìm kiếm
                DatabaseHelper.ShowDishes(DishFlowPanel); // Hiển thị lại tất cả các món ăn
            }
            else
            {
                DatabaseHelper.ShowDishesBySearch(DishFlowPanel, searchText);
            }
        }
    }
}
