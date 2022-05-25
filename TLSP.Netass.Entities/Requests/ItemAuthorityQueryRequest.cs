
namespace TLSP.Netass.Entities
{
	[Serializable]
	public class ItemAuthorityQueryRequest
    {

		[JsonPropertyName("forge_version")]
		public EGameVersion GameVersion { get; set; }

		[JsonPropertyName("item_id_list")]
		public List<ulong> ItemIDlist { get; set; }

		[JsonPropertyName("item_version_list")]
		public List<uint> ItemVersionList { get; set; }

		[JsonPropertyName("item_md5_list")]
		public List<string> ItemMD5List { get; set; }

		[JsonPropertyName("game_type")]
		public EGameType GameType  { get; set; }

		[JsonPropertyName("is_host")]
		public uint IsHost { get; set; } = 0;

	}
}
