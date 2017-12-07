using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Wms.Utils;


namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_ku
	/// </summary>
	public partial class tb_ku
	{
		public tb_ku()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		    return DbSQL.GetMaxID("k_id", "tb_ku"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int k_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_ku");
			strSql.Append(" where k_id="+k_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_ku model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.k_paid != null)
			{
				strSql1.Append("k_paid,");
				strSql2.Append(""+model.k_paid+",");
			}
			if (model.k_no != null)
			{
				strSql1.Append("k_no,");
				strSql2.Append("'"+model.k_no+"',");
			}
			if (model.k_name != null)
			{
				strSql1.Append("k_name,");
				strSql2.Append("'"+model.k_name+"',");
			}
			if (model.k_desc != null)
			{
				strSql1.Append("k_desc,");
				strSql2.Append("'"+model.k_desc+"',");
			}
			strSql.Append("insert into tb_ku(");
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
		public bool Update(Model.tb_ku model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_ku set ");
			if (model.k_paid != null)
			{
				strSql.Append("k_paid="+model.k_paid+",");
			}
			else
			{
				strSql.Append("k_paid= null ,");
			}
			if (model.k_no != null)
			{
				strSql.Append("k_no='"+model.k_no+"',");
			}
			else
			{
				strSql.Append("k_no= null ,");
			}
			if (model.k_name != null)
			{
				strSql.Append("k_name='"+model.k_name+"',");
			}
			if (model.k_desc != null)
			{
				strSql.Append("k_desc='"+model.k_desc+"',");
			}
			else
			{
				strSql.Append("k_desc= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where k_id="+ model.k_id+"");
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
		public bool Delete(int k_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_ku ");
			strSql.Append(" where k_id="+k_id+"" );
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
		public bool DeleteList(string k_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_ku ");
			strSql.Append(" where k_id in ("+k_idlist + ")  ");
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
		public Model.tb_ku GetModel(int k_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" k_id,k_paid,k_no,k_name,k_desc ");
			strSql.Append(" from tb_ku ");
			strSql.Append(" where k_id="+k_id+"" );
			Model.tb_ku model=new Model.tb_ku();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["k_id"]!=null && ds.Tables[0].Rows[0]["k_id"].ToString()!="")
				{
					model.k_id=int.Parse(ds.Tables[0].Rows[0]["k_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["k_paid"]!=null && ds.Tables[0].Rows[0]["k_paid"].ToString()!="")
				{
					model.k_paid=int.Parse(ds.Tables[0].Rows[0]["k_paid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["k_no"]!=null && ds.Tables[0].Rows[0]["k_no"].ToString()!="")
				{
					model.k_no=ds.Tables[0].Rows[0]["k_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["k_name"]!=null && ds.Tables[0].Rows[0]["k_name"].ToString()!="")
				{
					model.k_name=ds.Tables[0].Rows[0]["k_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["k_desc"]!=null && ds.Tables[0].Rows[0]["k_desc"].ToString()!="")
				{
					model.k_desc=ds.Tables[0].Rows[0]["k_desc"].ToString();
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
			strSql.Append("select k_id,k_paid,k_no,k_name,k_desc ");
			strSql.Append(" FROM tb_ku ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbSQL.Query(strSql.ToString());
		}
        public DataSet GetListT(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.k_id,tb.k_name,ta.k_no,ta.k_name,ta.k_desc,ta.k_paid ");
            strSql.Append(" FROM tb_ku ta inner join tb_ku tb on ta.k_paid=tb.k_id ");
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
			strSql.Append(" k_id,k_paid,k_no,k_name,k_desc ");
			strSql.Append(" FROM tb_ku ");
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
			strSql.Append("select count(1) FROM tb_ku ");
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
				strSql.Append("order by T.k_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_ku T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

