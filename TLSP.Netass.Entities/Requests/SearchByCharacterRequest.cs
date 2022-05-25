

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class SearchByCharacterRequest
    {
        [JsonPropertyName("game_id")]
        public string GameID { get; set; }
        [JsonPropertyName("game_type")]
        public EGameType GameType { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

    }
}
