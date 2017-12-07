using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class SelectCustomer : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string optrowid = null;
        private BLL.tb_kehu dal = new BLL.tb_kehu();
        private Model.tb_kehu model = new Model.tb_kehu();

        public SelectCustomer()
        {
            InitializeComponent();
        }

        private void bindData(string where)
        {
            treeView1.Nodes.Clear();
            DataTable dt = dal.GetList(String.IsNullOrEmpty(where) ? " " : where).Tables[0];
            foreach (DataRow r in dt.Rows)
            {
                TreeNode node = treeView1.Nodes.Add(r["h_id"].ToString(), r["h_name"].ToString());
            }
        }

        private void rstValue()
        {
            txtname.Text = "";
        }

        private void tvCustomers(object sender, TreeViewEventArgs e)
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
                FathertxtboxT.Text = lbldeptid.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择客户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void selectCustomer_Load(object sender, EventArgs e)
        {
            string sql = "";
            bindData(sql);
        }

        public TextBox Fathertxtbox { get; set; }

        public TextBox FathertxtboxT { get; set; }
    }
}
