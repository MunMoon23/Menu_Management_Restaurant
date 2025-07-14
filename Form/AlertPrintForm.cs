using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Menu_Management.Class;

namespace Menu_Management
{
    public partial class AlertPrintForm : Form
    {
        // Biến để hỗ trợ in hóa đơn
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog previewDialog = new PrintPreviewDialog();
        private int currentLine = 0;
        private List<string> billLines;

        // Thông tin hóa đơn
        public string BillID;
        public string OrderTime;
        public string EmloyeeName;
        public int ItemNumber;
        public float totalPrice;
        public List<OrderInfoClass> OrderInfos;

        public AlertPrintForm(string BillID, string OrderTime, string EmployeeName, int ItemNumber, float totalPrice, List<OrderInfoClass> OrderInfos)
        {
            InitializeComponent();
            this.BillID = BillID;
            this.OrderTime = OrderTime;
            this.EmloyeeName = EmployeeName;
            this.ItemNumber = ItemNumber;
            this.totalPrice = totalPrice;
            this.OrderInfos = OrderInfos;

            // Gắn sự kiện in 1 lần
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private void BuildBillContent()
        {
            billLines = new List<string>();
            billLines.Add("         HÓA ĐƠN BÁN HÀNG");
            billLines.Add("-------------------------------");
            billLines.Add($"Mã hóa đơn : {BillID}");
            billLines.Add($"Nhân viên   : {EmloyeeName}");
            billLines.Add($"Thời gian   : {OrderTime}");
            billLines.Add("-------------------------------");
            billLines.Add("Món           SL   Đơn giá");

            foreach (var item in OrderInfos)
            {
                billLines.Add($"{item.ItemName,-13} {item.ItemQuantity,2}   {item.ItemTotalPrice,7:N0}");
            }

            billLines.Add("-------------------------------");
            billLines.Add($"Tổng món: {ItemNumber}");
            billLines.Add($"Tổng tiền: {totalPrice:N0} VND");
            billLines.Add("-------------------------------");
            billLines.Add("  Cảm ơn quý khách đã ủng hộ!");
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 10);
            float yPos = 10; // Vị trí bắt đầu vẽ văn bản
            float leftMargin = 10; // Lề trái của trang in
            float lineHeight = font.GetHeight(e.Graphics); // Chiều cao của mỗi dòng văn bản
            int linesPerPage = (int)(e.MarginBounds.Height / lineHeight); // Số dòng có thể in trên mỗi trang

            while (currentLine < billLines.Count) //Lặp qua từng dòng trong danh sách
            {
                string line = billLines[currentLine];
                e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos); // Vẽ dòng văn bản, DrawString sẽ vẽ dòng văn bản tại vị trí (leftMargin, yPos) trên trang in
                yPos += lineHeight; // Cập nhật vị trí yPos cho dòng tiếp theo
                currentLine++; //tăng thêm 1 dòng

                if ((currentLine % linesPerPage) == 0)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
            currentLine = 0; // Reset cho lần in tiếp theo
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            BuildBillContent(); // Tạo nội dung hóa đơn

            // Gán tài liệu cho dialog xem trước
            previewDialog.Document = printDocument;
            previewDialog.Width = 600;
            previewDialog.Height = 800;

            // Hiển thị xem trước
            previewDialog.ShowDialog();

            // Sau khi preview xong → chọn máy in để in
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }

            this.Close(); // Đóng form sau khi in
        }

        private void NotPrintButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Không in, chỉ đóng form
        }
    }
}
