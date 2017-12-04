using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinExcel
{
    /// <summary>
    /// winForm程序导入导出EXCEL
    /// </summary>
    /// <remarks>
    /// 使用方法：
    /// 读取EXCEL数据:ImportExcel();
    /// 导出EXCEL:SaveAsExcel(system.data.datatable);
    /// </remarks>
    public class ExportExcels
    {
        /// <summary>
        /// 用oledb方式读取excel到datatable
        /// </summary>
        /// <remarks></remarks>
        /// <param name="strPath">文件存放路径</param>
        /// <returns></returns>
        private static System.Data.DataTable GetData(string strPath)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + strPath + ";" + "Extended Properties=Excel 8.0;";
                string strSheetName = "";
                using (OleDbConnection con = new OleDbConnection(strCon))
                {
                    con.Open();
                    System.Data.DataTable dtTemp = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    strSheetName = dtTemp.Rows[0][2].ToString().Trim();
                }
                String strCmd = "select * from [" + strSheetName + "]";
                OleDbDataAdapter cmd = new OleDbDataAdapter(strCmd, strCon);
                cmd.Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dt;
        }

        /// <summary>
        /// 导出到Excel
        /// </summary>
        /// <param name="dtExcel">数据源</param>
        public static void SaveAsExcel(System.Data.DataTable dtExcel)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出文件保存路径";
            saveFileDialog.ShowDialog();
            string strName = saveFileDialog.FileName;
            if (strName.Length != 0)
            {
                //导出到execl 
                System.Reflection.Missing miss = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.ApplicationClass excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                try
                {
                    excel.Application.Workbooks.Add(true);
                    excel.Visible = false;//若是true，则在导出的时候会显示EXcel界面。
                    if (excel == null)
                    {
                        MessageBox.Show("EXCEL无法启动！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Microsoft.Office.Interop.Excel.Workbooks books = (Microsoft.Office.Interop.Excel.Workbooks)excel.Workbooks;
                    Microsoft.Office.Interop.Excel.Workbook book = (Microsoft.Office.Interop.Excel.Workbook)(books.Add(miss));
                    Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                    sheet.Name = "test";

                    int m = 0, n = 0;
                    //生成列名称   这里i是从1开始的 因为我第0列是个隐藏列ID  没必要写进去
                    for (int i = 0; i < dtExcel.Columns.Count; i++)
                    {
                        excel.Cells[1, i + 1] = dtExcel.Columns[i].Caption.ToString();
                    }

                    //填充数据
                    for (int i = 0; i < dtExcel.Rows.Count; i++)
                    {
                        //j也是从1开始  原因如上  每个人需求不一样
                        for (int j = 0; j < dtExcel.Columns.Count; j++)
                        {
                            if (dtExcel.Rows[i][j].ToString().GetType() == typeof(string))
                            {
                                excel.Cells[i + 2, j + 1] = "'" + dtExcel.Rows[i][j].ToString().Trim();
                            }
                            else
                            {
                                excel.Cells[i + 2, j + 1] = dtExcel.Rows[i][j].ToString().Trim();
                            }
                        }
                    }

                    sheet.SaveAs(strName, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss);
                    book.Close(false, miss, miss);
                    books.Close();
                    excel.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(book);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(books);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                    GC.Collect();
                    MessageBox.Show("数据已经成功导出!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //toolStripProgressBar1.Value = 0;
                    System.Diagnostics.Process.Start(strName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                }
                finally
                {
                    //excel.Quit();
                    //KillSpecialExcel(excel);

                }
            }
        }



        private void ReleaseExcel(Microsoft.Office.Interop.Excel.Application m_objExcel)
        {
            m_objExcel.Quit();

            //System.Runtime.InteropServices.Marshal.ReleaseComObject((object)m_objExcel);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject((object)m_objBooks);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject((object)m_objBook);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject((object)sheet);

            //sheet = null;
            //m_objBook = null;
            //m_objBooks = null;
            m_objExcel = null;

            GC.Collect(0);
        }

        #region KillAllExcel 停止EXCEL进程
        private bool KillAllExcel(Microsoft.Office.Interop.Excel.Application m_objExcel)
        {
            try
            {
                if (m_objExcel != null) // isRunning是判断xlApp是怎么启动的flag.
                {
                    m_objExcel.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(m_objExcel);
                    //释放COM组件，其实就是将其引用计数减1
                    //System.Diagnostics.Process theProc;
                    foreach (System.Diagnostics.Process theProc in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                    {
                        //先关闭图形窗口。如果关闭失败...有的时候在状态里看不到图形窗口的excel了，
                        //但是在进程里仍然有EXCEL.EXE的进程存在，那么就需要杀掉它:p
                        if (theProc.CloseMainWindow() == false)
                        {
                            theProc.Kill();
                        }
                    }
                    m_objExcel = null;
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion


        public static void Export(string fileName, DataGridView myDGV)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
            //写入标题
            for (int i = 0; i < myDGV.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < myDGV.Rows.Count; r++)
            {
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
            MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

