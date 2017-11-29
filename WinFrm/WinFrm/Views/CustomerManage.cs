using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class CustomerManage : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public CustomerManage()
        {
            InitializeComponent();
        }

        private void frmkehu_Load(object sender, EventArgs e)
        {
            BindData(" ");
        }
        public string optrowid = null;
        BLL.tb_kehu dal = new BLL.tb_kehu();
        Model.tb_kehu model = new Model.tb_kehu();

        private void BindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "客户编号";
            dataGridView1.Columns[2].HeaderText = "客户名称";
            dataGridView1.Columns[3].HeaderText = "联系人";
            dataGridView1.Columns[4].HeaderText = "联系电话";
            dataGridView1.Columns[5].HeaderText = "客户地址";
            dataGridView1.Columns[6].HeaderText = "所在地邮编";
            dataGridView1.Columns[7].Visible = false;
        }

        private void SetModifyMode(bool blnEdit)
        {
            txtno.ReadOnly = !blnEdit;
            txtname.ReadOnly = !blnEdit;
            txtuname.ReadOnly = !blnEdit;
            txttel.ReadOnly = !blnEdit;
            txtaddress.ReadOnly = !blnEdit;
            txtzipcode.ReadOnly = !blnEdit;
        }
        private bool ValidateIput()
        {
            if (this.txtno.Text.Trim() == "")
            {
                MessageBox.Show("请输入客户编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
                return false;
            }
            if (this.txtname.Text.Trim() == "")
            {
                MessageBox.Show("请输入客户名称", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtname.Focus();
                return false;
            }

            return true;
        }
        private void ClearCtlValue()
        {
            txtno.Text = txtname.Text = "";
            txttel.Text = txtuname.Text = "";
            txtaddress.Text = txtzipcode.Text = "";
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
                    txtno.Text = model.h_no;
                    txtname.Text = model.h_name;

                    txttel.Text = model.h_tel;
                    txtuname.Text = model.h_uname;

                    txtaddress.Text = model.h_address;
                    txtzipcode.Text = model.h_zipcode;
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
                        BindData(" ");
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
                    model = new Model.tb_kehu();
                    if (!String.IsNullOrEmpty(optrowid))
                    { model = dal.GetModel(int.Parse(optrowid)); }
                    model.h_no = this.txtno.Text;
                    model.h_name = this.txtname.Text;

                    model.h_tel = this.txttel.Text;
                    model.h_uname = this.txtuname.Text;

                    model.h_address = this.txtaddress.Text;
                    model.h_zipcode = this.txtzipcode.Text;

                    if (String.IsNullOrEmpty(optrowid))
                    {
                        int i = dal.Add(model);
                        if (i > 0)
                        {
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCtlValue();
                            BindData(" ");
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
                            BindData(" ");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                BindData(" ");
                ClearCtlValue();
                SetModifyMode(false);
                optrowid = null;
            }

            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }


    }
}
