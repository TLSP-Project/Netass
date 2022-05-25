

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class ItemIDsRequest
    {
        [JsonPropertyName("item_ids")]
        public List<string> ItemIDs { get; set; }

        public static implicit operator ItemIDsRequest(List<string> ids) => new ItemIDsRequest{ ItemIDs = ids};
    }
}
