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

        string BillID;
        string OrderTime;
        string EmloyeeName;

        float totalPrice;
        public UC_BillItem(string billid, string OrderTime, string employeename, float total)
        {
            InitializeComponent();
            Bill.Text = billid;
            this.BillID = billid;

            OrderedTime.Text = OrderTime;
            this.OrderTime = OrderTime;

            EmployeeName.Text = employeename;
            this.EmloyeeName = employeename;

            OrderTotal.Text = total.ToString("C2");
            this.totalPrice = total;
        }

        public UC_BillItem()
        {
            InitializeComponent();
        }

        public void AddToBill(int ItemNumber, string itemName, string quantity,float price)
        {
            Label item = new Label();
            item.Text = ItemNumber.ToString() + "---" + itemName + "---" + quantity + "---" + price.ToString();
            OrderItemHolderFlowPanel.Controls.Add(item);
        }

        public void CalculateTotalPrice()
        {

        }
        
    }
}
