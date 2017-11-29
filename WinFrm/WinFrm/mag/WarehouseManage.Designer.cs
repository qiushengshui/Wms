namespace WinFrm.mag
{
    partial class WarehouseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseManage));
            this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
            this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
            this.tBtnNew = new System.Windows.Forms.ToolBarButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tBtnEdit = new System.Windows.Forms.ToolBarButton();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tBtnDelete = new System.Windows.Forms.ToolBarButton();
            this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBtnQuit
            // 
            this.tBtnQuit.ImageIndex = 5;
            this.tBtnQuit.Name = "tBtnQuit";
            this.tBtnQuit.Text = "退出";
            this.tBtnQuit.ToolTipText = "退出";
            // 
            // tBtnCancel
            // 
            this.tBtnCancel.ImageIndex = 4;
            this.tBtnCancel.Name = "tBtnCancel";
            this.tBtnCancel.Text = "取消";
            this.tBtnCancel.ToolTipText = "取消";
            // 
            // tBtnNew
            // 
            this.tBtnNew.ImageIndex = 0;
            this.tBtnNew.Name = "tBtnNew";
            this.tBtnNew.Text = "新增";
            this.tBtnNew.ToolTipText = "新增";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 330);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(411, 304);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // tBtnEdit
            // 
            this.tBtnEdit.ImageIndex = 1;
            this.tBtnEdit.Name = "tBtnEdit";
            this.tBtnEdit.Text = "修改";
            this.tBtnEdit.ToolTipText = "修改";
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
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(433, 28);
            this.toolBar1.TabIndex = 82;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_name);
            this.groupBox2.Controls.Add(this.t_no);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 74);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据编辑区";
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(271, 31);
            this.t_name.Name = "t_name";
            this.t_name.ReadOnly = true;
            this.t_name.Size = new System.Drawing.Size(128, 21);
            this.t_name.TabIndex = 32;
            // 
            // t_no
            // 
            this.t_no.Location = new System.Drawing.Point(80, 31);
            this.t_no.Name = "t_no";
            this.t_no.ReadOnly = true;
            this.t_no.Size = new System.Drawing.Size(119, 21);
            this.t_no.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "仓库名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编号：";
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
            // WarehouseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "WarehouseManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主档管理->仓库管理";
            this.Load += new System.EventHandler(this.frmku_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBarButton tBtnQuit;
        private System.Windows.Forms.ToolBarButton tBtnCancel;
        private System.Windows.Forms.ToolBarButton tBtnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton tBtnEdit;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton tBtnDelete;
        private System.Windows.Forms.ToolBarButton tBtnSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList2;
    }
}