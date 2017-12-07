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
    /// 系统用户
    /// </summary>
    public partial class AccountManage : Form
    {
        public string m_id;
        public string m_ty;
        public string optrowid;
        private BLL.tb_user dal = new BLL.tb_user();
        private Model.tb_user model = new Model.tb_user();

        public AccountManage()
        {
            InitializeComponent();
        }

        private void accountManage_Load(object sender, EventArgs e)
        {
            bindData(" u_type=1 ");
        }

        private void bindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "姓名";
            dataGridView1.Columns[3].HeaderText = "电话";
            dataGridView1.Columns[4].HeaderText = "登录名";
            dataGridView1.Columns[5].HeaderText = "邮箱";
            dataGridView1.Columns[6].HeaderText = "创建日期";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void setModifyMode(bool blnEdit)
        {
            txtname.ReadOnly = !blnEdit;
            txtlogname.ReadOnly = !blnEdit;
            txttel.ReadOnly = !blnEdit;
            txtemail.ReadOnly = !blnEdit;
        }

        private bool validateInput()
        {
            if (this.txtname.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtname.Focus();
                return false;
            }
            if (this.txtlogname.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtlogname.Focus();
                return false;
            }

            return true;
        }

        private void rstValue()
        {
            txtname.Text = txtlogname.Text = "";
            txttel.Text = txtemail.Text = "";
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
                    txtname.Text = model.u_name;
                    txtlogname.Text = model.u_log;
                    txttel.Text = model.u_tel;
                    txtemail.Text = model.u_email;
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
                        bindData(" u_type=1 ");
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
                    model = new Model.tb_user();
                    if (!String.IsNullOrEmpty(optrowid))
                    { model = dal.GetModel(int.Parse(optrowid)); }
                    model.u_name = this.txtname.Text;
                    model.u_log = this.txtlogname.Text;
                    model.u_tel = this.txttel.Text;
                    model.u_email = this.txtemail.Text;
                    if (String.IsNullOrEmpty(optrowid))
                    {
                        model.u_type = 1;
                        model.u_adddate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        model.u_pwd = "000000";
                        int i = dal.Add(model);
                        if (i > 0)
                        {
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rstValue();
                            bindData(" u_type=1 ");
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
                            bindData(" u_type=1 ");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                bindData(" u_type=1 ");
                rstValue();
                setModifyMode(false);
                optrowid = null;
            }

            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }

    }
}
