namespace WinFrm.mag
{
    partial class StockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOrder));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
            this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
            this.tBtnDelete = new System.Windows.Forms.ToolBarButton();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
            this.btn_dept = new System.Windows.Forms.Button();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.tBtnEdit = new System.Windows.Forms.ToolBarButton();
            this.tBtnNew = new System.Windows.Forms.ToolBarButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkehu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkhid = new System.Windows.Forms.TextBox();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(72, 70);
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(167, 21);
            this.txtuser.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "经办人员：";
            // 
            // tBtnCancel
            // 
            this.tBtnCancel.ImageIndex = 4;
            this.tBtnCancel.Name = "tBtnCancel";
            this.tBtnCancel.Text = "取消";
            this.tBtnCancel.ToolTipText = "取消";
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
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(72, 29);
            this.txtno.Name = "txtno";
            this.txtno.ReadOnly = true;
            this.txtno.Size = new System.Drawing.Size(167, 21);
            this.txtno.TabIndex = 49;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(323, 70);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.Size = new System.Drawing.Size(405, 45);
            this.txtdesc.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 45;
            this.label10.Text = "备注说明：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 330);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入库订单列表";
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
            // tBtnQuit
            // 
            this.tBtnQuit.ImageIndex = 5;
            this.tBtnQuit.Name = "tBtnQuit";
            this.tBtnQuit.Text = "退出";
            this.tBtnQuit.ToolTipText = "退出";
            // 
            // btn_dept
            // 
            this.btn_dept.Enabled = false;
            this.btn_dept.Location = new System.Drawing.Point(456, 28);
            this.btn_dept.Name = "btn_dept";
            this.btn_dept.Size = new System.Drawing.Size(32, 23);
            this.btn_dept.TabIndex = 32;
            this.btn_dept.Text = "...";
            this.btn_dept.UseVisualStyleBackColor = true;
            this.btn_dept.Click += new System.EventHandler(this.btn_dept_Click);
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(595, 30);
            this.txtsum.Name = "txtsum";
            this.txtsum.ReadOnly = true;
            this.txtsum.Size = new System.Drawing.Size(167, 21);
            this.txtsum.TabIndex = 27;
            // 
            // tBtnEdit
            // 
            this.tBtnEdit.ImageIndex = 1;
            this.tBtnEdit.Name = "tBtnEdit";
            this.tBtnEdit.Text = "修改";
            this.tBtnEdit.ToolTipText = "修改";
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
            this.groupBox2.Controls.Add(this.txtuser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtno);
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_dept);
            this.groupBox2.Controls.Add(this.txtsum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtkehu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtkhid);
            this.groupBox2.Location = new System.Drawing.Point(3, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 123);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据编辑区";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "订单总额：";
            // 
            // txtkehu
            // 
            this.txtkehu.Location = new System.Drawing.Point(323, 29);
            this.txtkehu.Name = "txtkehu";
            this.txtkehu.ReadOnly = true;
            this.txtkehu.Size = new System.Drawing.Size(130, 21);
            this.txtkehu.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "订单编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "入驻商家：";
            // 
            // txtkhid
            // 
            this.txtkhid.Location = new System.Drawing.Point(494, 29);
            this.txtkhid.Name = "txtkhid";
            this.txtkhid.Size = new System.Drawing.Size(18, 21);
            this.txtkhid.TabIndex = 48;
            this.txtkhid.Visible = false;
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
            this.toolBar1.Size = new System.Drawing.Size(797, 28);
            this.toolBar1.TabIndex = 76;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // StockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolBar1);
            this.MaximizeBox = false;
            this.Name = "StockOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库管理>入库订单管理";
            this.Load += new System.EventHandler(this.frmru_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolBarButton tBtnCancel;
        private System.Windows.Forms.ToolBarButton tBtnSubmit;
        private System.Windows.Forms.ToolBarButton tBtnDelete;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolBarButton tBtnQuit;
        private System.Windows.Forms.Button btn_dept;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.ToolBarButton tBtnEdit;
        private System.Windows.Forms.ToolBarButton tBtnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkehu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkhid;
        private System.Windows.Forms.ToolBar toolBar1;
    }
}