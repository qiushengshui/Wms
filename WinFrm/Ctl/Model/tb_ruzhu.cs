using System;
namespace Ctl.Model
{
	/// <summary>
	/// tb_ruzhu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_ruzhu
	{
		public tb_ruzhu()
		{}
		#region Model
		private int _r_id;
		private string _r_no;
		private string _r_name;
		private string _r_uname;
		private string _r_utel;
		private string _r_address;
		private string _r_desc;
		/// <summary>
		/// 
		/// </summary>
		public int r_id
		{
			set{ _r_id=value;}
			get{return _r_id;}
		}
		/// <summary>
		/// 入驻编号
		/// </summary>
		public string r_no
		{
			set{ _r_no=value;}
			get{return _r_no;}
		}
		/// <summary>
		/// 商家名称
		/// </summary>
		public string r_name
		{
			set{ _r_name=value;}
			get{return _r_name;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string r_uname
		{
			set{ _r_uname=value;}
			get{return _r_uname;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string r_utel
		{
			set{ _r_utel=value;}
			get{return _r_utel;}
		}
		/// <summary>
		/// 商家地址
		/// </summary>
		public string r_address
		{
			set{ _r_address=value;}
			get{return _r_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string r_desc
		{
			set{ _r_desc=value;}
			get{return _r_desc;}
		}
		#endregion Model

	}
}

