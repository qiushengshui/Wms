using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.mag
{
    public partial class StockOutOrder : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public StockOutOrder()
        {
            InitializeComponent();
        }
        public string optrowid = null;
        Ctl.BLL.tb_order dal = new Ctl.BLL.tb_order();
        Ctl.Model.tb_order model = new Ctl.Model.tb_order();
        Ctl.BLL.tb_kehu dalz = new Ctl.BLL.tb_kehu();
        Ctl.Model.tb_kehu modelz = new Ctl.Model.tb_kehu();

        private void BindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单编号";
            dataGridView1.Columns[2].HeaderText = "下单时间";
            dataGridView1.Columns[3].HeaderText = "客户姓名";
            dataGridView1.Columns[4].HeaderText = "客户电话";
            dataGridView1.Columns[5].HeaderText = "客户地址";
            dataGridView1.Columns[6].HeaderText = "所在地邮编";
            dataGridView1.Columns[7].HeaderText = "订单总额";
            dataGridView1.Columns[8].HeaderText = "提货人姓名";
            dataGridView1.Columns[9].HeaderText = "备注说明";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void SetModifyMode(bool blnEdit)
        {
            txtno.ReadOnly = !blnEdit;
            txtuser.ReadOnly = !blnEdit;
            txtdesc.ReadOnly = !blnEdit;
            txtsum.ReadOnly = !blnEdit;

            txtkehu.Enabled = blnEdit;
            btn_dept.Enabled = blnEdit;
        }
        private bool ValidateIput()
        { 
            if (this.txtno.Text.Trim() == "")
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
            txtno.Text = txtkehu.Text= txtkhid.Text=txtuser.Text = "";
            txtdesc.Text = txtsum.Text = "";
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
                    txtno.Text = model.o_no;
                    txtkhid.Text = model.o_busy.ToString();
                    modelz = dalz.GetModel((int)model.o_busy);
                    txtkehu.Text = modelz.h_name;
                    txtsum.Text = model.o_sum;
                    txtdesc.Text = model.o_desc;
                    txtuser.Text = model.o_user;
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
                    model = new Ctl.Model.tb_order();
                    if (!String.IsNullOrEmpty(optrowid))
                    { model = dal.GetModel(int.Parse(optrowid)); }
                    model.o_busy = int.Parse(this.txtkhid.Text);
                    model.o_no = this.txtno.Text;

                    model.o_sum = this.txtsum.Text;
                    model.o_desc = this.txtdesc.Text;
                    model.o_user = this.txtuser.Text;
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
            f2.Fathertxtbox = this.txtkehu;
            f2.FathertxtboxT = this.txtkhid;
            f2.Show();
        }

        private void frmchu_Load(object sender, EventArgs e)
        {
            BindData("o_type=2");
        }

    }
}
