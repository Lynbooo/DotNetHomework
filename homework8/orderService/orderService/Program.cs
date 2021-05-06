using System;

namespace orderService
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService administrator = new OrderService();
            char controller = '1';
            int counter = 0;
            String id;
            String filePath = @"ordersFile.xml";
            administrator.Import(filePath);
            Console.WriteLine(
                      "1: Add new order" + "\r\n"
                    + "2: Delete order" + "\r\n"
                    + "3: Modify an order" + "\r\n"
                    + "4: Query an order" + "\r\n"
                    + "0: Quit"
                    );
            Order order;
            while (controller != '0')
            {
                Console.WriteLine("please enter the number corresponding to the amendment:");
                //controller = Convert.ToInt32(Console.ReadLine());
                controller = Convert.ToChar(Console.ReadLine());
                switch (controller)
                {
                    case '1':
                        Console.WriteLine("please enter ClientName:");
                        String clientName = Console.ReadLine();
                        Console.WriteLine("please enter ClientTel:");
                        String clientTel = Console.ReadLine();
                        Console.WriteLine("please enter ClientAddress:");
                        String clientAddress = Console.ReadLine();
                        Client newClientInfo = new Client(clientName, clientTel, clientAddress);
                        //2021040201
                        String orderId = Convert.ToString(DateTime.Now.Year)
                            + Convert.ToString(DateTime.Now.Month)
                            + Convert.ToString(DateTime.Now.Day)
                            + Convert.ToString(counter);
                        counter++;
                        Console.WriteLine("please enter OrderDiscount:");
                        double orderDiscount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("please enter GoodName:");
                        String goodName = Console.ReadLine();
                        Console.WriteLine("please enter GoodPrice:");
                        double goodPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("please enter new GoodNumber:");
                        int goodNumber = Convert.ToInt32(Console.ReadLine());
                        OrderDetails newDetail = new OrderDetails(goodName, goodPrice, goodNumber);
                        DateTime createTime = DateTime.Now;

                        order = new Order(newClientInfo, orderId, orderDiscount, createTime, newDetail);
                        administrator.AddOrder(order);
                        Console.WriteLine("newOrder:\r\n" + order);
                        break;
                    case '2':
                        Console.WriteLine("please enter order's Id which you want to delete:");
                        order = administrator.QueryOrder(Console.ReadLine());
                        administrator.DeleteOrder(order);
                        break;
                    case '3':
                        Console.WriteLine("please enter order's Id which you want to modify:");
                        id = Console.ReadLine();
                        order = administrator.QueryOrder(id);
                        Order modifiedOrder = Modify(order);
                        administrator.ModifyOrder(order, modifiedOrder);
                        Console.WriteLine("oldOrder:\r\n" + order + "newOrder:\r\n" + modifiedOrder);
                        break;
                    case '4':
                        Console.WriteLine("please enter order's Id which you want to query:");
                        id = Console.ReadLine();
                        order = administrator.QueryOrder(id);
                        Console.WriteLine(order);
                        break;
                    default:
                        break;
                }
            }
            administrator.Export(filePath);
            Order Modify(Order oldOrder)
            {
                Order modifiedOrder = oldOrder;
                char controller2 = '1';
                Console.WriteLine(
                          "1: ClientName" + "\r\n"
                        + "2: ClientTel" + "\r\n"
                        + "3: ClientAddress" + "\r\n"
                        + "4: OrderDiscount" + "\r\n"
                        + "5: OrderDetails" + "\r\n"
                        + "0: Quit"
                        );
                while (controller2 != '0')
                {
                    Console.WriteLine("please enter the number corresponding to the amendment:");
                    controller2 = Convert.ToChar(Console.ReadLine());
                    switch (controller2)
                    {
                        case '1':
                            Console.WriteLine("please enter new ClientName:");
                            modifiedOrder.ClientInfo.ClientName = Console.ReadLine();
                            break;
                        case '2':
                            Console.WriteLine("please enter new ClientTel:");
                            modifiedOrder.ClientInfo.ClientTel = Console.ReadLine();
                            break;
                        case '3':
                            Console.WriteLine("please enter new ClientAddress:");
                            modifiedOrder.ClientInfo.ClientAddress = Console.ReadLine();
                            break;
                        case '4':
                            Console.WriteLine("please enter new OrderDiscount:");
                            modifiedOrder.OrderDiscount = Convert.ToDouble(Console.ReadLine());
                            break;
                        case '5':
                            Console.WriteLine(modifiedOrder.OrderDetails);
                            OrderDetails detail = new OrderDetails();
                            Console.WriteLine("please enter new GoodName:");
                            detail.GoodName = Console.ReadLine();
                            Console.WriteLine("please enter new GoodPrice:");
                            detail.GoodPrice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("please enter new GoodNumber:");
                            detail.GoodNumber = Convert.ToInt32(Console.ReadLine());
                            modifiedOrder.AddOrderDetail(detail);
                            break;
                        default:
                            break;
                    }
                }
                return modifiedOrder;
            }
        }
    }
}
