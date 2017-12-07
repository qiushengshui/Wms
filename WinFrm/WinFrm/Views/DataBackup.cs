using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Wms.Utils;

namespace Wms.Views
{
    public partial class DataBackup : Form
    {
        public DataBackup()
        {
            InitializeComponent();
        }

        private void dataBackup_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup(object sender, EventArgs e)
        {
            try
            {
                string str = Application.StartupPath.ToString();//获得应用程序的启动路径
                str = str.Substring(0, str.LastIndexOf("\\"));//指定获得路径
                str = str.Substring(0, str.LastIndexOf("\\"));
                str += @"\Backup";
                string sql = string.Format("backup database dbcvT to disk='" + str + "\\" + textBox1.Text.Trim() + ".bak" + "'");
                int i = DbSQL.getbyquery(sql);
                if (MessageBox.Show("OK", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                { this.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
