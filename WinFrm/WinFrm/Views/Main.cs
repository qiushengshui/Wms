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
        public string m_username = null;
        public string m_id = null;
        public string m_ty = null;
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

        private void frmain_Load(object sender, EventArgs e)
        {
            if (m_ty == "3")
            {
                tsddbMasterFileManage.Visible = false;
            }
            Ctl.BLL.tb_proc dal = new Ctl.BLL.tb_proc();
            Ctl.Model.tb_proc model = new Ctl.Model.tb_proc();


            DataSet ds = dal.GetListT2("p_num<=p_xx");
            if (ds.Tables[0].Rows.Count > 0)
            {
                InventoryWarningQuery aa = new InventoryWarningQuery();
                aa.Show();
            }
            tsslWelcomeInfo.Text = this.m_username + "（" + (this.m_ty == "4" ? "管理员" : "普通用户") + "） " + tsslWelcomeInfo.Text;
            tsslDateInfo.Text = DateTime.Now.ToString();
        }

        private void 修改密码tsmiChangePwd(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ChangePwd") == true)
            {
                return;
            }
            ChangePwd newFrm = new ChangePwd();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 注销用户tsmiLoginOut(object sender, EventArgs e)
        {
            Login newFrm = new Login();
            newFrm.Show();
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
            StockOrder newFrm = new StockOrder();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 商品验收入库tsmiProdAcceptance(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdAcceptance") == true)
            {
                return;
            }
            ProdAcceptance newFrm = new ProdAcceptance();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 出库订单管理tsmiStockOutOrder(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("StockOutOrder") == true)
            {
                return;
            }
            StockOutOrder newFrm = new StockOutOrder();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 商品出库管理tsmiProdStockOutManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdStockOutManage") == true)
            {
                return;
            }
            ProdStockOutManage newFrm = new ProdStockOutManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 商品报废tsmiprodScrap(object sender, EventArgs e)
        {
            ProdScrap aa = new ProdScrap();
            aa.Show();
        }

        private void 退货管理tsmiReturnManage(object sender, EventArgs e)
        {

        }

        private void 预警管理tsmiWarningManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("WarningManage") == true)
            {
                return;
            }
            WarningManage newFrm = new WarningManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 盘点管理tsmiCheckManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("CheckManage") == true)
            {
                return;
            }
            CheckManage newFrm = new CheckManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 商品库存查询tsmiProdInventoryQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdInventoryQuery") == true)
            {
                return;
            }
            ProdInventoryQuery newFrm = new ProdInventoryQuery();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 入库记录查询tmsiStockRecordQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("StockRecordQuery") == true)
            {
                return;
            }
            StockRecordQuery newFrm = new StockRecordQuery();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 出库记录查询tsmiStockOutRecordQuery(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("StockOutRecordQuery") == true)
            {
                return;
            }
            StockOutRecordQuery newFrm = new StockOutRecordQuery();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 库存预警查询tsmiInventoryWarningQuery(object sender, EventArgs e)
        {
            InventoryWarningQuery aa = new InventoryWarningQuery();
            aa.Show();
        }

        private void 用户管理tmsiAccountManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("AccountManage") == true)
            {
                return;
            }
            AccountManage newFrm = new AccountManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 客户管理tmsiCustomerManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("CustomerManage") == true)
            {
                return;
            }
            CustomerManage newFrm = new CustomerManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 入驻商家tmsiProviderManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProviderManage") == true)
            {
                return;
            }
            ProviderManage newFrm = new ProviderManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 商品管理tmsiProdManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdManage") == true)
            {
                return;
            }
            ProdManage newFrm = new ProdManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 商品分类tmsiProdCategory(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("ProdCategory") == true)
            {
                return;
            }
            ProdCategory newFrm = new ProdCategory();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 仓库管理tmsiWarehouseManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("WarehouseManage") == true)
            {
                return;
            }
            WarehouseManage newFrm = new WarehouseManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void 库区管理tmsiWarehouseAreaManage(object sender, EventArgs e)
        {
            if (this.checkChildFormIsExist("WarehouseAreaManage") == true)
            {
                return;
            }
            WarehouseAreaManage newFrm = new WarehouseAreaManage();
            newFrm.m_id = m_id;
            newFrm.m_ty = m_ty;
            newFrm.MdiParent = this;
            newFrm.Show();
        }

    }
}
