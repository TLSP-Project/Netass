

namespace TLSP.Netass.Entities
{
    [Serializable]
    public class SearchChannelByItemIDListRequest
    {
        [JsonPropertyName("item_id_list")]
        public List<string> ItemIDList { get; set; }
        [JsonPropertyName("channel_id")]
        public int ChannelID { get; set; }

        public SearchChannelByItemIDListRequest()
        {

        }

    }
}
