using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wms.Views
{
    public partial class ProdCategory : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string optrowid = null;
        private BLL.tb_type dal = new BLL.tb_type();
        private Model.tb_type model = new Model.tb_type();

        public ProdCategory()
        {
            InitializeComponent();
        }

        private void prodCategory_Load(object sender, EventArgs e)
        {
            bindData("");
        }

        private void bindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "分类编号";
            dataGridView1.Columns[3].HeaderText = "分类名称";
            dataGridView1.Columns[4].Visible = false;
        }

        private void setModifyMode(bool blnEdit)
        {
            this.t_name.ReadOnly = !blnEdit;
            this.t_no.ReadOnly = !blnEdit;

        }

        private bool validateIput()
        {
            if (this.t_no.Text.Trim() == "")
            {
                MessageBox.Show("请输入分类编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.t_no.Focus();
                return false;
            }
            if (this.t_name.Text.Trim() == "")
            {
                MessageBox.Show("请输入分类名称", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.t_name.Focus();
                return false;
            }


            return true;
        }

        private void rstValue()
        {
            string val = "";
            this.t_name.Text = val;
            this.t_no.Text = val;
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
                        bindData("");
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
                if (validateIput())
                {
                    model = new Model.tb_type();

                    if (!string.IsNullOrEmpty(optrowid))
                    {
                        model = dal.GetModel(int.Parse(optrowid));
                    }

                    model.t_name = this.t_name.Text;

                    model.t_no = this.t_no.Text;

                    if (String.IsNullOrEmpty(optrowid))
                    {
                        DataTable dt = dal.GetList(" t_name='" + model.t_name + "' or t_no='" + model.t_no + "' ").Tables[0];
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("恭喜你，已存在该名称，请更换", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (dal.Add(model) > 0)
                        {
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rstValue();
                            bindData("");
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
                            bindData("");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                bindData("");
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
                    this.t_name.Text = model.t_name;

                    this.t_no.Text = model.t_no;
                }
            }
        }
    }
}
