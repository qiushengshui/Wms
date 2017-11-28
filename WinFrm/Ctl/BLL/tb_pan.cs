using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Ctl.Model;
namespace Ctl.BLL
{
	/// <summary>
	/// tb_pan
	/// </summary>
	public partial class tb_pan
	{
		private readonly Ctl.DAL.tb_pan dal=new Ctl.DAL.tb_pan();
		public tb_pan()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int p_id)
		{
			return dal.Exists(p_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Ctl.Model.tb_pan model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Ctl.Model.tb_pan model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int p_id)
		{
			
			return dal.Delete(p_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string p_idlist )
		{
			return dal.DeleteList(p_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Ctl.Model.tb_pan GetModel(int p_id)
		{
			
			return dal.GetModel(p_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Ctl.Model.tb_pan GetModelByCache(int p_id)
		{
			
			string CacheKey = "tb_panModel-" + p_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(p_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Ctl.Model.tb_pan)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Ctl.Model.tb_pan> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Ctl.Model.tb_pan> DataTableToList(DataTable dt)
		{
			List<Ctl.Model.tb_pan> modelList = new List<Ctl.Model.tb_pan>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Ctl.Model.tb_pan model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Ctl.Model.tb_pan();
					if(dt.Rows[n]["p_id"]!=null && dt.Rows[n]["p_id"].ToString()!="")
					{
						model.p_id=int.Parse(dt.Rows[n]["p_id"].ToString());
					}
					if(dt.Rows[n]["p_pid"]!=null && dt.Rows[n]["p_pid"].ToString()!="")
					{
						model.p_pid=int.Parse(dt.Rows[n]["p_pid"].ToString());
					}
					if(dt.Rows[n]["p_time"]!=null && dt.Rows[n]["p_time"].ToString()!="")
					{
					model.p_time=dt.Rows[n]["p_time"].ToString();
					}
					if(dt.Rows[n]["p_user"]!=null && dt.Rows[n]["p_user"].ToString()!="")
					{
					model.p_user=dt.Rows[n]["p_user"].ToString();
					}
					if(dt.Rows[n]["p_numold"]!=null && dt.Rows[n]["p_numold"].ToString()!="")
					{
						model.p_numold=decimal.Parse(dt.Rows[n]["p_numold"].ToString());
					}
					if(dt.Rows[n]["p_numnow"]!=null && dt.Rows[n]["p_numnow"].ToString()!="")
					{
						model.p_numnow=int.Parse(dt.Rows[n]["p_numnow"].ToString());
					}
					if(dt.Rows[n]["p_remark"]!=null && dt.Rows[n]["p_remark"].ToString()!="")
					{
					model.p_remark=dt.Rows[n]["p_remark"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

