using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_type
	/// </summary>
	public partial class tb_type
	{
		public tb_type()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbSQL.GetMaxID("t_id", "tb_type"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int t_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_type");
			strSql.Append(" where t_id="+t_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_type model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.t_paid != null)
			{
				strSql1.Append("t_paid,");
				strSql2.Append(""+model.t_paid+",");
			}
			if (model.t_no != null)
			{
				strSql1.Append("t_no,");
				strSql2.Append("'"+model.t_no+"',");
			}
			if (model.t_name != null)
			{
				strSql1.Append("t_name,");
				strSql2.Append("'"+model.t_name+"',");
			}
			if (model.t_desc != null)
			{
				strSql1.Append("t_desc,");
				strSql2.Append("'"+model.t_desc+"',");
			}
			strSql.Append("insert into tb_type(");
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
		public bool Update(Model.tb_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_type set ");
			if (model.t_paid != null)
			{
				strSql.Append("t_paid="+model.t_paid+",");
			}
			else
			{
				strSql.Append("t_paid= null ,");
			}
			if (model.t_no != null)
			{
				strSql.Append("t_no='"+model.t_no+"',");
			}
			else
			{
				strSql.Append("t_no= null ,");
			}
			if (model.t_name != null)
			{
				strSql.Append("t_name='"+model.t_name+"',");
			}
			if (model.t_desc != null)
			{
				strSql.Append("t_desc='"+model.t_desc+"',");
			}
			else
			{
				strSql.Append("t_desc= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where t_id="+ model.t_id+"");
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
		public bool Delete(int t_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_type ");
			strSql.Append(" where t_id="+t_id+"" );
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
		public bool DeleteList(string t_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_type ");
			strSql.Append(" where t_id in ("+t_idlist + ")  ");
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
		public Model.tb_type GetModel(int t_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" t_id,t_paid,t_no,t_name,t_desc ");
			strSql.Append(" from tb_type ");
			strSql.Append(" where t_id="+t_id+"" );
			Model.tb_type model=new Model.tb_type();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["t_id"]!=null && ds.Tables[0].Rows[0]["t_id"].ToString()!="")
				{
					model.t_id=int.Parse(ds.Tables[0].Rows[0]["t_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["t_paid"]!=null && ds.Tables[0].Rows[0]["t_paid"].ToString()!="")
				{
					model.t_paid=int.Parse(ds.Tables[0].Rows[0]["t_paid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["t_no"]!=null && ds.Tables[0].Rows[0]["t_no"].ToString()!="")
				{
					model.t_no=ds.Tables[0].Rows[0]["t_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["t_name"]!=null && ds.Tables[0].Rows[0]["t_name"].ToString()!="")
				{
					model.t_name=ds.Tables[0].Rows[0]["t_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["t_desc"]!=null && ds.Tables[0].Rows[0]["t_desc"].ToString()!="")
				{
					model.t_desc=ds.Tables[0].Rows[0]["t_desc"].ToString();
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
			strSql.Append("select t_id,t_paid,t_no,t_name,t_desc ");
			strSql.Append(" FROM tb_type ");
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
			strSql.Append(" t_id,t_paid,t_no,t_name,t_desc ");
			strSql.Append(" FROM tb_type ");
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
			strSql.Append("select count(1) FROM tb_type ");
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
				strSql.Append("order by T.t_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_type T ");
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

