using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZXing.QrCode;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using WinExcel;

namespace WinFrm.Views
{
    public partial class ProdInventoryQuery : Form
    {
        EncodingOptions options = null;
        BarcodeWriter writer = null; 
        public string m_id = null;
        public string m_ty = null;
        DataSet ds = null;
        public ProdInventoryQuery()
        {
            InitializeComponent();
        }
        public string optrowid = null;
        BLL.tb_proc dal = new BLL.tb_proc();
        Model.tb_proc model = new Model.tb_proc();

        private void BindData(string where)
        {
             ds = dal.GetListT2(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "商品编号";
            dataGridView1.Columns[2].HeaderText = "商品名称";
            dataGridView1.Columns[3].HeaderText = "库存数量";
            dataGridView1.Columns[4].HeaderText = "商品类型";
            dataGridView1.Columns[5].HeaderText = "商品品牌";
            dataGridView1.Columns[6].HeaderText = "型号规格";
            dataGridView1.Columns[7].HeaderText = "存储仓库";
            dataGridView1.Columns[8].HeaderText = "所存库区";
            dataGridView1.Columns[9].HeaderText = "生产厂家";
            dataGridView1.Columns[10].HeaderText = "所属商家";
            
        }

        private void frmchan_Load(object sender, EventArgs e)
        {
            BindData("");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " 1=1 ";
            if (!string.IsNullOrEmpty(z_no.Text))
            {
                sql += " and p_no='" + z_no.Text + "' ";
            }
            if (!string.IsNullOrEmpty(z_name.Text))
            {
                sql += " and p_name='" + z_name.Text + "' ";
            }
            BindData(sql);
        }

        private void 导出报表exportExcel(object sender, EventArgs e)
        {
            //ExportExcels.Export("123", dataGridView1);
            ExportExcels.SaveAsExcel(ds.Tables[0]);
        }

        
    }
}
