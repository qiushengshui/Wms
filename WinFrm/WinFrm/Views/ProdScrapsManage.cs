using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wms.Views
{
    public partial class ProdScrapsManage : Form
    {
        public string m_id;
        public string m_ty;
        public string optrowid;
        private BLL.tb_churu dal = new BLL.tb_churu();
        private BLL.tb_proc dalt = new BLL.tb_proc();
        private Model.tb_churu model = new Model.tb_churu();

        public ProdScrapsManage()
        {
            InitializeComponent();
        }

        private void prodScrapsManage_Load(object sender, EventArgs e)
        {
            bindDdl();
            bindData("cr_type=3");
        }

        private void bindData(string where)
        {
            DataSet ds = dal.GetListB(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "商品编号";
            dataGridView1.Columns[2].HeaderText = "商品名称";
            dataGridView1.Columns[3].HeaderText = "报废数量";
            dataGridView1.Columns[4].HeaderText = "报废时间";
            dataGridView1.Columns[5].HeaderText = "报废原因";
        }

        private void bindDdl()
        {
            BLL.tb_order dalo = new BLL.tb_order();
            DataTable dt = dalo.GetList(1000, "o_type=3", "o_type desc").Tables[0];
        }

        private void setModifyMode(bool blnEdit)
        {
            this.txtno.ReadOnly = !blnEdit;
            this.txtnum.ReadOnly = !blnEdit;
            this.txtdesc.ReadOnly = !blnEdit;
            this.btn_js.Enabled = blnEdit;

        }

        private bool validateInput()
        {
            if (this.txttyid.Text.Trim() == "")
            {
                MessageBox.Show("请先检索商品", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
                return false;
            }
            if (this.txtnum.Text.Trim() == "")
            {
                MessageBox.Show("请输入本次报废数量", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtnum.Focus();
                return false;
            }
            return true;
        }

        private void rstValue()
        {
            string val = "";
            this.txtno.Text = val;
            this.txttyid.Text = val;
            this.txtname.Text = val;
            this.txtnum.Text = val;
            this.txtdesc.Text = val;
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
                        bindData("cr_type=3");
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
                    model = new Model.tb_churu();
                    if (!string.IsNullOrEmpty(optrowid))
                    {
                        model = dal.GetModel(int.Parse(optrowid));
                    }
                    model.cr_pid = int.Parse(txttyid.Text);
                    model.cr_remark = txtdesc.Text;
                    model.cr_type = 3;
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
                        Model.tb_proc mop = new Model.tb_proc();
                        BLL.tb_proc dap = new BLL.tb_proc();
                        mop = dap.GetModel(int.Parse(txttyid.Text));
                        if (mop.p_num < int.Parse(this.txtnum.Text))
                        {
                            MessageBox.Show("库存不足，请更换", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(mop.p_xx))
                            {
                                if (mop.p_num < int.Parse(mop.p_xx))
                                {
                                    MessageBox.Show("已达到库存预警下限", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            if (dal.Add(model) > 0)
                            {
                                mop.p_num = mop.p_num - int.Parse(this.txtnum.Text);
                                dap.Update(mop);
                                MessageBox.Show("恭喜你，报废成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                rstValue();
                                bindData("cr_type=3");
                                setModifyMode(false);
                                optrowid = null;
                            }
                        }
                    }
                    else
                    {
                        if (dal.Update(model))
                        {
                            MessageBox.Show("恭喜你，修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rstValue();
                            bindData("cr_type=3");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                bindData("cr_type=3");
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
                    this.txtdesc.Text = model.cr_remark;
                    this.txtnum.Text = model.cr_num.ToString();
                }
            }
        }

        private void btnCheckClick(object sender, EventArgs e)
        {
            if (this.txtno.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
            }

            else
            {
                getStr(txtno.Text);
            }
        }

        private void getStr(string no)
        {
            string reStr = "";
            if (!string.IsNullOrEmpty(no))
            {
                DataTable dt = dalt.GetList(" p_no='" + no + "'").Tables[0];
                if (dt.Rows.Count == 0) { MessageBox.Show("无此商品"); return; }
                txttyid.Text = dt.Rows[0]["p_id"].ToString();
                reStr = dt.Rows.Count > 0 ? dt.Rows[0]["p_name"].ToString() : "";
                txtname.Text = reStr;
            }

        }



    }
}
