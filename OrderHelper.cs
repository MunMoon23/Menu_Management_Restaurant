using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Management
{
    internal class OrderHelper
    {
        public static float totalPrice = 0; //Tổng tiền của đơn hàng hiện tại

        internal static void CalculateTotalPrice(FlowLayoutPanel Orderfl)
        {
            float total = 0;
            foreach (Control item in Orderfl.Controls)
            {
                if (item is UC_OrderItem OrderItem)
                {
                    total += OrderItem.orderPrice * OrderItem.quantity;
                }   
            }
            totalPrice = total; //Cập nhật tổng tiền
        }
    }
}
