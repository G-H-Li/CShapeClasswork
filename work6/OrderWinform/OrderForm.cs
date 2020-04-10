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
    public partial class OrderForm : Form
    {
        private string buyerName;
        private string sellerName;

        public string BuyerName { get => buyerName; set => buyerName = value; }
        public string SellerName { get => sellerName; set => sellerName = value; }

        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(int id, string time, string buyer, string seller): this()
        {
            tbOrderID.Text = id.ToString();
            tbOrderTime.Text = time;
            tbBuyer.Text = buyer;
            tbSeller.Text = seller;
        }

        private void BtnMakeSure_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbBuyer.Clear();
            tbSeller.Clear();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.SellerName = tbSeller.Text;
            this.BuyerName = tbBuyer.Text;
        }
    }
}
