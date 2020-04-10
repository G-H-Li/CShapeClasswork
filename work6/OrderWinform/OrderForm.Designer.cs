namespace OrderWinform
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrderId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMakeSure = new System.Windows.Forms.Button();
            this.tbSeller = new System.Windows.Forms.TextBox();
            this.tbBuyer = new System.Windows.Forms.TextBox();
            this.tbOrderTime = new System.Windows.Forms.TextBox();
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderId.Location = new System.Drawing.Point(3, 3);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(3);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(81, 77);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "订单号：";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnMakeSure, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSeller, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbBuyer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbOrderTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSeller, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBuyer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbOrderID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 251);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnMakeSure
            // 
            this.btnMakeSure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMakeSure.Location = new System.Drawing.Point(177, 225);
            this.btnMakeSure.Name = "btnMakeSure";
            this.btnMakeSure.Size = new System.Drawing.Size(81, 23);
            this.btnMakeSure.TabIndex = 14;
            this.btnMakeSure.Text = "确认";
            this.btnMakeSure.UseVisualStyleBackColor = true;
            this.btnMakeSure.Click += new System.EventHandler(this.BtnMakeSure_Click);
            // 
            // tbSeller
            // 
            this.tbSeller.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbSeller.Location = new System.Drawing.Point(264, 142);
            this.tbSeller.Name = "tbSeller";
            this.tbSeller.Size = new System.Drawing.Size(83, 21);
            this.tbSeller.TabIndex = 11;
            // 
            // tbBuyer
            // 
            this.tbBuyer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBuyer.Location = new System.Drawing.Point(90, 142);
            this.tbBuyer.Name = "tbBuyer";
            this.tbBuyer.Size = new System.Drawing.Size(81, 21);
            this.tbBuyer.TabIndex = 10;
            // 
            // tbOrderTime
            // 
            this.tbOrderTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbOrderTime.Location = new System.Drawing.Point(264, 59);
            this.tbOrderTime.Name = "tbOrderTime";
            this.tbOrderTime.ReadOnly = true;
            this.tbOrderTime.Size = new System.Drawing.Size(83, 21);
            this.tbOrderTime.TabIndex = 9;
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeller.Location = new System.Drawing.Point(177, 86);
            this.lblSeller.Margin = new System.Windows.Forms.Padding(3);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(81, 77);
            this.lblSeller.TabIndex = 7;
            this.lblSeller.Text = "卖家：";
            this.lblSeller.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuyer.Location = new System.Drawing.Point(3, 86);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(3);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(81, 77);
            this.lblBuyer.TabIndex = 5;
            this.lblBuyer.Text = "买家：";
            this.lblBuyer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderTime.Location = new System.Drawing.Point(177, 3);
            this.lblOrderTime.Margin = new System.Windows.Forms.Padding(3);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(81, 77);
            this.lblOrderTime.TabIndex = 2;
            this.lblOrderTime.Text = "订单时间：";
            this.lblOrderTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbOrderID.Location = new System.Drawing.Point(90, 59);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(81, 21);
            this.tbOrderID.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Location = new System.Drawing.Point(90, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderForm";
            this.Text = "订单处理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMakeSure;
        private System.Windows.Forms.TextBox tbSeller;
        private System.Windows.Forms.TextBox tbBuyer;
        private System.Windows.Forms.TextBox tbOrderTime;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblOrderTime;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Button btnClear;
    }
}