using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WinFrm.Utils;


namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_order
	/// </summary>
	public partial class tb_order
	{
		public tb_order()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbSQL.GetMaxID("o_id", "tb_order"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int o_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_order");
			strSql.Append(" where o_id="+o_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_order model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.o_no != null)
			{
				strSql1.Append("o_no,");
				strSql2.Append("'"+model.o_no+"',");
			}
			if (model.o_type != null)
			{
				strSql1.Append("o_type,");
				strSql2.Append(""+model.o_type+",");
			}
			if (model.o_time != null)
			{
				strSql1.Append("o_time,");
				strSql2.Append("'"+model.o_time+"',");
			}
			if (model.o_busy != null)
			{
				strSql1.Append("o_busy,");
				strSql2.Append(""+model.o_busy+",");
			}
			if (model.o_sum != null)
			{
				strSql1.Append("o_sum,");
				strSql2.Append("'"+model.o_sum+"',");
			}
			if (model.o_user != null)
			{
				strSql1.Append("o_user,");
				strSql2.Append("'"+model.o_user+"',");
			}
			if (model.o_desc != null)
			{
				strSql1.Append("o_desc,");
				strSql2.Append("'"+model.o_desc+"',");
			}
			strSql.Append("insert into tb_order(");
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
		public bool Update(Model.tb_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_order set ");
			if (model.o_no != null)
			{
				strSql.Append("o_no='"+model.o_no+"',");
			}
			else
			{
				strSql.Append("o_no= null ,");
			}
			if (model.o_type != null)
			{
				strSql.Append("o_type="+model.o_type+",");
			}
			else
			{
				strSql.Append("o_type= null ,");
			}
			if (model.o_time != null)
			{
				strSql.Append("o_time='"+model.o_time+"',");
			}
			else
			{
				strSql.Append("o_time= null ,");
			}
			if (model.o_busy != null)
			{
				strSql.Append("o_busy="+model.o_busy+",");
			}
			else
			{
				strSql.Append("o_busy= null ,");
			}
			if (model.o_sum != null)
			{
				strSql.Append("o_sum='"+model.o_sum+"',");
			}
			else
			{
				strSql.Append("o_sum= null ,");
			}
			if (model.o_user != null)
			{
				strSql.Append("o_user='"+model.o_user+"',");
			}
			else
			{
				strSql.Append("o_user= null ,");
			}
			if (model.o_desc != null)
			{
				strSql.Append("o_desc='"+model.o_desc+"',");
			}
			else
			{
				strSql.Append("o_desc= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where o_id="+ model.o_id+"");
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
		public bool Delete(int o_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_order ");
			strSql.Append(" where o_id="+o_id+"" );
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
		public bool DeleteList(string o_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_order ");
			strSql.Append(" where o_id in ("+o_idlist + ")  ");
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
		public Model.tb_order GetModel(int o_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" o_id,o_no,o_type,o_time,o_busy,o_sum,o_user,o_desc ");
			strSql.Append(" from tb_order ");
			strSql.Append(" where o_id="+o_id+"" );
			Model.tb_order model=new Model.tb_order();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["o_id"]!=null && ds.Tables[0].Rows[0]["o_id"].ToString()!="")
				{
					model.o_id=int.Parse(ds.Tables[0].Rows[0]["o_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["o_no"]!=null && ds.Tables[0].Rows[0]["o_no"].ToString()!="")
				{
					model.o_no=ds.Tables[0].Rows[0]["o_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["o_type"]!=null && ds.Tables[0].Rows[0]["o_type"].ToString()!="")
				{
					model.o_type=int.Parse(ds.Tables[0].Rows[0]["o_type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["o_time"]!=null && ds.Tables[0].Rows[0]["o_time"].ToString()!="")
				{
					model.o_time=ds.Tables[0].Rows[0]["o_time"].ToString();
				}
				if(ds.Tables[0].Rows[0]["o_busy"]!=null && ds.Tables[0].Rows[0]["o_busy"].ToString()!="")
				{
					model.o_busy=int.Parse(ds.Tables[0].Rows[0]["o_busy"].ToString());
				}
				if(ds.Tables[0].Rows[0]["o_sum"]!=null && ds.Tables[0].Rows[0]["o_sum"].ToString()!="")
				{
					model.o_sum=ds.Tables[0].Rows[0]["o_sum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["o_user"]!=null && ds.Tables[0].Rows[0]["o_user"].ToString()!="")
				{
					model.o_user=ds.Tables[0].Rows[0]["o_user"].ToString();
				}
				if(ds.Tables[0].Rows[0]["o_desc"]!=null && ds.Tables[0].Rows[0]["o_desc"].ToString()!="")
				{
					model.o_desc=ds.Tables[0].Rows[0]["o_desc"].ToString();
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
            strSql.Append("select o_id,o_no,o_time,h_name,h_tel,h_address,h_zipcode,o_sum,o_user,o_desc,o_busy,o_type ");
            strSql.Append(" FROM tb_order ta inner join tb_kehu tb on ta.o_busy=tb.h_id ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbSQL.Query(strSql.ToString());
		}
        public DataSet GetListR(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select o_id,o_no,o_time,r_name,r_utel,r_address,r_uname,o_sum,o_user,o_desc,o_busy,o_type ");
            strSql.Append(" FROM tb_order ta inner join tb_ruzhu tb on ta.o_busy=tb.r_id ");
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
			strSql.Append(" o_id,o_no,o_type,o_time,o_busy,o_sum,o_user,o_desc ");
			strSql.Append(" FROM tb_order ");
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
			strSql.Append("select count(1) FROM tb_order ");
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
				strSql.Append("order by T.o_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_order T ");
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

