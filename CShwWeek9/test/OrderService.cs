using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MySql.Data;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System.Data.Entity;

namespace test {
  /// <summary>
  /// OrderService
  /// </summary>
  public class OrderService {
    private List<Order> orderList;
    private Db db;
        public Db DB { get => this.db; }
    /// <summary>
    /// constructor
    /// </summary>
    public OrderService() {
      orderList = new List<Order>();
            db = new Db();
    }

    /// <summary>
    /// add new order
    /// </summary>
    /// <param name="order">the order to be added</param>
    public void AddOrder(Order order) {
            if (db.order != null)
            {
                foreach (Order o in db.order)
                {
                    if (o.Id == order.Id)
                        throw new ApplicationException($"the orderList contains an order with ID {order.Id} !");
                }
                db.order.Add(order);
            }
            else
                db.order.Add(order);
            db.SaveChanges();
        }

    /// <summary>
    /// update the order
    /// </summary>
    /// <param name="order">the order to be updated</param>
    public void Update(Order order) {
            using (var db = new Db())
            {
                db.order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    /// <summary>
    /// query by orderId
    /// </summary>
    /// <param name="orderId">id of the order to find</param>
    /// <returns>List<Order></returns> 
    public Order GetById(int orderId) {
            using (var db = new Db())
            {
                var result = db.order.SingleOrDefault(o => o.Id == orderId);
                return result;
            }
    }

    /// <summary>
    /// remove order
    /// </summary>
    /// <param name="orderId">id of the order which will be removed</param> 
    public void RemoveOrder(int orderId) {
            if (db.order != null)
            {
                var result = db.order.SingleOrDefault(o => o.Id == orderId);
                db.orderDetail.RemoveRange(result.Details);
                db.order.Remove(result);
                db.SaveChanges();
            }
        }

    /// <summary>
    /// query all orders
    /// </summary>
    /// <returns>List<Order>:all the orders</returns> 
    public List<Order> QueryAll() {
            if (db.order != null)
            {
                var result = db.order.ToList();
                return result;
            }
            else
                return null;
        }


    /// <summary>
    /// query by goodsName
    /// </summary>
    /// <param name="goodsName">the name of goods in order's orderDetail</param>
    /// <returns></returns> 
    public List<Order> QueryByGoodsName(string goodsName) {
            if (db.order != null)
            {
                var q = db.order.Include("Details").ToList();
                List<Order> result = q.Where(o => o.Details.Exists(d => d.Goods.Name == goodsName)).ToList();
                return result;
            }
            else
                return null;
    }

    /// <summary>
    /// query orders whose totalAmount >= totalAmount
    /// </summary>
    /// <param name="totalAmount">the minimum totalAmount</param>
    /// <returns></returns> 
    public List<Order> QueryByTotalAmount(float totalAmount) {
            if (db.order != null)
            {
                var q = db.order.ToList();
                List<Order> result = q.Where(o => o.TotalAmount >= totalAmount).ToList();
                return result.ToList();
            }
            else
                return null;
        }

    /// <summary>
    /// query by customerName
    /// </summary>
    /// <param name="customerName">customer name</param>
    /// <returns></returns> 
    public List<Order> QueryByCustomerName(string customerName) {
            if (db.order != null)
            {
                var result = db.order.Where(o => o.Customer.Name == customerName);
                return result.ToList();
            }
            else
                return null;
        }

    public void Sort(Comparison<Order> comparison) {
      orderList.Sort(comparison);
    }

    /// <summary>
    /// Exprot the orders to an xml file.
    /// </summary>
    public void Export(String fileName) {
      if (Path.GetExtension(fileName) != ".xml")
        throw new ArgumentException("the exported file must be a xml file!");
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
                if (db.order != null)
                {
                    var result = db.order.ToList<Order>();
                    xs.Serialize(fs, result);
                }
                //xs.Serialize(fs, this.orderList);
      }
    }

    /// <summary>
    /// import from an xml file
    /// </summary>
    public List<Order> Import(string path) {
      if (Path.GetExtension(path) != ".xml")
        throw new ArgumentException($"{path} isn't a xml file!");
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      List<Order> result = new List<Order>();
      try {
        using (FileStream fs = new FileStream(path, FileMode.Open)) {
          return (List<Order>)xs.Deserialize(fs);
        }
      }catch(Exception e) {
        throw new ApplicationException("import error:" + e.Message);
      }
     
    }

  }
}
