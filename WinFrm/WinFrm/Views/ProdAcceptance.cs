﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wms.Views
{
    public partial class ProdAcceptance : Form
    {
        public string m_id;
        public string m_ty;
        public string optrowid = null;
        private BLL.tb_churu dal = new BLL.tb_churu();
        private BLL.tb_proc dalt = new BLL.tb_proc();
        private BLL.tb_order der = new BLL.tb_order();
        private Model.tb_churu model = new Model.tb_churu();
        private Model.tb_order mode = new Model.tb_order();

        public ProdAcceptance()
        {
            InitializeComponent();
        }

        private void prodAcceptance_Load(object sender, EventArgs e)
        {
            bindDdl();
            bindData("cr_type=1");
        }

        private void bindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单编号";
            dataGridView1.Columns[2].HeaderText = "商品编号";
            dataGridView1.Columns[3].HeaderText = "商品名称";
            dataGridView1.Columns[4].HeaderText = "入库数量";
            dataGridView1.Columns[5].HeaderText = "入库时间";
            dataGridView1.Columns[6].HeaderText = "采购单价";
            dataGridView1.Columns[7].HeaderText = "入驻商家";
            dataGridView1.Columns[8].HeaderText = "存储仓库";
            dataGridView1.Columns[9].HeaderText = "所在库区";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
        }

        private void bindDdl()
        {
            DataTable mydt = new DataTable("cs");
            DataColumn dc = null;
            dc = mydt.Columns.Add("cid", Type.GetType("System.Int32"));
            dc = mydt.Columns.Add("cname", Type.GetType("System.String"));
            DataRow newRow;
            newRow = mydt.NewRow();
            newRow["cid"] = "1";
            newRow["cname"] = "是";
            mydt.Rows.Add(newRow);

            newRow = mydt.NewRow();
            newRow["cid"] = "0";
            newRow["cname"] = "否";
            mydt.Rows.Add(newRow);

            this.txtstatus.DataSource = mydt;
            txtstatus.DisplayMember = "cname";
            txtstatus.ValueMember = "cid";

            BLL.tb_order dalo = new BLL.tb_order();
            DataTable dt = dalo.GetList(1000, "o_type=1", "o_id desc").Tables[0];
            this.txtorder.DataSource = dt;
            txtorder.DisplayMember = "o_no";
            txtorder.ValueMember = "o_id";
        }

        private void setModifyMode(bool blnEdit)
        {
            this.txtno.ReadOnly = !blnEdit;
            this.txtorder.Enabled = blnEdit;
            this.txtstatus.Enabled = blnEdit;
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
                MessageBox.Show("请输入本次入库数量", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtnum.Focus();
                return false;
            }
            if (this.txtstatus.SelectedValue == "")
            {
                MessageBox.Show("请设置验收状态", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtstatus.Focus();
                return false;
            }
            return true;
        }

        private void rstValue()
        {
            string val = "";
            this.txtorder.Text = val;
            this.txtno.Text = val;
            this.txttyid.Text = val;
            this.txtname.Text = val;
            this.txtprice.Text = val;
            this.txtnum.Text = val;
            this.txtrek.Text = val;
            this.txtstatus.SelectedValue = "1";
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
                        bindData("cr_type=1");
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
                    model.cr_type = 1;
                    model.cr_yan = int.Parse(this.txtstatus.SelectedValue.ToString());
                    int tempNum = int.Parse(this.txtnum.Text);
                    if (tempNum <= 0)
                    {
                        MessageBox.Show("输入数量有误，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    model.cr_num = tempNum;
                    if (String.IsNullOrEmpty(optrowid))
                    {
                        model.cr_time = System.DateTime.Now.ToString("yyyy-MM-dd");
                        if (dal.Add(model) > 0)
                        {
                            BLL.tb_proc dap = new BLL.tb_proc();
                            Model.tb_proc mop = new Model.tb_proc();
                            mop = dap.GetModel(int.Parse(txttyid.Text));
                            if (model.cr_yan == 1)
                            {
                                mop.p_num = mop.p_num + int.Parse(this.txtnum.Text); //验收状态：是
                            }
                            else
                            {
                                mop.p_num = mop.p_num + 0; //验收状态：否
                            }
                            if (!string.IsNullOrEmpty(mop.p_sx))
                            {
                                if (mop.p_num > int.Parse(mop.p_sx))
                                {
                                    MessageBox.Show("已超过库存预警上限，请更换", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            dap.Update(mop);
                            if (model.cr_yan == 1)
                            {
                                MessageBox.Show("恭喜你，验收入库成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); //验收状态：是
                            }
                            else
                            {
                                MessageBox.Show("商品验收入库失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); //验收状态：否
                            }
                            rstValue();
                            bindData("cr_type=1");
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
                            bindData("cr_type=1");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                bindData("cr_type=1");
                rstValue();
                setModifyMode(false);
                optrowid = null;
            }

            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }

        private void dgvCellClick(object sender, DataGridViewCellEventArgs e)
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
                    this.txtstatus.SelectedValue = model.cr_yan.ToString();
                }
            }
        }

        private void btnChooseClick(object sender, EventArgs e)
        {
            if (this.txtno.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
            }
            else
            {
                if (txtorder.SelectedValue != "")
                    getStr(txtno.Text);
                else
                {
                    MessageBox.Show("请选择订单", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void getStr(string _no)
        {
            mode = der.GetModel(Convert.ToInt32(txtorder.SelectedValue));
            String provider = Convert.ToString(mode.o_busy);
            string reStr = "";
            if (!string.IsNullOrEmpty(_no))
            {
                //DataTable dt = dalt.GetList(" p_no='" + _no + "' and p_rzfid=" + txtorder.SelectedValue).Tables[0];
                DataTable dt = dalt.GetList(" p_no='" + _no + "' and p_rzfid=" + provider).Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("该订单所属商家下无此商品");
                    return;
                }
                txttyid.Text = dt.Rows[0]["p_id"].ToString();
                reStr = dt.Rows.Count > 0 ? dt.Rows[0]["p_name"].ToString() : "";
                txtname.Text = reStr;
            }
        }

    }
}
