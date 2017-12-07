using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinExcel;

namespace Wms.Views
{
    public partial class StockOutRecordQuery : Form
    {
        public string m_id;
        public string m_ty;
        public string optrowid = null;
        private BLL.tb_churu dal = new BLL.tb_churu();
        private Model.tb_churu model = new Model.tb_churu();

        public StockOutRecordQuery()
        {
            InitializeComponent();
        }

        private void stockOutRecordQuery_Load(object sender, EventArgs e)
        {
            //BindData(" ");
        }

        private void bindData(string where)
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

        private void btnQueryClick(object sender, EventArgs e)
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
            if (!string.IsNullOrEmpty(txtorder.Text))
            {
                sql += " and o_no='" + txtorder.Text + "' ";
            }
            if (!string.IsNullOrEmpty(txtkehu.Text))
            {
                sql += " and h_name='" + txtkehu.Text + "' ";
            }
            bindData(sql);
        }

        private void 导出报表exportExcel(object sender, EventArgs e)
        {
            ExportToExcel.OutputAsExcelFile(dataGridView1);
        }

    }
}
