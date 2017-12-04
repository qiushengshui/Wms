using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinExcel;

namespace WinFrm.Views
{
    public partial class StockRecordQuery : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public StockRecordQuery()
        {
            InitializeComponent();
        }

        private void frmcxr_Load(object sender, EventArgs e)
        {

        }

        public string optrowid = null;
        BLL.tb_churu dal = new BLL.tb_churu();
        Model.tb_churu model = new Model.tb_churu();

        private void BindData(string where)
        {
            DataSet ds = dal.GetList(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单编号";
            dataGridView1.Columns[2].HeaderText = "商品编号";
            dataGridView1.Columns[3].HeaderText = "商品名称";
            dataGridView1.Columns[4].HeaderText = "入库数量";
            dataGridView1.Columns[5].HeaderText = "入库时间";
            dataGridView1.Columns[6].HeaderText = "采购单价";
            dataGridView1.Columns[7].HeaderText = "入驻商家";
            dataGridView1.Columns[8].HeaderText = "存储仓库";
            dataGridView1.Columns[9].HeaderText = "所在库区";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " cr_type=1 ";
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
                sql += " and r_name='" + txtkehu.Text + "' ";
            }
            BindData(sql);
        }

        private void 导出报表exportExcel(object sender, EventArgs e)
        {
            ExportToExcel.OutputAsExcelFile(dataGridView1);
        }

    }
}
