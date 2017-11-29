using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
	/// <summary>
	/// 数据访问类:tb_proc
	/// </summary>
	public partial class tb_proc
	{
		public tb_proc()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbSQL.GetMaxID("p_id", "tb_proc"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int p_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_proc");
			strSql.Append(" where p_id="+p_id+" ");
			return DbSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.tb_proc model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.p_no != null)
			{
				strSql1.Append("p_no,");
				strSql2.Append("'"+model.p_no+"',");
			}
			if (model.p_name != null)
			{
				strSql1.Append("p_name,");
				strSql2.Append("'"+model.p_name+"',");
			}
			if (model.p_tyid != null)
			{
				strSql1.Append("p_tyid,");
				strSql2.Append(""+model.p_tyid+",");
			}
			if (model.p_pinpai != null)
			{
				strSql1.Append("p_pinpai,");
				strSql2.Append("'"+model.p_pinpai+"',");
			}
			if (model.p_model != null)
			{
				strSql1.Append("p_model,");
				strSql2.Append("'"+model.p_model+"',");
			}
			if (model.p_shang != null)
			{
				strSql1.Append("p_shang,");
				strSql2.Append("'"+model.p_shang+"',");
			}
			if (model.p_price != null)
			{
				strSql1.Append("p_price,");
				strSql2.Append("'"+model.p_price+"',");
			}
			if (model.p_unit != null)
			{
				strSql1.Append("p_unit,");
				strSql2.Append("'"+model.p_unit+"',");
			}
			if (model.p_sx != null)
			{
				strSql1.Append("p_sx,");
				strSql2.Append("'"+model.p_sx+"',");
			}
			if (model.p_xx != null)
			{
				strSql1.Append("p_xx,");
				strSql2.Append("'"+model.p_xx+"',");
			}
			if (model.p_desc != null)
			{
				strSql1.Append("p_desc,");
				strSql2.Append("'"+model.p_desc+"',");
			}
			if (model.p_addtime != null)
			{
				strSql1.Append("p_addtime,");
				strSql2.Append("'"+model.p_addtime+"',");
			}
			if (model.p_ckid != null)
			{
				strSql1.Append("p_ckid,");
				strSql2.Append(""+model.p_ckid+",");
			}
			if (model.p_kqid != null)
			{
				strSql1.Append("p_kqid,");
				strSql2.Append(""+model.p_kqid+",");
			}
			if (model.p_num != null)
			{
				strSql1.Append("p_num,");
				strSql2.Append(""+model.p_num+",");
            }
            if (model.p_rzfid != null)
            {
                strSql1.Append("p_rzfid,");
                strSql2.Append("" + model.p_rzfid + ",");
            }
			strSql.Append("insert into tb_proc(");
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
		public bool Update(Model.tb_proc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_proc set ");
			if (model.p_no != null)
			{
				strSql.Append("p_no='"+model.p_no+"',");
			}
			else
			{
				strSql.Append("p_no= null ,");
			}
			if (model.p_name != null)
			{
				strSql.Append("p_name='"+model.p_name+"',");
			}
			else
			{
				strSql.Append("p_name= null ,");
			}
			if (model.p_tyid != null)
			{
				strSql.Append("p_tyid="+model.p_tyid+",");
			}
			else
			{
				strSql.Append("p_tyid= null ,");
			}
			if (model.p_pinpai != null)
			{
				strSql.Append("p_pinpai='"+model.p_pinpai+"',");
			}
			else
			{
				strSql.Append("p_pinpai= null ,");
			}
			if (model.p_model != null)
			{
				strSql.Append("p_model='"+model.p_model+"',");
			}
			else
			{
				strSql.Append("p_model= null ,");
			}
			if (model.p_shang != null)
			{
				strSql.Append("p_shang='"+model.p_shang+"',");
			}
			else
			{
				strSql.Append("p_shang= null ,");
			}
			if (model.p_price != null)
			{
				strSql.Append("p_price='"+model.p_price+"',");
			}
			else
			{
				strSql.Append("p_price= null ,");
			}
			if (model.p_unit != null)
			{
				strSql.Append("p_unit='"+model.p_unit+"',");
			}
			else
			{
				strSql.Append("p_unit= null ,");
			}
			if (model.p_sx != null)
			{
				strSql.Append("p_sx='"+model.p_sx+"',");
			}
			else
			{
				strSql.Append("p_sx= null ,");
			}
			if (model.p_xx != null)
			{
				strSql.Append("p_xx='"+model.p_xx+"',");
			}
			else
			{
				strSql.Append("p_xx= null ,");
			}
			if (model.p_desc != null)
			{
				strSql.Append("p_desc='"+model.p_desc+"',");
			}
			else
			{
				strSql.Append("p_desc= null ,");
			}
			if (model.p_addtime != null)
			{
				strSql.Append("p_addtime='"+model.p_addtime+"',");
			}
			else
			{
				strSql.Append("p_addtime= null ,");
			}
			if (model.p_ckid != null)
			{
				strSql.Append("p_ckid="+model.p_ckid+",");
			}
			else
			{
				strSql.Append("p_ckid= null ,");
			}
			if (model.p_kqid != null)
			{
				strSql.Append("p_kqid="+model.p_kqid+",");
			}
			else
			{
				strSql.Append("p_kqid= null ,");
			}
			if (model.p_num != null)
			{
				strSql.Append("p_num="+model.p_num+",");
			}
			else
			{
				strSql.Append("p_num= null ,");
            }
            if (model.p_rzfid != null)
            {
                strSql.Append("p_rzfid=" + model.p_rzfid + ",");
            }
            else
            {
                strSql.Append("p_rzfid= null ,");
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
			strSql.Append("delete from tb_proc ");
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
			strSql.Append("delete from tb_proc ");
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
		public Model.tb_proc GetModel(int p_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
            strSql.Append(" p_id,p_no,p_name,p_tyid,p_pinpai,p_model,p_shang,p_price,p_unit,p_sx,p_xx,p_desc,p_addtime,p_ckid,p_kqid,p_num,p_rzfid ");
			strSql.Append(" from tb_proc ");
			strSql.Append(" where p_id="+p_id+"" );
			Model.tb_proc model=new Model.tb_proc();
			DataSet ds=DbSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["p_id"]!=null && ds.Tables[0].Rows[0]["p_id"].ToString()!="")
				{
					model.p_id=int.Parse(ds.Tables[0].Rows[0]["p_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_no"]!=null && ds.Tables[0].Rows[0]["p_no"].ToString()!="")
				{
					model.p_no=ds.Tables[0].Rows[0]["p_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_name"]!=null && ds.Tables[0].Rows[0]["p_name"].ToString()!="")
				{
					model.p_name=ds.Tables[0].Rows[0]["p_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_tyid"]!=null && ds.Tables[0].Rows[0]["p_tyid"].ToString()!="")
				{
					model.p_tyid=int.Parse(ds.Tables[0].Rows[0]["p_tyid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_pinpai"]!=null && ds.Tables[0].Rows[0]["p_pinpai"].ToString()!="")
				{
					model.p_pinpai=ds.Tables[0].Rows[0]["p_pinpai"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_model"]!=null && ds.Tables[0].Rows[0]["p_model"].ToString()!="")
				{
					model.p_model=ds.Tables[0].Rows[0]["p_model"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_shang"]!=null && ds.Tables[0].Rows[0]["p_shang"].ToString()!="")
				{
					model.p_shang=ds.Tables[0].Rows[0]["p_shang"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_price"]!=null && ds.Tables[0].Rows[0]["p_price"].ToString()!="")
				{
					model.p_price=ds.Tables[0].Rows[0]["p_price"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_unit"]!=null && ds.Tables[0].Rows[0]["p_unit"].ToString()!="")
				{
					model.p_unit=ds.Tables[0].Rows[0]["p_unit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_sx"]!=null && ds.Tables[0].Rows[0]["p_sx"].ToString()!="")
				{
					model.p_sx=ds.Tables[0].Rows[0]["p_sx"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_xx"]!=null && ds.Tables[0].Rows[0]["p_xx"].ToString()!="")
				{
					model.p_xx=ds.Tables[0].Rows[0]["p_xx"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_desc"]!=null && ds.Tables[0].Rows[0]["p_desc"].ToString()!="")
				{
					model.p_desc=ds.Tables[0].Rows[0]["p_desc"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_addtime"]!=null && ds.Tables[0].Rows[0]["p_addtime"].ToString()!="")
				{
					model.p_addtime=ds.Tables[0].Rows[0]["p_addtime"].ToString();
				}
				if(ds.Tables[0].Rows[0]["p_ckid"]!=null && ds.Tables[0].Rows[0]["p_ckid"].ToString()!="")
				{
					model.p_ckid=int.Parse(ds.Tables[0].Rows[0]["p_ckid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_kqid"]!=null && ds.Tables[0].Rows[0]["p_kqid"].ToString()!="")
				{
					model.p_kqid=int.Parse(ds.Tables[0].Rows[0]["p_kqid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["p_num"]!=null && ds.Tables[0].Rows[0]["p_num"].ToString()!="")
				{
					model.p_num=int.Parse(ds.Tables[0].Rows[0]["p_num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["p_rzfid"] != null && ds.Tables[0].Rows[0]["p_rzfid"].ToString() != "")
                {
                    model.p_rzfid = int.Parse(ds.Tables[0].Rows[0]["p_rzfid"].ToString());
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
            strSql.Append("select p_id,p_no,p_name,p_tyid,p_pinpai,p_model,p_shang,p_price,p_unit,p_sx,p_xx,p_desc,p_addtime,p_ckid,p_kqid,p_num,p_rzfid ");
			strSql.Append(" FROM tb_proc ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbSQL.Query(strSql.ToString());
		}
        public DataSet GetListT(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select p_id,p_no,p_name,tb.t_name,p_pinpai,p_model,tc.k_name,td.k_name,p_shang,p_price,p_unit,p_addtime,p_sx,p_xx,p_desc,p_ckid,p_kqid,p_num,p_tyid,p_rzfid,r_name ");
            strSql.Append(" FROM tb_proc ta inner join tb_type tb on ta.p_tyid=tb.t_id inner join tb_ku tc on ta.p_ckid=tc.k_id inner join tb_ku td on ta.p_kqid=td.k_id inner join tb_ruzhu te on ta.p_rzfid=te.r_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbSQL.Query(strSql.ToString());
        }
        public DataSet GetListT2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select p_id,p_no,p_name,p_num,tb.t_name,p_pinpai,p_model,tc.k_name,td.k_name,p_shang,r_name ");
            strSql.Append(" FROM tb_proc ta inner join tb_type tb on ta.p_tyid=tb.t_id inner join tb_ku tc on ta.p_ckid=tc.k_id inner join tb_ku td on ta.p_kqid=td.k_id inner join tb_ruzhu te on ta.p_rzfid=te.r_id ");
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
            strSql.Append(" p_id,p_no,p_name,p_tyid,p_pinpai,p_model,p_shang,p_price,p_unit,p_sx,p_xx,p_desc,p_addtime,p_ckid,p_kqid,p_num,p_rzfid ");
			strSql.Append(" FROM tb_proc ");
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
			strSql.Append("select count(1) FROM tb_proc ");
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
			strSql.Append(")AS Row, T.*  from tb_proc T ");
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

