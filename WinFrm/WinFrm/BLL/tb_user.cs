using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Model;
namespace BLL
{
    /// <summary>
    /// tb_user
    /// </summary>
    public partial class tb_user
    {
        private readonly DAL.tb_user dal = new DAL.tb_user();
        public tb_user()
        { }
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
        public bool Exists(int u_id)
        {
            return dal.Exists(u_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.tb_user model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.tb_user model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int u_id)
        {

            return dal.Delete(u_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string u_idlist)
        {
            return dal.DeleteList(u_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.tb_user GetModel(int u_id)
        {

            return dal.GetModel(u_id);
        }
        public Model.tb_user GetModel(string log, string pwd)
        {

            return dal.GetModel(log, pwd);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.tb_user GetModelByCache(int u_id)
        {

            string CacheKey = "tb_userModel-" + u_id;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(u_id);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.tb_user)objModel;
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.tb_user> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.tb_user> DataTableToList(DataTable dt)
        {
            List<Model.tb_user> modelList = new List<Model.tb_user>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.tb_user model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.tb_user();
                    if (dt.Rows[n]["u_id"] != null && dt.Rows[n]["u_id"].ToString() != "")
                    {
                        model.u_id = int.Parse(dt.Rows[n]["u_id"].ToString());
                    }
                    if (dt.Rows[n]["u_log"] != null && dt.Rows[n]["u_log"].ToString() != "")
                    {
                        model.u_log = dt.Rows[n]["u_log"].ToString();
                    }
                    if (dt.Rows[n]["u_pwd"] != null && dt.Rows[n]["u_pwd"].ToString() != "")
                    {
                        model.u_pwd = dt.Rows[n]["u_pwd"].ToString();
                    }
                    if (dt.Rows[n]["u_no"] != null && dt.Rows[n]["u_no"].ToString() != "")
                    {
                        model.u_no = dt.Rows[n]["u_no"].ToString();
                    }
                    if (dt.Rows[n]["u_name"] != null && dt.Rows[n]["u_name"].ToString() != "")
                    {
                        model.u_name = dt.Rows[n]["u_name"].ToString();
                    }
                    if (dt.Rows[n]["u_tel"] != null && dt.Rows[n]["u_tel"].ToString() != "")
                    {
                        model.u_tel = dt.Rows[n]["u_tel"].ToString();
                    }
                    if (dt.Rows[n]["u_email"] != null && dt.Rows[n]["u_email"].ToString() != "")
                    {
                        model.u_email = dt.Rows[n]["u_email"].ToString();
                    }
                    if (dt.Rows[n]["u_type"] != null && dt.Rows[n]["u_type"].ToString() != "")
                    {
                        model.u_type = int.Parse(dt.Rows[n]["u_type"].ToString());
                    }
                    if (dt.Rows[n]["u_sex"] != null && dt.Rows[n]["u_sex"].ToString() != "")
                    {
                        model.u_sex = dt.Rows[n]["u_sex"].ToString();
                    }
                    if (dt.Rows[n]["u_address"] != null && dt.Rows[n]["u_address"].ToString() != "")
                    {
                        model.u_address = dt.Rows[n]["u_address"].ToString();
                    }
                    if (dt.Rows[n]["u_adddate"] != null && dt.Rows[n]["u_adddate"].ToString() != "")
                    {
                        model.u_adddate = dt.Rows[n]["u_adddate"].ToString();
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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

