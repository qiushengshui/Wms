using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_kehu
	/// </summary>
	public partial class tb_kehu
	{
		private readonly DAL.tb_kehu dal=new DAL.tb_kehu();
		public tb_kehu()
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
		public bool Exists(int h_id)
		{
			return dal.Exists(h_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_kehu model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_kehu model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int h_id)
		{
			
			return dal.Delete(h_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string h_idlist )
		{
			return dal.DeleteList(h_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_kehu GetModel(int h_id)
		{
			
			return dal.GetModel(h_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.tb_kehu GetModelByCache(int h_id)
		{
			
			string CacheKey = "tb_kehuModel-" + h_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(h_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.tb_kehu)objModel;
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
		public List<Model.tb_kehu> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_kehu> DataTableToList(DataTable dt)
		{
			List<Model.tb_kehu> modelList = new List<Model.tb_kehu>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_kehu model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_kehu();
					if(dt.Rows[n]["h_id"]!=null && dt.Rows[n]["h_id"].ToString()!="")
					{
						model.h_id=int.Parse(dt.Rows[n]["h_id"].ToString());
					}
					if(dt.Rows[n]["h_no"]!=null && dt.Rows[n]["h_no"].ToString()!="")
					{
					model.h_no=dt.Rows[n]["h_no"].ToString();
					}
					if(dt.Rows[n]["h_name"]!=null && dt.Rows[n]["h_name"].ToString()!="")
					{
					model.h_name=dt.Rows[n]["h_name"].ToString();
					}
					if(dt.Rows[n]["h_tel"]!=null && dt.Rows[n]["h_tel"].ToString()!="")
					{
					model.h_tel=dt.Rows[n]["h_tel"].ToString();
					}
					if(dt.Rows[n]["h_address"]!=null && dt.Rows[n]["h_address"].ToString()!="")
					{
					model.h_address=dt.Rows[n]["h_address"].ToString();
					}
					if(dt.Rows[n]["h_zipcode"]!=null && dt.Rows[n]["h_zipcode"].ToString()!="")
					{
					model.h_zipcode=dt.Rows[n]["h_zipcode"].ToString();
					}
					if(dt.Rows[n]["h_uname"]!=null && dt.Rows[n]["h_uname"].ToString()!="")
					{
					model.h_uname=dt.Rows[n]["h_uname"].ToString();
					}
					if(dt.Rows[n]["h_remark"]!=null && dt.Rows[n]["h_remark"].ToString()!="")
					{
					model.h_remark=dt.Rows[n]["h_remark"].ToString();
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

