using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class StockOutOrder : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string optrowid = null;
        private BLL.tb_order dal = new BLL.tb_order();
        private Model.tb_order model = new Model.tb_order();
        private BLL.tb_kehu dalz = new BLL.tb_kehu();
        private Model.tb_kehu modelz = new Model.tb_kehu();

        public StockOutOrder()
        {
            InitializeComponent();
        }


        private void frmchu_Load(object sender, EventArgs e)
        {
            BindData("o_type=2");
        }

        private void BindData(string where)
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

        private void SetModifyMode(bool blnEdit)
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
        private bool ValidateIput()
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
        private void ClearCtlValue()
        {
            txtOderNo.Text = txtCustomer.Text = txtkhid.Text = txtuser.Text = "";
            txtdesc.Text = txtsum.Text = "";
            txtsum.Text = "";
            txtname.Text = "";
            txtProdNo.Text = "";
            txtnum.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.ToolTipText == "新增")
            {
                ClearCtlValue();
                SetModifyMode(true);
                optrowid = null;
            }
            if (e.Button.ToolTipText == "修改")
            {
                if (!String.IsNullOrEmpty(optrowid))
                {
                    SetModifyMode(true);
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
                        ClearCtlValue();
                        MessageBox.Show("恭喜你，删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindData("o_type=2");
                        SetModifyMode(false);
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
                if (ValidateIput())
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
                            ClearCtlValue();
                            BindData("o_type=2");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                    else
                    {
                        if (dal.Update(model))
                        {
                            MessageBox.Show("恭喜你，修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCtlValue();
                            BindData("o_type=2");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                BindData("o_type=2");
                ClearCtlValue();
                SetModifyMode(false);
                optrowid = null;
            }

            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }


        private void btn_dept_Click(object sender, EventArgs e)
        {
            SelectCustomer f2 = new SelectCustomer();
            f2.Fathertxtbox = this.txtCustomer;
            f2.FathertxtboxT = this.txtkhid;
            f2.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtProdNo.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtProdNo.Focus();
            }
            else
            {
                GetStr(txtProdNo.Text);
            }
        }

        BLL.tb_proc dalt = new BLL.tb_proc();
        private int pid;
        private void GetStr(string _no)
        {
            if (!string.IsNullOrEmpty(_no))
            {
                DataTable dt = dalt.GetList(" p_no='" + _no + "'").Tables[0];
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
