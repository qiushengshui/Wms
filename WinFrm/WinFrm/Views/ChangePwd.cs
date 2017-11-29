using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm
{
    /// <summary>
    /// 修改密码
    /// </summary>
    public partial class ChangePwd : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLL.tb_user dal = new BLL.tb_user();
            Model.tb_user model = new Model.tb_user();
            if (this.txtpwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入旧密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtpwd.Focus();
                return;
            }
            if (this.txtpassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入新密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtpassword.Focus();
                return;
            }
            if (this.txtpasswordok.Text.Trim() == "")
            {
                MessageBox.Show("请再次输入新密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtpasswordok.Focus();
                return;
            }

            if (!String.IsNullOrEmpty(m_id))
            {
                DataRow[] dr = dal.GetList(" ").Tables[0].Select(" u_id=" + m_id);
                if (dr.Length > 0)
                {
                    if (dr[0]["u_pwd"].ToString() != txtpwd.Text.Trim().ToString())
                    {
                        MessageBox.Show("旧密码错误", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.txtpwd.Focus();
                        this.txtpwd.Text = "";
                        this.txtpassword.Text = "";
                        this.txtpasswordok.Text = "";
                    }
                    else
                    {
                        if (this.txtpassword.Text != this.txtpasswordok.Text)
                        {
                            MessageBox.Show("两次新密码不一致", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            model = dal.GetModel(int.Parse(m_id));
                            model.u_pwd = this.txtpasswordok.Text;                           
                            dal.Update(model);
                           // DialogResult result= MessageBox.Show("","",MessageBo)
                            MessageBox.Show("修改密码成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtpwd.Text = "";
                            this.txtpassword.Text = "";
                            this.txtpasswordok.Text = "";
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmudtpwd_Load(object sender, EventArgs e)
        {

        }
    }
}
