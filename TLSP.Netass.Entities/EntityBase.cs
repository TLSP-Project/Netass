
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class EntityBase
    {
        [JsonPropertyName("entity_id")]
        public string EntityID { get; set; }
    }
}
