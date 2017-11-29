using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class ProdStockOutManage : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public ProdStockOutManage()
        {
            InitializeComponent();
        }

        private void frmchuds_Load(object sender, EventArgs e)
        {
            BindDdl();
            BindData("cr_type=2");
        }

        public string optrowid = null;
        BLL.tb_churu dal = new BLL.tb_churu();
        Model.tb_churu model = new Model.tb_churu();

        private void BindData(string where)
        {
            DataSet ds = dal.GetListC(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单编号";
            dataGridView1.Columns[2].HeaderText = "商品编号";
            dataGridView1.Columns[3].HeaderText = "商品名称";
            dataGridView1.Columns[4].HeaderText = "出库数量";
            dataGridView1.Columns[5].HeaderText = "出库时间";
            dataGridView1.Columns[6].HeaderText = "出库单价";
            dataGridView1.Columns[7].HeaderText = "客户名称";
            dataGridView1.Columns[8].HeaderText = "客户电话";
            dataGridView1.Columns[9].HeaderText = "客户地址";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
        }
        private void BindDdl()
        {
            BLL.tb_order dalo = new BLL.tb_order();
            DataTable dt = dalo.GetList(1000, "o_type=2", "o_id desc").Tables[0];
            this.txtorder.DataSource = dt;
            txtorder.DisplayMember = "o_no";
            txtorder.ValueMember = "o_id";
        }
        private void SetModifyMode(bool blnEdit)
        {
            this.txtno.ReadOnly = !blnEdit;
            this.txtorder.Enabled = blnEdit;
            this.txtprice.ReadOnly = !blnEdit;
            this.txtnum.ReadOnly = !blnEdit;
            this.txtrek.ReadOnly = !blnEdit;
            this.btn_js.Enabled = blnEdit;

        }
        private bool ValidateIput()
        {
            if (this.txttyid.Text.Trim() == "")
            {
                MessageBox.Show("请先检索商品", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
                return false;
            }
            if (this.txtorder.Text.Trim() == "")
            {
                MessageBox.Show("请选择所属订单", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtorder.Focus();
                return false;
            }
            if (this.txtnum.Text.Trim() == "")
            {
                MessageBox.Show("请输入本次出库数量", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtnum.Focus();
                return false;
            }

            return true;
        }
        private void ClearCtlValue()
        {
            string val = "";
            this.txtorder.Text = val;
            this.txtno.Text = val;
            this.txttyid.Text = val;
            this.txtname.Text = val;
            this.txtprice.Text = val;
            this.txtnum.Text = val;
            this.txtrek.Text = val;
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
                        BindData("cr_type=2");
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
                    model = new Model.tb_churu();

                    if (!string.IsNullOrEmpty(optrowid))
                    {
                        model = dal.GetModel(int.Parse(optrowid));
                    }

                    model.cr_oid = int.Parse(this.txtorder.SelectedValue.ToString());
                    model.cr_pid = int.Parse(txttyid.Text);
                    model.cr_price = decimal.Parse(txtprice.Text);
                    model.cr_remark = txtrek.Text;

                    model.cr_type = 2;
                    model.cr_num = int.Parse(this.txtnum.Text);

                    if (String.IsNullOrEmpty(optrowid))
                    {
                        model.cr_time = System.DateTime.Now.ToString("yyyy-MM-dd");

                        if (dal.Add(model) > 0)
                        {
                            BLL.tb_proc dap = new BLL.tb_proc();
                            Model.tb_proc mop = new Model.tb_proc();
                            mop = dap.GetModel(int.Parse(txttyid.Text));
                            if (!string.IsNullOrEmpty(mop.p_xx))
                            {
                                if (mop.p_num < int.Parse(mop.p_xx))
                                {
                                    MessageBox.Show("已达到库存预警上限", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                                }
                            }
                            if (mop.p_num < int.Parse(this.txtnum.Text))
                            {
                                MessageBox.Show("库存不足，请更换", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                            }
                            mop.p_num = mop.p_num - int.Parse(this.txtnum.Text);
                            dap.Update(mop);
                            MessageBox.Show("恭喜你，出库成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCtlValue();
                            BindData("cr_type=2");
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
                            BindData("cr_type=2");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                BindData("cr_type=2");
                ClearCtlValue();
                SetModifyMode(false);
                optrowid = null;
            }

            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            optrowid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!String.IsNullOrEmpty(optrowid))
            {
                model = dal.GetModel(int.Parse(optrowid));
                if (model != null)
                {
                    BLL.tb_proc dalp = new BLL.tb_proc();
                    Model.tb_proc molp = new Model.tb_proc();
                    molp = dalp.GetModel(int.Parse(model.cr_pid.ToString()));
                    this.txtno.Text = molp.p_no;
                    this.txtname.Text = molp.p_name;
                    this.txttyid.Text = model.cr_pid.ToString();
                    this.txtorder.SelectedValue = model.cr_oid.ToString();
                    this.txtprice.Text = model.cr_price.ToString();
                    this.txtrek.Text = model.cr_remark;
                    this.txtnum.Text = model.cr_num.ToString();
                }
            }
        }

        private void btn_js_Click(object sender, EventArgs e)
        {
            if (this.txtno.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
            }

            else
            {
                if (txtorder.SelectedValue != "")
                    GetStr(txtno.Text);
                else
                {
                    MessageBox.Show("请选择订单", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        BLL.tb_proc dalt = new BLL.tb_proc();
        private void GetStr(string _no)
        {
            string reStr = "";
            if (!string.IsNullOrEmpty(_no))
            {
                DataTable dt = dalt.GetList(" p_no='" + _no + "' and p_rzfid=" + txtorder.SelectedValue).Tables[0];
                if (dt.Rows.Count == 0) { MessageBox.Show("该订单所属商家下无此商品"); return; }
                txttyid.Text = dt.Rows[0]["p_id"].ToString();
                reStr = dt.Rows.Count > 0 ? dt.Rows[0]["p_name"].ToString() : "";
                txtname.Text = reStr;
            }

        }



    }
}
