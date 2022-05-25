
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class EntityIDRequest
    {
        [JsonPropertyName("entity_id")]
        public string EntityID { get; set; }


        public EntityIDRequest(string entityID)
        {
            EntityID = entityID;
        }
    }
}
