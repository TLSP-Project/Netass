
namespace TLSP.Netass.Entities
{
    public class MCVersionEntity
    {

        [JsonPropertyName("mc_version_id")]
        [JsonConverter(typeof(GameVersionIDConverter))]
        public EGameVersion GameVersion { get; set; }
        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }
        [JsonPropertyName("java_version")]
        public EJavaType JavaVersion { get; set; }
    }
}
