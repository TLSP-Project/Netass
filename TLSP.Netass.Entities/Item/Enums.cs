namespace TLSP.Netass.Entities
{


	[Serializable]
	public enum EItemBalanceGrade
	{

		NO_GRADE,

		A,

		B,

		C
	}

	[Serializable]
	public enum EItemType
	{
		/// <summary>
		/// 游戏
		/// </summary>
		GAME = 1,
		/// <summary>
		/// 组件
		/// </summary>
		COMPONENT
		/// <summary>
		/// 组件包，已弃用
		/// </summary>
		//PACKAGE
	}
	[Serializable]
	public enum EItemAvailableScope
	{

		NO_SCOPE,

		CLIENT_ONLY,

		SERVER_ONLY,

		CLIENT_SERVER
	}
	public enum EtemReviewStatus
	{

		REVIEW_PENDING,

		REVIEW_OK,

		REVIEW_REJECTED,

		OFF_STOCK,

		DELETED
	}
	public enum EItemGoodsState
	{

		NOT_FOR_SALE,

		NORMAL,

		NO_PRICE
	}

	[Serializable]
	public enum EItemMasterType
	{
		/// <summary>
		/// 所有组件
		/// </summary>
		None,
		/// <summary>
		/// 
		/// </summary>
		Single,
		/// <summary>
		/// 网络游戏
		/// </summary>
		NET_GAME,
		/// <summary>
		/// 功能组件
		/// </summary>
		FUNCTIONAL,
		/// <summary>
		/// 视觉组件
		/// </summary>
		VISUAL,
		/// <summary>
		/// 地图组件
		/// </summary>
		MAP,
		/// <summary>
		/// 玩法组件
		/// </summary>
		GAME_PLAY,
		/// <summary>
		/// 形象组件
		/// </summary>
		APPERANCE = 10,
		/// <summary>
		/// 联机地图
		/// </summary>
		ONLINE_LOBBY_MAP
	}

	[Serializable]
	public enum EItemAvailableGameVerison
	{
		V_1_7_10 = 1,

		V_1_8_0,

		V_1_9_4,

		V_1_11_2,

		V_1_8_8,

		V_1_10_2,

		V_1_12_2 = 10,

		V_CPPGame = 13,

		V_1_13_2,

		V_1_14_2,

		V_1_15,

		V_1_16
	}




}
