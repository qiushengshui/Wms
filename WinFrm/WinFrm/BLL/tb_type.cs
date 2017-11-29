using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Ctl.Model;
namespace Ctl.BLL
{
	/// <summary>
	/// tb_type
	/// </summary>
	public partial class tb_type
	{
		private readonly Ctl.DAL.tb_type dal=new Ctl.DAL.tb_type();
		public tb_type()
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
		public bool Exists(int t_id)
		{
			return dal.Exists(t_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Ctl.Model.tb_type model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Ctl.Model.tb_type model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int t_id)
		{
			
			return dal.Delete(t_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string t_idlist )
		{
			return dal.DeleteList(t_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Ctl.Model.tb_type GetModel(int t_id)
		{
			
			return dal.GetModel(t_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Ctl.Model.tb_type GetModelByCache(int t_id)
		{
			
			string CacheKey = "tb_typeModel-" + t_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(t_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Ctl.Model.tb_type)objModel;
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
		public List<Ctl.Model.tb_type> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Ctl.Model.tb_type> DataTableToList(DataTable dt)
		{
			List<Ctl.Model.tb_type> modelList = new List<Ctl.Model.tb_type>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Ctl.Model.tb_type model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Ctl.Model.tb_type();
					if(dt.Rows[n]["t_id"]!=null && dt.Rows[n]["t_id"].ToString()!="")
					{
						model.t_id=int.Parse(dt.Rows[n]["t_id"].ToString());
					}
					if(dt.Rows[n]["t_paid"]!=null && dt.Rows[n]["t_paid"].ToString()!="")
					{
						model.t_paid=int.Parse(dt.Rows[n]["t_paid"].ToString());
					}
					if(dt.Rows[n]["t_no"]!=null && dt.Rows[n]["t_no"].ToString()!="")
					{
					model.t_no=dt.Rows[n]["t_no"].ToString();
					}
					if(dt.Rows[n]["t_name"]!=null && dt.Rows[n]["t_name"].ToString()!="")
					{
					model.t_name=dt.Rows[n]["t_name"].ToString();
					}
					if(dt.Rows[n]["t_desc"]!=null && dt.Rows[n]["t_desc"].ToString()!="")
					{
					model.t_desc=dt.Rows[n]["t_desc"].ToString();
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

