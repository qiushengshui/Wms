using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WinFrm.Utils;


namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_pan
	/// </summary>
	public partial class tb_pan
	{
		public tb_pan()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbSQL.GetMaxID("p_id", "tb_pan"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int p_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_pan");
			strSql.Append(" where p_id="+p_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_pan model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.p_pid != null)
			{
				strSql1.Append("p_pid,");
				strSql2.Append(""+model.p_pid+",");
			}
			if (model.p_time != null)
			{
				strSql1.Append("p_time,");
				strSql2.Append("'"+model.p_time+"',");
			}
			if (model.p_user != null)
			{
				strSql1.Append("p_user,");
				strSql2.Append("'"+model.p_user+"',");
			}
			if (model.p_numold != null)
			{
				strSql1.Append("p_numold,");
				strSql2.Append(""+model.p_numold+",");
			}
			if (model.p_numnow != null)
			{
				strSql1.Append("p_numnow,");
				strSql2.Append(""+model.p_numnow+",");
			}
			if (model.p_remark != null)
			{
				strSql1.Append("p_remark,");
				strSql2.Append("'"+model.p_remark+"',");
			}
			strSql.Append("insert into tb_pan(");
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
		public bool Update(Model.tb_pan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_pan set ");
			if (model.p_pid != null)
			{
				strSql.Append("p_pid="+model.p_pid+",");
			}
			else
			{
				strSql.Append("p_pid= null ,");
			}
			if (model.p_time != null)
			{
				strSql.Append("p_time='"+model.p_time+"',");
			}
			else
			{
				strSql.Append("p_time= null ,");
			}
			if (model.p_user != null)
			{
				strSql.Append("p_user='"+model.p_user+"',");
			}
			else
			{
				strSql.Append("p_user= null ,");
			}
			if (model.p_numold != null)
			{
				strSql.Append("p_numold="+model.p_numold+",");
			}
			else
			{
				strSql.Append("p_numold= null ,");
			}
			if (model.p_numnow != null)
			{
				strSql.Append("p_numnow="+model.p_numnow+",");
			}
			else
			{
				strSql.Append("p_numnow= null ,");
			}
			if (model.p_remark != null)
			{
				strSql.Append("p_remark='"+model.p_remark+"',");
			}
			else
			{
				strSql.Append("p_remark= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where p_id="+ model.p_id+"");
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
		public bool Delete(int p_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_pan ");
			strSql.Append(" where p_id="+p_id+"" );
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
		public bool DeleteList(string p_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_pan ");
			strSql.Append(" where p_id in ("+p_idlist + ")  ");
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
		public Model.tb_pan GetModel(int p_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" p_id,p_pid,p_time,p_user,p_numold,p_numnow,p_remark ");
			strSql.Append(" from tb_pan ");
			strSql.Append(" where p_id="+p_id+"" );
			Model.tb_pan model=new Model.tb_pan();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["p_id"]!=null && ds.Tables[0].Rows[0]["p_id"].ToString()!="")
				{
					model.p_id=int.Parse(ds.Tables[0].Rows[0]["p_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_pid"]!=null && ds.Tables[0].Rows[0]["p_pid"].ToString()!="")
				{
					model.p_pid=int.Parse(ds.Tables[0].Rows[0]["p_pid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_time"]!=null && ds.Tables[0].Rows[0]["p_time"].ToString()!="")
				{
					model.p_time=ds.Tables[0].Rows[0]["p_time"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_user"]!=null && ds.Tables[0].Rows[0]["p_user"].ToString()!="")
				{
					model.p_user=ds.Tables[0].Rows[0]["p_user"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_numold"]!=null && ds.Tables[0].Rows[0]["p_numold"].ToString()!="")
				{
					model.p_numold=decimal.Parse(ds.Tables[0].Rows[0]["p_numold"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_numnow"]!=null && ds.Tables[0].Rows[0]["p_numnow"].ToString()!="")
				{
					model.p_numnow=int.Parse(ds.Tables[0].Rows[0]["p_numnow"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_remark"]!=null && ds.Tables[0].Rows[0]["p_remark"].ToString()!="")
				{
					model.p_remark=ds.Tables[0].Rows[0]["p_remark"].ToString();
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
			strSql.Append("select ta.p_id,tb.p_no,tb.p_name,ta.p_time,ta.p_numold,ta.p_numnow,ta.p_user,ta.p_remark,ta.p_pid ");
			strSql.Append(" FROM tb_pan ta inner join tb_proc tb on ta.p_pid=tb.p_id ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			strSql.Append(" p_id,p_pid,p_time,p_user,p_numold,p_numnow,p_remark ");
			strSql.Append(" FROM tb_pan ");
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
			strSql.Append("select count(1) FROM tb_pan ");
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
				strSql.Append("order by T.p_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_pan T ");
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

