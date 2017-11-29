using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_churu
	/// </summary>
	public partial class tb_churu
	{
		private readonly DAL.tb_churu dal=new DAL.tb_churu();
		public tb_churu()
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
		public bool Exists(int cr_id)
		{
			return dal.Exists(cr_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_churu model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_churu model)
		{
			return dal.Update(model);
		}

        public DataSet GetListB(string v)
        {
            return dal.GetListB(v);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int cr_id)
		{
			
			return dal.Delete(cr_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string cr_idlist )
		{
			return dal.DeleteList(cr_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_churu GetModel(int cr_id)
		{
			
			return dal.GetModel(cr_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.tb_churu GetModelByCache(int cr_id)
		{
			
			string CacheKey = "tb_churuModel-" + cr_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(cr_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.tb_churu)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        public DataSet GetListC(string strWhere)
        {
            return dal.GetListC(strWhere);
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
		public List<Model.tb_churu> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_churu> DataTableToList(DataTable dt)
		{
			List<Model.tb_churu> modelList = new List<Model.tb_churu>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_churu model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_churu();
					if(dt.Rows[n]["cr_id"]!=null && dt.Rows[n]["cr_id"].ToString()!="")
					{
						model.cr_id=int.Parse(dt.Rows[n]["cr_id"].ToString());
					}
					if(dt.Rows[n]["cr_oid"]!=null && dt.Rows[n]["cr_oid"].ToString()!="")
					{
						model.cr_oid=int.Parse(dt.Rows[n]["cr_oid"].ToString());
					}
					if(dt.Rows[n]["cr_pid"]!=null && dt.Rows[n]["cr_pid"].ToString()!="")
					{
						model.cr_pid=int.Parse(dt.Rows[n]["cr_pid"].ToString());
					}
					if(dt.Rows[n]["cr_time"]!=null && dt.Rows[n]["cr_time"].ToString()!="")
					{
					model.cr_time=dt.Rows[n]["cr_time"].ToString();
					}
					if(dt.Rows[n]["cr_type"]!=null && dt.Rows[n]["cr_type"].ToString()!="")
					{
						model.cr_type=int.Parse(dt.Rows[n]["cr_type"].ToString());
					}
					if(dt.Rows[n]["cr_num"]!=null && dt.Rows[n]["cr_num"].ToString()!="")
					{
						model.cr_num=int.Parse(dt.Rows[n]["cr_num"].ToString());
					}
					if(dt.Rows[n]["cr_yan"]!=null && dt.Rows[n]["cr_yan"].ToString()!="")
					{
						model.cr_yan=int.Parse(dt.Rows[n]["cr_yan"].ToString());
					}
					if(dt.Rows[n]["cr_price"]!=null && dt.Rows[n]["cr_price"].ToString()!="")
					{
						model.cr_price=decimal.Parse(dt.Rows[n]["cr_price"].ToString());
					}
					if(dt.Rows[n]["cr_remark"]!=null && dt.Rows[n]["cr_remark"].ToString()!="")
					{
					model.cr_remark=dt.Rows[n]["cr_remark"].ToString();
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

