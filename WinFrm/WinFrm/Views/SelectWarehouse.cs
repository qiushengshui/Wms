using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class SelectWarehouse : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string optrowid = null;
        private BLL.tb_ku dal = new BLL.tb_ku();
        private Model.tb_ku model = new Model.tb_ku();

        public SelectWarehouse()
        {
            InitializeComponent();
        }

        private void bindData(string where)
        {
            treeView1.Nodes.Clear();
            DataTable dt = dal.GetList(String.IsNullOrEmpty(where) ? " " : where).Tables[0];
            foreach (DataRow r in dt.Rows)
            {
                TreeNode node = treeView1.Nodes.Add(r["k_id"].ToString(), r["k_name"].ToString());
            }

        }

        private void rstValue()
        {
            txtname.Text = "";
        }

        private void selectWarehouse_Load(object sender, EventArgs e)
        {
            bindData("k_paid=0");
        }

        private void tvSelectWarehouse(object sender, TreeViewEventArgs e)
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

        private void btnConfirmClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbldeptid.Text))
            {
                Fathertxtbox.Text = lbldeptname.Text;
                Fatxtdid.Text = lbldeptid.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择仓库", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public TextBox Fathertxtbox { get; set; }

        public TextBox Fatxtdid { get; set; }
    }
}
