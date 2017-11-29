using System;
namespace Model
{
	/// <summary>
	/// tb_ku:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_ku
	{
		public tb_ku()
		{}
		#region Model
		private int _k_id;
		private int? _k_paid=0;
		private string _k_no;
		private string _k_name;
		private string _k_desc;
		/// <summary>
		/// 
		/// </summary>
		public int k_id
		{
			set{ _k_id=value;}
			get{return _k_id;}
		}
		/// <summary>
		/// 0:仓库;>0:库区;
		/// </summary>
		public int? k_paid
		{
			set{ _k_paid=value;}
			get{return _k_paid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string k_no
		{
			set{ _k_no=value;}
			get{return _k_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string k_name
		{
			set{ _k_name=value;}
			get{return _k_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string k_desc
		{
			set{ _k_desc=value;}
			get{return _k_desc;}
		}
		#endregion Model

	}
}

