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
    public partial class UC_BillItem : UserControl
    {
        public FlowLayoutPanel OrderPanel => OrderItemHolderFlowPanel;
        public event EventHandler ClearBillItemClicked;

        public string BillID;
        public string OrderTime;
        public string EmloyeeName;
        public int ItemNumber;
        public float totalPrice;

        public List<OrderInfoClass> OrderInfos;
        public UC_BillItem(string billid, string OrderTime, string employeename)
        {
            InitializeComponent();
            OrderInfos = new List<OrderInfoClass>();
            Bill.Text = billid;
            this.BillID = billid;

            OrderedTime.Text = OrderTime;
            this.OrderTime = OrderTime;

            EmployeeName.Text = employeename;
            this.EmloyeeName = employeename;
        }

        public UC_BillItem()
        {
            InitializeComponent();
            OrderInfos = new List<OrderInfoClass>();
        }

        public void AddToBill(int ItemNumber, string itemName, string quantity, string price)
        {
            this.OrderInfos.Add(new OrderInfoClass
            {
                ItemName = itemName,
                ItemQuantity = int.Parse(quantity),
                ItemTotalPrice = float.Parse(price)
            });
            Label item = new Label();
            item.AutoSize = true;
            item.MaximumSize = new Size(260, 0);
            item.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            item.Text = ItemNumber.ToString() + " --- " + itemName + " --- " + quantity + " --- " + price;
            item.Margin = new Padding(3);

            OrderPanel.Controls.Add(item);
        }

        public void CalculateTotalPrice()
        {
            OrderTotal.Text = "";
            OrderTotal.Text = totalPrice.ToString();
        }

        private void ClearBillItem_Click(object sender, EventArgs e)
        {
            ClearBillItemClicked?.Invoke(this, e);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            AlertPrintForm printform = new AlertPrintForm(this.BillID, this.OrderTime, this.EmloyeeName, this.ItemNumber, this.totalPrice, this.OrderInfos);
            printform.Show();
        }
    }
}
