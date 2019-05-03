namespace OrderForm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Db : DbContext
    {
        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetail> orderDetail { get; set; }
        public DbSet<Goods> goods { get; set; }
        public DbSet<Customer> customer { get; set; }

        public Db()
            : base("name=Db")
        {
            Database.SetInitializer<Db>(new DropCreateDatabaseAlways<Db>());   
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
