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
using Microsoft.Data.SqlClient;

namespace Menu_Management
{
    public partial class ChangeMenuForm : Form
    {
        Panel mainpanel;
        SqlConnection sqlcon = null;
        public ChangeMenuForm(Panel mainpanel)
        {
            InitializeComponent();
            this.mainpanel=mainpanel;
        }

        private void LoadDishes()
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Dishes", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Chuyển cột ảnh sang Image
                foreach (DataRow row in dt.Rows)
                {
                    if (row["DishImage"] != DBNull.Value)
                    {
                        byte[] imgData = (byte[])row["DishImage"];
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            row["DishImage"] = Image.FromStream(ms);
                        }
                    }
                }

                // Gán dữ liệu vào DataGridView
                ShowData.DataSource = dt;

                // Cài đặt để cột ảnh hiển thị đúng
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)ShowData.Columns["DishImage"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();

                // Lấy CategoryID từ tên
                SqlCommand getCategoryCmd = new SqlCommand("SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName", sqlcon);
                getCategoryCmd.Parameters.AddWithValue("@CategoryName", CategoryCBB.SelectedItem.ToString());

                SqlDataReader reader = getCategoryCmd.ExecuteReader();
                string categoryID = "";

                if (reader.Read())
                {
                    categoryID = reader["CategoryID"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Category.", "Thông báo");
                    reader.Close();
                    return;
                }

                reader.Close(); // đóng reader trước khi dùng SqlCommand khác

                // Xử lý ảnh
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                // Thêm món ăn vào bảng Dishes
                SqlCommand insertCmd = new SqlCommand("INSERT INTO Dishes (DishID, DishName, CategoryID, Price, DishImage) VALUES (@DishID, @DishName, @CategoryID, @Price, @DishImage)", sqlcon);
                insertCmd.Parameters.AddWithValue("@DishID", DishIdTxt.Text);
                insertCmd.Parameters.AddWithValue("@DishName", NameTxt.Text);
                insertCmd.Parameters.AddWithValue("@CategoryID", categoryID);
                insertCmd.Parameters.AddWithValue("@Price", float.Parse(PriceTxt.Text));
                insertCmd.Parameters.AddWithValue("@DishImage", imageBytes);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm món ăn thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể thêm món ăn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }


        private void AlterBtn_Click(object sender, EventArgs e)
        {

            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeMenuForm_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Categories", sqlcon);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                string categoryName = reader["CategoryName"].ToString();
                foreach (char c in categoryName)
                {
                    CategoryCBB.Items.Add(c);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            LoadDishes();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void ShowData_SelectionChanged(object sender, EventArgs e)
        {  
            if (ShowData.CurrentRow != null && ShowData.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = ShowData.CurrentRow;

                if (row.Cells["DishImage"].Value != DBNull.Value)
                {
                    object cellValue = row.Cells["DishImage"].Value;

                    if (cellValue is byte[] imgBytes)
                    {
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    else if (cellValue is Image img)
                    {
                        pictureBox.Image = img;
                    }
                }
                else
                {
                    pictureBox.Image = null;
                }
            
        }

    }
}
}
