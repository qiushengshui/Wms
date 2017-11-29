using System;
namespace Model
{
	/// <summary>
	/// tb_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_type
	{
		public tb_type()
		{}
		#region Model
		private int _t_id;
		private int? _t_paid=0;
		private string _t_no;
		private string _t_name;
		private string _t_desc;
		/// <summary>
		/// 
		/// </summary>
		public int t_id
		{
			set{ _t_id=value;}
			get{return _t_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? t_paid
		{
			set{ _t_paid=value;}
			get{return _t_paid;}
		}
		/// <summary>
		/// 商品分类编号
		/// </summary>
		public string t_no
		{
			set{ _t_no=value;}
			get{return _t_no;}
		}
		/// <summary>
		/// 商品分类名称
		/// </summary>
		public string t_name
		{
			set{ _t_name=value;}
			get{return _t_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string t_desc
		{
			set{ _t_desc=value;}
			get{return _t_desc;}
		}
		#endregion Model

	}
}

