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
    /// 登陆
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //string pgname = txtUser.Text.ToString().Trim();
            //string pgpwd = txtPwd.Text.ToString().Trim();

            string pgname = "admin";
            string pgpwd = "admin";

            if (pgname == "" || pgpwd == "")
            {
                MessageBox.Show("用户名或密码不能为空");
                txtUser.Focus();
                return;
            }
            // 业务逻辑层（BLL）/实体类库（Model）/数据访问层（DAL） 三层调用
            Ctl.BLL.tb_user dal = new Ctl.BLL.tb_user();
            Ctl.Model.tb_user user = new Ctl.Model.tb_user();
            user = dal.GetModel(pgname, pgpwd);

            if (user != null)
            {
                switch (user.u_type)
                {
                    case 2:
                        //gan.frmain f3 = new gan.frmain();
                        //f3.m_id = model.u_id.ToString();
                        //f3.m_ty = model.u_type.ToString();
                        //f3.Show();
                        break;
                    case 3:
                        if (cbAccountType.Text != "普通用户")
                        {
                            MessageBox.Show("登录权限错误");
                        }
                        else
                        {
                            mag.Main f3 = new mag.Main();
                            f3.m_username = user.u_name;
                            f3.m_id = user.u_id.ToString();
                            f3.m_ty = user.u_type.ToString();
                            f3.Show();
                            this.Hide();
                        }
                        break;
                    case 4:
                        if (cbAccountType.Text != "管理员")
                        {
                            MessageBox.Show("登录权限错误");
                        }
                        else
                        {
                            mag.Main f5 = new mag.Main();
                            f5.m_username = user.u_name;
                            f5.m_id = user.u_id.ToString();
                            f5.m_ty = user.u_type.ToString();
                            f5.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        MessageBox.Show("数据错误");
                        break;
                }

            }
            else
            {
                MessageBox.Show("用户名或密码不正确");
                return;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = txtPwd.Text = "";
            this.Close();
        }
    }
}
