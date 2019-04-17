using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShwWeek7
{
    [Serializable]
    public class Order:IComparable
    {

        private List<OrderDetail> details=new List<OrderDetail>();

        public Order()
        {

        }
        public Order(uint orderId, Customer customer) {
            Id = orderId;
            Customer = customer;
        }

        public uint Id { get; set; }

        public Customer Customer { get; set; }


        public List<OrderDetail> Details {
            get =>this.details; }

        public void AddDetails(OrderDetail orderDetail) {
            if (this.Details.Contains(orderDetail))  {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            details.Add(orderDetail);
        }

        public void RemoveDetails(uint orderDetailId) {
            details.RemoveAll(d =>d.Id==orderDetailId);
        }

        public double GetSumPrice()
        {
            double sum = 0;
            foreach(OrderDetail od in details)
            {
                sum += (od.Goods.Price * od.Quantity);
            }
            return sum;
        }

        public override bool Equals(object obj)
        {
            Order b = obj as Order;
            return (b != null && Id == b.Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{Id} 顾客信息：{Customer.ToString()}\n订单明细：\n");
            foreach(OrderDetail o in details)
            {
                result.Append($"{o.ToString()}\n");
            }
            return result.ToString();
        }

        public int CompareTo(Object obj)
        {
            Order b = obj as Order;
            if(b==null)
            {
                throw new Exception($"Order cannot compare to {obj.ToString()}!");
            }
            if (Id > b.Id)
                return 1;
            else if (Id == b.Id)
                return 0;
            else
                return -1;
        }
    }
}
