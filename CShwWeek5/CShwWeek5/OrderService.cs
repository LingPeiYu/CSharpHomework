using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShwWeek5
{
    //实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    class OrderService
    {

        private List<Order> orderList;

        public OrderService()
        {
            orderList = new List<Order>();
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
            List<Order> result = new List<Order>();
            foreach (Order order in orderList)
            {
                foreach (OrderDetail detail in order.Details)
                {
                    if (detail.Goods.Name == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderList
                .Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }


        public void SortOrderListById()
        {
            orderList.Sort();
        }

        public void SortOrderListBySumPrice()
        {
            orderList.Sort((o1,o2)=>(int)(o1.GetSumPrice()-o2.GetSumPrice()));
        }
    }
}
