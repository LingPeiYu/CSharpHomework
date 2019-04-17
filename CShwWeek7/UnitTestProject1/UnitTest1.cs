using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using CShwWeek7;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest_OrderService
    {
        Customer customer1;
        Customer customer2;

        Goods milk;
        Goods eggs;
        Goods apple;

        OrderDetail orderDetails1;
        OrderDetail orderDetails2;
        OrderDetail orderDetails3;

        Order order1;
        Order order2;
        Order order3;

        bool haveInitial = false;

        OrderService os = new OrderService();
        List<Order> orders;
        List<Order> orderList;
        XmlSerializer xmlSer;

        private void Initialize()
        {
            customer1 = new Customer(1, "Customer1");
            customer2 = new Customer(2, "Customer2");

            milk = new Goods(1, "Milk", 69.9);
            eggs = new Goods(2, "eggs", 4.99);
            apple = new Goods(3, "apple", 5.59);

            orderDetails1 = new OrderDetail(1, apple, 8);
            orderDetails2 = new OrderDetail(2, eggs, 2);
            orderDetails3 = new OrderDetail(3, milk, 1);

            order1 = new Order(1, customer1);
            order2 = new Order(2, customer2);
            order3 = new Order(3, customer2);
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            //order1.AddOrderDetails(orderDetails3);
            order2.AddDetails(orderDetails2);
            order2.AddDetails(orderDetails3);
            order3.AddDetails(orderDetails3);

            os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);

            orderList = new List<Order>() { order1, order2 };

            xmlSer = new XmlSerializer(orderList.GetType());

            haveInitial = true;
        }

        [TestMethod]
        public void TestMethod_GetById1()
        {
            if (!haveInitial)
                Initialize();
            Order result = os.GetById(2);
            Assert.IsTrue(result.Id==2);
        }
        [TestMethod]
        public void TestMethod_GetById2()
        {
            if (!haveInitial)
                Initialize();
            Order result = os.GetById(90);
            Assert.IsNull(result);
        }
        [TestMethod]
        public void TestMethod_AddOrder()
        {
            if (!haveInitial)
                Initialize();
            os.AddOrder(order3);
            Assert.IsNotNull(os.GetById(order3.Id));

        }
        [TestMethod]
        public void TestMethod_RemoveOrder()
        {
            if (!haveInitial)
                Initialize();
            os.RemoveOrder(order3.Id);
            Assert.IsNull(os.GetById(order3.Id));
        }
        [TestMethod]
        public void TestMethod_QueryAllOrders()
        {
            if (!haveInitial)
                Initialize();
            orders = os.QueryAllOrders();
            bool result = false;
            if (orders.Count == orderList.Count)
            {
                result = true;
                for (int i = 0; i < orders.Count - 1; i++)
                    if (!orders[i].Equals(orderList[i]))
                        result = false;
            }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod_QueryByGoodsName()
        {
            if (!haveInitial)
                Initialize();
            orders = os.QueryByGoodsName("apple");
            bool result = true;
            foreach (Order o in orders)
                if (!o.Details.Exists(de => de.Goods.Name == "apple"))
                    result = false;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod_QueryByCustomerName()
        {
            if (!haveInitial)
                Initialize();
            orders = os.QueryByCustomerName("Customer2");
            bool result = true;
            foreach (Order o in orders)
                if (o.Customer.Name != "Customer2")
                    result = false;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod_SortOrderListById()
        {
            if (!haveInitial)
                Initialize();
            bool result = true;
            os.SortOrderListById();
            orders = os.QueryAllOrders();
            for (int i = 0; i < orders.Count - 1; i++)
                if (orders[i].Id > orders[i + 1].Id)
                    result = false;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod_SortOrderListBySumPrice()
        {
            if (!haveInitial)
                Initialize();
            bool result = true;
            os.SortOrderListBySumPrice();
            orders = os.QueryAllOrders();
            for (int i = 0; i < orders.Count - 1; i++)
                if (orders[i].GetSumPrice() > orders[i + 1].GetSumPrice())
                    result = false;
            Assert.IsTrue(result);
        }
       [TestMethod]
        public void TestMethod_Export()
        {
            if (!haveInitial)
                Initialize();
            os.Export();
            bool result = false;
            orderList = os.QueryAllOrders();
            using (FileStream fs = new FileStream("orderList.temp", FileMode.Open))
            {
                orders = (List<Order>)xmlSer.Deserialize(fs);
                if (orders.Count == orderList.Count)
                {
                    result = true;
                    for (int i = 0; i < orders.Count - 1; i++)
                        if (!orders[i].Equals(orderList[i]))
                            result = false;
                }
            }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod_Import()
        {
            if (!haveInitial)
                Initialize();
            bool result = false;
            orderList = os.QueryAllOrders();
            os.Export();
            os.Import();
            orders = os.QueryAllOrders();
            if (orders.Count == orderList.Count)
            {
                result = true;
                for (int i = 0; i < orders.Count - 1; i++)
                    if (!orders[i].Equals(orderList[i]))
                        result = false;
            }
            Assert.IsTrue(result);
        }
    }
}
