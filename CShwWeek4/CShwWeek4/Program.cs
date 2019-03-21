using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShwWeek4
{
    //闹钟
    public class RingEventArgs:EventArgs
    {
        public int hour;
        public int minute;
    }

    public delegate void RingEventHandler(object sender, RingEventArgs e);

    class RingClock
    {
        public event RingEventHandler Ring;

        private int hour;
        private int minute;

        public void Set()
        {
            Console.WriteLine("请输入闹钟设定时间：");
            Console.Write("请输入 时：");
            while(!int.TryParse(Console.ReadLine(),out hour))
            {
                Console.Write("输入错误，请重新输入：");
            }
            Console.Write("请输入 分：");
            while (!int.TryParse(Console.ReadLine(), out minute))
            {
                Console.Write("输入错误，请重新输入：");
            }
        }

        public void ShowTime()
        {
            int nowh = DateTime.Now.Hour;
            int nowm = DateTime.Now.Minute;
            Console.Clear();
            Console.Write($"当前时间：{DateTime.Now.ToShortTimeString().ToString()}");
            while (DateTime.Now.Hour!=hour||DateTime.Now.Minute!=minute)
            {
                if (nowh != DateTime.Now.Hour|| nowm != DateTime.Now.Minute)
                {
                    nowh = DateTime.Now.Hour;
                    nowm = DateTime.Now.Minute;
                    Console.Clear();
                    Console.Write($"当前时间：{DateTime.Now.ToShortTimeString().ToString()}");
                }
            }
            Console.WriteLine();
            RingEventArgs e = new RingEventArgs();
            e.hour = hour;
            e.minute = minute;
            Ring(this, e);
        }
    }

    class UseRingClock
    {
        RingClock rc = new RingClock();

        public void Use()
        {
            Console.WriteLine("闹钟程序");
            rc.Ring += Ring;
            rc.Set();
            rc.ShowTime();
        }

        public void Ring(object sender,RingEventArgs e)
        {
            Console.WriteLine($"已到达设置时间{e.hour}:{e.minute}");
        }
    }


    //订单管理
    class Order
    {
        OrderService os = new OrderService();
        public void OrderProRun()
        {
            int choice;
            bool esc=false;
            Console.WriteLine("订单管理");
            while (!esc)
            {
                Console.Write("1、添加订单 2、删除订单 3、修改订单 4、查询订单 5、退出\n请输入操作（1/2/3/4/5）：");
                int.TryParse(Console.ReadLine(), out choice);
                while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5)
                {
                    Console.Write("输入错误，请重新输入：");
                    int.TryParse(Console.ReadLine(), out choice);
                }
                switch (choice)
                {
                    case 1:
                        os.AddOrder();
                        break;
                    case 2:
                        os.DeleteOrder();
                        break;
                    case 3:
                        os.ChangeOrder();
                        break;
                    case 4:
                        os.SearchOrder();
                        break;
                    case 5:
                        esc = true;
                        break;
                }
            }
        }
    }

    class OrderDetails
    {
        public int numOfOrder;
        public string commodityName;
        public string customer;
    }

    class OrderService
    {
        public List<OrderDetails> orderList = new List<OrderDetails>();

        public void SearchOrder()
        {
            int choice;
            int count;
            bool match;
            string key;
            Console.Write("1、按订单号查询 2、按商品名称查询 3、按客户查询\n请输入查询方式（1/2/3）：");
            int.TryParse(Console.ReadLine(), out choice);
            while(choice!=1&&choice!=2&&choice!=3)
            {
                Console.Write("输入错误，请重新输入：");
                int.TryParse(Console.ReadLine(), out choice);
            }
            Console.Write("请输入查询信息：");
            key = Console.ReadLine();
            count = 0;
            for (int i = 0; i < orderList.Count; i++)
            {
                switch(choice)
                {
                    case 1:
                        match = (key == orderList[i].numOfOrder.ToString());
                        break;
                    case 2:
                        match = (key == orderList[i].commodityName);
                        break;
                    case 3:
                        match = (key == orderList[i].customer);
                        break;
                    default:
                        match = false;
                        break;
                }
                if (match)
                {
                    Console.WriteLine($"{i} 订单号：{orderList[i].numOfOrder} 商品名称：{orderList[i].commodityName} 客户：{orderList[i].customer}");
                    count++;
                }
            }
            Console.WriteLine($"查询完毕，找到{count}个订单");
        }

        public void AddOrder()
        {
            int num;
            OrderDetails newOrder = new OrderDetails();
            Console.Write("请输入订单号：");
            while(!int.TryParse(Console.ReadLine(),out num))
                Console.Write("输入错误，请重新输入：");
            newOrder.numOfOrder = num;
            Console.Write("请输入商品名称：");
            newOrder.commodityName = Console.ReadLine();
            Console.Write("请输入客户：");
            newOrder.customer = Console.ReadLine();
            orderList.Add(newOrder);
            Console.WriteLine("添加成功");
        }

        public void ChangeOrder()
        {
            try
            {
                int numL;
                int choice;
                Console.Write("请输入修改订单列表内序号：");
                numL = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入修改内容序号(1、订单号 2、商品名称 3、客户）：");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入修改内容：");
                switch (choice)
                {
                    case 1:
                        orderList[numL].numOfOrder = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        orderList[numL].commodityName = Console.ReadLine();
                        break;
                    case 3:
                        orderList[numL].customer = Console.ReadLine();
                        break;
                }
                Console.WriteLine($"修改成功，修改后内容为:\n{numL} 订单号：{orderList[numL].numOfOrder} 商品名称：{orderList[numL].commodityName} 客户：{orderList[numL].customer}");
            }
            catch
            {
                Console.WriteLine("操作发生异常，请检查输入");
            }
        }

        public void DeleteOrder()
        {
            try
            {
                int numL;
                Console.Write("请输入删除订单列表内序号：");
                numL = Convert.ToInt32(Console.ReadLine());
                orderList.RemoveAt(numL);
                Console.WriteLine("删除成功");
            }
            catch
            {
                Console.WriteLine("操作发生异常，请检查输入");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UseRingClock urc = new UseRingClock();
            urc.Use();
            Console.WriteLine("按任意键继续");
            Console.ReadKey();
            Console.Clear();
            Order order = new Order();
            order.OrderProRun();
        }
    }
}
