namespace WinFrm.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslWelcomeInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslloguser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDateInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ttsddbSystemManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoginOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbStockManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiStockOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProdAcceptance = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsddbStockOutManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiStockOutOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProdStockOutManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturnManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiprodScrap = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsddbInventoryManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCheckManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWarningManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ttsddbIntegratedQuery = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiProdInventoryQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiStockRecordQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockOutRecordQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInventoryWarningQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbMasterFileManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmsiAccountManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiCustomerManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiProviderManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiProdManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiProdCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiWarehouseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiWarehouseAreaManage = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWelcomeInfo,
            this.tsslloguser,
            this.tsslDateInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.TabIndex = 5;
            // 
            // tsslWelcomeInfo
            // 
            this.tsslWelcomeInfo.Name = "tsslWelcomeInfo";
            this.tsslWelcomeInfo.Size = new System.Drawing.Size(176, 17);
            this.tsslWelcomeInfo.Text = "欢迎您进入超市仓库管理系统！";
            // 
            // tsslloguser
            // 
            this.tsslloguser.Name = "tsslloguser";
            this.tsslloguser.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslDateInfo
            // 
            this.tsslDateInfo.Name = "tsslDateInfo";
            this.tsslDateInfo.Size = new System.Drawing.Size(630, 17);
            this.tsslDateInfo.Spring = true;
            this.tsslDateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttsddbSystemManage,
            this.tsddbStockManage,
            this.ttsddbStockOutManage,
            this.ttsddbInventoryManage,
            this.ttsddbIntegratedQuery,
            this.tsddbMasterFileManage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 4;
            // 
            // ttsddbSystemManage
            // 
            this.ttsddbSystemManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttsddbSystemManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePwd,
            this.tsmiLoginOut,
            this.tsmiExit});
            this.ttsddbSystemManage.Image = ((System.Drawing.Image)(resources.GetObject("ttsddbSystemManage.Image")));
            this.ttsddbSystemManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttsddbSystemManage.Name = "ttsddbSystemManage";
            this.ttsddbSystemManage.Size = new System.Drawing.Size(69, 22);
            this.ttsddbSystemManage.Text = "系统管理";
            // 
            // tsmiChangePwd
            // 
            this.tsmiChangePwd.Name = "tsmiChangePwd";
            this.tsmiChangePwd.Size = new System.Drawing.Size(124, 22);
            this.tsmiChangePwd.Text = "修改密码";
            this.tsmiChangePwd.Click += new System.EventHandler(this.修改密码tsmiChangePwd);
            // 
            // tsmiLoginOut
            // 
            this.tsmiLoginOut.Name = "tsmiLoginOut";
            this.tsmiLoginOut.Size = new System.Drawing.Size(124, 22);
            this.tsmiLoginOut.Text = "注销用户";
            this.tsmiLoginOut.Click += new System.EventHandler(this.注销用户tsmiLoginOut);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(124, 22);
            this.tsmiExit.Text = "退出系统";
            this.tsmiExit.Click += new System.EventHandler(this.退出系统tsmiExit);
            // 
            // tsddbStockManage
            // 
            this.tsddbStockManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbStockManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStockOrder,
            this.tsmiProdAcceptance});
            this.tsddbStockManage.Image = ((System.Drawing.Image)(resources.GetObject("tsddbStockManage.Image")));
            this.tsddbStockManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbStockManage.Name = "tsddbStockManage";
            this.tsddbStockManage.Size = new System.Drawing.Size(69, 22);
            this.tsddbStockManage.Text = "入库管理";
            // 
            // tsmiStockOrder
            // 
            this.tsmiStockOrder.Name = "tsmiStockOrder";
            this.tsmiStockOrder.Size = new System.Drawing.Size(148, 22);
            this.tsmiStockOrder.Text = "入库订单管理";
            this.tsmiStockOrder.Click += new System.EventHandler(this.入库订单管理tsmiStockOrder);
            // 
            // tsmiProdAcceptance
            // 
            this.tsmiProdAcceptance.Name = "tsmiProdAcceptance";
            this.tsmiProdAcceptance.Size = new System.Drawing.Size(148, 22);
            this.tsmiProdAcceptance.Text = "商品验收入库";
            this.tsmiProdAcceptance.Click += new System.EventHandler(this.商品验收入库tsmiProdAcceptance);
            // 
            // ttsddbStockOutManage
            // 
            this.ttsddbStockOutManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttsddbStockOutManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStockOutOrder,
            this.tsmiProdStockOutManage,
            this.tsmiReturnManage,
            this.tsmiprodScrap});
            this.ttsddbStockOutManage.Image = ((System.Drawing.Image)(resources.GetObject("ttsddbStockOutManage.Image")));
            this.ttsddbStockOutManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttsddbStockOutManage.Name = "ttsddbStockOutManage";
            this.ttsddbStockOutManage.Size = new System.Drawing.Size(69, 22);
            this.ttsddbStockOutManage.Text = "出库管理";
            // 
            // tsmiStockOutOrder
            // 
            this.tsmiStockOutOrder.Name = "tsmiStockOutOrder";
            this.tsmiStockOutOrder.Size = new System.Drawing.Size(152, 22);
            this.tsmiStockOutOrder.Text = "出库订单管理";
            this.tsmiStockOutOrder.Click += new System.EventHandler(this.出库订单管理tsmiStockOutOrder);
            // 
            // tsmiProdStockOutManage
            // 
            this.tsmiProdStockOutManage.Name = "tsmiProdStockOutManage";
            this.tsmiProdStockOutManage.Size = new System.Drawing.Size(152, 22);
            this.tsmiProdStockOutManage.Text = "商品出库管理";
            this.tsmiProdStockOutManage.Click += new System.EventHandler(this.商品出库管理tsmiProdStockOutManage);
            // 
            // tsmiReturnManage
            // 
            this.tsmiReturnManage.Name = "tsmiReturnManage";
            this.tsmiReturnManage.Size = new System.Drawing.Size(152, 22);
            this.tsmiReturnManage.Text = "退货管理";
            this.tsmiReturnManage.Click += new System.EventHandler(this.退货管理tsmiReturnManage);
            // 
            // tsmiprodScrap
            // 
            this.tsmiprodScrap.Name = "tsmiprodScrap";
            this.tsmiprodScrap.Size = new System.Drawing.Size(152, 22);
            this.tsmiprodScrap.Text = "商品报废";
            this.tsmiprodScrap.Click += new System.EventHandler(this.商品报废tsmiprodScrap);
            // 
            // ttsddbInventoryManage
            // 
            this.ttsddbInventoryManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttsddbInventoryManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckManage,
            this.tsmiWarningManage});
            this.ttsddbInventoryManage.Image = ((System.Drawing.Image)(resources.GetObject("ttsddbInventoryManage.Image")));
            this.ttsddbInventoryManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttsddbInventoryManage.Name = "ttsddbInventoryManage";
            this.ttsddbInventoryManage.Size = new System.Drawing.Size(69, 22);
            this.ttsddbInventoryManage.Text = "库存管理";
            // 
            // tsmiCheckManage
            // 
            this.tsmiCheckManage.Name = "tsmiCheckManage";
            this.tsmiCheckManage.Size = new System.Drawing.Size(152, 22);
            this.tsmiCheckManage.Text = "盘点管理";
            this.tsmiCheckManage.Click += new System.EventHandler(this.盘点管理tsmiCheckManage);
            // 
            // tsmiWarningManage
            // 
            this.tsmiWarningManage.Name = "tsmiWarningManage";
            this.tsmiWarningManage.Size = new System.Drawing.Size(152, 22);
            this.tsmiWarningManage.Text = "预警管理";
            this.tsmiWarningManage.Click += new System.EventHandler(this.预警管理tsmiWarningManage);
            // 
            // ttsddbIntegratedQuery
            // 
            this.ttsddbIntegratedQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttsddbIntegratedQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProdInventoryQuery,
            this.tmsiStockRecordQuery,
            this.tsmiStockOutRecordQuery,
            this.tsmiInventoryWarningQuery});
            this.ttsddbIntegratedQuery.Image = ((System.Drawing.Image)(resources.GetObject("ttsddbIntegratedQuery.Image")));
            this.ttsddbIntegratedQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttsddbIntegratedQuery.Name = "ttsddbIntegratedQuery";
            this.ttsddbIntegratedQuery.Size = new System.Drawing.Size(69, 22);
            this.ttsddbIntegratedQuery.Text = "综合查询";
            // 
            // tsmiProdInventoryQuery
            // 
            this.tsmiProdInventoryQuery.Name = "tsmiProdInventoryQuery";
            this.tsmiProdInventoryQuery.Size = new System.Drawing.Size(148, 22);
            this.tsmiProdInventoryQuery.Text = "商品库存查询";
            this.tsmiProdInventoryQuery.Click += new System.EventHandler(this.商品库存查询tsmiProdInventoryQuery);
            // 
            // tmsiStockRecordQuery
            // 
            this.tmsiStockRecordQuery.Name = "tmsiStockRecordQuery";
            this.tmsiStockRecordQuery.Size = new System.Drawing.Size(148, 22);
            this.tmsiStockRecordQuery.Text = "入库记录查询";
            this.tmsiStockRecordQuery.Click += new System.EventHandler(this.入库记录查询tmsiStockRecordQuery);
            // 
            // tsmiStockOutRecordQuery
            // 
            this.tsmiStockOutRecordQuery.Name = "tsmiStockOutRecordQuery";
            this.tsmiStockOutRecordQuery.Size = new System.Drawing.Size(148, 22);
            this.tsmiStockOutRecordQuery.Text = "出库记录查询";
            this.tsmiStockOutRecordQuery.Click += new System.EventHandler(this.出库记录查询tsmiStockOutRecordQuery);
            // 
            // tsmiInventoryWarningQuery
            // 
            this.tsmiInventoryWarningQuery.Name = "tsmiInventoryWarningQuery";
            this.tsmiInventoryWarningQuery.Size = new System.Drawing.Size(148, 22);
            this.tsmiInventoryWarningQuery.Text = "库存预警查询";
            this.tsmiInventoryWarningQuery.Click += new System.EventHandler(this.库存预警查询tsmiInventoryWarningQuery);
            // 
            // tsddbMasterFileManage
            // 
            this.tsddbMasterFileManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbMasterFileManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiAccountManage,
            this.tmsiCustomerManage,
            this.tmsiProviderManage,
            this.tmsiProdManage,
            this.tmsiProdCategory,
            this.tmsiWarehouseManage,
            this.tmsiWarehouseAreaManage});
            this.tsddbMasterFileManage.Image = ((System.Drawing.Image)(resources.GetObject("tsddbMasterFileManage.Image")));
            this.tsddbMasterFileManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbMasterFileManage.Name = "tsddbMasterFileManage";
            this.tsddbMasterFileManage.Size = new System.Drawing.Size(69, 22);
            this.tsddbMasterFileManage.Text = "主档管理";
            // 
            // tmsiAccountManage
            // 
            this.tmsiAccountManage.Name = "tmsiAccountManage";
            this.tmsiAccountManage.Size = new System.Drawing.Size(124, 22);
            this.tmsiAccountManage.Text = "用户管理";
            this.tmsiAccountManage.Click += new System.EventHandler(this.用户管理tmsiAccountManage);
            // 
            // tmsiCustomerManage
            // 
            this.tmsiCustomerManage.Name = "tmsiCustomerManage";
            this.tmsiCustomerManage.Size = new System.Drawing.Size(124, 22);
            this.tmsiCustomerManage.Text = "客户管理";
            this.tmsiCustomerManage.Click += new System.EventHandler(this.客户管理tmsiCustomerManage);
            // 
            // tmsiProviderManage
            // 
            this.tmsiProviderManage.Name = "tmsiProviderManage";
            this.tmsiProviderManage.Size = new System.Drawing.Size(124, 22);
            this.tmsiProviderManage.Text = "入驻商家";
            this.tmsiProviderManage.Click += new System.EventHandler(this.入驻商家tmsiProviderManage);
            // 
            // tmsiProdManage
            // 
            this.tmsiProdManage.Name = "tmsiProdManage";
            this.tmsiProdManage.Size = new System.Drawing.Size(124, 22);
            this.tmsiProdManage.Text = "商品管理";
            this.tmsiProdManage.Click += new System.EventHandler(this.商品管理tmsiProdManage);
            // 
            // tmsiProdCategory
            // 
            this.tmsiProdCategory.Name = "tmsiProdCategory";
            this.tmsiProdCategory.Size = new System.Drawing.Size(124, 22);
            this.tmsiProdCategory.Text = "商品分类";
            this.tmsiProdCategory.Click += new System.EventHandler(this.商品分类tmsiProdCategory);
            // 
            // tmsiWarehouseManage
            // 
            this.tmsiWarehouseManage.Name = "tmsiWarehouseManage";
            this.tmsiWarehouseManage.Size = new System.Drawing.Size(124, 22);
            this.tmsiWarehouseManage.Text = "仓库管理";
            this.tmsiWarehouseManage.Click += new System.EventHandler(this.仓库管理tmsiWarehouseManage);
            // 
            // tmsiWarehouseAreaManage
            // 
            this.tmsiWarehouseAreaManage.Name = "tmsiWarehouseAreaManage";
            this.tmsiWarehouseAreaManage.Size = new System.Drawing.Size(124, 22);
            this.tmsiWarehouseAreaManage.Text = "库区管理";
            this.tmsiWarehouseAreaManage.Click += new System.EventHandler(this.库区管理tmsiWarehouseAreaManage);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 438);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市仓库管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslWelcomeInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslloguser;
        private System.Windows.Forms.ToolStripStatusLabel tsslDateInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ttsddbSystemManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripDropDownButton tsddbStockManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiProdAcceptance;
        private System.Windows.Forms.ToolStripDropDownButton ttsddbStockOutManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockOutOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiProdStockOutManage;
        private System.Windows.Forms.ToolStripDropDownButton ttsddbInventoryManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiWarningManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckManage;
        private System.Windows.Forms.ToolStripDropDownButton ttsddbIntegratedQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiProdInventoryQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockOutRecordQuery;
        private System.Windows.Forms.ToolStripDropDownButton tsddbMasterFileManage;
        private System.Windows.Forms.ToolStripMenuItem tmsiAccountManage;
        private System.Windows.Forms.ToolStripMenuItem tmsiCustomerManage;
        private System.Windows.Forms.ToolStripMenuItem tmsiProviderManage;
        private System.Windows.Forms.ToolStripMenuItem tmsiProdManage;
        private System.Windows.Forms.ToolStripMenuItem tmsiProdCategory;
        private System.Windows.Forms.ToolStripMenuItem tmsiWarehouseManage;
        private System.Windows.Forms.ToolStripMenuItem tmsiWarehouseAreaManage;
        private System.Windows.Forms.ToolStripMenuItem tmsiStockRecordQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiprodScrap;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoginOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiInventoryWarningQuery;
    }
}