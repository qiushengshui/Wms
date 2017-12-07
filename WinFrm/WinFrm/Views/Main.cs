using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    /// <summary>
    /// 系统主界面（登陆后）
    /// </summary>
    public partial class Main : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string m_username = null;
        private BLL.tb_proc dal = new BLL.tb_proc();
        private Model.tb_proc model = new Model.tb_proc();

        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是否成功激活MdiChildren窗体
        /// </summary>
        /// <param name="childFrmName"></param>
        /// <returns></returns>
        private bool checkChildFormIsExist(string childFrmName)
        {
            foreach (Form childFrm in this.MdiChildren)
            {
                if (childFrm.Name == childFrmName)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                    {
                        childFrm.WindowState = FormWindowState.Normal;
                    }
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (m_ty == "3")
            {
                tsddbMasterFileManage.Visible = false;
                ttsddbSystemManage.DropDownItems[0].Visible = false;
                ttsddbSystemManage.DropDownItems[1].Visible = false;
            }
            //开启实时时间刷新任务
            this.timer.Enabled = true;
            DataSet ds = dal.GetListT2("p_num<=p_xx");
            if (ds.Tables[0].Rows.Count > 0)
            {
                InventoryWarningQuery inventoryWarningQuery = new InventoryWarningQuery();
                inventoryWarningQuery.MdiParent = this;
                inventoryWarningQuery.m_id = m_id;
                inventoryWarningQuery.m_ty = m_ty;
                inventoryWarningQuery.Show();
            }
            tsslWelcomeInfo.Text = this.m_username + "（" + (this.m_ty == "4" ? "管理员" : "普通用户") + "） " + tsslWelcomeInfo.Text;
        }

        private void 修改密码tsmiChangePwd(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ChangePwd") == true)
            {
                return;
            }
            ChangePwd changePwd = new ChangePwd();
            changePwd.m_id = m_id;
            changePwd.m_ty = m_ty;
            changePwd.MdiParent = this;
            changePwd.Show();
        }

        private void 注销用户tsmiLoginOut(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void 退出系统tsmiExit(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void 入库订单管理tsmiStockOrder(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("StockOrder") == true)
            {
                return;
            }
            StockOrder stockOrder = new StockOrder();
            stockOrder.m_id = m_id;
            stockOrder.m_ty = m_ty;
            stockOrder.MdiParent = this;
            stockOrder.Show();
        }

        private void 商品验收入库tsmiProdAcceptance(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdAcceptance") == true)
            {
                return;
            }
            ProdAcceptance prodAcceptance = new ProdAcceptance();
            prodAcceptance.m_id = m_id;
            prodAcceptance.m_ty = m_ty;
            prodAcceptance.MdiParent = this;
            prodAcceptance.Show();
        }

        private void 出库订单管理tsmiStockOutOrder(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("StockOutOrder") == true)
            {
                return;
            }
            StockOutOrder stockOutOrder = new StockOutOrder();
            stockOutOrder.m_id = m_id;
            stockOutOrder.m_ty = m_ty;
            stockOutOrder.MdiParent = this;
            stockOutOrder.Show();
        }

        private void 商品出库管理tsmiProdStockOutManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdStockOutManage") == true)
            {
                return;
            }
            ProdStockOutManage prodStockOutManage = new ProdStockOutManage();
            prodStockOutManage.m_id = m_id;
            prodStockOutManage.m_ty = m_ty;
            prodStockOutManage.MdiParent = this;
            prodStockOutManage.Show();
        }

        private void 商品报废tsmiprodScrap(object sender, EventArgs e)
        {
            ProdScrapsManage prodScrap = new ProdScrapsManage();
            prodScrap.MdiParent = this;
            prodScrap.m_id = m_id;
            prodScrap.m_ty = m_ty;
            prodScrap.Show();
        }

        private void 退货管理tsmiReturnManage(object sender, EventArgs e)
        {
            ProdReturnManage prodReturn = new ProdReturnManage();
            prodReturn.MdiParent = this;
            prodReturn.m_id = m_id;
            prodReturn.m_ty = m_ty;
            prodReturn.Show();
        }

        private void 预警管理tsmiWarningManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("WarningManage") == true)
            {
                return;
            }
            WarningManage warningManage = new WarningManage();
            warningManage.m_id = m_id;
            warningManage.m_ty = m_ty;
            warningManage.MdiParent = this;
            warningManage.Show();
        }

        private void 盘点管理tsmiCheckManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("CheckManage") == true)
            {
                return;
            }
            CheckManage checkManage = new CheckManage();
            checkManage.m_id = m_id;
            checkManage.m_ty = m_ty;
            checkManage.MdiParent = this;
            checkManage.Show();
        }

        private void 商品库存查询tsmiProdInventoryQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdInventoryQuery") == true)
            {
                return;
            }
            ProdInventoryQuery prodInventoryQuery = new ProdInventoryQuery();
            prodInventoryQuery.m_id = m_id;
            prodInventoryQuery.m_ty = m_ty;
            prodInventoryQuery.MdiParent = this;
            prodInventoryQuery.Show();
        }

        private void 入库记录查询tmsiStockRecordQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("StockRecordQuery") == true)
            {
                return;
            }
            StockRecordQuery stockRecordQuery = new StockRecordQuery();
            stockRecordQuery.m_id = m_id;
            stockRecordQuery.m_ty = m_ty;
            stockRecordQuery.MdiParent = this;
            stockRecordQuery.Show();
        }

        private void 出库记录查询tsmiStockOutRecordQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("StockOutRecordQuery") == true)
            {
                return;
            }
            StockOutRecordQuery stockOutRecordQuery = new StockOutRecordQuery();
            stockOutRecordQuery.m_id = m_id;
            stockOutRecordQuery.m_ty = m_ty;
            stockOutRecordQuery.MdiParent = this;
            stockOutRecordQuery.Show();
        }

        private void 库存预警查询tsmiInventoryWarningQuery(object sender, EventArgs e)
        {
            InventoryWarningQuery inventoryWarningQuery = new InventoryWarningQuery();
            inventoryWarningQuery.m_id = m_id;
            inventoryWarningQuery.m_ty = m_ty;
            inventoryWarningQuery.MdiParent = this;
            inventoryWarningQuery.Show();
        }

        private void 商品退货查询tmsiProdReturnQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdReturnQuery") == true)
            {
                return;
            }
            ProdReturnQuery prodReturnQuery = new ProdReturnQuery();
            prodReturnQuery.m_id = m_id;
            prodReturnQuery.m_ty = m_ty;
            prodReturnQuery.MdiParent = this;
            prodReturnQuery.Show();
        }

        private void 商品报废查询tmsiProdScrapsQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdScrapsQuery") == true)
            {
                return;
            }
            ProdScrapsQuery prodScrapsQuery = new ProdScrapsQuery();
            prodScrapsQuery.m_id = m_id;
            prodScrapsQuery.m_ty = m_ty;
            prodScrapsQuery.MdiParent = this;
            prodScrapsQuery.Show();
        }

        private void 用户管理tmsiAccountManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("AccountManage") == true)
            {
                return;
            }
            AccountManage accountManage = new AccountManage();
            accountManage.m_id = m_id;
            accountManage.m_ty = m_ty;
            accountManage.MdiParent = this;
            accountManage.Show();
        }

        private void 客户管理tmsiCustomerManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("CustomerManage") == true)
            {
                return;
            }
            CustomerManage customerManage = new CustomerManage();
            customerManage.m_id = m_id;
            customerManage.m_ty = m_ty;
            customerManage.MdiParent = this;
            customerManage.Show();
        }

        private void 入驻商家tmsiProviderManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProviderManage") == true)
            {
                return;
            }
            ProviderManage providerManage = new ProviderManage();
            providerManage.m_id = m_id;
            providerManage.m_ty = m_ty;
            providerManage.MdiParent = this;
            providerManage.Show();
        }

        private void 商品管理tmsiProdManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdManage") == true)
            {
                return;
            }
            ProdManage prodManage = new ProdManage();
            prodManage.m_id = m_id;
            prodManage.m_ty = m_ty;
            prodManage.MdiParent = this;
            prodManage.Show();
        }

        private void 商品分类tmsiProdCategory(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdCategory") == true)
            {
                return;
            }
            ProdCategory prodCategory = new ProdCategory();
            prodCategory.m_id = m_id;
            prodCategory.m_ty = m_ty;
            prodCategory.MdiParent = this;
            prodCategory.Show();
        }

        private void 仓库管理tmsiWarehouseManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("WarehouseManage") == true)
            {
                return;
            }
            WarehouseManage warehouseManage = new WarehouseManage();
            warehouseManage.m_id = m_id;
            warehouseManage.m_ty = m_ty;
            warehouseManage.MdiParent = this;
            warehouseManage.Show();
        }

        private void 库区管理tmsiWarehouseAreaManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("WarehouseAreaManage") == true)
            {
                return;
            }
            WarehouseAreaManage warehouseAreaManage = new WarehouseAreaManage();
            warehouseAreaManage.m_id = m_id;
            warehouseAreaManage.m_ty = m_ty;
            warehouseAreaManage.MdiParent = this;
            warehouseAreaManage.Show();
        }

        private void 数据备份tsmiDataBackUp(object sender, EventArgs e)
        {
            DataBackup dbBackup = new DataBackup();
            dbBackup.Show();
        }

        private void 数据恢复tsmiDataRecover(object sender, EventArgs e)
        {
            DataRecover dbRecover = new DataRecover();
            dbRecover.Show();
        }

        private void 实时时间timerTick(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            tsslDateInfo.Text = dt.ToString();
        }

    }
}
