using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFrm.Views
{
    public partial class ProdManage : Form
    {
        public string m_id = null;
        public string m_ty = null;
        public string optrowid = null;
        private BLL.tb_proc dal = new BLL.tb_proc();
        private BLL.tb_type dalt = new BLL.tb_type();
        private BLL.tb_ku dalk = new BLL.tb_ku();
        private BLL.tb_ruzhu dalr = new BLL.tb_ruzhu();
        private Model.tb_proc model = new Model.tb_proc();
        private Model.tb_type molt = new Model.tb_type();
        private Model.tb_ku molk = new Model.tb_ku();
        private Model.tb_ruzhu molr = new Model.tb_ruzhu();

        public ProdManage()
        {
            InitializeComponent();
        }

        private void bindData(string where)
        {
            DataSet ds = dal.GetListT(String.IsNullOrEmpty(where) ? " " : where);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "商品编号";
            dataGridView1.Columns[2].HeaderText = "商品名称";
            dataGridView1.Columns[3].HeaderText = "商品类型";
            dataGridView1.Columns[4].HeaderText = "商品品牌";
            dataGridView1.Columns[5].HeaderText = "型号规格";
            dataGridView1.Columns[6].HeaderText = "存储仓库";
            dataGridView1.Columns[7].HeaderText = "所存库区";
            dataGridView1.Columns[8].HeaderText = "生产厂家";
            dataGridView1.Columns[9].HeaderText = "商品单价";
            dataGridView1.Columns[10].HeaderText = "商品单位";
            dataGridView1.Columns[11].HeaderText = "创建时间";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].HeaderText = "所属商家";
        }

        private void setModifyMode(bool blnEdit)
        {
            txtno.ReadOnly = !blnEdit;
            txtname.ReadOnly = !blnEdit;
            txtppai.ReadOnly = !blnEdit;

            txtmodel.ReadOnly = !blnEdit;
            txtchjia.ReadOnly = !blnEdit;
            txtprice.ReadOnly = !blnEdit;

            txtunit.Enabled = blnEdit;
            btn_type.Enabled = blnEdit;
            btn_cangku.Enabled = blnEdit;
            btn_dept.Enabled = blnEdit;
            button1.Enabled = blnEdit;

        }

        private bool validateIput()
        {
            if (this.txtno.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品编号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtno.Focus();
                return false;
            }
            if (this.txtname.Text.Trim() == "")
            {
                MessageBox.Show("请输入商品名称", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtname.Focus();
                return false;
            }
            if (this.txttyid.Text.Trim() == "")
            {
                MessageBox.Show("请选择商品类型", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (this.txtckid.Text.Trim() == "")
            {
                MessageBox.Show("请选择存储仓库", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (this.txtkqid.Text.Trim() == "")
            {
                MessageBox.Show("请选择所存仓库", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (this.txtrzsjid.Text.Trim() == "")
            {
                MessageBox.Show("请选择所属商家", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        private void rstValue()
        {
            txtno.Text = txtname.Text = "";
            txtchjia.Text = txtprice.Text = "";
            txtkqid.Text = txtckid.Text = txttyid.Text = "";
            txtck.Text = txtkuqu.Text = txttype.Text = "";
            txtrzsj.Text = txtrzsjid.Text = "";
        }

        private void prodManage_Load(object sender, EventArgs e)
        {
            bindData("");
        }

        private void dgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            optrowid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!String.IsNullOrEmpty(optrowid))
            {
                model = dal.GetModel(Int32.Parse(optrowid));
                if (model != null)
                {
                    txttype.Text = getStr(1, int.Parse(model.p_tyid.ToString()));
                    txtck.Text = getStr(2, int.Parse(model.p_ckid.ToString()));
                    txtkuqu.Text = getStr(2, int.Parse(model.p_kqid.ToString()));
                    txtrzsj.Text = getStr(4, int.Parse(model.p_rzfid.ToString()));
                    txttyid.Text = model.p_tyid.ToString();
                    txtckid.Text = model.p_ckid.ToString();
                    txtkqid.Text = model.p_kqid.ToString();
                    txtrzsjid.Text = model.p_rzfid.ToString();

                    txtno.Text = model.p_no;
                    txtname.Text = model.p_name;
                    txtprice.Text = model.p_price;
                    txtchjia.Text = model.p_shang;
                    txtunit.SelectedText = model.p_unit;
                    txtppai.Text = model.p_pinpai;
                    txtmodel.Text = model.p_model;

                }
            }
        }

        private void tbBtnClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.ToolTipText == "新增")
            {
                rstValue();
                setModifyMode(true);
                optrowid = null;
            }
            if (e.Button.ToolTipText == "修改")
            {
                if (!String.IsNullOrEmpty(optrowid))
                {
                    setModifyMode(true);
                }
                else
                {
                    MessageBox.Show("请选择所要修改的行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (e.Button.ToolTipText == "删除")
            {
                if (!String.IsNullOrEmpty(optrowid))
                {
                    DialogResult result = MessageBox.Show("确认删除？", "删除数据", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        dal.Delete(int.Parse(optrowid));
                        rstValue();
                        MessageBox.Show("恭喜你，删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindData("");
                        setModifyMode(false);
                        optrowid = null;
                    }
                }
                else
                {
                    MessageBox.Show("请选择所要删除的行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (e.Button.ToolTipText == "提交")
            {
                if (validateIput())
                {
                    model = new Model.tb_proc();
                    if (!String.IsNullOrEmpty(optrowid))
                    { model = dal.GetModel(int.Parse(optrowid)); }
                    model.p_no = this.txtno.Text;
                    model.p_name = this.txtname.Text;
                    model.p_pinpai = this.txtppai.Text;
                    model.p_model = this.txtmodel.Text;
                    model.p_price = this.txtprice.Text;
                    model.p_shang = txtchjia.Text;
                    model.p_unit = txtunit.Text;
                    model.p_ckid = int.Parse(this.txtckid.Text);
                    model.p_kqid = int.Parse(this.txtkqid.Text);
                    model.p_tyid = int.Parse(this.txttyid.Text);
                    model.p_rzfid = int.Parse(this.txtrzsjid.Text);
                    if (String.IsNullOrEmpty(optrowid))
                    {
                        model.p_addtime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        int i = dal.Add(model);
                        if (i > 0)
                        {
                            MessageBox.Show("恭喜你，新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rstValue();
                            bindData("");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                    else
                    {
                        if (dal.Update(model))
                        {
                            MessageBox.Show("恭喜你，修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rstValue();
                            bindData("");
                            setModifyMode(false);
                            optrowid = null;
                        }
                    }
                }
            }
            if (e.Button.ToolTipText == "取消")
            {
                bindData("");
                rstValue();
                setModifyMode(false);
                optrowid = null;
            }
            if (e.Button.ToolTipText == "退出")
            {
                this.Close();
            }
        }

        private void btnSelectProdTypeClick(object sender, EventArgs e)
        {
            SelectProdType selectProdType = new SelectProdType();
            selectProdType.Fathertxtbox = this.txttype;
            selectProdType.Fatxtdid = this.txttyid;
            selectProdType.Show();
        }

        private void btnSelectWarehouseAreaClick(object sender, EventArgs e)
        {
            if (txtckid.Text == "")
            {
                MessageBox.Show("请先选择存储仓库"); return;
            }
            SelectWarehouseArea selectWarehouseArea = new SelectWarehouseArea();
            selectWarehouseArea.Fathertxtbox = this.txtkuqu;
            selectWarehouseArea.Fatxtzid = this.txtkqid;
            selectWarehouseArea.m_paid = this.txtckid.Text;
            selectWarehouseArea.Show();
        }

        private void btnWarehouseClick(object sender, EventArgs e)
        {
            SelectWarehouse selectWarehouse = new SelectWarehouse();
            selectWarehouse.Fathertxtbox = this.txtck;
            selectWarehouse.Fatxtdid = this.txtckid;
            selectWarehouse.Show();
        }

        private void btnProviderClick(object sender, EventArgs e)
        {
            SelectProvider selectProvider = new SelectProvider();
            selectProvider.Fathertxtbox = this.txtrzsj;
            selectProvider.FathertxtboxT = this.txtrzsjid;
            selectProvider.Show();
        }

        private string getStr(int type, int id)
        {
            string reStr = "";
            if (type == 1)
            {
                molt = new Model.tb_type();
                molt = dalt.GetModel(id);
                reStr = molt != null ? molt.t_name : "";
            }
            else if (type == 2 || type == 3)
            {
                molk = new Model.tb_ku();
                molk = dalk.GetModel(id);
                reStr = molk != null ? molk.k_name : "";
            }
            else if (type == 4)
            {
                molr = new Model.tb_ruzhu();
                molr = dalr.GetModel(id);
                reStr = molr != null ? molr.r_name : "";
            }
            return reStr;
        }

    }
}
