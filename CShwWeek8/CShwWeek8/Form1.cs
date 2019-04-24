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
    public partial class Form1 : Form
    {
        public string[] sortChoices =  {"Id", "Total Price" };
        public string[] queryChoices = { "All", "Goods Name", "Custumer Name" };
        public uint Id { get; set; }
        public float TotalPrice { get; set; }
        public string QueryNameData { get; set; }

        OrderService os = new OrderService();
        BindingSource orderDataBS = new BindingSource();
        Form2 addForm;

        public void AddOrder(Order o)
        {
            os.AddOrder(o);
            orderDataBS.DataSource = null;
            orderDataBS.DataSource = os.QueryAllOrders();
        }

        public Form1()
        {
            InitializeComponent();
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9);
            Goods eggs = new Goods(2, "eggs", 4.99);
            Goods apple = new Goods(3, "apple", 5.59);

            OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
            OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
            OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            Order order3 = new Order(3, customer2);
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            //order1.AddOrderDetails(orderDetails3);
            order2.AddDetails(orderDetails2);
            order2.AddDetails(orderDetails3);
            order3.AddDetails(orderDetails3);

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);

            //数据绑定
            orderDataBS.DataSource = os.QueryAllOrders();
            dataGridView.DataSource = orderDataBS;
            textBoxForSearch.DataBindings.Add("Text", this, "Id");
            textBoxForQuery.DataBindings.Add("Text", this, "QueryNameData");
            comboBoxForQuery.DataSource = queryChoices;
            comboBoxForQuery.DisplayMember = queryChoices[0];
            comboBoxForSort.DataSource = sortChoices;
            comboBoxForSort.DisplayMember = sortChoices[0];

            addForm = new Form2(this);
            addForm.TopLevel = true;
        }

        private void buttonOfSort_Click(object sender, EventArgs e)
        {
            if (comboBoxForSort.SelectedText == "Id")
                os.SortOrderListById();
            else if (comboBoxForSort.SelectedText == "Total Price")
                os.SortOrderListBySumPrice();
            orderDataBS.DataSource = os.QueryAllOrders();
        }

        private void buttonForQuery_Click(object sender, EventArgs e)
        {
            if (comboBoxForQuery.SelectedIndex == 0)
                orderDataBS.DataSource = os.QueryAllOrders();
            else if (comboBoxForQuery.SelectedIndex == 1)
                orderDataBS.DataSource = os.QueryByGoodsName(QueryNameData);
            else if (comboBoxForQuery.SelectedIndex == 2)
                orderDataBS.DataSource = os.QueryByCustomerName(QueryNameData);
        }

        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            orderDataBS.DataSource = os.GetById(Id);
        }

        private void buttonForRemove_Click(object sender, EventArgs e)
        {
            uint selectedId = Convert.ToUInt32(dataGridView.CurrentRow.Cells[0].Value);
            os.RemoveOrder(selectedId);
            orderDataBS.DataSource = null;
            orderDataBS.DataSource = os.QueryAllOrders();
        }

        private void buttonForExport_Click(object sender, EventArgs e)
        {
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = ".\\";

            //设置文件类型 
            sfd.Filter = "*.temp|*.temp";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //设置默认的文件名
            sfd.FileName = "orderlist";

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                os.Export(localFilePath);
            }
        }

        private void buttonForImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = ".\\";
            openFileDialog.Filter = "*.temp|*.temp";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = openFileDialog.FileName.ToString();
                os.Import(localFilePath);
            }
            orderDataBS.DataSource = os.QueryAllOrders();
        }

        private void buttonForAdd_Click(object sender, EventArgs e)
        {
            addForm.ShowDialog();
        }
    }
}
