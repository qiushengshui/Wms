namespace WinFrm.Views
{
    partial class SelectWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectWarehouse));
            this.lbldeptname2 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lbldeptname = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbldeptid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lbldeptid2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldeptname2
            // 
            this.lbldeptname2.AutoSize = true;
            this.lbldeptname2.Location = new System.Drawing.Point(152, 49);
            this.lbldeptname2.Name = "lbldeptname2";
            this.lbldeptname2.Size = new System.Drawing.Size(0, 12);
            this.lbldeptname2.TabIndex = 78;
            this.lbldeptname2.Visible = false;
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
            // lbldeptname
            // 
            this.lbldeptname.AutoSize = true;
            this.lbldeptname.Location = new System.Drawing.Point(73, 49);
            this.lbldeptname.Name = "lbldeptname";
            this.lbldeptname.Size = new System.Drawing.Size(0, 12);
            this.lbldeptname.TabIndex = 77;
            this.lbldeptname.Visible = false;
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
            // lbldeptid
            // 
            this.lbldeptid.AutoSize = true;
            this.lbldeptid.Location = new System.Drawing.Point(14, 507);
            this.lbldeptid.Name = "lbldeptid";
            this.lbldeptid.Size = new System.Drawing.Size(0, 12);
            this.lbldeptid.TabIndex = 76;
            this.lbldeptid.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "确认选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "选择：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldeptname2);
            this.groupBox1.Controls.Add(this.lbldeptname);
            this.groupBox1.Controls.Add(this.lbldeptid);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 504);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(59, 28);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(152, 21);
            this.txtname.TabIndex = 47;
            // 
            // treeView1
            // 
            this.treeView1.ItemHeight = 25;
            this.treeView1.Location = new System.Drawing.Point(9, 67);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(290, 428);
            this.treeView1.TabIndex = 46;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lbldeptid2
            // 
            this.lbldeptid2.AutoSize = true;
            this.lbldeptid2.Location = new System.Drawing.Point(159, 517);
            this.lbldeptid2.Name = "lbldeptid2";
            this.lbldeptid2.Size = new System.Drawing.Size(0, 12);
            this.lbldeptid2.TabIndex = 77;
            this.lbldeptid2.Visible = false;
            // 
            // SelectWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldeptid2);
            this.MaximizeBox = false;
            this.Name = "SelectWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库";
            this.Load += new System.EventHandler(this.sel_frmcangku_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldeptname2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lbldeptname;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbldeptid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lbldeptid2;
    }
}