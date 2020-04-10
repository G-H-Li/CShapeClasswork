namespace OrderWinform
{
    partial class OrderItemForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPerPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbPerPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMakeSure = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnMakeSure, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPerPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbItemName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPerPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblItemName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblItemId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbItemID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemId.Location = new System.Drawing.Point(3, 3);
            this.lblItemId.Margin = new System.Windows.Forms.Padding(3);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(80, 75);
            this.lblItemId.TabIndex = 0;
            this.lblItemId.Text = "序列号：";
            this.lblItemId.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.Location = new System.Drawing.Point(175, 3);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(3);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(80, 75);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "商品名称：";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPerPrice
            // 
            this.lblPerPrice.AutoSize = true;
            this.lblPerPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerPrice.Location = new System.Drawing.Point(3, 84);
            this.lblPerPrice.Margin = new System.Windows.Forms.Padding(3);
            this.lblPerPrice.Name = "lblPerPrice";
            this.lblPerPrice.Size = new System.Drawing.Size(80, 75);
            this.lblPerPrice.TabIndex = 5;
            this.lblPerPrice.Text = "单价：";
            this.lblPerPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Location = new System.Drawing.Point(175, 84);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(3);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 75);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "数量：";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbItemID
            // 
            this.tbItemID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbItemID.Location = new System.Drawing.Point(89, 57);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(80, 21);
            this.tbItemID.TabIndex = 8;
            // 
            // tbItemName
            // 
            this.tbItemName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbItemName.Location = new System.Drawing.Point(261, 57);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(80, 21);
            this.tbItemName.TabIndex = 9;
            // 
            // tbPerPrice
            // 
            this.tbPerPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPerPrice.Location = new System.Drawing.Point(89, 138);
            this.tbPerPrice.Name = "tbPerPrice";
            this.tbPerPrice.Size = new System.Drawing.Size(80, 21);
            this.tbPerPrice.TabIndex = 10;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbQuantity.Location = new System.Drawing.Point(261, 138);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(80, 21);
            this.tbQuantity.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Location = new System.Drawing.Point(89, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnMakeSure
            // 
            this.btnMakeSure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMakeSure.Location = new System.Drawing.Point(175, 218);
            this.btnMakeSure.Name = "btnMakeSure";
            this.btnMakeSure.Size = new System.Drawing.Size(80, 23);
            this.btnMakeSure.TabIndex = 14;
            this.btnMakeSure.Text = "确认";
            this.btnMakeSure.UseVisualStyleBackColor = true;
            this.btnMakeSure.Click += new System.EventHandler(this.BtnMakeSure_Click);
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 244);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderItemForm";
            this.Text = "订单项目处理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPerPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Button btnMakeSure;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPerPrice;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Button btnClear;
    }
}