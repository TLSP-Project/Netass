

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class AddRoleRequest
    {
        public AddRoleRequest()
        {

        }

        public AddRoleRequest( string entityId,string gameId, EGameType gameType, string userId,string name, ulong createTime)
        {
            this.EntityId = entityId;
            this.GameId = gameId;
            this.GameType = gameType;
            this.UserId = userId;
            this.Name = name;
            this.CreateTime = createTime;
        }

        [JsonPropertyName("entity_id")]
        public string EntityId { get; } ="0";   

        [JsonPropertyName("game_id")]
        public string GameId { get; set; }

        [JsonPropertyName("game_type")]
        public EGameType GameType { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("create_time")]
        public ulong CreateTime { get; } = 555555UL;

	}
}
