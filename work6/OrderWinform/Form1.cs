using ClassOrderManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinform
{
    public partial class Form1 : Form
    {
        OrderService service = new OrderService();
        public Form1()
        {
            Random random = new Random();
            InitializeComponent();
            service.AddOrder("陆先生", "华为");
            service.orders[0].AddItem("手机", random.Next(1000, 2000), random.Next(1, 5));
            service.orders[0].AddItem("耳机", random.Next(50, 1000), random.Next(2, 5));
            service.orders[0].AddItem("耳机", random.Next(50, 1000), random.Next(5, 10));
            service.AddOrder("li先生", "oppo");
            service.orders[1].AddItem("手机", random.Next(1000, 2000), random.Next(1, 5));
            service.orders[1].AddItem("耳机", random.Next(50, 1000), random.Next(2, 5));
            bindingSourceOrder.DataSource = service.orders;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string buyer = tbBuyer.Text;
            string seller = tbSeller.Text;
            if(tbOrderId.Text == ""&& buyer == "" && seller == "")
            {
                bindingSourceOrder.DataSource = service.orders;
            }
            if (tbOrderId.Text != "")
            {
                try
                {
                    int id = Convert.ToInt32(tbOrderId.Text);
                    bindingSourceOrder.DataSource = service.SearchOrders(id, "", -1, -1);
                }
                catch(Exception)
                {
                    tbOrderId.Clear();
                }
            }
            else if (buyer != "" || seller != "")
            {
                bindingSourceOrder.DataSource = service.SearchOrders(buyer, seller);
            }
        }

        private void BtnSearchInfoClear_Click(object sender, EventArgs e)
        {
            tbOrderId.Clear();
            tbBuyer.Clear();
            tbSeller.Clear();
        }

        private void ExportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择要保存的位置";
            saveFileDialog.InitialDirectory = "C://";
            saveFileDialog.Filter = "XML文件(*.xml)|*.xml";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                service.Export(path);
            }
        }

        private void ImportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的文件";
            openFileDialog.InitialDirectory = "C://";
            openFileDialog.Filter = "XML文件(*.xml)|*.xml";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                service.Import(path);
            }
        }

        private void AddNewOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            if(orderForm.ShowDialog() == DialogResult.Yes)
            {
                Order added= (Order)dataGridViewOrder.CurrentRow.DataBoundItem;
                service.AddOrder(added, orderForm.BuyerName, orderForm.SellerName);
            }
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            for(int i=0; i < dataGridViewOrder.SelectedRows.Count; i++)
            {
                Order selected = (Order)dataGridViewOrder.SelectedRows[i].DataBoundItem;
                service.DeleteOrder(selected.Id);
            }
        }

        private void AddOrderItem_Click(object sender, EventArgs e)
        {
            OrderItemForm orderItemForm = new OrderItemForm();
            if(orderItemForm.ShowDialog() == DialogResult.Yes)
            {
                Order selectedOrder = (Order)dataGridViewOrder.CurrentRow.DataBoundItem;
                OrderItem item = (OrderItem)dataGridViewOrderItem.CurrentRow.DataBoundItem;
                service.orders[selectedOrder.Id].AddItem(item, orderItemForm.ItemName, orderItemForm.Price, orderItemForm.Quantity);
            }
        }

        private void DeleteOrderItem_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)dataGridViewOrder.CurrentRow.DataBoundItem;
            for (int i = 0; i < dataGridViewOrderItem.SelectedRows.Count; i++)
            {
                OrderItem selectedItem = (OrderItem)dataGridViewOrderItem.SelectedRows[i].DataBoundItem;
                service.DeleteOrderItem(selectedOrder.Id, selectedItem.Id);
            }
        }

        private void BtnSearchOrderItem_Click(object sender, EventArgs e)
        {
            //处理输入
            string name = tbItemName.Text;
            float price = -1;
            int quantity = -1;
            try
            {
                if (tbPerPrice.Text != "")
                {
                    price = (float)Convert.ToDouble(tbPerPrice.Text);
                }
                if (tbQuantity.Text != "")
                {
                    quantity = Convert.ToInt32(tbQuantity.Text);
                }
            }
            catch(Exception)
            {
                tbPerPrice.Clear();
                tbQuantity.Clear();
                bindingSourceOrderItem.DataSource = itemsBindingSource;
            }
            //进行查询
            if (tbItemName.Text == "" && tbPerPrice.Text == "" && tbQuantity.Text == "")
            {
                bindingSourceOrderItem.DataSource = itemsBindingSource;
                return;
            }
            Order selectedOrder = (Order)dataGridViewOrder.CurrentRow.DataBoundItem;
            bindingSourceOrderItem.DataSource = service.SearchOrders(selectedOrder.Id, name, price, quantity);
        }

        private void BtnModifyOrder_Click(object sender, EventArgs e)
        {
            if(dataGridViewOrder.SelectedRows.Count <= 0)
            {
                return;
            }
            Order selectedOrder = (Order)dataGridViewOrder.SelectedRows[0].DataBoundItem;
            OrderForm orderForm = new OrderForm(selectedOrder.Id,selectedOrder.Time,selectedOrder.BuyerName,selectedOrder.SellerName);
            if (orderForm.ShowDialog() == DialogResult.Yes)
            {
                service.ModifyOrderHeader(selectedOrder.Id, orderForm.BuyerName, orderForm.SellerName);
            }
        }

        private void BtnModifyItem_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)dataGridViewOrder.CurrentRow.DataBoundItem;
            OrderItem item = (OrderItem)dataGridViewOrderItem.CurrentRow.DataBoundItem;
            OrderItemForm orderItemForm = new OrderItemForm(item.Id,item.ItemName,item.UnitPrice,item.Quantity);
            if (orderItemForm.ShowDialog() == DialogResult.Yes)
            {
                service.orders[selectedOrder.Id].ModifyItem
                    (item.Id,
                    orderItemForm.ItemName,
                    orderItemForm.Price,
                    orderItemForm.Quantity);
            }
        }
    }
}
