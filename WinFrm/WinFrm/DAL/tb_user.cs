using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 数据访问类:tb_user
    /// </summary>
    public partial class tb_user
    {
        public tb_user()
        { }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbSQL.GetMaxID("u_id", "tb_user");
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int u_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_user");
            strSql.Append(" where u_id=" + u_id + " ");
            return DbSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.tb_user model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.u_log != null)
            {
                strSql1.Append("u_log,");
                strSql2.Append("'" + model.u_log + "',");
            }
            if (model.u_pwd != null)
            {
                strSql1.Append("u_pwd,");
                strSql2.Append("'" + model.u_pwd + "',");
            }
            if (model.u_no != null)
            {
                strSql1.Append("u_no,");
                strSql2.Append("'" + model.u_no + "',");
            }
            if (model.u_name != null)
            {
                strSql1.Append("u_name,");
                strSql2.Append("'" + model.u_name + "',");
            }
            if (model.u_tel != null)
            {
                strSql1.Append("u_tel,");
                strSql2.Append("'" + model.u_tel + "',");
            }
            if (model.u_email != null)
            {
                strSql1.Append("u_email,");
                strSql2.Append("'" + model.u_email + "',");
            }
            if (model.u_type != null)
            {
                strSql1.Append("u_type,");
                strSql2.Append("" + model.u_type + ",");
            }
            if (model.u_sex != null)
            {
                strSql1.Append("u_sex,");
                strSql2.Append("'" + model.u_sex + "',");
            }
            if (model.u_address != null)
            {
                strSql1.Append("u_address,");
                strSql2.Append("'" + model.u_address + "',");
            }
            if (model.u_adddate != null)
            {
                strSql1.Append("u_adddate,");
                strSql2.Append("'" + model.u_adddate + "',");
            }
            strSql.Append("insert into tb_user(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
            object obj = DbSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.tb_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_user set ");
            if (model.u_log != null)
            {
                strSql.Append("u_log='" + model.u_log + "',");
            }
            else
            {
                strSql.Append("u_log= null ,");
            }
            if (model.u_pwd != null)
            {
                strSql.Append("u_pwd='" + model.u_pwd + "',");
            }
            else
            {
                strSql.Append("u_pwd= null ,");
            }
            if (model.u_no != null)
            {
                strSql.Append("u_no='" + model.u_no + "',");
            }
            else
            {
                strSql.Append("u_no= null ,");
            }
            if (model.u_name != null)
            {
                strSql.Append("u_name='" + model.u_name + "',");
            }
            else
            {
                strSql.Append("u_name= null ,");
            }
            if (model.u_tel != null)
            {
                strSql.Append("u_tel='" + model.u_tel + "',");
            }
            else
            {
                strSql.Append("u_tel= null ,");
            }
            if (model.u_email != null)
            {
                strSql.Append("u_email='" + model.u_email + "',");
            }
            else
            {
                strSql.Append("u_email= null ,");
            }
            if (model.u_type != null)
            {
                strSql.Append("u_type=" + model.u_type + ",");
            }
            else
            {
                strSql.Append("u_type= null ,");
            }
            if (model.u_sex != null)
            {
                strSql.Append("u_sex='" + model.u_sex + "',");
            }
            else
            {
                strSql.Append("u_sex= null ,");
            }
            if (model.u_address != null)
            {
                strSql.Append("u_address='" + model.u_address + "',");
            }
            else
            {
                strSql.Append("u_address= null ,");
            }
            if (model.u_adddate != null)
            {
                strSql.Append("u_adddate='" + model.u_adddate + "',");
            }
            else
            {
                strSql.Append("u_adddate= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where u_id=" + model.u_id + "");
            int rowsAffected = DbSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int u_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_user ");
            strSql.Append(" where u_id=" + u_id + "");
            int rowsAffected = DbSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string u_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_user ");
            strSql.Append(" where u_id in (" + u_idlist + ")  ");
            int rows = DbSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.tb_user GetModel(int u_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" u_id,u_log,u_pwd,u_no,u_name,u_tel,u_email,u_type,u_sex,u_address,u_adddate ");
            strSql.Append(" from tb_user ");
            strSql.Append(" where u_id=" + u_id + "");
            Model.tb_user model = new Model.tb_user();
            DataSet ds = DbSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["u_id"] != null && ds.Tables[0].Rows[0]["u_id"].ToString() != "")
                {
                    model.u_id = int.Parse(ds.Tables[0].Rows[0]["u_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["u_log"] != null && ds.Tables[0].Rows[0]["u_log"].ToString() != "")
                {
                    model.u_log = ds.Tables[0].Rows[0]["u_log"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_pwd"] != null && ds.Tables[0].Rows[0]["u_pwd"].ToString() != "")
                {
                    model.u_pwd = ds.Tables[0].Rows[0]["u_pwd"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_no"] != null && ds.Tables[0].Rows[0]["u_no"].ToString() != "")
                {
                    model.u_no = ds.Tables[0].Rows[0]["u_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_name"] != null && ds.Tables[0].Rows[0]["u_name"].ToString() != "")
                {
                    model.u_name = ds.Tables[0].Rows[0]["u_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_tel"] != null && ds.Tables[0].Rows[0]["u_tel"].ToString() != "")
                {
                    model.u_tel = ds.Tables[0].Rows[0]["u_tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_email"] != null && ds.Tables[0].Rows[0]["u_email"].ToString() != "")
                {
                    model.u_email = ds.Tables[0].Rows[0]["u_email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_type"] != null && ds.Tables[0].Rows[0]["u_type"].ToString() != "")
                {
                    model.u_type = int.Parse(ds.Tables[0].Rows[0]["u_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["u_sex"] != null && ds.Tables[0].Rows[0]["u_sex"].ToString() != "")
                {
                    model.u_sex = ds.Tables[0].Rows[0]["u_sex"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_address"] != null && ds.Tables[0].Rows[0]["u_address"].ToString() != "")
                {
                    model.u_address = ds.Tables[0].Rows[0]["u_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_adddate"] != null && ds.Tables[0].Rows[0]["u_adddate"].ToString() != "")
                {
                    model.u_adddate = ds.Tables[0].Rows[0]["u_adddate"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }


        public Model.tb_user GetModel(string log, string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" u_id,u_log,u_pwd,u_no,u_name,u_tel,u_email,u_type,u_sex,u_address,u_adddate ");
            strSql.Append(" from tb_user ");
            strSql.Append(" where u_log='" + log + "' and u_pwd='" + pwd + "' ");
            Model.tb_user model = new Model.tb_user();
            DataSet ds = DbSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["u_id"] != null && ds.Tables[0].Rows[0]["u_id"].ToString() != "")
                {
                    model.u_id = int.Parse(ds.Tables[0].Rows[0]["u_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["u_log"] != null && ds.Tables[0].Rows[0]["u_log"].ToString() != "")
                {
                    model.u_log = ds.Tables[0].Rows[0]["u_log"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_pwd"] != null && ds.Tables[0].Rows[0]["u_pwd"].ToString() != "")
                {
                    model.u_pwd = ds.Tables[0].Rows[0]["u_pwd"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_no"] != null && ds.Tables[0].Rows[0]["u_no"].ToString() != "")
                {
                    model.u_no = ds.Tables[0].Rows[0]["u_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_name"] != null && ds.Tables[0].Rows[0]["u_name"].ToString() != "")
                {
                    model.u_name = ds.Tables[0].Rows[0]["u_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_tel"] != null && ds.Tables[0].Rows[0]["u_tel"].ToString() != "")
                {
                    model.u_tel = ds.Tables[0].Rows[0]["u_tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_email"] != null && ds.Tables[0].Rows[0]["u_email"].ToString() != "")
                {
                    model.u_email = ds.Tables[0].Rows[0]["u_email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_type"] != null && ds.Tables[0].Rows[0]["u_type"].ToString() != "")
                {
                    model.u_type = int.Parse(ds.Tables[0].Rows[0]["u_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["u_sex"] != null && ds.Tables[0].Rows[0]["u_sex"].ToString() != "")
                {
                    model.u_sex = ds.Tables[0].Rows[0]["u_sex"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_address"] != null && ds.Tables[0].Rows[0]["u_address"].ToString() != "")
                {
                    model.u_address = ds.Tables[0].Rows[0]["u_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["u_adddate"] != null && ds.Tables[0].Rows[0]["u_adddate"].ToString() != "")
                {
                    model.u_adddate = ds.Tables[0].Rows[0]["u_adddate"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select u_id,u_pwd,u_name,u_tel,u_log,u_email,u_adddate,u_type,u_sex,u_address,u_no ");
            strSql.Append(" FROM tb_user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" u_id,u_log,u_pwd,u_no,u_name,u_tel,u_email,u_type,u_sex,u_address,u_adddate ");
            strSql.Append(" FROM tb_user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.u_id desc");
            }
            strSql.Append(")AS Row, T.*  from tb_user T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  Method
    }
}

