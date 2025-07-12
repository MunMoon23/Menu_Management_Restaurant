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
        private BillForm billform;
        public HomeForm(BillForm billform)
        {
            InitializeComponent();
            CategoryLabel.Text = "All";
            DatabaseHelper.ShowCategory(CategoryFlowPanel, OrderflowLayout, OrderTotalLabel, DishFlowPanel);
            DatabaseHelper.ShowDishes(DishFlowPanel, OrderflowLayout, OrderTotalLabel);
            this.billform=billform;
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchBar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                DishFlowPanel.Controls.Clear(); // Xóa tất cả các điều khiển trong DishFlowPanel nếu không có từ khóa tìm kiếm
                DatabaseHelper.ShowDishes(DishFlowPanel, OrderflowLayout, OrderTotalLabel); // Hiển thị lại tất cả các món ăn
            }
            else
            {
                DatabaseHelper.ShowDishesBySearch(DishFlowPanel, searchText);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int billid = rd.Next(1000, 9999);
            string timestamp = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            float total = 0;
            try
            {
                total = float.Parse(OrderTotalLabel.Text);
            }
            catch
            {
                MessageBox.Show("Please add items to the order before placing it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UC_BillItem BillItem = new UC_BillItem( "#"+ billid.ToString(), timestamp, "AKZM");
            BillItem.ClearBillItemClicked += (sender, e) =>
            {
                billform.billflowpanel.Controls.Remove(BillItem);
            };
            int itemnumber = 0;
            float totalprice = 0;
            foreach (Control controlitem in OrderflowLayout.Controls)
            {
                if(controlitem is UC_OrderItem Orderitem)
                {
                    itemnumber++;
                    string itemname = Orderitem.name;
                    int itemquantity = Orderitem.quantity;
                    float itemprice = Orderitem.orderPrice * itemquantity;
                    totalprice += itemprice;
                    BillItem.AddToBill(itemnumber, itemname, itemquantity.ToString(), itemprice.ToString());

                }
            }
            BillItem.totalPrice = totalprice;
            BillItem.CalculateTotalPrice();
            billform.billflowpanel.Controls.Add(BillItem);
        }
    }
}
