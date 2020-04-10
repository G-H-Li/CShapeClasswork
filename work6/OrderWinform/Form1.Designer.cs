namespace OrderWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.导入xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出xml文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblpOrderSearch = new System.Windows.Forms.TableLayoutPanel();
            this.scSearchContent = new System.Windows.Forms.SplitContainer();
            this.lblOrderSearchId = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.lblSearchBuyer = new System.Windows.Forms.Label();
            this.tbBuyer = new System.Windows.Forms.TextBox();
            this.lblSearchSeller = new System.Windows.Forms.Label();
            this.tbSeller = new System.Windows.Forms.TextBox();
            this.btnSearchInfoClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrderItem = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.bindingSourceOrderItem = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorOrder = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewOrder = new System.Windows.Forms.ToolStripButton();
            this.DeleteOrder = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorOrderItem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AddOrderItem = new System.Windows.Forms.ToolStripButton();
            this.DeleteOrderItem = new System.Windows.Forms.ToolStripButton();
            this.btnSearchItem = new System.Windows.Forms.ToolStripButton();
            this.lblItemName = new System.Windows.Forms.ToolStripLabel();
            this.tbItemName = new System.Windows.Forms.ToolStripTextBox();
            this.lblPerPrice = new System.Windows.Forms.ToolStripLabel();
            this.tbPerPrice = new System.Windows.Forms.ToolStripTextBox();
            this.lblQuantity = new System.Windows.Forms.ToolStripLabel();
            this.tbQuantity = new System.Windows.Forms.ToolStripTextBox();
            this.btnModifyOrder = new System.Windows.Forms.ToolStripButton();
            this.btnModifyItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            this.tblpOrderSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSearchContent)).BeginInit();
            this.scSearchContent.Panel1.SuspendLayout();
            this.scSearchContent.Panel2.SuspendLayout();
            this.scSearchContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOrder)).BeginInit();
            this.bindingNavigatorOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOrderItem)).BeginInit();
            this.bindingNavigatorOrderItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1088, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.CheckOnClick = true;
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入xmlToolStripMenuItem,
            this.导出xml文件ToolStripMenuItem});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(44, 21);
            this.miFile.Text = "文件";
            // 
            // 导入xmlToolStripMenuItem
            // 
            this.导入xmlToolStripMenuItem.Name = "导入xmlToolStripMenuItem";
            this.导入xmlToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.导入xmlToolStripMenuItem.Text = "导入xml文件";
            this.导入xmlToolStripMenuItem.Click += new System.EventHandler(this.ImportXMLToolStripMenuItem_Click);
            // 
            // 导出xml文件ToolStripMenuItem
            // 
            this.导出xml文件ToolStripMenuItem.Name = "导出xml文件ToolStripMenuItem";
            this.导出xml文件ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.导出xml文件ToolStripMenuItem.Text = "导出xml文件";
            this.导出xml文件ToolStripMenuItem.Click += new System.EventHandler(this.ExportXMLToolStripMenuItem_Click);
            // 
            // tblpOrderSearch
            // 
            this.tblpOrderSearch.ColumnCount = 8;
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpOrderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpOrderSearch.Controls.Add(this.tbBuyer, 3, 0);
            this.tblpOrderSearch.Controls.Add(this.lblSearchBuyer, 2, 0);
            this.tblpOrderSearch.Controls.Add(this.tbOrderId, 1, 0);
            this.tblpOrderSearch.Controls.Add(this.lblOrderSearchId, 0, 0);
            this.tblpOrderSearch.Controls.Add(this.lblSearchSeller, 4, 0);
            this.tblpOrderSearch.Controls.Add(this.tbSeller, 5, 0);
            this.tblpOrderSearch.Controls.Add(this.btnSearchInfoClear, 6, 0);
            this.tblpOrderSearch.Controls.Add(this.btnSearch, 7, 0);
            this.tblpOrderSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblpOrderSearch.Location = new System.Drawing.Point(0, 25);
            this.tblpOrderSearch.Name = "tblpOrderSearch";
            this.tblpOrderSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tblpOrderSearch.RowCount = 1;
            this.tblpOrderSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpOrderSearch.Size = new System.Drawing.Size(1088, 38);
            this.tblpOrderSearch.TabIndex = 1;
            // 
            // scSearchContent
            // 
            this.scSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSearchContent.Location = new System.Drawing.Point(0, 63);
            this.scSearchContent.Margin = new System.Windows.Forms.Padding(5);
            this.scSearchContent.Name = "scSearchContent";
            // 
            // scSearchContent.Panel1
            // 
            this.scSearchContent.Panel1.AutoScroll = true;
            this.scSearchContent.Panel1.Controls.Add(this.bindingNavigatorOrder);
            this.scSearchContent.Panel1.Controls.Add(this.dataGridViewOrder);
            this.scSearchContent.Panel1.Controls.Add(this.toolStripContainer1);
            this.scSearchContent.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.scSearchContent.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // scSearchContent.Panel2
            // 
            this.scSearchContent.Panel2.AutoScroll = true;
            this.scSearchContent.Panel2.Controls.Add(this.bindingNavigatorOrderItem);
            this.scSearchContent.Panel2.Controls.Add(this.dataGridViewOrderItem);
            this.scSearchContent.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.scSearchContent.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.scSearchContent.Size = new System.Drawing.Size(1088, 441);
            this.scSearchContent.SplitterDistance = 374;
            this.scSearchContent.TabIndex = 2;
            // 
            // lblOrderSearchId
            // 
            this.lblOrderSearchId.AutoSize = true;
            this.lblOrderSearchId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderSearchId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderSearchId.Location = new System.Drawing.Point(6, 3);
            this.lblOrderSearchId.Name = "lblOrderSearchId";
            this.lblOrderSearchId.Size = new System.Drawing.Size(91, 32);
            this.lblOrderSearchId.TabIndex = 0;
            this.lblOrderSearchId.Text = "订单号:";
            this.lblOrderSearchId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOrderId
            // 
            this.tbOrderId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrderId.Location = new System.Drawing.Point(103, 6);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(167, 21);
            this.tbOrderId.TabIndex = 1;
            // 
            // lblSearchBuyer
            // 
            this.lblSearchBuyer.AutoSize = true;
            this.lblSearchBuyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearchBuyer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearchBuyer.Location = new System.Drawing.Point(276, 3);
            this.lblSearchBuyer.Name = "lblSearchBuyer";
            this.lblSearchBuyer.Size = new System.Drawing.Size(91, 32);
            this.lblSearchBuyer.TabIndex = 2;
            this.lblSearchBuyer.Text = "买家:";
            this.lblSearchBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBuyer
            // 
            this.tbBuyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBuyer.Location = new System.Drawing.Point(373, 6);
            this.tbBuyer.Name = "tbBuyer";
            this.tbBuyer.Size = new System.Drawing.Size(167, 21);
            this.tbBuyer.TabIndex = 3;
            // 
            // lblSearchSeller
            // 
            this.lblSearchSeller.AutoSize = true;
            this.lblSearchSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearchSeller.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearchSeller.Location = new System.Drawing.Point(546, 3);
            this.lblSearchSeller.Name = "lblSearchSeller";
            this.lblSearchSeller.Size = new System.Drawing.Size(91, 32);
            this.lblSearchSeller.TabIndex = 2;
            this.lblSearchSeller.Text = "卖家:";
            this.lblSearchSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSeller
            // 
            this.tbSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSeller.Location = new System.Drawing.Point(643, 6);
            this.tbSeller.Name = "tbSeller";
            this.tbSeller.Size = new System.Drawing.Size(167, 21);
            this.tbSeller.TabIndex = 3;
            // 
            // btnSearchInfoClear
            // 
            this.btnSearchInfoClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchInfoClear.Location = new System.Drawing.Point(816, 6);
            this.btnSearchInfoClear.Name = "btnSearchInfoClear";
            this.btnSearchInfoClear.Size = new System.Drawing.Size(129, 26);
            this.btnSearchInfoClear.TabIndex = 4;
            this.btnSearchInfoClear.Text = "清除";
            this.btnSearchInfoClear.UseVisualStyleBackColor = true;
            this.btnSearchInfoClear.Click += new System.EventHandler(this.BtnSearchInfoClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(951, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.AllowUserToResizeRows = false;
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1,
            this.buyerNameDataGridViewTextBoxColumn1,
            this.sellerNameDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dataGridViewOrder.DataSource = this.bindingSourceOrder;
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowTemplate.Height = 23;
            this.dataGridViewOrder.RowTemplate.ReadOnly = true;
            this.dataGridViewOrder.Size = new System.Drawing.Size(368, 435);
            this.dataGridViewOrder.TabIndex = 1;
            // 
            // dataGridViewOrderItem
            // 
            this.dataGridViewOrderItem.AllowUserToAddRows = false;
            this.dataGridViewOrderItem.AutoGenerateColumns = false;
            this.dataGridViewOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ItemName,
            this.UnitPrice,
            this.Quantity,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridViewOrderItem.DataSource = this.bindingSourceOrderItem;
            this.dataGridViewOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderItem.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrderItem.Name = "dataGridViewOrderItem";
            this.dataGridViewOrderItem.RowTemplate.Height = 23;
            this.dataGridViewOrderItem.Size = new System.Drawing.Size(704, 435);
            this.dataGridViewOrderItem.TabIndex = 2;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(125, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(62, 116);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // bindingSourceOrderItem
            // 
            this.bindingSourceOrderItem.DataSource = this.itemsBindingSource;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.bindingSourceOrder;
            // 
            // bindingNavigatorOrder
            // 
            this.bindingNavigatorOrder.AddNewItem = this.AddNewOrder;
            this.bindingNavigatorOrder.BindingSource = this.bindingSourceOrder;
            this.bindingNavigatorOrder.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorOrder.DeleteItem = this.DeleteOrder;
            this.bindingNavigatorOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.AddNewOrder,
            this.DeleteOrder,
            this.btnModifyOrder});
            this.bindingNavigatorOrder.Location = new System.Drawing.Point(3, 413);
            this.bindingNavigatorOrder.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorOrder.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorOrder.MoveNextItem = null;
            this.bindingNavigatorOrder.MovePreviousItem = null;
            this.bindingNavigatorOrder.Name = "bindingNavigatorOrder";
            this.bindingNavigatorOrder.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorOrder.Size = new System.Drawing.Size(368, 25);
            this.bindingNavigatorOrder.TabIndex = 4;
            this.bindingNavigatorOrder.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Checked = true;
            this.bindingNavigatorMoveFirstItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Checked = true;
            this.bindingNavigatorMoveLastItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AddNewOrder
            // 
            this.AddNewOrder.Checked = true;
            this.AddNewOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddNewOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("AddNewOrder.Image")));
            this.AddNewOrder.Name = "bindingNavigatorAddNewItem";
            this.AddNewOrder.RightToLeftAutoMirrorImage = true;
            this.AddNewOrder.Size = new System.Drawing.Size(23, 22);
            this.AddNewOrder.Text = "新添";
            this.AddNewOrder.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddNewOrder.Click += new System.EventHandler(this.AddNewOrder_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Checked = true;
            this.DeleteOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DeleteOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteOrder.Image = ((System.Drawing.Image)(resources.GetObject("DeleteOrder.Image")));
            this.DeleteOrder.Name = "bindingNavigatorDeleteItem";
            this.DeleteOrder.RightToLeftAutoMirrorImage = true;
            this.DeleteOrder.Size = new System.Drawing.Size(23, 22);
            this.DeleteOrder.Text = "删除";
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // bindingNavigatorOrderItem
            // 
            this.bindingNavigatorOrderItem.AddNewItem = this.AddOrderItem;
            this.bindingNavigatorOrderItem.BindingSource = this.bindingSourceOrderItem;
            this.bindingNavigatorOrderItem.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorOrderItem.DeleteItem = this.DeleteOrderItem;
            this.bindingNavigatorOrderItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorOrderItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.AddOrderItem,
            this.DeleteOrderItem,
            this.btnModifyItem,
            this.btnSearchItem,
            this.lblItemName,
            this.tbItemName,
            this.lblPerPrice,
            this.tbPerPrice,
            this.lblQuantity,
            this.tbQuantity});
            this.bindingNavigatorOrderItem.Location = new System.Drawing.Point(3, 413);
            this.bindingNavigatorOrderItem.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorOrderItem.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorOrderItem.MoveNextItem = null;
            this.bindingNavigatorOrderItem.MovePreviousItem = null;
            this.bindingNavigatorOrderItem.Name = "bindingNavigatorOrderItem";
            this.bindingNavigatorOrderItem.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorOrderItem.Size = new System.Drawing.Size(704, 25);
            this.bindingNavigatorOrderItem.TabIndex = 3;
            this.bindingNavigatorOrderItem.Text = "bindingNavigator2";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "移到第一条记录";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "位置";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem1.Text = "/ {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // AddOrderItem
            // 
            this.AddOrderItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddOrderItem.Image = ((System.Drawing.Image)(resources.GetObject("AddOrderItem.Image")));
            this.AddOrderItem.Name = "bindingNavigatorAddNewItem";
            this.AddOrderItem.RightToLeftAutoMirrorImage = true;
            this.AddOrderItem.Size = new System.Drawing.Size(23, 22);
            this.AddOrderItem.Text = "新添";
            this.AddOrderItem.Click += new System.EventHandler(this.AddOrderItem_Click);
            // 
            // DeleteOrderItem
            // 
            this.DeleteOrderItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteOrderItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteOrderItem.Image")));
            this.DeleteOrderItem.Name = "bindingNavigatorDeleteItem";
            this.DeleteOrderItem.RightToLeftAutoMirrorImage = true;
            this.DeleteOrderItem.Size = new System.Drawing.Size(23, 22);
            this.DeleteOrderItem.Text = "删除";
            this.DeleteOrderItem.Click += new System.EventHandler(this.DeleteOrderItem_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Checked = true;
            this.btnSearchItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchItem.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(60, 21);
            this.btnSearchItem.Text = "查找项目";
            this.btnSearchItem.Click += new System.EventHandler(this.BtnSearchOrderItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(35, 22);
            this.lblItemName.Text = "名称:";
            // 
            // tbItemName
            // 
            this.tbItemName.BackColor = System.Drawing.SystemColors.Window;
            this.tbItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(50, 25);
            // 
            // lblPerPrice
            // 
            this.lblPerPrice.Name = "lblPerPrice";
            this.lblPerPrice.Size = new System.Drawing.Size(35, 22);
            this.lblPerPrice.Text = "单价:";
            // 
            // tbPerPrice
            // 
            this.tbPerPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPerPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tbPerPrice.Name = "tbPerPrice";
            this.tbPerPrice.Size = new System.Drawing.Size(50, 25);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(35, 22);
            this.lblQuantity.Text = "数量:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(50, 25);
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Checked = true;
            this.btnModifyOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnModifyOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModifyOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyOrder.Image")));
            this.btnModifyOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(84, 22);
            this.btnModifyOrder.Text = "修改订单信息";
            this.btnModifyOrder.Click += new System.EventHandler(this.BtnModifyOrder_Click);
            // 
            // btnModifyItem
            // 
            this.btnModifyItem.Checked = true;
            this.btnModifyItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnModifyItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModifyItem.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyItem.Image")));
            this.btnModifyItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifyItem.Name = "btnModifyItem";
            this.btnModifyItem.Size = new System.Drawing.Size(60, 22);
            this.btnModifyItem.Text = "修改项目";
            this.btnModifyItem.Click += new System.EventHandler(this.BtnModifyItem_Click);
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataSource = typeof(ClassOrderManager.Order);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "订单号";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "订单时间";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // buyerNameDataGridViewTextBoxColumn1
            // 
            this.buyerNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buyerNameDataGridViewTextBoxColumn1.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn1.HeaderText = "买家";
            this.buyerNameDataGridViewTextBoxColumn1.Name = "buyerNameDataGridViewTextBoxColumn1";
            this.buyerNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sellerNameDataGridViewTextBoxColumn1
            // 
            this.sellerNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellerNameDataGridViewTextBoxColumn1.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn1.HeaderText = "卖家";
            this.sellerNameDataGridViewTextBoxColumn1.Name = "sellerNameDataGridViewTextBoxColumn1";
            this.sellerNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "序列号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "名称";
            this.ItemName.Name = "ItemName";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 504);
            this.Controls.Add(this.scSearchContent);
            this.Controls.Add(this.tblpOrderSearch);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tblpOrderSearch.ResumeLayout(false);
            this.tblpOrderSearch.PerformLayout();
            this.scSearchContent.Panel1.ResumeLayout(false);
            this.scSearchContent.Panel1.PerformLayout();
            this.scSearchContent.Panel2.ResumeLayout(false);
            this.scSearchContent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSearchContent)).EndInit();
            this.scSearchContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOrder)).EndInit();
            this.bindingNavigatorOrder.ResumeLayout(false);
            this.bindingNavigatorOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOrderItem)).EndInit();
            this.bindingNavigatorOrderItem.ResumeLayout(false);
            this.bindingNavigatorOrderItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem 导入xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出xml文件ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblpOrderSearch;
        private System.Windows.Forms.Label lblOrderSearchId;
        private System.Windows.Forms.SplitContainer scSearchContent;
        private System.Windows.Forms.Label lblSearchBuyer;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.TextBox tbBuyer;
        private System.Windows.Forms.Label lblSearchSeller;
        private System.Windows.Forms.TextBox tbSeller;
        private System.Windows.Forms.Button btnSearchInfoClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderItem;
        private System.Windows.Forms.BindingSource bindingSourceOrder;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.BindingSource bindingSourceOrderItem;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorOrder;
        private System.Windows.Forms.ToolStripButton AddNewOrder;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton DeleteOrder;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorOrderItem;
        private System.Windows.Forms.ToolStripButton AddOrderItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton DeleteOrderItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton btnSearchItem;
        private System.Windows.Forms.ToolStripLabel lblItemName;
        private System.Windows.Forms.ToolStripTextBox tbItemName;
        private System.Windows.Forms.ToolStripLabel lblPerPrice;
        private System.Windows.Forms.ToolStripTextBox tbPerPrice;
        private System.Windows.Forms.ToolStripLabel lblQuantity;
        private System.Windows.Forms.ToolStripTextBox tbQuantity;
        private System.Windows.Forms.ToolStripButton btnModifyOrder;
        private System.Windows.Forms.ToolStripButton btnModifyItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}

