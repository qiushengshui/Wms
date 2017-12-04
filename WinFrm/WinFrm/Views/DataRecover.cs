using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFrm.Utils;


 namespace WinFrm.Views

{
    public partial class DataRecover : Form
    {
        public DataRecover()
        {
            InitializeComponent();
        }

        private void dataRecover_Load(object sender, EventArgs e)
        {
            string str = Application.StartupPath.ToString();//获得应用程序的启动路径
            str = str.Substring(0, str.LastIndexOf("\\"));//指定获得路径
            str = str.Substring(0, str.LastIndexOf("\\"));
            str += @"\Backup";
            textBox1.Text = str + "\\" + "5.bak";
        }

        private void btnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecover(object sender, EventArgs e)
        {
            try
            {

                string sql = string.Format("use master restore database dbcvT from disk='" + textBox1.Text.Trim() + "'");
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

