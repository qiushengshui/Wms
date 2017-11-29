using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_ruzhu
	/// </summary>
	public partial class tb_ruzhu
	{
		public tb_ruzhu()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbSQL.GetMaxID("r_id", "tb_ruzhu"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int r_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_ruzhu");
			strSql.Append(" where r_id="+r_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_ruzhu model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.r_no != null)
			{
				strSql1.Append("r_no,");
				strSql2.Append("'"+model.r_no+"',");
			}
			if (model.r_name != null)
			{
				strSql1.Append("r_name,");
				strSql2.Append("'"+model.r_name+"',");
			}
			if (model.r_uname != null)
			{
				strSql1.Append("r_uname,");
				strSql2.Append("'"+model.r_uname+"',");
			}
			if (model.r_utel != null)
			{
				strSql1.Append("r_utel,");
				strSql2.Append("'"+model.r_utel+"',");
			}
			if (model.r_address != null)
			{
				strSql1.Append("r_address,");
				strSql2.Append("'"+model.r_address+"',");
			}
			if (model.r_desc != null)
			{
				strSql1.Append("r_desc,");
				strSql2.Append("'"+model.r_desc+"',");
			}
			strSql.Append("insert into tb_ruzhu(");
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
		public bool Update(Model.tb_ruzhu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_ruzhu set ");
			if (model.r_no != null)
			{
				strSql.Append("r_no='"+model.r_no+"',");
			}
			else
			{
				strSql.Append("r_no= null ,");
			}
			if (model.r_name != null)
			{
				strSql.Append("r_name='"+model.r_name+"',");
			}
			if (model.r_uname != null)
			{
				strSql.Append("r_uname='"+model.r_uname+"',");
			}
			else
			{
				strSql.Append("r_uname= null ,");
			}
			if (model.r_utel != null)
			{
				strSql.Append("r_utel='"+model.r_utel+"',");
			}
			else
			{
				strSql.Append("r_utel= null ,");
			}
			if (model.r_address != null)
			{
				strSql.Append("r_address='"+model.r_address+"',");
			}
			else
			{
				strSql.Append("r_address= null ,");
			}
			if (model.r_desc != null)
			{
				strSql.Append("r_desc='"+model.r_desc+"',");
			}
			else
			{
				strSql.Append("r_desc= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where r_id="+ model.r_id+"");
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
		public bool Delete(int r_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_ruzhu ");
			strSql.Append(" where r_id="+r_id+"" );
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
		public bool DeleteList(string r_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_ruzhu ");
			strSql.Append(" where r_id in ("+r_idlist + ")  ");
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
		public Model.tb_ruzhu GetModel(int r_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" r_id,r_no,r_name,r_uname,r_utel,r_address,r_desc ");
			strSql.Append(" from tb_ruzhu ");
			strSql.Append(" where r_id="+r_id+"" );
			Model.tb_ruzhu model=new Model.tb_ruzhu();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["r_id"]!=null && ds.Tables[0].Rows[0]["r_id"].ToString()!="")
				{
					model.r_id=int.Parse(ds.Tables[0].Rows[0]["r_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["r_no"]!=null && ds.Tables[0].Rows[0]["r_no"].ToString()!="")
				{
					model.r_no=ds.Tables[0].Rows[0]["r_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["r_name"]!=null && ds.Tables[0].Rows[0]["r_name"].ToString()!="")
				{
					model.r_name=ds.Tables[0].Rows[0]["r_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["r_uname"]!=null && ds.Tables[0].Rows[0]["r_uname"].ToString()!="")
				{
					model.r_uname=ds.Tables[0].Rows[0]["r_uname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["r_utel"]!=null && ds.Tables[0].Rows[0]["r_utel"].ToString()!="")
				{
					model.r_utel=ds.Tables[0].Rows[0]["r_utel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["r_address"]!=null && ds.Tables[0].Rows[0]["r_address"].ToString()!="")
				{
					model.r_address=ds.Tables[0].Rows[0]["r_address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["r_desc"]!=null && ds.Tables[0].Rows[0]["r_desc"].ToString()!="")
				{
					model.r_desc=ds.Tables[0].Rows[0]["r_desc"].ToString();
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
			strSql.Append("select r_id,r_no,r_name,r_uname,r_utel,r_address,r_desc ");
			strSql.Append(" FROM tb_ruzhu ");
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
			strSql.Append(" r_id,r_no,r_name,r_uname,r_utel,r_address,r_desc ");
			strSql.Append(" FROM tb_ruzhu ");
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
			strSql.Append("select count(1) FROM tb_ruzhu ");
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
				strSql.Append("order by T.r_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_ruzhu T ");
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

