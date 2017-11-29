using System;
namespace Model
{
	/// <summary>
	/// tb_kehu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_kehu
	{
		public tb_kehu()
		{}
		#region Model
		private int _h_id;
		private string _h_no;
		private string _h_name;
		private string _h_tel;
		private string _h_address;
		private string _h_zipcode;
		private string _h_uname;
		private string _h_remark;
		/// <summary>
		/// 
		/// </summary>
		public int h_id
		{
			set{ _h_id=value;}
			get{return _h_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string h_no
		{
			set{ _h_no=value;}
			get{return _h_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string h_name
		{
			set{ _h_name=value;}
			get{return _h_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string h_tel
		{
			set{ _h_tel=value;}
			get{return _h_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string h_address
		{
			set{ _h_address=value;}
			get{return _h_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string h_zipcode
		{
			set{ _h_zipcode=value;}
			get{return _h_zipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string h_uname
		{
			set{ _h_uname=value;}
			get{return _h_uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string h_remark
		{
			set{ _h_remark=value;}
			get{return _h_remark;}
		}
		#endregion Model

	}
}

