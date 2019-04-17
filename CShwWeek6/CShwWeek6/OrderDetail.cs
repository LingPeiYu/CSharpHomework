using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShwWeek7
{
    [Serializable]
    public class OrderDetail
    {
        public OrderDetail()
        {

        }

        public OrderDetail(uint id, Goods goods, uint quantity)
        {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
        }

        public uint Id { get; set; }

        public Goods Goods { get; set; }

        public uint Quantity { get; set; }

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
            return ($"{Id} 货物信息:{Goods.ToString()} 量:{Quantity}");
        }
    }
}
