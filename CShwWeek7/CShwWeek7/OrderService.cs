using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CShwWeek7
{

    //实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    public class OrderService
    {

        private List<Order> orderList;

        private XmlSerializer xmlSer;

        public OrderService()
        {
            orderList = new List<Order>();
            xmlSer = new XmlSerializer(orderList.GetType());
        }

        public void AddOrder(Order order)
        {
            foreach (Order o in orderList)
            {
                if (o.Id.Equals(order.Id))
                {
                    throw new Exception($"order-{order.Id} is already existed!");
                }
            }
            orderList.Add(order);
        }

        public Order GetById(uint orderId)
        {
            foreach (Order o in orderList)
            {
                if (o.Id == orderId)
                {
                    return o;
                }
            }
            return null;
        }

        public void RemoveOrder(uint orderId)
        {
            Order order = GetById(orderId);
            if (order == null) return;
            orderList.Remove(order);
        }

        public List<Order> QueryAllOrders()
        {
            return orderList;
        }

        public List<Order> QueryByGoodsName(string goodsName)
        {
            var result = from o in orderList where o.Details.Exists(de => de.Goods.Name == goodsName) orderby o.Id select o;
            return result.ToList<Order>();

        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var result = orderList.Where(o => o.Customer.Name == customerName).OrderBy(o=>o.Id);
            return result.ToList<Order>();
        }


        public void SortOrderListById()
        {
            orderList.Sort();
        }

        public void SortOrderListBySumPrice()
        {
            orderList.Sort((o1,o2)=>(int)(o1.GetSumPrice()-o2.GetSumPrice()));
        }

        public void Export()
        {
            using (FileStream fs = new FileStream("orderList.temp",FileMode.Create))
            {
                xmlSer.Serialize(fs, orderList);
            }
        }

        public void Import()
        {
            using (FileStream fs = new FileStream("orderList.temp", FileMode.Open))
            {
                orderList=(List<Order>)xmlSer.Deserialize(fs);
            }
        }
    }
}
