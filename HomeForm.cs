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
        public FlowLayoutPanel CategoryPanel 
        {
            get => CategoryFlowPanel;
        }
        private Image convertToImage(byte[] data)
        {
            byte[] imgData = data; //mảng chứa data của ảnh lấy từ CSDL (lúc này chính là byte)
            Image img = null; //tạo biến Image để lưu ảnh sau khi convert
            if (imgData != null) //khi ảnh được đọc lên khác null
            {
                using (MemoryStream ms = new MemoryStream(imgData)) //sử dụng đối tượng MemoryStream để lưu data ảnh (byte) được đọc vào luồng trực tiếp (bộ nhớ thay vì ổ cứng)
                {
                    img = Image.FromStream(ms); //chuyển đổi 1 luồng dữ liệu (byte) thành dạng ảnh thông qua FromStream và lưu vào biến img trước đó đã tạo
                    return img;
                }
            }
            else
            {
                return null;
            }
        }

        private void ShowCategory()
        {
            using (SqlConnection sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Categories", sqlcon);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    string categoryName = reader["CategoryName"].ToString();
                    byte[] cateimgdata = reader["CategoryIMG"] as byte[];
                    Image categoryImage = convertToImage(cateimgdata);
                    UC_CategoryItem categoryItem = new UC_CategoryItem(categoryName, categoryImage);
                    CategoryPanel.Controls.Add(categoryItem);
                }
            }
        }
        internal void ShowDishes(string categoryselection = null)
        {
            using (SqlConnection sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                sqlcon.Open();
                string dishfilteredQuery = "SELECT * FROM Dishes WHERE CategoryID = @categoryid";
                string fulldishQuery = "SELECT * FROM Dishes";
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                if (string.IsNullOrEmpty(categoryselection))
                {
                    sqlcmd.CommandText = fulldishQuery;
                }
                else
                {
                    sqlcmd.CommandText = dishfilteredQuery;
                    sqlcmd.Parameters.AddWithValue("@categoryid", categoryselection);
                }
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while(reader.Read())
                {
                    string dishName = reader["DishName"].ToString();
                    float price = float.Parse(reader["Price"].ToString());
                    byte[] dishImagedata = reader["DishIMG"]as byte[];
                    Image DishImage = convertToImage(dishImagedata);
                    UC_MenuItem Dish = new UC_MenuItem(dishName, price, DishImage);
                    DishFlowPanel.Controls.Add(Dish);
                }
                reader.Close();
            }
        }
        public HomeForm()
        {
            InitializeComponent();
            ShowCategory();
            ShowDishes();
            OrderPanel.Visible = false;
        }
    }
}
