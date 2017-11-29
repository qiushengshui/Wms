using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Ctl.DAL
{
	/// <summary>
	/// 数据访问类:tb_kehu
	/// </summary>
	public partial class tb_kehu
	{
		public tb_kehu()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbSQL.GetMaxID("h_id", "tb_kehu"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int h_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_kehu");
			strSql.Append(" where h_id="+h_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Ctl.Model.tb_kehu model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.h_no != null)
			{
				strSql1.Append("h_no,");
				strSql2.Append("'"+model.h_no+"',");
			}
			if (model.h_name != null)
			{
				strSql1.Append("h_name,");
				strSql2.Append("'"+model.h_name+"',");
			}
			if (model.h_tel != null)
			{
				strSql1.Append("h_tel,");
				strSql2.Append("'"+model.h_tel+"',");
			}
			if (model.h_address != null)
			{
				strSql1.Append("h_address,");
				strSql2.Append("'"+model.h_address+"',");
			}
			if (model.h_zipcode != null)
			{
				strSql1.Append("h_zipcode,");
				strSql2.Append("'"+model.h_zipcode+"',");
			}
			if (model.h_uname != null)
			{
				strSql1.Append("h_uname,");
				strSql2.Append("'"+model.h_uname+"',");
			}
			if (model.h_remark != null)
			{
				strSql1.Append("h_remark,");
				strSql2.Append("'"+model.h_remark+"',");
			}
			strSql.Append("insert into tb_kehu(");
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
		public bool Update(Ctl.Model.tb_kehu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_kehu set ");
			if (model.h_no != null)
			{
				strSql.Append("h_no='"+model.h_no+"',");
			}
			else
			{
				strSql.Append("h_no= null ,");
			}
			if (model.h_name != null)
			{
				strSql.Append("h_name='"+model.h_name+"',");
			}
			else
			{
				strSql.Append("h_name= null ,");
			}
			if (model.h_tel != null)
			{
				strSql.Append("h_tel='"+model.h_tel+"',");
			}
			else
			{
				strSql.Append("h_tel= null ,");
			}
			if (model.h_address != null)
			{
				strSql.Append("h_address='"+model.h_address+"',");
			}
			else
			{
				strSql.Append("h_address= null ,");
			}
			if (model.h_zipcode != null)
			{
				strSql.Append("h_zipcode='"+model.h_zipcode+"',");
			}
			else
			{
				strSql.Append("h_zipcode= null ,");
			}
			if (model.h_uname != null)
			{
				strSql.Append("h_uname='"+model.h_uname+"',");
			}
			else
			{
				strSql.Append("h_uname= null ,");
			}
			if (model.h_remark != null)
			{
				strSql.Append("h_remark='"+model.h_remark+"',");
			}
			else
			{
				strSql.Append("h_remark= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where h_id="+ model.h_id+"");
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
		public bool Delete(int h_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_kehu ");
			strSql.Append(" where h_id="+h_id+"" );
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
		public bool DeleteList(string h_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_kehu ");
			strSql.Append(" where h_id in ("+h_idlist + ")  ");
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
		public Ctl.Model.tb_kehu GetModel(int h_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" h_id,h_no,h_name,h_tel,h_address,h_zipcode,h_uname,h_remark ");
			strSql.Append(" from tb_kehu ");
			strSql.Append(" where h_id="+h_id+"" );
			Ctl.Model.tb_kehu model=new Ctl.Model.tb_kehu();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["h_id"]!=null && ds.Tables[0].Rows[0]["h_id"].ToString()!="")
				{
					model.h_id=int.Parse(ds.Tables[0].Rows[0]["h_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["h_no"]!=null && ds.Tables[0].Rows[0]["h_no"].ToString()!="")
				{
					model.h_no=ds.Tables[0].Rows[0]["h_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["h_name"]!=null && ds.Tables[0].Rows[0]["h_name"].ToString()!="")
				{
					model.h_name=ds.Tables[0].Rows[0]["h_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["h_tel"]!=null && ds.Tables[0].Rows[0]["h_tel"].ToString()!="")
				{
					model.h_tel=ds.Tables[0].Rows[0]["h_tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["h_address"]!=null && ds.Tables[0].Rows[0]["h_address"].ToString()!="")
				{
					model.h_address=ds.Tables[0].Rows[0]["h_address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["h_zipcode"]!=null && ds.Tables[0].Rows[0]["h_zipcode"].ToString()!="")
				{
					model.h_zipcode=ds.Tables[0].Rows[0]["h_zipcode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["h_uname"]!=null && ds.Tables[0].Rows[0]["h_uname"].ToString()!="")
				{
					model.h_uname=ds.Tables[0].Rows[0]["h_uname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["h_remark"]!=null && ds.Tables[0].Rows[0]["h_remark"].ToString()!="")
				{
					model.h_remark=ds.Tables[0].Rows[0]["h_remark"].ToString();
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
			strSql.Append("select h_id,h_no,h_name,h_uname,h_tel,h_address,h_zipcode,h_remark ");
			strSql.Append(" FROM tb_kehu ");
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
			strSql.Append(" h_id,h_no,h_name,h_tel,h_address,h_zipcode,h_uname,h_remark ");
			strSql.Append(" FROM tb_kehu ");
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
			strSql.Append("select count(1) FROM tb_kehu ");
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
				strSql.Append("order by T.h_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_kehu T ");
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

