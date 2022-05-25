
namespace TLSP.Netass.Entities
{
    public class ItemIDRequest
    {
        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }

        public static implicit operator ItemIDRequest(string id)
        {
            return new ItemIDRequest { ItemID = id };
        }
    }
}
