using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wms.Views
{
    public partial class StockOutOrder : Form
    {
        private int pid;
        public string m_id;
        public string m_ty;
        private string optrowid;
        private BLL.tb_proc dalt = new BLL.tb_proc();
        private BLL.tb_order dal = new BLL.tb_order();
        private BLL.tb_kehu dalz = new BLL.tb_kehu();
        private Model.tb_kehu modelz = new Model.tb_kehu();
        private Model.tb_order model = new Model.tb_order();

        public StockOutOrder()
        {
            InitializeComponent();
        }

        private void stockOutOrder_Load(object sender, EventArgs e)
        {
            bindData("o_type=2");
        }

        private void bindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单编号";
            dataGridView1.Columns[2].HeaderText = "下单时间";
            dataGridView1.Columns[3].HeaderText = "商品编号";
            dataGridView1.Columns[4].HeaderText = "商品名称";
            dataGridView1.Columns[5].HeaderText = "订单数量";
            dataGridView1.Columns[6].HeaderText = "订单总额";
            dataGridView1.Columns[7].HeaderText = "客户姓名";
            dataGridView1.Columns[8].HeaderText = "客户电话";
            dataGridView1.Columns[9].HeaderText = "客户地址";
            dataGridView1.Columns[10].HeaderText = "所在地邮编";
            dataGridView1.Columns[11].HeaderText = "提货人姓名";
            dataGridView1.Columns[12].HeaderText = "备注说明";
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
        }

        private void setModifyMode(bool blnEdit)
        {
            txtOderNo.ReadOnly = !blnEdit;
            txtuser.ReadOnly = !blnEdit;
            txtdesc.ReadOnly = !blnEdit;
            txtsum.ReadOnly = !blnEdit;
            btnChoose.Enabled = blnEdit;
            txtCustomer.ReadOnly = !blnEdit;
            btnSearch.Enabled = blnEdit;
            txtname.ReadOnly = !blnEdit;
            txtnum.ReadOnly = !blnEdit;
            txtProdNo.ReadOnly = !blnEdit;
        }

        private bool validateInput()
        {
            if (this.txtOderNo.Text.Trim() == "")
            {
                MessageBox.Show("请填写订单编号", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (this.txtkhid.Text.Trim() == "")
            {
                MessageBox.Show("请选择订单客户", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        private void rstValue()
        {
            txtOderNo.Text = "";
            txtCustomer.Text = "";
            txtkhid.Text = "";
            txtuser.Text = "";
            txtdesc.Text = "";
            txtsum.Text = "";
            txtsum.Text = "";
            txtname.Text = "";
            txtProdNo.Text = "";
            txtnum.Text = "";
        }

        private void dgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            optrowid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!String.IsNullOrEmpty(optrowid))
            {
                model = dal.GetModel(Int32.Parse(optrowid));
                if (model != null)
                {
                    txtOderNo.Text = model.o_no;
                    txtkhid.Text = model.o_busy.ToString();
                    modelz = dalz.GetModel((int)model.o_busy);
                    txtCustomer.Text = modelz.h_name;
                    txtsum.Text = model.o_sum;
                    txtdesc.Text = model.o_desc;
                    txtuser.Text = model.o_user;
                    txtnum.Text = model.o_num + "";
                    DataTable dt = dalt.GetList(" p_id='" + model.o_pid + "'").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        txtname.Text = dt.Rows[0]["p_name"].ToString();
                        txtProdNo.Text = dt.Rows[0]["p_no"].ToString();
                    }
                }
            }
        }

        private void tbBtnClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.ToolTipText == "新增")
            {
                rstValue();
                setModifyMode(true);
                optrowid = null;
            }
            if (e.Button.ToolTipText == "修改")
            {
                if (!String.IsNullOrEmpty(optrowid))
                {
                    setModifyMode(true);
                }
                else
                {
                    MessageBox.Show("请选择所要修改的行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (e.Button.ToolTipText == "删除")
            {
                if (!String.IsNullOrEmpty(optrowid))
                {
                    DialogResult result = MessageBox.Show("确认删除？", "删除数据", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        dal.Delete(int.Parse(optrowid));
                        rstValue();
                        MessageBox.Show("恭喜你，删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindData("o_type=2");
                        setModifyMode(false);
                        optrowid = null;
                    }
                }
                else
                {
                    MessageBox.Show("请选择所要删除的行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (e.Button.ToolTipText == "提交")
            {
                if (validateInput())
                {
                    model = new Model.tb_order();
                    if (!String.IsNullOrEmpty(optrowid))
                    {
                        model = dal.GetModel(int.Parse(optrowid));
                    }
                    model.o_busy = int.Parse(this.txtkhid.Text);
                    model.o_no = this.txtOderNo.Text;
                    model.o_sum = this.txtsum.Text;
                    model.o_desc = this.txtdesc.Text;
                    model.o_user = this.txtuser.Text;
                    model.o_num = int.Parse(this.txtnum.Text);
                    model.o_pid = pid;
                    model.o_type = 2;
                    if (String.IsNullOrEmpty(optrowid))
                    {
                        model.o_time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        int i = dal.Add(model);
                        if (i > 0)
                        {
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rstValue();
                            bindData("o_type=2");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                    else
                    {
                        if (dal.Update(model))
                        {
                            MessageBox.Show("恭喜你，修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rstValue();
                            bindData("o_type=2");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                bindData("o_type=2");
                rstValue();
                setModifyMode(false);
                optrowid = null;
            }

            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }

        private void btnChooseClick(object sender, EventArgs e)
        {
            SelectCustomer f2 = new SelectCustomer();
            f2.Fathertxtbox = this.txtCustomer;
            f2.FathertxtboxT = this.txtkhid;
            f2.Show();
        }

        private void btnSearchClick(object sender, EventArgs e)
        {
            if (this.txtProdNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtProdNo.Focus();
            }
            else
            {
                getStr(txtProdNo.Text);
            }
        }

        private void getStr(string no)
        {
            if (!string.IsNullOrEmpty(no))
            {
                DataTable dt = dalt.GetList(" p_no='" + no + "'").Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("该系统无此商品，请先到商品管理中添加该商品！");
                    return;
                }
                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0]["p_name"].ToString();
                    pid = Convert.ToInt32(dt.Rows[0]["p_id"]);
                }
            }
        }

    }
}
