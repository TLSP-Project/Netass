
namespace TLSP.Netass.Entities
{
    [Serializable]
    public class SearchByItemChannelRequest
    {
        [JsonPropertyName("item_id")]
        public string ItemID { get; set; }
        [JsonPropertyName("channel_id")]
        public string ChannelID { get; set; }

        public SearchByItemChannelRequest(string itemID ,string channelID)
        {
            ItemID = itemID;
            ChannelID = channelID;
        }
    }
}
