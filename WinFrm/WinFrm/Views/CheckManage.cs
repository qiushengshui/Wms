using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class CheckManage : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public CheckManage()
        {
            InitializeComponent();
        }
        public string optrowid = null;
        BLL.tb_pan dal = new BLL.tb_pan();
        Model.tb_pan model = new Model.tb_pan();

        private void BindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "商品编号";
            dataGridView1.Columns[2].HeaderText = "商品名称";
            dataGridView1.Columns[3].HeaderText = "盘点日期";
            dataGridView1.Columns[4].HeaderText = "库存数量";
            dataGridView1.Columns[5].HeaderText = "本次盘点数量";
            dataGridView1.Columns[6].HeaderText = "盘点人员";
            dataGridView1.Columns[7].HeaderText = "盘点说明";
            //dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void SetModifyMode(bool blnEdit)
        {
            txtno.ReadOnly = !blnEdit;            
            txtnumnow.ReadOnly = !blnEdit;
            txtuser.ReadOnly = !blnEdit;
            txtrek.ReadOnly = !blnEdit;

            btn_js.Enabled = blnEdit;

        }
        private bool ValidateIput()
        {
            if (this.txttyid.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
                return false;
            }
            if (this.txtnumnow.Text.Trim() == "")
            {
                MessageBox.Show("请输入本次盘点数量", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtname.Focus();
                return false;
            }
            
            return true;
        }
        private void ClearCtlValue()
        {
            txtno.Text = txtname.Text = "";
            txttime.Text = txtrek.Text = "";
            txttyid.Text = "";

            txtnumnow.Text = txtnumold.Text = txtuser.Text = "";
        }
        private void frmpan_Load(object sender, EventArgs e)
        {
            BindData("");
        }
        BLL.tb_proc dalt = new BLL.tb_proc();
        private string GetStr(string _no)
        {
            string reStr = "";
            if (!string.IsNullOrEmpty(_no))
            {
                DataTable dt = dalt.GetList(" p_no='" + _no + "' ").Tables[0];
                txttyid.Text = dt.Rows[0]["p_id"].ToString();
                txtnumold.Text = dt.Rows[0]["p_num"].ToString();
                reStr = dt.Rows.Count > 0 ? dt.Rows[0]["p_name"].ToString() : "";
            }

            return reStr;
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
                    Model.tb_proc ml = new Model.tb_proc();
                    ml = dalt.GetModel(int.Parse(model.p_pid.ToString()));
                    txtname.Text = ml.p_name;
                    txtno.Text = ml.p_no;                    
                    txttyid.Text = model.p_pid.ToString();

                    txttime.Text = model.p_time;
                    txtnumold.Text = model.p_numold.ToString();
                    txtnumnow.Text = model.p_numnow.ToString();
                    txtuser.Text = model.p_user;
                    txtrek.Text = model.p_remark;

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
                        BindData("");
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
                    model = new Model.tb_pan();
                    if (!String.IsNullOrEmpty(optrowid))
                    { model = dal.GetModel(int.Parse(optrowid)); }
                    model.p_pid = int.Parse(this.txttyid.Text);
                    model.p_time = this.txttime.Text;
                    model.p_numold = decimal.Parse(this.txtnumold.Text);
                    model.p_numnow = int.Parse(this.txtnumnow.Text);
                    model.p_user = txtuser.Text;
                    model.p_remark = this.txtrek.Text;

                    
                    if (String.IsNullOrEmpty(optrowid))
                    {
                        
                        int i = dal.Add(model);
                        if (i > 0)
                        {
                            BLL.tb_proc dalp = new BLL.tb_proc();
                            Model.tb_proc molp = new Model.tb_proc();
                            molp = dalp.GetModel(int.Parse(model.p_pid.ToString()));
                            molp.p_num = model.p_numnow;
                            dalp.Update(molp);
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCtlValue();
                            BindData("");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                    else
                    {
                        if (dal.Update(model))
                        {
                            BLL.tb_proc dalp = new BLL.tb_proc();
                            Model.tb_proc molp = new Model.tb_proc();
                            molp = dalp.GetModel(int.Parse(model.p_pid.ToString()));
                            molp.p_num = model.p_numnow;
                            dalp.Update(molp);
                            MessageBox.Show("恭喜你，修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCtlValue();
                            BindData("");
                            SetModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }

            if (e.Button.ToolTipText == "取消")
            {
                BindData("");
                ClearCtlValue();
                SetModifyMode(false);
                optrowid = null;
            }

            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }

        private void btn_js_Click(object sender, EventArgs e)
        {
            if (this.txtno.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
            }
            txtname.Text = GetStr(txtno.Text);
            txttime.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
