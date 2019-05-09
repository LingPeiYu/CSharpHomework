using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CShwWeek10.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CShwWeek10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly Db _context;

        public OrdersController(Db context)
        {
            _context = context;
            
            if (_context.order.Count() == 0)
            {
                Customer customer1 = new Customer(1, "Customer1");
                _context.customer.Add(customer1);
                 Customer customer2 = new Customer(2, "Customer2");
                 _context.customer.Add(customer2);

                 Goods milk = new Goods(1, "Milk", 69.9f);
                 _context.goods.Add(milk);
                 Goods eggs = new Goods(2, "eggs", 4.99f);
                 _context.goods.Add(eggs);
                 Goods apple = new Goods(3, "apple", 5.59f);
                 _context.goods.Add(apple);

                 Order order1 = new Order(1, customer1);
                 order1.AddDetails(new OrderDetail(apple, 8));
                 order1.AddDetails(new OrderDetail(eggs, 10));
                 order1.AddDetails(new OrderDetail(milk, 10));

                 Order order2 = new Order(2, customer2);
                 order2.AddDetails(new OrderDetail(eggs, 10));
                 order2.AddDetails(new OrderDetail(milk, 10));

                 Order order3 = new Order(3, customer2);
                 order3.AddDetails(new OrderDetail(milk, 100));
                _context.order.Add(order1);
                _context.order.Add(order2);
                _context.order.Add(order3);
                _context.SaveChanges();
            }
            
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.order.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(long id)
        {
            //var order = await _context.order.FindAsync(id);
            var order = await _context.order.FirstOrDefaultAsync(o=>o.Id==id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order item)
        {
            _context.order.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrder), new { id = item.Id }, item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(long id, Order item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(long id)
        {
            //var orderItem = await _context.order.FindAsync(id);
            var orderItem = await _context.order.FirstOrDefaultAsync(o=>o.Id==id);

            if (orderItem == null)
            {
                return NotFound();
            }

            _context.order.Remove(orderItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
