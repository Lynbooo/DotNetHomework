using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace homework5
{
    class Order : IComparable<Order>
    {
        private Client clientInfo;//客户信息
        private int orderId;   //订单号
        private double orderAmount;   //订单金额
        private double orderDiscount; //订单优惠
        private DateTime orderCreateTime;  //订单创建时间
        private List<OrderDetails> orderDetails = new List<OrderDetails>();  //订单明细
        public Order() { }
        public Order(
            Client clientInfo,
            int orderId,
            double orderDiscount,
            DateTime orderCreateTime,
            OrderDetails orderDetail
            )
        {
            ClientInfo = clientInfo;
            OrderId = orderId;
            OrderAmount = OrderAmount;
            OrderDiscount = orderDiscount;
            OrderCreateTime = orderCreateTime;
            orderDetails.Add(orderDetail);
        }
        public void AddOrderDetail(OrderDetails orderDetail)
        {
            foreach (OrderDetails detail in orderDetails)
            {
                if (orderDetail.Equals(detail))
                    throw new ArgumentOutOfRangeException("invalid good's detail!");
            }
            orderDetails.Add(orderDetail);
        }
        public Client ClientInfo {
            get { return clientInfo; }
            set
            {
                if (value == null) throw new ArgumentOutOfRangeException("invalid clientInfo!");
                clientInfo = value;
            }
        }
        public int OrderId
        {
            get { return orderId; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("invalid orderId!");
                orderId = value;
            }
        }
        public double OrderAmount
        {
            get {  return orderAmount = OrderDiscount * OrderDetails.Sum(t=>t.TotalAmount); }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("invalid orderAmount!");
                orderAmount = value;
            }
        }
        public double OrderDiscount
        {
            get { return orderDiscount; }
            set
            {
                if (value < 0 || value > 1) throw new ArgumentOutOfRangeException("invalid orderDiscount!");
                orderDiscount = value;
            }
        }
        public DateTime OrderCreateTime
        {
            get { return orderCreateTime; }
            set
            {
                if (value == null) throw new ArgumentOutOfRangeException("invalid orderCreateTime!");
                orderCreateTime = value;
            }
        }
        public List<OrderDetails> OrderDetails { get { return orderDetails; } }
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                ClientInfo == order.ClientInfo &&
                OrderId == order.OrderId &&
                OrderAmount == order.OrderAmount &&
                OrderDiscount == order.orderDiscount &&
                OrderCreateTime == order.OrderCreateTime &&
                OrderDetails == order.OrderDetails;

        }
        public override int GetHashCode()
        {
            var hashCode = 1505761165;
            hashCode = hashCode * -1521134295 + ClientInfo.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderDiscount.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderCreateTime.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderDetails.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            String details = "";
            int n = 1;
            foreach(OrderDetails detail in orderDetails)
            {
                details = details + n.ToString() + ":  " + detail + "\r\n";
                n++;
            }
            return "ClientInfo:\r\n" + ClientInfo + "\r\n"
                + "OrderId: " + OrderId + "\r\n"
                + "OrderAmount: " + OrderAmount + "\r\n"
                + "OrderDiscount: " + OrderDiscount + "\r\n"
                + "OrderCreateTime: " + OrderCreateTime + "\r\n"
                + "OrderDetails:\r\n" + details;
        }
        public int CompareTo([AllowNull] Order other)
        {
            Order order = other as Order;
            if (order == null)
                throw new NotImplementedException();
            return this.OrderId.CompareTo(order.OrderId);
            
        }
    }

}
