﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class StockOrder : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public StockOrder()
        {
            InitializeComponent();
        }

        private void frmru_Load(object sender, EventArgs e)
        {
            BindData("o_type=1");
        }
        public string optrowid = null;
        BLL.tb_order dal = new BLL.tb_order();
        Model.tb_order model = new Model.tb_order();
        BLL.tb_ruzhu dalz = new BLL.tb_ruzhu();
        Model.tb_ruzhu modelz = new Model.tb_ruzhu();

        private void BindData(string where)
        {
            DataSet ds = dal.GetListR(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单编号";
            dataGridView1.Columns[2].HeaderText = "订单时间";
            dataGridView1.Columns[3].HeaderText = "商品编号";
            dataGridView1.Columns[4].HeaderText = "商品名称";
            dataGridView1.Columns[5].HeaderText = "订单数量";
            dataGridView1.Columns[6].HeaderText = "订单总额";
            dataGridView1.Columns[7].HeaderText = "入驻商名称";
            dataGridView1.Columns[8].HeaderText = "商家电话";
            dataGridView1.Columns[9].HeaderText = "商铺位置";
            dataGridView1.Columns[10].HeaderText = "联系人";
            dataGridView1.Columns[11].HeaderText = "经办人员";
            dataGridView1.Columns[12].HeaderText = "备注说明";
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
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
            txtno.Text = txtkehu.Text = txtkhid.Text = txtuser.Text = "";
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
                    txtkehu.Text = modelz.r_name;
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
                        BindData("o_type=1");
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
                    model.o_no = this.txtno.Text;

                    model.o_sum = this.txtsum.Text;
                    model.o_desc = this.txtdesc.Text;
                    model.o_user = this.txtuser.Text;

                    model.o_type = 1;
                    if (String.IsNullOrEmpty(optrowid))
                    {
                        model.o_time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        int i = dal.Add(model);
                        if (i > 0)
                        {
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCtlValue();
                            BindData("o_type=1");
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
                            BindData("o_type=1");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                BindData("o_type=1");
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
            SelectProvider f2 = new SelectProvider();
            f2.Fathertxtbox = this.txtkehu;
            f2.FathertxtboxT = this.txtkhid;
            f2.Show();
        }



    }
}
