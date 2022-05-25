using System;
using System.Collections.Generic;
using System.Text;

namespace TLSP.Netass.Entities
{
	[Serializable]
    public class RoleEntity :EntityBase
    {
		/// <summary>
		/// 此角色所属游戏的ID
		/// </summary>
		[JsonPropertyName("game_id")]
		public string GameID { get; set; }

		/// <summary>
		/// 此角色所属游戏的游戏类型
		/// </summary>
		[JsonPropertyName("game_type")] 
		public EGameType GameType { get; set; }

		/// <summary>
		/// 此角色所属用户的ID
		/// </summary>
		[JsonPropertyName("user_id")]
		public uint UserId { get; set; }

		/// <summary>
		/// 角色名称
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// 角色创建时间
		/// </summary>
		[JsonPropertyName("create_time")]
		public ulong CreateTime { get; set; }

		/// <summary>
		/// 角色更新时间
		/// </summary>
		[JsonPropertyName("expire_time")]
		public ulong ExpireTime { get; set; }
	}
}
