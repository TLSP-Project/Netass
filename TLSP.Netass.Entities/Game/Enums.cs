


namespace TLSP.Netass.Entities
{
	[Serializable]
	public enum ETextureType
	{
		SKIN = 31,
		SPECIAL_SKIN = 42,
		FOUR_DIMENSIONAL_SKIN = 41
	}



	[Serializable]
	public enum EGameVersion : uint
	{

		NONE,

		V_CPP = 100000000U,

		V_RTX = 200000000U,

		V_1_7_10 = 1007010U,

		V_1_10_2 = 1010002U,

		V_1_8 = 1008000U,

		V_1_11_2 = 1011002U,

		V_1_12_2 = 1012002U,

		V_1_8_8 = 1008008U,

		V_1_8_9,

		V_1_9_4 = 1009004U,

		V_1_6_4 = 1006004U,

		V_1_7_2 = 1007002U,

		V_1_12 = 1012000U,

		V_1_13_2 = 1013002U,

		V_1_14_3 = 1014003U,

		V_1_15 = 1015000U,

		V_1_16 = 1016000U,

		V_1_18 = 1018000U
	}





	[JsonConverter(typeof(JsonStringEnumConverter))]
	[Serializable]
	public enum EGameClientType
	{
		all,
		java,
		cpp
	}

	[Serializable]
	public enum EJavaType
	{
		None,
		Java7 = 7,
		Java8,
		Java17 =17
	}

	[Serializable]
	public enum EGameType
	{
		NONE = -1,

		/// <summary>
		/// 单人游戏
		/// </summary>
		SINGLE_GAME = 1,
		/// <summary>
		/// 网络游戏
		/// </summary>
		NET_GAME,

		MC_GAME = 7,
		/// <summary>
		/// 租赁服游戏
		/// </summary>
		SERVER_GAME,
		/// <summary>
		/// 局域网游戏
		/// </summary>
		LAN_GAME,
		/// <summary>
		/// 联机大厅游戏
		/// </summary>
		ONLINE_LOBBY_GAME
	}


}
