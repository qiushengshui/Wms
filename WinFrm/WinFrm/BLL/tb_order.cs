using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_order
	/// </summary>
	public partial class tb_order
	{
		private readonly DAL.tb_order dal=new DAL.tb_order();
		public tb_order()
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
		public bool Exists(int o_id)
		{
			return dal.Exists(o_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_order model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_order model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int o_id)
		{
			
			return dal.Delete(o_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string o_idlist )
		{
			return dal.DeleteList(o_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_order GetModel(int o_id)
		{
			
			return dal.GetModel(o_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.tb_order GetModelByCache(int o_id)
		{
			
			string CacheKey = "tb_orderModel-" + o_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(o_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.tb_order)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        public DataSet GetListR(string strWhere)
        {
            return dal.GetListR(strWhere);
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
		public List<Model.tb_order> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_order> DataTableToList(DataTable dt)
		{
			List<Model.tb_order> modelList = new List<Model.tb_order>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_order model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_order();
					if(dt.Rows[n]["o_id"]!=null && dt.Rows[n]["o_id"].ToString()!="")
					{
						model.o_id=int.Parse(dt.Rows[n]["o_id"].ToString());
					}
					if(dt.Rows[n]["o_no"]!=null && dt.Rows[n]["o_no"].ToString()!="")
					{
					model.o_no=dt.Rows[n]["o_no"].ToString();
					}
					if(dt.Rows[n]["o_type"]!=null && dt.Rows[n]["o_type"].ToString()!="")
					{
						model.o_type=int.Parse(dt.Rows[n]["o_type"].ToString());
					}
					if(dt.Rows[n]["o_time"]!=null && dt.Rows[n]["o_time"].ToString()!="")
					{
					model.o_time=dt.Rows[n]["o_time"].ToString();
					}
					if(dt.Rows[n]["o_busy"]!=null && dt.Rows[n]["o_busy"].ToString()!="")
					{
						model.o_busy=int.Parse(dt.Rows[n]["o_busy"].ToString());
					}
					if(dt.Rows[n]["o_sum"]!=null && dt.Rows[n]["o_sum"].ToString()!="")
					{
					model.o_sum=dt.Rows[n]["o_sum"].ToString();
					}
					if(dt.Rows[n]["o_user"]!=null && dt.Rows[n]["o_user"].ToString()!="")
					{
					model.o_user=dt.Rows[n]["o_user"].ToString();
					}
					if(dt.Rows[n]["o_desc"]!=null && dt.Rows[n]["o_desc"].ToString()!="")
					{
					model.o_desc=dt.Rows[n]["o_desc"].ToString();
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

