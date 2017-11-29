using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// tb_proc
	/// </summary>
	public partial class tb_proc
	{
		private readonly DAL.tb_proc dal=new DAL.tb_proc();
		public tb_proc()
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
		public int  Add(Model.tb_proc model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.tb_proc model)
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
		public Model.tb_proc GetModel(int p_id)
		{
			
			return dal.GetModel(p_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.tb_proc GetModelByCache(int p_id)
		{
			
			string CacheKey = "tb_procModel-" + p_id;
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
			return (Model.tb_proc)objModel;
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
        public DataSet GetListT2(string strWhere)
        {
            return dal.GetListT2(strWhere);
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
		public List<Model.tb_proc> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.tb_proc> DataTableToList(DataTable dt)
		{
			List<Model.tb_proc> modelList = new List<Model.tb_proc>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_proc model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_proc();
					if(dt.Rows[n]["p_id"]!=null && dt.Rows[n]["p_id"].ToString()!="")
					{
						model.p_id=int.Parse(dt.Rows[n]["p_id"].ToString());
					}
					if(dt.Rows[n]["p_no"]!=null && dt.Rows[n]["p_no"].ToString()!="")
					{
					model.p_no=dt.Rows[n]["p_no"].ToString();
					}
					if(dt.Rows[n]["p_name"]!=null && dt.Rows[n]["p_name"].ToString()!="")
					{
					model.p_name=dt.Rows[n]["p_name"].ToString();
					}
					if(dt.Rows[n]["p_tyid"]!=null && dt.Rows[n]["p_tyid"].ToString()!="")
					{
						model.p_tyid=int.Parse(dt.Rows[n]["p_tyid"].ToString());
					}
					if(dt.Rows[n]["p_pinpai"]!=null && dt.Rows[n]["p_pinpai"].ToString()!="")
					{
					model.p_pinpai=dt.Rows[n]["p_pinpai"].ToString();
					}
					if(dt.Rows[n]["p_model"]!=null && dt.Rows[n]["p_model"].ToString()!="")
					{
					model.p_model=dt.Rows[n]["p_model"].ToString();
					}
					if(dt.Rows[n]["p_shang"]!=null && dt.Rows[n]["p_shang"].ToString()!="")
					{
					model.p_shang=dt.Rows[n]["p_shang"].ToString();
					}
					if(dt.Rows[n]["p_price"]!=null && dt.Rows[n]["p_price"].ToString()!="")
					{
					model.p_price=dt.Rows[n]["p_price"].ToString();
					}
					if(dt.Rows[n]["p_unit"]!=null && dt.Rows[n]["p_unit"].ToString()!="")
					{
					model.p_unit=dt.Rows[n]["p_unit"].ToString();
					}
					if(dt.Rows[n]["p_sx"]!=null && dt.Rows[n]["p_sx"].ToString()!="")
					{
					model.p_sx=dt.Rows[n]["p_sx"].ToString();
					}
					if(dt.Rows[n]["p_xx"]!=null && dt.Rows[n]["p_xx"].ToString()!="")
					{
					model.p_xx=dt.Rows[n]["p_xx"].ToString();
					}
					if(dt.Rows[n]["p_desc"]!=null && dt.Rows[n]["p_desc"].ToString()!="")
					{
					model.p_desc=dt.Rows[n]["p_desc"].ToString();
					}
					if(dt.Rows[n]["p_addtime"]!=null && dt.Rows[n]["p_addtime"].ToString()!="")
					{
					model.p_addtime=dt.Rows[n]["p_addtime"].ToString();
					}
					if(dt.Rows[n]["p_ckid"]!=null && dt.Rows[n]["p_ckid"].ToString()!="")
					{
						model.p_ckid=int.Parse(dt.Rows[n]["p_ckid"].ToString());
					}
					if(dt.Rows[n]["p_kqid"]!=null && dt.Rows[n]["p_kqid"].ToString()!="")
					{
						model.p_kqid=int.Parse(dt.Rows[n]["p_kqid"].ToString());
					}
					if(dt.Rows[n]["p_num"]!=null && dt.Rows[n]["p_num"].ToString()!="")
					{
						model.p_num=int.Parse(dt.Rows[n]["p_num"].ToString());
                    }
                    if (dt.Rows[n]["p_rzfid"] != null && dt.Rows[n]["p_rzfid"].ToString() != "")
                    {
                        model.p_rzfid = int.Parse(dt.Rows[n]["p_rzfid"].ToString());
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

