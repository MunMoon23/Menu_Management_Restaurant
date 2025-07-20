using FastReport;
using Menu_Management.Class;
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
using FastReport.Export.PdfSimple;

namespace Menu_Management
{
    public partial class AdminCheckoutFrm : Form
    {
        public AdminCheckoutFrm()
        {
            InitializeComponent();
        }

        private void ReportItemWise_Click(object sender, EventArgs e)
        {
            DateTime fromDate = StartDate.Value.Date;
            DateTime toDate = EndDate.Value.Date.AddDays(1).AddTicks(-1);

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                string query = @"
                SELECT 
                    D.DishName,
                    BD.UnitPrice,
                    SUM(BD.Quantity) AS SoLuong,
                    SUM(BD.Quantity * BD.UnitPrice) AS ThanhTien
                FROM BillDetails BD
                JOIN Dishes D ON BD.DishID = D.DishID
                JOIN Bills B ON BD.BillID = B.BillID
                WHERE B.OrderTime BETWEEN @FromDate AND @ToDate
                      AND B.Status = N'Done'
                GROUP BY D.DishName, BD.UnitPrice

                UNION ALL

                SELECT 
                    N'TỔNG CỘNG' AS DishName,
                    NULL AS UnitPrice,
                    SUM(BD.Quantity),
                    SUM(BD.Quantity * BD.UnitPrice)
                FROM BillDetails BD
                JOIN Dishes D ON BD.DishID = D.DishID
                JOIN Bills B ON BD.BillID = B.BillID
                WHERE B.OrderTime BETWEEN @FromDate AND @ToDate
                      AND B.Status = N'Done';";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            Report report = new Report();
            report.Load("C:/Users/Phu/Desktop/.net project/Menu Management/Reports/ItemWiseReport.frx"); //cần thêm file
            report.RegisterData(dt, "Revenue");
            report.GetDataSource("Revenue").Enabled = true;

            report.SetParameterValue("FromDate", fromDate);
            report.SetParameterValue("ToDate", toDate);

            report.Prepare();
            string exportPath = $"C:/Users/Phu/Desktop/.net project/Menu Management/ExportReport/DoanhThu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            PDFSimpleExport pdfExport = new PDFSimpleExport();
            report.Export(pdfExport, exportPath);
            report.Dispose();

            MessageBox.Show("✅ Đã xuất báo cáo thành công:\n" + exportPath, "FastReport", MessageBoxButtons.OK);
        }
    }
}
