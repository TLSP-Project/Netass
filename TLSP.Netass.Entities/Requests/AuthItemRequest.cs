

namespace TLSP.Netass.Entities
{
	[Serializable]
	public class AuthItemRequest
	{
		
		[JsonPropertyName("mc_version_id")]
		public EGameVersion GameVersion { get; set; }
		[JsonPropertyName("game_type")]
		public EGameType GameType { get; set; }
	}
}
