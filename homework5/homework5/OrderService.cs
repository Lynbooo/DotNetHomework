using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homework5
{
    class OrderService
    {
        private List<Order> ordersList = new List<Order>();
        public OrderService() { }
        private List<Order> OrdersList {
            get { return ordersList; }
            set {
                if (value == null) throw new ArgumentOutOfRangeException("invalid ordersList!");
                ordersList = value;
            }
        }
        public void AddOrder(Order newOrder)
        {
            foreach (Order order in ordersList) {
                if (order.Equals(newOrder))
                    throw new ArgumentOutOfRangeException("invalid order");
            }
            ordersList.Add(newOrder);
            ordersList.Sort((o1, o2) => o1.OrderId - o2.OrderId);
        }
        public void DeleteOrder(Order theOrder)
        {
            Order orderToDelete = new Order();
            foreach (Order order in ordersList)
            {
                if (order.Equals(theOrder))
                    orderToDelete = order;
            }
            ordersList.Remove(orderToDelete);
        }
        public Order QueryOrder(int id)
        {
            IEnumerable<Order> order = from o in ordersList
                           where o.OrderId == id
                           select o;
            Order theOrder = new Order();
            foreach (var o in order)
                theOrder = o;
            return theOrder;
        }
        public void ModifyOrder(Order oldOrder, Order newOrder)
        {
            ordersList.Remove(oldOrder);
            ordersList.Add(newOrder);
        }
    }
}
