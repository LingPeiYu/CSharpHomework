using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShwWeek5
{
    [Serializable]
    public class Customer
    {

        public uint Id { get; set; }

        public string Name { get; set; }

        public Customer()
        {

        }

        public Customer(uint id, string name) {
            this.Id = id;
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            Customer b = obj as Customer;
            return (b != null && Id == b.Id && Name == b.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
