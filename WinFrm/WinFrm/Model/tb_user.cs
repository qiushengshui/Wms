using System;
namespace Ctl.Model
{
	/// <summary>
	/// tb_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_user
	{
		public tb_user()
		{}
		#region Model
		private int _u_id;
		private string _u_log;
		private string _u_pwd;
		private string _u_no;
		private string _u_name;
		private string _u_tel;
		private string _u_email;
		private int? _u_type;
		private string _u_sex;
		private string _u_address;
		private string _u_adddate;
		/// <summary>
		/// 
		/// </summary>
        public int u_id
        {
            set { _u_id = value; }
            get { return _u_id; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string u_log
		{
			set{ _u_log=value;}
			get{return _u_log;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_pwd
		{
			set{ _u_pwd=value;}
			get{return _u_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_no
		{
			set{ _u_no=value;}
			get{return _u_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_name
		{
			set{ _u_name=value;}
			get{return _u_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_tel
		{
			set{ _u_tel=value;}
			get{return _u_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_email
		{
			set{ _u_email=value;}
			get{return _u_email;}
		}
		/// <summary>
		/// 4,3,2
		/// </summary>
		public int? u_type
		{
			set{ _u_type=value;}
			get{return _u_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_sex
		{
			set{ _u_sex=value;}
			get{return _u_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_address
		{
			set{ _u_address=value;}
			get{return _u_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string u_adddate
		{
			set{ _u_adddate=value;}
			get{return _u_adddate;}
		}
		#endregion Model

	}
}

