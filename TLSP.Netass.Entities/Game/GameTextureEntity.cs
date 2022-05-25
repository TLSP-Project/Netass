

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class GameTextureEntity : EntityBase
    {
        [JsonPropertyName("game_type")]
        public EGameType GameType { get; set; }

        [JsonPropertyName("skin_type")]
        public ETextureType SkinType { get; set; }

        [JsonPropertyName("skin_id")]
        public long SkinID { get; set; }

        [JsonPropertyName("skin_mode")]
        public int SkinMode { get; set; }

        [JsonPropertyName("client_type")]
        public EGameClientType ClientType { get; set; }
    }
}
