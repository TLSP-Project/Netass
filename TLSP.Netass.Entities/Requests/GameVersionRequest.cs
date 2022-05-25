
namespace TLSP.Netass.Entities
{
    [Serializable] 
    public class GameVersionRequest
    {
        [JsonPropertyName("mc_version")]
        public EGameVersion GameVersion { get; set; }

    }
}
