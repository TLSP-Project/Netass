
namespace TLSP.Netass.Entities
{
	[Serializable]
	public class AuthItemEntity : EntityBase
	{

		[JsonPropertyName("mc_version_id")]
		public EGameVersion GameVersion { get; set; }
		[JsonPropertyName("game_type")]
		public EGameType GameType { get; set; }
		[JsonPropertyName("iid_list")]
		public List<ulong> ItemIDList { get; set; }
	}
}
