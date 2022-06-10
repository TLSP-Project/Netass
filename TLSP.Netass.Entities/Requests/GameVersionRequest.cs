
namespace TLSP.Netass.Entities
{
    [Serializable] 
    public class GameVersionRequest
    {
        [JsonPropertyName("mc_version")]
        public EGameVersion GameVersion { get; set; }

        public static implicit operator GameVersionRequest(EGameVersion ver) => new GameVersionRequest() { GameVersion = ver};
    }
}
