
namespace TLSP.Netass.Entities
{
	[Serializable]
	public class ItemDownloadEntity : EntityBase
	{
		[JsonPropertyName("item_id")]
		public string ItemID { get; set; }
		[JsonPropertyName("user_id")]
		public string UserID { get; set; }

		[JsonPropertyName("itype")]
		public int ItemType { get; set; }

		[JsonPropertyName("mtypeid")]
		public EItemMasterType MasterType { get; set; }

		[JsonPropertyName("stypeid")]
		public int SubType { get; set; }

		[JsonPropertyName("sub_entities")]
		public List<ItemDownloadSubEntity> SubEntities { get; set; }


		[JsonPropertyName("sub_mod_list")]
		public List<ulong> SubModList { get; set; }

	}
	[Serializable]
	public class ItemDownloadSubEntity : EntityBase
	{
		[JsonPropertyName("java_version")]
		public EJavaType JavaVersion { get; set; }


		[JsonPropertyName("mc_version_name")]
		[JsonConverter(typeof(GameVersionNameConverter))]
		public EGameVersion GameVerison { get; set; }


		[JsonPropertyName("res_url")]
		public string URL { get; set; }


		[JsonPropertyName("res_size")]
		public long Size { get; set; }


		[JsonPropertyName("res_md5")]
		public string MD5 { get; set; }


		[JsonPropertyName("jar_md5")]
		public string JarMD5 { get; set; }


		[JsonPropertyName("res_name")]
		public string Name { get; set; }


		[JsonPropertyName("file_name")]
		public string FileName { get; set; }


		[JsonPropertyName("res_version")]
		public int Version { get; set; }
	}
}
