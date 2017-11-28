using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Ctl.Model;
namespace Ctl.BLL
{
	/// <summary>
	/// tb_ku
	/// </summary>
	public partial class tb_ku
	{
		private readonly Ctl.DAL.tb_ku dal=new Ctl.DAL.tb_ku();
		public tb_ku()
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
		public bool Exists(int k_id)
		{
			return dal.Exists(k_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Ctl.Model.tb_ku model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Ctl.Model.tb_ku model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int k_id)
		{
			
			return dal.Delete(k_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string k_idlist )
		{
			return dal.DeleteList(k_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Ctl.Model.tb_ku GetModel(int k_id)
		{
			
			return dal.GetModel(k_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Ctl.Model.tb_ku GetModelByCache(int k_id)
		{
			
			string CacheKey = "tb_kuModel-" + k_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(k_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Ctl.Model.tb_ku)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        public DataSet GetListT(string strWhere)
        {
            return dal.GetListT(strWhere);
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
		public List<Ctl.Model.tb_ku> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Ctl.Model.tb_ku> DataTableToList(DataTable dt)
		{
			List<Ctl.Model.tb_ku> modelList = new List<Ctl.Model.tb_ku>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Ctl.Model.tb_ku model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Ctl.Model.tb_ku();
					if(dt.Rows[n]["k_id"]!=null && dt.Rows[n]["k_id"].ToString()!="")
					{
						model.k_id=int.Parse(dt.Rows[n]["k_id"].ToString());
					}
					if(dt.Rows[n]["k_paid"]!=null && dt.Rows[n]["k_paid"].ToString()!="")
					{
						model.k_paid=int.Parse(dt.Rows[n]["k_paid"].ToString());
					}
					if(dt.Rows[n]["k_no"]!=null && dt.Rows[n]["k_no"].ToString()!="")
					{
					model.k_no=dt.Rows[n]["k_no"].ToString();
					}
					if(dt.Rows[n]["k_name"]!=null && dt.Rows[n]["k_name"].ToString()!="")
					{
					model.k_name=dt.Rows[n]["k_name"].ToString();
					}
					if(dt.Rows[n]["k_desc"]!=null && dt.Rows[n]["k_desc"].ToString()!="")
					{
					model.k_desc=dt.Rows[n]["k_desc"].ToString();
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

