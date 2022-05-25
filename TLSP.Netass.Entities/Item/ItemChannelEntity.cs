

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class ItemChannelEntity :EntityBase
    {
        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }
        [JsonPropertyName("channel_id")]
        public string ChannelID { get; set; }
        [JsonPropertyName("title_image_url")]
        public string TitleImageUrl { get; set; }
    }
}
