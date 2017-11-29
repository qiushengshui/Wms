using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class WarehouseAreaManage : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public WarehouseAreaManage()
        {
            InitializeComponent();
        }

        private void frmkuqu_Load(object sender, EventArgs e)
        {
            BindDdl();
            BindData("ta.k_paid>0 and tb.k_paid=0");
        }
        public string optrowid = null;
        Ctl.BLL.tb_ku dal = new Ctl.BLL.tb_ku();
        Ctl.Model.tb_ku model = new Ctl.Model.tb_ku();

        private void BindData(string where)
        {
            DataSet ds = dal.GetListT(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "所属仓库";
            dataGridView1.Columns[2].HeaderText = "库区编号";
            dataGridView1.Columns[3].HeaderText = "库区名称";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        private void BindDdl()
        {
            DataTable dt = dal.GetList("k_paid=0").Tables[0];
            this.txtpaid.DataSource = dt;
            txtpaid.DisplayMember = "k_name";
            txtpaid.ValueMember = "k_id";
        }
        private void SetModifyMode(bool blnEdit)
        {
            this.txtpaid.Enabled = blnEdit;
            this.t_name.ReadOnly = !blnEdit;
            this.t_no.ReadOnly = !blnEdit;

        }
        private bool ValidateIput()
        {
            if (this.txtpaid.Text.Trim() == "")
            {
                MessageBox.Show("请选择所属仓库", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtpaid.Focus();
                return false;
            }
            if (this.t_no.Text.Trim() == "")
            {
                MessageBox.Show("请输入库区编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.t_no.Focus();
                return false;
            }
            if (this.t_name.Text.Trim() == "")
            {
                MessageBox.Show("请输入库区名称", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.t_name.Focus();
                return false;
            }


            return true;
        }
        private void ClearCtlValue()
        {
            string val = "";
            this.txtpaid.Text = val;
            this.t_name.Text = val;

            this.t_no.Text = val;
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
                        BindData("ta.k_paid>0 and tb.k_paid=0");
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
                    model = new Ctl.Model.tb_ku();

                    if (!string.IsNullOrEmpty(optrowid))
                    {
                        model = dal.GetModel(int.Parse(optrowid));
                    }

                    model.k_name = this.t_name.Text;

                    model.k_paid = int.Parse(this.txtpaid.SelectedValue.ToString());
                    model.k_no = this.t_no.Text;

                    if (String.IsNullOrEmpty(optrowid))
                    {
                        DataTable dt = dal.GetList(" k_paid="+model.k_paid+" and (k_name='" + model.k_name + "' or k_no='" + model.k_no + "') ").Tables[0];
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("已存在该名称，请更换", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (dal.Add(model) > 0)
                        {
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCtlValue();
                            BindData("ta.k_paid>0 and tb.k_paid=0");
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
                            BindData("ta.k_paid>0 and tb.k_paid=0");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                BindData("ta.k_paid>0 and tb.k_paid=0");
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
                    this.t_name.Text = model.k_name;
                    this.txtpaid.SelectedValue = model.k_paid.ToString();
                    this.t_no.Text = model.k_no;
                }
            }
        }


    }
}
