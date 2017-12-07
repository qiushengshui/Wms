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
    public partial class ProdScrapsQuery : Form
    {
        public string m_id;
        public string m_ty;
        public string optrowid = null;
        private BLL.tb_churu dal = new BLL.tb_churu();
        private Model.tb_churu model = new Model.tb_churu();

        public ProdScrapsQuery()
        {
            InitializeComponent();
        }

        private void stockOutRecordQuery_Load(object sender, EventArgs e)
        {
            //BindData(" ");
        }

        private void bindData(string where)
        {
            DataSet ds = dal.GetListB(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "商品编号";
            dataGridView1.Columns[2].HeaderText = "商品名称";
            dataGridView1.Columns[3].HeaderText = "报废数量";
            dataGridView1.Columns[4].HeaderText = "报废时间";
            dataGridView1.Columns[5].HeaderText = "报废原因";
   
        }

        private void btnQueryClick(object sender, EventArgs e)
        {
            string sql = " cr_type=3 ";
            if (!string.IsNullOrEmpty(txtno.Text))
            {
                sql += " and p_no='" + txtno.Text + "' ";
            }
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                sql += " and p_name='" + txtname.Text + "' ";
            }
            bindData(sql);
        }

        private void 导出报表exportExcel(object sender, EventArgs e)
        {
            ExportToExcel.OutputAsExcelFile(dataGridView1);
        }

    }
}
