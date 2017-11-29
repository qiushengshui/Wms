namespace WinFrm.mag
{
    partial class ProdScrap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdScrap));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
            this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
            this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
            this.tBtnDelete = new System.Windows.Forms.ToolBarButton();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txttyid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBtnEdit = new System.Windows.Forms.ToolBarButton();
            this.btn_js = new System.Windows.Forms.Button();
            this.tBtnNew = new System.Windows.Forms.ToolBarButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // tBtnCancel
            // 
            this.tBtnCancel.ImageIndex = 4;
            this.tBtnCancel.Name = "tBtnCancel";
            this.tBtnCancel.Text = "取消";
            this.tBtnCancel.ToolTipText = "取消";
            // 
            // tBtnQuit
            // 
            this.tBtnQuit.ImageIndex = 5;
            this.tBtnQuit.Name = "tBtnQuit";
            this.tBtnQuit.Text = "退出";
            this.tBtnQuit.ToolTipText = "退出";
            // 
            // tBtnSubmit
            // 
            this.tBtnSubmit.ImageIndex = 3;
            this.tBtnSubmit.Name = "tBtnSubmit";
            this.tBtnSubmit.Text = "提交";
            this.tBtnSubmit.ToolTipText = "提交";
            // 
            // tBtnDelete
            // 
            this.tBtnDelete.ImageIndex = 2;
            this.tBtnDelete.Name = "tBtnDelete";
            this.tBtnDelete.Text = "删除";
            this.tBtnDelete.ToolTipText = "删除";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(790, 39);
            this.txtnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnum.Name = "txtnum";
            this.txtnum.ReadOnly = true;
            this.txtnum.Size = new System.Drawing.Size(197, 25);
            this.txtnum.TabIndex = 51;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(681, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "本次报废数量：";
            // 
            // txttyid
            // 
            this.txttyid.Location = new System.Drawing.Point(1011, 41);
            this.txttyid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttyid.Name = "txttyid";
            this.txttyid.Size = new System.Drawing.Size(27, 25);
            this.txttyid.TabIndex = 48;
            this.txttyid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 380);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tBtnEdit
            // 
            this.tBtnEdit.ImageIndex = 1;
            this.tBtnEdit.Name = "tBtnEdit";
            this.tBtnEdit.Text = "修改";
            this.tBtnEdit.ToolTipText = "修改";
            this.tBtnEdit.Visible = false;
            // 
            // btn_js
            // 
            this.btn_js.Enabled = false;
            this.btn_js.Location = new System.Drawing.Point(280, 37);
            this.btn_js.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_js.Name = "btn_js";
            this.btn_js.Size = new System.Drawing.Size(63, 29);
            this.btn_js.TabIndex = 31;
            this.btn_js.Text = "检索";
            this.btn_js.UseVisualStyleBackColor = true;
            this.btn_js.Click += new System.EventHandler(this.btn_js_Click);
            // 
            // tBtnNew
            // 
            this.tBtnNew.ImageIndex = 0;
            this.tBtnNew.Name = "tBtnNew";
            this.tBtnNew.Text = "新增";
            this.tBtnNew.ToolTipText = "新增";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnum);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txttyid);
            this.groupBox2.Controls.Add(this.btn_js);
            this.groupBox2.Controls.Add(this.txtno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(4, 465);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1055, 152);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据编辑区";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(96, 39);
            this.txtno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtno.Name = "txtno";
            this.txtno.ReadOnly = true;
            this.txtno.Size = new System.Drawing.Size(179, 25);
            this.txtno.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "商品编号：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(448, 39);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(197, 25);
            this.txtname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "商品名称：";
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tBtnNew,
            this.tBtnEdit,
            this.tBtnDelete,
            this.tBtnSubmit,
            this.tBtnCancel,
            this.tBtnQuit});
            this.toolBar1.ButtonSize = new System.Drawing.Size(31, 35);
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList2;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(1067, 28);
            this.toolBar1.TabIndex = 82;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1055, 412);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品报废列表";
            // 
            // ProdScrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ProdScrap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出库管理->商品报废";
            this.Load += new System.EventHandler(this.frmchuds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton tBtnCancel;
        private System.Windows.Forms.ToolBarButton tBtnQuit;
        private System.Windows.Forms.ToolBarButton tBtnSubmit;
        private System.Windows.Forms.ToolBarButton tBtnDelete;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttyid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolBarButton tBtnEdit;
        private System.Windows.Forms.Button btn_js;
        private System.Windows.Forms.ToolBarButton tBtnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}