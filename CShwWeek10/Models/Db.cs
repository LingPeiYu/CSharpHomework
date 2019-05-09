using Microsoft.EntityFrameworkCore;

namespace CShwWeek10.Models
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options)
            : base(options)
        {
        }

        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetail> orderDetail { get; set; }
        public DbSet<Goods> goods { get; set; }
        public DbSet<Customer> customer { get; set; }
    }
}