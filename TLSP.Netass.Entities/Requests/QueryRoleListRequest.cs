
namespace TLSP.Netass.Entities
{
    public class QueryRoleListRequest : SeachListRequest
    {
        [JsonPropertyName("user_id")]
        public string UserID { get; set; }
        [JsonPropertyName("game_id")]
        public string GameID { get; set; }
        [JsonPropertyName("game_type")]
        public EGameType GameType { get; set; }

    }
}
