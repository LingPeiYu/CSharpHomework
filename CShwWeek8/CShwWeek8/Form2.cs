using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShwWeek8
{
    public partial class Form2 : Form
    {
        public uint Id { get; set; }
        public Customer c = new Customer();
        public List<OrderDetail> odl = new List<OrderDetail>();
        public OrderDetail orde = new OrderDetail();
        public int GoodsNum { get; set; }

        Order o;
        BindingSource bs;
        Form1 target;

        public Form2(Form1 target)
        {
            this.target = target;
            orde.Goods = new Goods();
            InitializeComponent();
            customId.DataBindings.Add("Text", c, "Id");
            customName.DataBindings.Add("Text", c, "Name");
            odId.DataBindings.Add("Text", orde, "Id");
            goodsId.DataBindings.Add("Text", orde.Goods, "Id");
            goodName.DataBindings.Add("Text", orde.Goods, "Name");
            goodPrice.DataBindings.Add("Text", orde.Goods, "Price");
            goodsNum.DataBindings.Add("Text", orde, "Quantity");
            Idtxt.DataBindings.Add("Text", this, "Id");
            bs = new BindingSource();
            bs.DataSource = odl;
            dataGridView.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odl.Add(orde);
            bs.DataSource = null;
            bs.DataSource = odl;
        }

        private void SureAdd_Click(object sender, EventArgs e)
        {
            o = new Order(Id,c);
            foreach (OrderDetail od in odl)
                o.AddDetails(od);
            target.AddOrder(o);
            this.Close();
        }
    }
}
