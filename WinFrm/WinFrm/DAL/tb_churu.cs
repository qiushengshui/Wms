using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WinFrm.Utils;


namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_churu
	/// </summary>
	public partial class tb_churu
	{
		public tb_churu()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbSQL.GetMaxID("cr_id", "tb_churu"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int cr_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_churu");
			strSql.Append(" where cr_id="+cr_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_churu model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.cr_oid != null)
			{
				strSql1.Append("cr_oid,");
				strSql2.Append(""+model.cr_oid+",");
			}
			if (model.cr_pid != null)
			{
				strSql1.Append("cr_pid,");
				strSql2.Append(""+model.cr_pid+",");
			}
			if (model.cr_time != null)
			{
				strSql1.Append("cr_time,");
				strSql2.Append("'"+model.cr_time+"',");
			}
			if (model.cr_type != null)
			{
				strSql1.Append("cr_type,");
				strSql2.Append(""+model.cr_type+",");
			}
			if (model.cr_num != null)
			{
				strSql1.Append("cr_num,");
				strSql2.Append(""+model.cr_num+",");
			}
			if (model.cr_yan != null)
			{
				strSql1.Append("cr_yan,");
				strSql2.Append(""+model.cr_yan+",");
			}
			if (model.cr_price != null)
			{
				strSql1.Append("cr_price,");
				strSql2.Append(""+model.cr_price+",");
			}
			if (model.cr_remark != null)
			{
				strSql1.Append("cr_remark,");
				strSql2.Append("'"+model.cr_remark+"',");
			}
			strSql.Append("insert into tb_churu(");
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
		public bool Update(Model.tb_churu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_churu set ");
			if (model.cr_oid != null)
			{
				strSql.Append("cr_oid="+model.cr_oid+",");
			}
			else
			{
				strSql.Append("cr_oid= null ,");
			}
			if (model.cr_pid != null)
			{
				strSql.Append("cr_pid="+model.cr_pid+",");
			}
			else
			{
				strSql.Append("cr_pid= null ,");
			}
			if (model.cr_time != null)
			{
				strSql.Append("cr_time='"+model.cr_time+"',");
			}
			else
			{
				strSql.Append("cr_time= null ,");
			}
			if (model.cr_type != null)
			{
				strSql.Append("cr_type="+model.cr_type+",");
			}
			else
			{
				strSql.Append("cr_type= null ,");
			}
			if (model.cr_num != null)
			{
				strSql.Append("cr_num="+model.cr_num+",");
			}
			else
			{
				strSql.Append("cr_num= null ,");
			}
			if (model.cr_yan != null)
			{
				strSql.Append("cr_yan="+model.cr_yan+",");
			}
			else
			{
				strSql.Append("cr_yan= null ,");
			}
			if (model.cr_price != null)
			{
				strSql.Append("cr_price="+model.cr_price+",");
			}
			else
			{
				strSql.Append("cr_price= null ,");
			}
			if (model.cr_remark != null)
			{
				strSql.Append("cr_remark='"+model.cr_remark+"',");
			}
			else
			{
				strSql.Append("cr_remark= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where cr_id="+ model.cr_id+"");
			int rowsAffected=DbSQL.ExecuteSql(strSql.ToString());
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
		public bool Delete(int cr_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_churu ");
			strSql.Append(" where cr_id="+cr_id+"" );
			int rowsAffected=DbSQL.ExecuteSql(strSql.ToString());
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
		public bool DeleteList(string cr_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_churu ");
			strSql.Append(" where cr_id in ("+cr_idlist + ")  ");
			int rows=DbSQL.ExecuteSql(strSql.ToString());
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
		public Model.tb_churu GetModel(int cr_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" cr_id,cr_oid,cr_pid,cr_time,cr_type,cr_num,cr_yan,cr_price,cr_remark ");
			strSql.Append(" from tb_churu ");
			strSql.Append(" where cr_id="+cr_id+"" );
			Model.tb_churu model=new Model.tb_churu();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["cr_id"]!=null && ds.Tables[0].Rows[0]["cr_id"].ToString()!="")
				{
					model.cr_id=int.Parse(ds.Tables[0].Rows[0]["cr_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cr_oid"]!=null && ds.Tables[0].Rows[0]["cr_oid"].ToString()!="")
				{
					model.cr_oid=int.Parse(ds.Tables[0].Rows[0]["cr_oid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cr_pid"]!=null && ds.Tables[0].Rows[0]["cr_pid"].ToString()!="")
				{
					model.cr_pid=int.Parse(ds.Tables[0].Rows[0]["cr_pid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cr_time"]!=null && ds.Tables[0].Rows[0]["cr_time"].ToString()!="")
				{
					model.cr_time=ds.Tables[0].Rows[0]["cr_time"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cr_type"]!=null && ds.Tables[0].Rows[0]["cr_type"].ToString()!="")
				{
					model.cr_type=int.Parse(ds.Tables[0].Rows[0]["cr_type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cr_num"]!=null && ds.Tables[0].Rows[0]["cr_num"].ToString()!="")
				{
					model.cr_num=int.Parse(ds.Tables[0].Rows[0]["cr_num"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cr_yan"]!=null && ds.Tables[0].Rows[0]["cr_yan"].ToString()!="")
				{
					model.cr_yan=int.Parse(ds.Tables[0].Rows[0]["cr_yan"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cr_price"]!=null && ds.Tables[0].Rows[0]["cr_price"].ToString()!="")
				{
					model.cr_price=decimal.Parse(ds.Tables[0].Rows[0]["cr_price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cr_remark"]!=null && ds.Tables[0].Rows[0]["cr_remark"].ToString()!="")
				{
					model.cr_remark=ds.Tables[0].Rows[0]["cr_remark"].ToString();
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
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select cr_id,o_no,p_no,p_name,cr_num,cr_time,cr_price,r_name,te.k_name,tf.k_name,cr_remark,cr_type,cr_yan,cr_oid,cr_pid ");
            strSql.Append(" FROM tb_churu ta inner join tb_order tb on ta.cr_oid=tb.o_id inner join tb_proc tc on ta.cr_pid=tc.p_id inner join tb_ruzhu td on tb.o_busy=td.r_id inner join tb_ku te on tc.p_ckid=te.k_id inner join tb_ku tf on tc.p_kqid=tf.k_id ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbSQL.Query(strSql.ToString());
		}

        public DataSet GetListC(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cr_id,o_no,p_no,p_name,cr_num,cr_time,cr_price,h_name,h_tel,h_address,cr_remark,cr_type,cr_yan,cr_oid,cr_pid ");
            strSql.Append(" FROM tb_churu ta inner join tb_order tb on ta.cr_oid=tb.o_id inner join tb_proc tc on ta.cr_pid=tc.p_id inner join tb_kehu td on tb.o_busy=td.h_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbSQL.Query(strSql.ToString());
        }

        public DataSet GetListB(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cr_id,p_no,p_name,cr_num,cr_time,cr_remark");
            strSql.Append(" FROM tb_churu ta  inner join tb_proc tc on ta.cr_pid=tc.p_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" cr_id,cr_oid,cr_pid,cr_time,cr_type,cr_num,cr_yan,cr_price,cr_remark ");
			strSql.Append(" FROM tb_churu ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tb_churu ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.cr_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_churu T ");
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

