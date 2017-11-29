using System;
namespace Ctl.Model
{
	/// <summary>
	/// tb_pan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_pan
	{
		public tb_pan()
		{}
		#region Model
		private int _p_id;
		private int? _p_pid;
		private string _p_time;
		private string _p_user;
		private decimal? _p_numold;
		private int? _p_numnow;
		private string _p_remark;
		/// <summary>
		/// 
		/// </summary>
		public int p_id
		{
			set{ _p_id=value;}
			get{return _p_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? p_pid
		{
			set{ _p_pid=value;}
			get{return _p_pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_time
		{
			set{ _p_time=value;}
			get{return _p_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_user
		{
			set{ _p_user=value;}
			get{return _p_user;}
		}
		/// <summary>
		/// 原库存量
		/// </summary>
		public decimal? p_numold
		{
			set{ _p_numold=value;}
			get{return _p_numold;}
		}
		/// <summary>
		/// 实际数量
		/// </summary>
		public int? p_numnow
		{
			set{ _p_numnow=value;}
			get{return _p_numnow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_remark
		{
			set{ _p_remark=value;}
			get{return _p_remark;}
		}
		#endregion Model

	}
}

