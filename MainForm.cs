using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Menu_Management
{
    public partial class MainForm : Form
    {
        SqlConnection sqlcon = null;
        public MainForm()
        {
            CheckConnection();
            InitializeComponent();
        }
        private Image convertToImage(byte[] data)
        {
            byte[] imgData = data; //mảng chứa data của ảnh lấy từ CSDL (lúc này chính là byte)
            Image img = null; //tạo biến Image để lưu ảnh sau khi convert
            if(imgData != null) //khi ảnh được đọc lên khác null
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
        private void CheckConnection()
        {
            try
            {
                sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString());
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    MessageBox.Show("Database connection successful!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }
        private void ShowForm(Form f)
        {
            MainPanel.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(f);
            f.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Home_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            ShowForm(hf);
            sqlcon = new SqlConnection(DatabaseHelper.GetConnectionString());
            try
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
                    hf.CategoryPanel.Controls.Add(categoryItem);
                }
                reader.Close();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Home_Click(sender, e);
        }

        private void Tables_Click(object sender, EventArgs e)
        {
            ShowForm(new TableForm());
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            ShowForm(new Setting());
        }
    }
}
