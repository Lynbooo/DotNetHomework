using System;
using System.Collections.Generic;
using System.Text;

namespace homework5
{
    class OrderDetails
    {
        private String goodName;    //商品名称
        private double goodPrice;   //商品单价
        private int goodNumber;     //商品数量
        private double totalAmount; //总价
        public OrderDetails() { }
        public OrderDetails(string goodName, double goodPrice, int goodNumber)
        {
            GoodName = goodName;
            GoodPrice = goodPrice;
            GoodNumber = goodNumber;
            TotalAmount = TotalAmount;
        }
        public String GoodName
        {
            get { return goodName; }
            set
            {
                if (value == null) throw new ArgumentOutOfRangeException("invalid goodName!");
                goodName = value;
            }
        }
        public double GoodPrice
        {
            get { return goodPrice; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("invalid goodPrice!");
                goodPrice = value;
            }
        }
        public int GoodNumber
        {
            get { return goodNumber; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("invalid goodNumber!");
                goodNumber = value;
            }
        }
        public double TotalAmount
        {
            get { return totalAmount = GoodPrice * GoodNumber; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("invalid totalAmount!");
                totalAmount = value;
            }
        }
        public override bool Equals(object obj)
        {
            var orderDetails = obj as OrderDetails;
            return orderDetails != null &&
                GoodName == orderDetails.GoodName &&
                GoodNumber == orderDetails.GoodNumber &&
                GoodPrice == orderDetails.GoodPrice &&
                TotalAmount == orderDetails.TotalAmount;
        }
        public override int GetHashCode()
        {
            var hashCode = 1505761165;
            hashCode = hashCode * -1521134295 + GoodName.GetHashCode();
            hashCode = hashCode * -1521134295 + GoodNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + GoodPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalAmount.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return "GoodName: " + GoodName + "  "
                + "GoodPrice: " + GoodPrice.ToString() + "  "
                + "GoodNumber: " + GoodNumber.ToString() + "  "
                + "TotalAmount: " + TotalAmount.ToString() + "  ";
        }
    }
}
