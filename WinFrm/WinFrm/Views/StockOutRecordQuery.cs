using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class StockOutRecordQuery : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public StockOutRecordQuery()
        {
            InitializeComponent();
        }

        private void frmcx_Load(object sender, EventArgs e)
        {
            //BindData(" ");
        }
        public string optrowid = null;
        Ctl.BLL.tb_churu dal = new Ctl.BLL.tb_churu();
        Ctl.Model.tb_churu model = new Ctl.Model.tb_churu();

        private void BindData(string where)
        {
            DataSet ds = dal.GetListC(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单编号";
            dataGridView1.Columns[2].HeaderText = "商品编号";
            dataGridView1.Columns[3].HeaderText = "商品名称";
            dataGridView1.Columns[4].HeaderText = "出库数量";
            dataGridView1.Columns[5].HeaderText = "出库时间";
            dataGridView1.Columns[6].HeaderText = "出库单价";
            dataGridView1.Columns[7].HeaderText = "客户名称";
            dataGridView1.Columns[8].HeaderText = "客户电话";
            dataGridView1.Columns[9].HeaderText = "客户地址";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " cr_type=2 ";
            if (!string.IsNullOrEmpty(txtno.Text))
            {
                sql += " and p_no='" + txtno.Text + "' ";
            }
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                sql += " and p_name='" + txtname.Text + "' ";
            }
            if (!string.IsNullOrEmpty(txtno.Text))
            {
                sql += " and o_no='" + txtorder.Text + "' ";
            }
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                sql += " and h_name='" + txtkehu.Text + "' ";
            }
            BindData(sql);
        }

    }
}
