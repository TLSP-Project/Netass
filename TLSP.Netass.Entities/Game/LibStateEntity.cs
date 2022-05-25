

namespace TLSP.Netass.Entities
{
	[Serializable]
	public class LibStateEntity : EntityBase
	{
		[JsonPropertyName("state")]
		public int State { get; set; }
	}
}
