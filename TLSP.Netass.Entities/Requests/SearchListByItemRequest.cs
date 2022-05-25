
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class SearchListByItemIDRequest : SeachListRequest
    {
        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }

        public static implicit operator SearchListByItemIDRequest(string id) => new SearchListByItemIDRequest { ItemID = id };
    }
}
