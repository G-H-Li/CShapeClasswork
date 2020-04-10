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
    public partial class OrderItemForm : Form
    {
        private int itemId;
        private string itemName;
        private float price;
        private int quantity;
        public OrderItemForm()
        {
            InitializeComponent();
            tbItemID.Enabled = false;
        }

        public OrderItemForm(int id, string name, float price, int quantity) : this()
        {
            tbItemID.Text = id.ToString();
            tbItemName.Text = name;
            tbPerPrice.Text = price.ToString();
            tbQuantity.Text = quantity.ToString();
        }

        public int ItemId { get => itemId; set => itemId = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        private void BtnMakeSure_Click(object sender, EventArgs e)
        {
            try
            {
                this.Price = (float)Convert.ToDouble(tbPerPrice.Text);
                this.Quantity = Convert.ToInt32(tbQuantity.Text);
                this.itemName = tbItemName.Text;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            catch(Exception)
            {
                tbPerPrice.Clear();
                tbQuantity.Clear();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbItemName.Clear();
            tbPerPrice.Clear();
            tbQuantity.Clear();
        }
    }
}
