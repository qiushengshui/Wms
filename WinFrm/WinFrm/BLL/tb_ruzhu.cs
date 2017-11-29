using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_ruzhu
	/// </summary>
	public partial class tb_ruzhu
	{
		private readonly DAL.tb_ruzhu dal=new DAL.tb_ruzhu();
		public tb_ruzhu()
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
		public bool Exists(int r_id)
		{
			return dal.Exists(r_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_ruzhu model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_ruzhu model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int r_id)
		{
			
			return dal.Delete(r_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string r_idlist )
		{
			return dal.DeleteList(r_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_ruzhu GetModel(int r_id)
		{
			
			return dal.GetModel(r_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.tb_ruzhu GetModelByCache(int r_id)
		{
			
			string CacheKey = "tb_ruzhuModel-" + r_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(r_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.tb_ruzhu)objModel;
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
		public List<Model.tb_ruzhu> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_ruzhu> DataTableToList(DataTable dt)
		{
			List<Model.tb_ruzhu> modelList = new List<Model.tb_ruzhu>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_ruzhu model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_ruzhu();
					if(dt.Rows[n]["r_id"]!=null && dt.Rows[n]["r_id"].ToString()!="")
					{
						model.r_id=int.Parse(dt.Rows[n]["r_id"].ToString());
					}
					if(dt.Rows[n]["r_no"]!=null && dt.Rows[n]["r_no"].ToString()!="")
					{
					model.r_no=dt.Rows[n]["r_no"].ToString();
					}
					if(dt.Rows[n]["r_name"]!=null && dt.Rows[n]["r_name"].ToString()!="")
					{
					model.r_name=dt.Rows[n]["r_name"].ToString();
					}
					if(dt.Rows[n]["r_uname"]!=null && dt.Rows[n]["r_uname"].ToString()!="")
					{
					model.r_uname=dt.Rows[n]["r_uname"].ToString();
					}
					if(dt.Rows[n]["r_utel"]!=null && dt.Rows[n]["r_utel"].ToString()!="")
					{
					model.r_utel=dt.Rows[n]["r_utel"].ToString();
					}
					if(dt.Rows[n]["r_address"]!=null && dt.Rows[n]["r_address"].ToString()!="")
					{
					model.r_address=dt.Rows[n]["r_address"].ToString();
					}
					if(dt.Rows[n]["r_desc"]!=null && dt.Rows[n]["r_desc"].ToString()!="")
					{
					model.r_desc=dt.Rows[n]["r_desc"].ToString();
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

