
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class SeachListRequest
    {
        [JsonPropertyName("offset")]
        public int Offset { get; set; } = 0;
        [JsonPropertyName("length")]
        public int Length { get; set; } = 10;

    }
}
