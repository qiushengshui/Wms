using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class WarningManage : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public WarningManage()
        {
            InitializeComponent();
        }

        private void frmdrug_Load(object sender, EventArgs e)
        {
            BindData("");
        }
        public string optrowid = null;
        BLL.tb_proc dal = new BLL.tb_proc();
        Model.tb_proc model = new Model.tb_proc();

        private void BindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "商品编号";
            dataGridView1.Columns[2].HeaderText = "商品名称";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].HeaderText = "预警上限";
            dataGridView1.Columns[10].HeaderText = "预警下限";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
        }

        private void SetModifyMode(bool blnEdit)
        {
            this.txtsx.ReadOnly = !blnEdit;            
            this.txtxx.ReadOnly = !blnEdit;

        }
        private bool ValidateIput()
        {
            if (this.txtsx.Text.Trim() == "")
            {
                MessageBox.Show("请输入预警上限", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
                return false;
            }
            if (this.txtxx.Text.Trim() == "")
            {
                MessageBox.Show("请输入预警下限", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtname.Focus();
                return false;
            }

            return true;
        }
        private void ClearCtlValue()
        {
            string val = "";

            this.txtname.Text = val;

            this.txtno.Text = val;
            this.txtsx.Text = val;
            this.txtxx.Text = val;
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
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
            if (e.Button.ToolTipText == "提交")
            {
                if (ValidateIput())
                {
                    model = new Model.tb_proc();

                    if (!string.IsNullOrEmpty(optrowid))
                    {
                        model = dal.GetModel(int.Parse(optrowid));
                    }

                    model.p_sx = this.txtsx.Text;
                    model.p_xx = this.txtxx.Text;

                    if (!String.IsNullOrEmpty(optrowid))
                    {
                        if (dal.Update(model))
                        {
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            optrowid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!String.IsNullOrEmpty(optrowid))
            {
                model = dal.GetModel(int.Parse(optrowid));
                if (model != null)
                {
                    this.txtno.Text = model.p_no;
                    this.txtname.Text = model.p_name;
                    this.txtsx.Text = model.p_sx;
                    this.txtxx.Text = model.p_xx;
                }
            }
        }


    }
}
