using System;
namespace Model
{
	/// <summary>
	/// tb_churu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_churu
	{
		public tb_churu()
		{}
		#region Model
		private int _cr_id;
		private int? _cr_oid;
		private int? _cr_pid;
		private string _cr_time;
		private int? _cr_type;
		private int? _cr_num;
		private int? _cr_yan=1;
		private decimal? _cr_price;
		private string _cr_remark;
		/// <summary>
		/// 
		/// </summary>
		public int cr_id
		{
			set{ _cr_id=value;}
			get{return _cr_id;}
		}
		/// <summary>
		/// 订单ID
		/// </summary>
		public int? cr_oid
		{
			set{ _cr_oid=value;}
			get{return _cr_oid;}
		}
		/// <summary>
		/// 商品ID
		/// </summary>
		public int? cr_pid
		{
			set{ _cr_pid=value;}
			get{return _cr_pid;}
		}
		/// <summary>
		/// 出入时间
		/// </summary>
		public string cr_time
		{
			set{ _cr_time=value;}
			get{return _cr_time;}
		}
		/// <summary>
		/// 类型:1:入;2:出
		/// </summary>
		public int? cr_type
		{
			set{ _cr_type=value;}
			get{return _cr_type;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public int? cr_num
		{
			set{ _cr_num=value;}
			get{return _cr_num;}
		}
		/// <summary>
		/// 1:验收通过
		/// </summary>
		public int? cr_yan
		{
			set{ _cr_yan=value;}
			get{return _cr_yan;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? cr_price
		{
			set{ _cr_price=value;}
			get{return _cr_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cr_remark
		{
			set{ _cr_remark=value;}
			get{return _cr_remark;}
		}
		#endregion Model

	}
}

