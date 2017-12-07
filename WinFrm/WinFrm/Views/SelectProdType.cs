using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class SelectProdType : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string optrowid = null;
        private BLL.tb_type dal = new BLL.tb_type();
        private Model.tb_type model = new Model.tb_type();

        public SelectProdType()
        {
            InitializeComponent();
        }

        private void bindData(string where)
        {
            treeView1.Nodes.Clear();
            DataTable dt = dal.GetList(String.IsNullOrEmpty(where) ? " " : where).Tables[0];
            foreach (DataRow r in dt.Rows)
            {
                TreeNode node = treeView1.Nodes.Add(r["t_id"].ToString(), r["t_name"].ToString());
            }
        }

        private void rstValue()
        {
            txtname.Text = "";
        }

        private void selectProdType_Load(object sender, EventArgs e)
        {
            bindData("");
        }

        private void tvSelectProdType(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                optrowid = treeView1.SelectedNode.Name.ToString();
                string txt = treeView1.SelectedNode.Text.ToString();
                lbldeptname.Text = txt;
                lbldeptid.Text = optrowid;
                txtname.Text = txt;
            }
        }

        private void btvnConfirmClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbldeptid.Text))
            {
                Fathertxtbox.Text = lbldeptname.Text;
                Fatxtdid.Text = lbldeptid.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择商品类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public TextBox Fathertxtbox { get; set; }

        public TextBox Fatxtdid { get; set; }

    }
}
