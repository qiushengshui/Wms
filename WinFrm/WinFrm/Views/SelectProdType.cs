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
        public SelectProdType()
        {
            InitializeComponent();
        }
        public string optrowid = null;
        Ctl.BLL.tb_type dal = new Ctl.BLL.tb_type();
        Ctl.Model.tb_type model = new Ctl.Model.tb_type();

        private void BindData(string where)
        {
            treeView1.Nodes.Clear();
            DataTable dt = dal.GetList(String.IsNullOrEmpty(where) ? " " : where).Tables[0];

            foreach (DataRow r in dt.Rows)
            {
                TreeNode node = treeView1.Nodes.Add(r["t_id"].ToString(), r["t_name"].ToString());
            }
        }
        private void ClearCtlValue()
        {
            txtname.Text = "";
        }


        private void frmsupp_Load(object sender, EventArgs e)
        {
            BindData("");
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
        public TextBox Fatxtdid { get; set; }
        private void button1_Click(object sender, EventArgs e)
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


    }
}
