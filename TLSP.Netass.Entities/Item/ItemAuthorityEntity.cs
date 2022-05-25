
namespace TLSP.Netass.Entities
{
	[Serializable]
	public class ItemAuthorityEntity : EntityBase
    {

		[JsonPropertyName("item_id")]
		public ulong ItemID { get; set; }
		[JsonPropertyName("iteitem_versionm_id")]
		public uint ItemVersion { get; set; }
		[JsonPropertyName("priority")]
		public int Priority { get; set; }
		[JsonPropertyName("key")]
		public string Key { get; set; }
		[JsonPropertyName("name")]
		public string Name { get; set; }
		[JsonPropertyName("md5")]
		public string MD5 { get; set; }
	}
}
