using System;
namespace Ctl.Model
{
	/// <summary>
	/// tb_order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_order
	{
		public tb_order()
		{}
		#region Model
		private int _o_id;
		private string _o_no;
		private int? _o_type;
		private string _o_time;
		private int? _o_busy;
		private string _o_sum;
		private string _o_user;
		private string _o_desc;
		/// <summary>
		/// 
		/// </summary>
		public int o_id
		{
			set{ _o_id=value;}
			get{return _o_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string o_no
		{
			set{ _o_no=value;}
			get{return _o_no;}
		}
		/// <summary>
		/// 1:入库;2:出库;
		/// </summary>
		public int? o_type
		{
			set{ _o_type=value;}
			get{return _o_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string o_time
		{
			set{ _o_time=value;}
			get{return _o_time;}
		}
		/// <summary>
		/// 商家(入驻方/客户)
		/// </summary>
		public int? o_busy
		{
			set{ _o_busy=value;}
			get{return _o_busy;}
		}
		/// <summary>
		/// 订单总金额
		/// </summary>
		public string o_sum
		{
			set{ _o_sum=value;}
			get{return _o_sum;}
		}
		/// <summary>
		/// 经手人/提货人
		/// </summary>
		public string o_user
		{
			set{ _o_user=value;}
			get{return _o_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string o_desc
		{
			set{ _o_desc=value;}
			get{return _o_desc;}
		}
		#endregion Model

	}
}

