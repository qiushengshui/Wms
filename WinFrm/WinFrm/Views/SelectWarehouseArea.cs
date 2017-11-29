using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class SelectWarehouseArea : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string m_paid = null;
        public SelectWarehouseArea()
        {
            InitializeComponent();
        }
        public string optrowid = null;
        Ctl.BLL.tb_ku dal = new Ctl.BLL.tb_ku();
        Ctl.Model.tb_ku model = new Ctl.Model.tb_ku();

        private void BindData(string where)
        {
            treeView1.Nodes.Clear();
            DataTable dt = dal.GetList(String.IsNullOrEmpty(where) ? " " : where).Tables[0];

            foreach (DataRow r in dt.Rows)
            {
                TreeNode node = treeView1.Nodes.Add(r["k_id"].ToString(), r["k_name"].ToString());
            }
        }
        private void ClearCtlValue()
        {
            txtname.Text = "";
        }


        private void frmsupp_Load(object sender, EventArgs e)
        {
            BindData(" k_paid=" + m_paid);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
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
        public TextBox Fathertxtbox { get; set; }
        public TextBox Fatxtzid { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbldeptid.Text))
            {
                Fathertxtbox.Text = lbldeptname.Text;
                Fatxtzid.Text = lbldeptid.Text;
                
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择部门", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


    }
}
