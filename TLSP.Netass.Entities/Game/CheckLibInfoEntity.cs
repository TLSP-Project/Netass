

namespace TLSP.Netass.Entities
{
    public class CheckLibInfoEntity : EntityBase
    {


		[JsonPropertyName("client_version")]
		public ulong ClientVersion { get; set; }
		[JsonPropertyName("common")]
		public List<LibInfo> CommonLibs { get; set; }
		[JsonPropertyName("vec_blacklist")]
		public List<LibInfo> BlackList { get; set; }
		[JsonPropertyName("vec_whitelist")]

		public List<LibInfo> WhiteList { get; set; }

		[Serializable]
		public class LibInfo
		{
			[JsonPropertyName("nm")]
			public string Name { get; set; }
			[JsonPropertyName("md5")]
			public List<string> MD5 { get; set; }
			[JsonPropertyName("sz")]
			public List<long> Size { get; set; }
			[JsonPropertyName("ctime")]
			public List<long> CreatTime { get; set; }
		}
	}
}
