using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wms
{
    /// <summary>
    /// 登陆
    /// </summary>
    public partial class Login : Form
    {
        // 业务逻辑层（BLL）/实体类库（Model）/数据访问层（DAL） 三层调用
        private BLL.tb_user dal = new BLL.tb_user();
        private Model.tb_user user = new Model.tb_user();

        public Login()
        {
            InitializeComponent();
        }

        private void btnConfirmClick(object sender, EventArgs e)
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
            user = dal.GetModel(pgname, pgpwd);
            if (user != null)
            {
                switch (user.u_type)
                {
                    case 0:
                        if (cbAccountType.Text != "管理员")
                        {
                            MessageBox.Show("登录权限错误");
                        }
                        else
                        {
                            Views.Main f5 = new Views.Main();
                            f5.m_username = user.u_name;
                            f5.m_id = user.u_id.ToString();
                            f5.m_ty = user.u_type.ToString();
                            f5.Show();
                            this.Hide();
                        }
                        break;
                    case 1:
                        if (cbAccountType.Text != "普通用户")
                        {
                            MessageBox.Show("登录权限错误");
                        }
                        else
                        {
                            Views.Main main = new Views.Main();
                            main.m_username = user.u_name;
                            main.m_id = user.u_id.ToString();
                            main.m_ty = user.u_type.ToString();
                            main.Show();
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

        private void btnCancelClick(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPwd.Text = "";
            this.Close();
        }
    }
}
