namespace WinFrm.Views
{
    partial class ProdManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdManage));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtkuqu = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtrzsjid = new System.Windows.Forms.TextBox();
            this.txtrzsj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkqid = new System.Windows.Forms.TextBox();
            this.txtunit = new System.Windows.Forms.ComboBox();
            this.txtppai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.btn_dept = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtckid = new System.Windows.Forms.TextBox();
            this.txtck = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttyid = new System.Windows.Forms.TextBox();
            this.btn_cangku = new System.Windows.Forms.Button();
            this.txtchjia = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_type = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tBtnNew = new System.Windows.Forms.ToolBarButton();
            this.tBtnEdit = new System.Windows.Forms.ToolBarButton();
            this.tBtnDelete = new System.Windows.Forms.ToolBarButton();
            this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
            this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
            this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // txtkuqu
            // 
            this.txtkuqu.Location = new System.Drawing.Point(598, 92);
            this.txtkuqu.Name = "txtkuqu";
            this.txtkuqu.ReadOnly = true;
            this.txtkuqu.Size = new System.Drawing.Size(130, 21);
            this.txtkuqu.TabIndex = 25;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(72, 21);
            this.txtno.Name = "txtno";
            this.txtno.ReadOnly = true;
            this.txtno.Size = new System.Drawing.Size(149, 21);
            this.txtno.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "商品编号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "所存库区：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtrzsjid);
            this.groupBox2.Controls.Add(this.txtrzsj);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtkqid);
            this.groupBox2.Controls.Add(this.txtunit);
            this.groupBox2.Controls.Add(this.txtppai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtkuqu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtmodel);
            this.groupBox2.Controls.Add(this.btn_dept);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtckid);
            this.groupBox2.Controls.Add(this.txtck);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txttyid);
            this.groupBox2.Controls.Add(this.btn_cangku);
            this.groupBox2.Controls.Add(this.txtchjia);
            this.groupBox2.Controls.Add(this.txttype);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_type);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 155);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据编辑区";
            // 
            // txtrzsjid
            // 
            this.txtrzsjid.Location = new System.Drawing.Point(303, 128);
            this.txtrzsjid.Name = "txtrzsjid";
            this.txtrzsjid.Size = new System.Drawing.Size(21, 21);
            this.txtrzsjid.TabIndex = 59;
            this.txtrzsjid.Visible = false;
            // 
            // txtrzsj
            // 
            this.txtrzsj.Location = new System.Drawing.Point(72, 128);
            this.txtrzsj.Name = "txtrzsj";
            this.txtrzsj.ReadOnly = true;
            this.txtrzsj.Size = new System.Drawing.Size(187, 21);
            this.txtrzsj.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "所属商家：";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(265, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkqid
            // 
            this.txtkqid.Location = new System.Drawing.Point(482, 92);
            this.txtkqid.Name = "txtkqid";
            this.txtkqid.Size = new System.Drawing.Size(23, 21);
            this.txtkqid.TabIndex = 55;
            this.txtkqid.Visible = false;
            // 
            // txtunit
            // 
            this.txtunit.Enabled = false;
            this.txtunit.FormattingEnabled = true;
            this.txtunit.Items.AddRange(new object[] {
            "个",
            "瓶",
            "箱",
            "桶",
            "斤",
            "片",
            "台",
            "张",
            "包",
            "袋",
            "条",
            "把",
            "辆",
            "件"});
            this.txtunit.Location = new System.Drawing.Point(155, 92);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(66, 20);
            this.txtunit.TabIndex = 54;
            // 
            // txtppai
            // 
            this.txtppai.Location = new System.Drawing.Point(72, 58);
            this.txtppai.Name = "txtppai";
            this.txtppai.ReadOnly = true;
            this.txtppai.Size = new System.Drawing.Size(149, 21);
            this.txtppai.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 52;
            this.label1.Text = "商品品牌：";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(311, 60);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.ReadOnly = true;
            this.txtmodel.Size = new System.Drawing.Size(164, 21);
            this.txtmodel.TabIndex = 51;
            // 
            // btn_dept
            // 
            this.btn_dept.Enabled = false;
            this.btn_dept.Location = new System.Drawing.Point(730, 91);
            this.btn_dept.Name = "btn_dept";
            this.btn_dept.Size = new System.Drawing.Size(32, 23);
            this.btn_dept.TabIndex = 32;
            this.btn_dept.Text = "...";
            this.btn_dept.UseVisualStyleBackColor = true;
            this.btn_dept.Click += new System.EventHandler(this.btn_dept_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 50;
            this.label11.Text = "型号规格：";
            // 
            // txtckid
            // 
            this.txtckid.Location = new System.Drawing.Point(484, 60);
            this.txtckid.Name = "txtckid";
            this.txtckid.Size = new System.Drawing.Size(21, 21);
            this.txtckid.TabIndex = 49;
            this.txtckid.Visible = false;
            // 
            // txtck
            // 
            this.txtck.Location = new System.Drawing.Point(311, 92);
            this.txtck.Name = "txtck";
            this.txtck.ReadOnly = true;
            this.txtck.Size = new System.Drawing.Size(130, 21);
            this.txtck.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "存储仓库：";
            // 
            // txttyid
            // 
            this.txttyid.Location = new System.Drawing.Point(484, 21);
            this.txttyid.Name = "txttyid";
            this.txttyid.Size = new System.Drawing.Size(21, 21);
            this.txttyid.TabIndex = 48;
            this.txttyid.Visible = false;
            // 
            // btn_cangku
            // 
            this.btn_cangku.Enabled = false;
            this.btn_cangku.Location = new System.Drawing.Point(444, 91);
            this.btn_cangku.Name = "btn_cangku";
            this.btn_cangku.Size = new System.Drawing.Size(32, 23);
            this.btn_cangku.TabIndex = 36;
            this.btn_cangku.Text = "...";
            this.btn_cangku.UseVisualStyleBackColor = true;
            this.btn_cangku.Click += new System.EventHandler(this.btn_cangku_Click);
            // 
            // txtchjia
            // 
            this.txtchjia.Location = new System.Drawing.Point(598, 60);
            this.txtchjia.Name = "txtchjia";
            this.txtchjia.ReadOnly = true;
            this.txtchjia.Size = new System.Drawing.Size(164, 21);
            this.txtchjia.TabIndex = 46;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(598, 21);
            this.txttype.Name = "txttype";
            this.txttype.ReadOnly = true;
            this.txttype.Size = new System.Drawing.Size(130, 21);
            this.txttype.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 45;
            this.label10.Text = "生产厂家：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "商品类型：";
            // 
            // btn_type
            // 
            this.btn_type.Enabled = false;
            this.btn_type.Location = new System.Drawing.Point(730, 20);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(32, 23);
            this.btn_type.TabIndex = 31;
            this.btn_type.Text = "...";
            this.btn_type.UseVisualStyleBackColor = true;
            this.btn_type.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(72, 92);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(78, 21);
            this.txtprice.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 41;
            this.label9.Text = "单价/单位：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(311, 21);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(164, 21);
            this.txtname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
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
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(800, 28);
            this.toolBar1.TabIndex = 73;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tBtnNew
            // 
            this.tBtnNew.ImageIndex = 0;
            this.tBtnNew.Name = "tBtnNew";
            this.tBtnNew.Text = "新增";
            this.tBtnNew.ToolTipText = "新增";
            // 
            // tBtnEdit
            // 
            this.tBtnEdit.ImageIndex = 1;
            this.tBtnEdit.Name = "tBtnEdit";
            this.tBtnEdit.Text = "修改";
            this.tBtnEdit.ToolTipText = "修改";
            // 
            // tBtnDelete
            // 
            this.tBtnDelete.ImageIndex = 2;
            this.tBtnDelete.Name = "tBtnDelete";
            this.tBtnDelete.Text = "删除";
            this.tBtnDelete.ToolTipText = "删除";
            // 
            // tBtnSubmit
            // 
            this.tBtnSubmit.ImageIndex = 3;
            this.tBtnSubmit.Name = "tBtnSubmit";
            this.tBtnSubmit.Text = "提交";
            this.tBtnSubmit.ToolTipText = "提交";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 330);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品管理列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(778, 304);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ProdManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ProdManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主档管理->商品管理";
            this.Load += new System.EventHandler(this.frmchan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtkuqu;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton tBtnNew;
        private System.Windows.Forms.ToolBarButton tBtnEdit;
        private System.Windows.Forms.ToolBarButton tBtnDelete;
        private System.Windows.Forms.ToolBarButton tBtnSubmit;
        private System.Windows.Forms.ToolBarButton tBtnCancel;
        private System.Windows.Forms.ToolBarButton tBtnQuit;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cangku;
        private System.Windows.Forms.TextBox txtck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dept;
        private System.Windows.Forms.Button btn_type;
        private System.Windows.Forms.TextBox txtchjia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtckid;
        private System.Windows.Forms.TextBox txttyid;
        private System.Windows.Forms.TextBox txtppai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtunit;
        private System.Windows.Forms.TextBox txtkqid;
        private System.Windows.Forms.TextBox txtrzsjid;
        private System.Windows.Forms.TextBox txtrzsj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}