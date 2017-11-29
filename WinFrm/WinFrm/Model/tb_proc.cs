using System;
namespace Model
{
	/// <summary>
	/// tb_proc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_proc
	{
		public tb_proc()
		{}
		#region Model
		private int _p_id;
		private string _p_no;
		private string _p_name;
		private int? _p_tyid;
		private string _p_pinpai;
		private string _p_model;
		private string _p_shang;
		private string _p_price;
		private string _p_unit;
		private string _p_sx;
		private string _p_xx;
		private string _p_desc;
		private string _p_addtime;
		private int? _p_ckid;
		private int? _p_kqid;
        private int? _p_num = 0;
        private int? _p_rzfid;
		/// <summary>
		/// 
		/// </summary>
		public int p_id
		{
			set{ _p_id=value;}
			get{return _p_id;}
		}
		/// <summary>
		/// 商品编号
		/// </summary>
		public string p_no
		{
			set{ _p_no=value;}
			get{return _p_no;}
		}
		/// <summary>
		/// 商品名称
		/// </summary>
		public string p_name
		{
			set{ _p_name=value;}
			get{return _p_name;}
		}
		/// <summary>
		/// 商品类型
		/// </summary>
		public int? p_tyid
		{
			set{ _p_tyid=value;}
			get{return _p_tyid;}
		}
		/// <summary>
		/// 品牌
		/// </summary>
		public string p_pinpai
		{
			set{ _p_pinpai=value;}
			get{return _p_pinpai;}
		}
		/// <summary>
		/// 型号
		/// </summary>
		public string p_model
		{
			set{ _p_model=value;}
			get{return _p_model;}
		}
		/// <summary>
		/// 生产厂家
		/// </summary>
		public string p_shang
		{
			set{ _p_shang=value;}
			get{return _p_shang;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public string p_price
		{
			set{ _p_price=value;}
			get{return _p_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_unit
		{
			set{ _p_unit=value;}
			get{return _p_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_sx
		{
			set{ _p_sx=value;}
			get{return _p_sx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_xx
		{
			set{ _p_xx=value;}
			get{return _p_xx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_desc
		{
			set{ _p_desc=value;}
			get{return _p_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string p_addtime
		{
			set{ _p_addtime=value;}
			get{return _p_addtime;}
		}
		/// <summary>
		/// 仓库ID
		/// </summary>
		public int? p_ckid
		{
			set{ _p_ckid=value;}
			get{return _p_ckid;}
		}
		/// <summary>
		/// 库区ID
		/// </summary>
		public int? p_kqid
		{
			set{ _p_kqid=value;}
			get{return _p_kqid;}
		}
		/// <summary>
		/// 库存数量
		/// </summary>
		public int? p_num
		{
			set{ _p_num=value;}
			get{return _p_num;}
		}
        public int? p_rzfid
        {
            set { _p_rzfid = value; }
            get { return _p_rzfid; }
        }
		#endregion Model

	}
}

