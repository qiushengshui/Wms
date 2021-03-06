﻿namespace Wms.Views
{
    partial class WarningManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtxx = new System.Windows.Forms.TextBox();
            this.txtsx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
            this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
            this.tBtnNew = new System.Windows.Forms.ToolBarButton();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tBtnEdit = new System.Windows.Forms.ToolBarButton();
            this.tBtnDelete = new System.Windows.Forms.ToolBarButton();
            this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 330);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(447, 304);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtxx);
            this.groupBox2.Controls.Add(this.txtsx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtno);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 101);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据编辑区";
            // 
            // txtxx
            // 
            this.txtxx.Location = new System.Drawing.Point(300, 63);
            this.txtxx.Name = "txtxx";
            this.txtxx.ReadOnly = true;
            this.txtxx.Size = new System.Drawing.Size(145, 21);
            this.txtxx.TabIndex = 36;
            // 
            // txtsx
            // 
            this.txtsx.Location = new System.Drawing.Point(80, 63);
            this.txtsx.Name = "txtsx";
            this.txtsx.ReadOnly = true;
            this.txtsx.Size = new System.Drawing.Size(145, 21);
            this.txtsx.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "预警下限：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "预警上限：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(300, 31);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(145, 21);
            this.txtname.TabIndex = 32;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(80, 31);
            this.txtno.Name = "txtno";
            this.txtno.ReadOnly = true;
            this.txtno.Size = new System.Drawing.Size(145, 21);
            this.txtno.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "商品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品编号：";
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
            this.tBtnNew.Visible = false;
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
            this.toolBar1.Size = new System.Drawing.Size(465, 28);
            this.toolBar1.TabIndex = 79;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbBtnClick);
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
            this.tBtnDelete.Visible = false;
            // 
            // tBtnSubmit
            // 
            this.tBtnSubmit.ImageIndex = 3;
            this.tBtnSubmit.Name = "tBtnSubmit";
            this.tBtnSubmit.Text = "提交";
            this.tBtnSubmit.ToolTipText = "提交";
            // 
            // WarningManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolBar1);
            this.MaximizeBox = false;
            this.Name = "WarningManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库内管理->库存预警管理";
            this.Load += new System.EventHandler(this.warningManage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton tBtnQuit;
        private System.Windows.Forms.ToolBarButton tBtnCancel;
        private System.Windows.Forms.ToolBarButton tBtnNew;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton tBtnEdit;
        private System.Windows.Forms.ToolBarButton tBtnDelete;
        private System.Windows.Forms.ToolBarButton tBtnSubmit;
        private System.Windows.Forms.TextBox txtxx;
        private System.Windows.Forms.TextBox txtsx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}