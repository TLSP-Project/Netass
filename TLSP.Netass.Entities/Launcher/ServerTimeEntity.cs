
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class ServerTimeEntity : EntityBase
    {
        [JsonPropertyName("current")]
        public uint CurrentTimeStamp { get; set; }
    }
}
