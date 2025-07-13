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
    public partial class AlertPrintForm : Form
    {
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
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }

        private void NotPrintButton_Click(object sender, EventArgs e)
        {

        }
    }
}
