using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace orderService
{
    public class OrderService
    {
        public List<Order> ordersList = new List<Order>();
        public OrderService() { }
        public bool AddOrder(Order newOrder)
        {
            foreach (Order order in ordersList)
            {
                if (order.Equals(newOrder))
                    throw new ArgumentOutOfRangeException("invalid order");
            }
            ordersList.Add(newOrder);
            ordersList.Sort((o1, o2) => Convert.ToInt32(o1.OrderId) - Convert.ToInt32(o2.OrderId));
            return true;
        }
        public bool DeleteOrder(Order theOrder)
        {
            Order orderToDelete = new Order();
            foreach (Order order in ordersList)
            {
                if (order.Equals(theOrder))
                    orderToDelete = order;
            }
            ordersList.Remove(orderToDelete);
            return true;
        }
        public Order QueryOrder(String id)
        {
            IEnumerable<Order> order = from o in ordersList
                                       where o.OrderId == id
                                       select o;
            Order theOrder = new Order();
            foreach (var o in order)
                theOrder = o;
            return theOrder;
        }
        public bool ModifyOrder(Order oldOrder, Order newOrder)
        {
            ordersList.Remove(oldOrder);
            ordersList.Add(newOrder);
            return true;
        }

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
        //根据xmlserializer来把对象序列化成XML，必须至少有一个参数为空的构造函数
        public void Export(String filePath) //将所有order序列化为XML文件
        {
            if (Path.GetExtension(filePath) != ".xml") throw new ArgumentException("文件类型错误");
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fs, this.ordersList);
            }
        }
        public void Import(String filePath) //从XML文件中载入订单
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (Path.GetExtension(filePath) != ".xml") throw new ArgumentException("文件类型错误");
                ordersList.Clear(); //清空ordersList集合中所有的元素对象
                if (fs.Length != 0)
                    this.ordersList = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
    }
}
