

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class QueryGameSkinRequest
    {
        [JsonPropertyName("user_id")]
        public uint UserID { get; set; }
        [JsonPropertyName("game_type")]
        public EGameType GameType { get; set; }
        [JsonPropertyName("client_type")]
        public EGameClientType ClientType { get; set; }

        public QueryGameSkinRequest(uint userID , EGameClientType clientType  = EGameClientType.java ,EGameType gameType = EGameType.NET_GAME)
        {
            UserID = userID;
            ClientType = clientType;
            GameType = gameType;
        }
    }
}
